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

namespace Paint
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point punto;

        public MainWindow()
        {
            InitializeComponent();
            punto = new Point();
        }

        private void c_paint_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                punto = e.GetPosition(this);
            }
        }

        private void c_paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line linea = new Line();
                linea.Stroke = SystemColors.WindowBrush;
                linea.X1 = punto.X;
                linea.Y1 = punto.Y;
                linea.X2 = e.GetPosition(this).X;
                linea.Y2 = e.GetPosition(this).Y;
                punto = e.GetPosition(this);
                c_paint.Children.Add(linea);

            }
        }


    }
}
