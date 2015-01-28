using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Net;
using Hardcodet.Wpf.TaskbarNotification;

namespace ClientForFPGAService
{
    /// <summary>
    /// Логика взаимодействия для QuickStart.xaml
    /// </summary>
    public partial class QuickStart
    {
        string name;
        public QuickStart(string userName)
        {
            this.name = userName;
            ClientForFPGAService.Properties.Settings.Default.startUpShow = true;
            bool startUp = ClientForFPGAService.Properties.Settings.Default.startUpShow;
            if (startUp)
            {
                InitializeComponent();
                userNameTextBlock.Text = name;
                CreateImageFromUrl("http://cs305106.vk.me/v305106921/6f97/oxQVHRg17ho.jpg", this.userAvatar);
            }
            else
            {         
                MainWindow window = new MainWindow();
                this.Close();
                window.Show();
            }
        }

        private void startUpShowing_Checked(object sender, RoutedEventArgs e)
        {            
            if ((bool)startUpShowing.IsChecked)
            {
                ClientForFPGAService.Properties.Settings.Default.startUpShow = false;
                ClientForFPGAService.Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Создание изображения из Url адреса
        /// </summary>
        /// <param name="Url">Url адрес изображения</param>
        /// <param name="resultImage">Контрол Image</param>
        public void CreateImageFromUrl(string Url, Image resultImage)
        {
            var image = new BitmapImage();
            int BytesToRead = 100;

            WebRequest request = WebRequest.Create(new Uri(Url, UriKind.Absolute));
            request.Timeout = -1;
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            BinaryReader reader = new BinaryReader(responseStream);
            MemoryStream memoryStream = new MemoryStream();

            byte[] bytebuffer = new byte[BytesToRead];
            int bytesRead = reader.Read(bytebuffer, 0, BytesToRead);

            while (bytesRead > 0)
            {
                memoryStream.Write(bytebuffer, 0, bytesRead);
                bytesRead = reader.Read(bytebuffer, 0, BytesToRead);
            }

            image.BeginInit();
            memoryStream.Seek(0, SeekOrigin.Begin);

            image.StreamSource = memoryStream;
            image.EndInit();

            resultImage.Source = image;
        }

        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Balloon balloon = new Balloon();

            balloon.BalloonText = "text";
            TaskbarIcon MyNotifyIcon = new TaskbarIcon();

            Image s = new Image();
            ImageSourceConverter imgs = new ImageSourceConverter();
            s.SetValue(Image.SourceProperty, imgs.ConvertFromString("pack://application:,,,/Images/login.ico"));

            MyNotifyIcon.IconSource = s.Source;
            MyNotifyIcon.ShowCustomBalloon(balloon, System.Windows.Controls.Primitives.PopupAnimation.Slide, 4000);

            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }
    }
}
