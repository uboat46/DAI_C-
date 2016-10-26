using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AplicaciónVideo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void timer_tick(Object sender, EventArgs e)
        {
            if (me_miVideo.Source != null)
            {
                if (me_miVideo.NaturalDuration.HasTimeSpan)
                {
                    lb_tiempo.Content = String.Format("{0}/{1}", me_miVideo.Position.ToString(@"mm\ss"), me_miVideo.NaturalDuration.TimeSpan.ToString(@"mm\ss"));
                }
            }
            else 
            {
                lb_tiempo.Content = "Archivo no encontrado";
            }
        }

        private void bt_play_Click_1(object sender, RoutedEventArgs e)
        {
            me_miVideo.Play();
        }

        private void bt_pause_Click_1(object sender, RoutedEventArgs e)
        {
            me_miVideo.Pause();
        }

        private void bt_stop_Click_1(object sender, RoutedEventArgs e)
        {
            me_miVideo.Stop();
        }

    }
}
