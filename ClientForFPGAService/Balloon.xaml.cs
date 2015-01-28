using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Hardcodet.Wpf.TaskbarNotification;

namespace ClientForFPGAService
{
    public partial class Balloon : UserControl
    {
        private bool isClosing = false;

        public static readonly DependencyProperty BalloonTextProperty =
            DependencyProperty.Register("BalloonText",
                typeof (string),
                typeof (Balloon),
                new FrameworkPropertyMetadata(""));
        public string BalloonText
        {
            get { return (string) GetValue(BalloonTextProperty); }
            set { SetValue(BalloonTextProperty, value); }
        }

        public Balloon()
        {
            InitializeComponent();
            TaskbarIcon.AddBalloonClosingHandler(this, OnBalloonClosing);
        }

        private void OnBalloonClosing(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            isClosing = true;
        }

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TaskbarIcon taskbarIcon = TaskbarIcon.GetParentTaskbarIcon(this);
            taskbarIcon.CloseBalloon();
        }

        private void grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isClosing) return;

            TaskbarIcon taskbarIcon = TaskbarIcon.GetParentTaskbarIcon(this);
            taskbarIcon.ResetBalloonCloseTimer();
        }

        private void OnFadeOutCompleted(object sender, EventArgs e)
        {
            Popup pp = (Popup) Parent;
            pp.IsOpen = false;
        }
    }
}