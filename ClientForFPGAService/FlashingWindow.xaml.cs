using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Threading;

namespace ClientForFPGAService
{
    /// <summary>
    /// Логика взаимодействия для FlashingWindow.xaml
    /// </summary>
    public partial class FlashingWindow
    {
        Bitmap _bitmap;
        BitmapSource _source;

        public FlashingWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(FlashingWindow_Loaded);
        }

        void FlashingWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _source = GetSource();
            imBackGround.Source = _source;
            ImageAnimator.Animate(_bitmap, OnFrameChanged);
        }

        private BitmapSource GetSource()
        {
            if (_bitmap == null)
            {
                _bitmap = new Bitmap(@"Images/bohF1.gif");
            }
            IntPtr handle = IntPtr.Zero;
            handle = _bitmap.GetHbitmap();
            return Imaging.CreateBitmapSourceFromHBitmap(
                    handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

        private void FrameUpdatedCallback()
        {
            ImageAnimator.UpdateFrames();
            if (_source != null)
                _source.Freeze();
            _source = GetSource();
            imBackGround.Source = _source;
            InvalidateVisual();
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                                    new Action(FrameUpdatedCallback));
        }
    }
}
