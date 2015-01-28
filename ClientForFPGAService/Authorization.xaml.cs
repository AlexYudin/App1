using System;
using System.Windows;

namespace ClientForFPGAService
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization
    {
        public Authorization()
        {
            InitializeComponent();
        }

        System.Windows.Threading.DispatcherTimer dispatcherTimer;

        private void logInButton_Click_1(object sender, RoutedEventArgs e)
        {
            labelLogin.Opacity = 0.07;
            labelPass.Opacity = 0.07;
            loginTextBox.Opacity = 0.07;
            passBox.Opacity = 0.07;
            logInButton.Opacity = 0.07;
            connectProgressRing.IsActive = true;

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            QuickStart window = new QuickStart(loginTextBox.Text);
            this.Close();
            window.Show();
            dispatcherTimer.Stop();
        }
    }
}
