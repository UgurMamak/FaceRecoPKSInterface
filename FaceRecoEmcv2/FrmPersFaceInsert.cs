#region MyRegion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;
using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;
using System.Threading;

#endregion
namespace FaceRecoEmcv2
{
    public partial class FrmPersFaceInsert : MaterialForm
    {
        public FrmPersFaceInsert()
        {
            InitializeComponent();
            #region material tasarım
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
            #endregion

              CameraCapture();
        }
        public string fnkImageLabel { get; set; }//resim etiketi
        public string persAd { get; set; }
        public string persSoyad { get; set; }
        public string dogumTarihi { get; set; }
        public string departman { get; set; }
        public double maaş { get; set; }

        #region Değişkenler ve tanımlamalar
        Capture _capture;
        Image<Bgr, Byte> currentFrame; //webcamden alınan kamera görüntüsünü tutması için bgr renk uzayından image tipinde değişken tanımladık.(**)
        Image<Gray, byte> result = null;//algılanan yüzü ve eğitme için kullanılacak olan yüzü tutmak için gri fortta Image değişkenleri oluşturduk.(**)
        Image<Gray, byte> grayframe = null; //kameradan alınan anlık görüntüleri gri formata dönüştürünce atayacağımız Image değişkeni(**)

        CascadeClassifier FaceCascade = new CascadeClassifier(Application.StartupPath + "/Cascades/haarcascade_frontalface_default.xml");

        //Çekilen resim verileri resultImages listesine eklenir(**)
        List<Image<Gray, byte>> resultImages = new List<Image<Gray, byte>>();
        int adet = 0;

        //resimi jpg formatında kaydetme işlemi için oluşturduğumuz değişkenler ve listeler(**)
        List<Image<Gray, byte>> ImagestoWrite = new List<Image<Gray, byte>>();

        //xml veri dosyasını kaydetmek için oluşturduğumuz değişkenler ve listeler.(**)
        List<string> NamestoWrite = new List<string>();
        List<string> NamesforFile = new List<string>();
        XmlDocument xmldocu = new XmlDocument();

        DbProcess prc = new DbProcess();
        #endregion

        #region Kamerayı açar.
        public void CameraCapture()
        {
            _capture = new Capture();
            _capture.QueryFrame();
            Application.Idle += new EventHandler(GoruntuYakala);
        }
        #endregion

        #region kamerayı kapatır.
        private void StopCapture()
        {
            Application.Idle -= new EventHandler(GoruntuYakala);
            if (_capture != null)
            { _capture.Dispose(); }
        }
        #endregion


        #region Kameradan algılanan görüntüde yüz algılama işlemini yapar.
        void GoruntuYakala(object sender, EventArgs e)
        {
            //kameradan alınan anlık görüntü yeniden boyutlandırılır.(**)
            currentFrame = _capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            if (currentFrame != null)
            {
                //Daha hızlı işlem yapabilmek için kameradan alınan anlık görüntü griye dönüştürülür.(**)
                grayframe = currentFrame.Convert<Gray, Byte>();

                //Haarcascade'den türettiğimiz nesneden yüz algılama işlemini gerçekleştirdik.(**)
                Rectangle[] facesDetected = FaceCascade.DetectMultiScale(grayframe, 1.2, 10, new Size(50, 50), Size.Empty);

                //Algılanan görüntünün çerçeveye alınacak bölgesi belirlenir.(**)
                //Paralel.For normal for döngüsünden daha hızlı çalışır.(**)
                for (int i = 0; i < facesDetected.Length; i++)// (Rectangle face_found in facesDetected)
                {
                    facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
                    facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
                    facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
                    facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.35);

                    //anlık görüntüden algılanan yüz resmini griye dönüştürür ve boyutlandırır.(100x100)(**) 
                    result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    result._EqualizeHist();//Histogram Eşitleme işlemi yapılır.

                    //algılanan yüz imgYuz imagebox nesnesinde gösterilir(**)
                    imgYuz.Image = result.ToBitmap();

                    //kamera görüntüsünde algılanan yüz resmi çerçeve içine alınır.(**)
                    currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);
                }
                resultImages.Add(result);

                //Kamera görüntüsü imgKamera nesnesinde gösterilir.(**)
                imgKamera.Image = currentFrame.ToBitmap();
            }
        }
        #endregion

        #region Resim çek butonuna basınca çalışacak fonk algılanan yüzü klasöre ve bilgileride xml dosyasına kaydeder.
        private bool FnkEgitimVerisiKaydet(Image FaceData)
        {
            try
            {
                Random rand = new Random();//isimlendirmede aynı isimlerin denk gelmesini engellemek için  rastgele oluşturulan sayılar atanam işlemi yapmak için oluşturdum.(**)
                bool file_create = true;
                string ResimLabel = "face_" + fnkImageLabel + "_" + rand.Next().ToString() + ".jpg";//kaydedilecek resmin label etiketi(**)
                while (file_create)
                {
                    //her ihtimale karşı oluşturulan dosya ismini dosyada daha önce kullanılıp kullanılmadığını anlamak için kontol ettim.(**)
                    //if (!File.Exists(Application.StartupPath + "/TrainedFaces/" + ResimLabel))//(dosyanın varlığı kontrol edilir.(**))
                    if (!File.Exists("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/" + ResimLabel))//(dosyanın varlığı kontrol edilir.(**))
                    {
                        file_create = false;
                    }
                    else
                    {
                        ResimLabel = "face_" + fnkImageLabel + "_" + rand.Next().ToString() + ".jpg";
                    }
                }
               // if (Directory.Exists(Application.StartupPath + "/TrainedFaces/"))//dizinin varlığı kontrol edilir(**)
                if (Directory.Exists("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/"))//dizinin varlığı kontrol edilir(**)
                {
                    //resim kaydetme işlemi(**)
                   // FaceData.Save(Application.StartupPath + "/TrainedFaces/" + ResimLabel, ImageFormat.Jpeg);
                    FaceData.Save("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/" + ResimLabel, ImageFormat.Jpeg);
                }
                else
                {
                    //Directory.CreateDirectory(Application.StartupPath + "/TrainedFaces/");//eğer TrainedFaces klasöü yoksa oluşturulur.(**)
                    Directory.CreateDirectory("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/");//eğer TrainedFaces klasöü yoksa oluşturulur.(**)
                   // FaceData.Save(Application.StartupPath + "/TrainedFaces/" + ResimLabel, ImageFormat.Jpeg);//klasör oluşturuldıktan sonra resim kaydetme işlemi gerçekleştirilir.(**)
                    FaceData.Save("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/" + ResimLabel, ImageFormat.Jpeg);//klasör oluşturuldıktan sonra resim kaydetme işlemi gerçekleştirilir.(**)
                }

                //Resim kaydedildikten sonra bilgileri xml dosyasına kaydetmemiz gerekiyor.(**)

                //if (File.Exists(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml"))//xml dosyasının varlığı kontrol edilir.(**)
                if (File.Exists("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/TrainedLabels.xml"))//xml dosyasının varlığı kontrol edilir.(**)
                {
                    bool loading = true;
                    while (loading)
                    {
                        try
                        {
                            //eğer xml belgesi varsa döküman yüklenir.(**)
                            //xmldocu.Load(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                            xmldocu.Load("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/TrainedLabels.xml");
                            loading = false;
                        }
                        catch
                        {
                            xmldocu = null;
                            xmldocu = new XmlDocument();
                            Thread.Sleep(10);
                        }
                    }
                    //xml belgesinin içerisinde kullılan ve yeni kayıt içinde kullanacağımız elementleri oluşturuyoruz.(**)
                    XmlElement root = xmldocu.DocumentElement;
                    XmlElement face_D = xmldocu.CreateElement("FACE");
                    XmlElement name_D = xmldocu.CreateElement("NAME");
                    XmlElement file_D = xmldocu.CreateElement("FILE");
                    //elementlerin içerisine ad soyad ve resimin label değerlerini girdim.(**)
                    name_D.InnerText = fnkImageLabel;
                    file_D.InnerText = ResimLabel;
                    // name_D nin ve file_D nin face_D'nin içerisinde bulunduğunu belirttik.Oluştrulan yapı aşağıdaki yorum satırındaki gibi olur.(**)                 
                    face_D.AppendChild(name_D);
                    face_D.AppendChild(file_D);
                    //face_D elementinin kök olduğu belirtilir.(**)
                    root.AppendChild(face_D);
                    //xml belgesinde yapılan değişiklikler kaydedilir.(**)
                   // xmldocu.Save(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                    xmldocu.Save("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/TrainedLabels.xml");
                }

                else
                {
                    //FileStream FSKisiBilgileri = File.OpenWrite(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");     //xml dosyası yoksa oluşturulur.(**)
                    FileStream FSKisiBilgileri = File.OpenWrite("C:/Users/Uğur/Desktop/PROJEA/FaceRecognition(ProjeA)/FaceRecoEmcv2/bin/Debug/TrainedFaces/TrainedLabels.xml");     //xml dosyası yoksa oluşturulur.(**)
                    using (XmlWriter writer = XmlWriter.Create(FSKisiBilgileri))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Faces_For_Training");
                        writer.WriteStartElement("FACE");
                        writer.WriteElementString("NAME", fnkImageLabel);
                        writer.WriteElementString("FILE", ResimLabel);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    FSKisiBilgileri.Close();
                }
                return true;
            }
            catch (Exception ex) {return false;}
        }
        #endregion


        #region Resim çek butonu
        private void btnResimCek_Click(object sender, EventArgs e)
        {
            if (!FnkEgitimVerisiKaydet(imgYuz.Image))
                MessageBox.Show("HATA", "Eğitim verileri kaydedilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                adet++;
                lblAdet.Text = adet.ToString();
                StopCapture();
                CameraCapture();

                if(adet==1){ FnkPersonelInsert();}//her resimde aynı kişiyi eklemeyi engellemek için kontrol ettim.
            }
        }
        #endregion

        #region
        void FnkPersonelInsert()
        {
            prc.prcPersonelInsert(persAd, persSoyad, dogumTarihi, departman, maaş);
        }
        #endregion
        private void FrmPersFaceInsert_Load(object sender, EventArgs e)
        {
                   
        }

        private void FrmPersFaceInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void FrmPersFaceInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            StopCapture();
        }
    }
}
