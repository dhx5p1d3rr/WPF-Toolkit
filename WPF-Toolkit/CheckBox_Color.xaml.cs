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

namespace WPF_Toolkit
{
    public partial class CheckBox_Color : UserControl
    {
        #region Variablen

        public bool CheckIt { get; set; }

        #endregion

        #region Constructor

        public CheckBox_Color()
        {
            InitializeComponent();
            this.Width = 30;
            this.Height = 30;
            CheckIt = false;
            chk_color.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Events

        private void ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Check();
        }

        private void ellipsechk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Check();
        }

        #endregion

        #region Funktionen

        public void Check()
        {
            if (CheckIt == false)
            {
                CheckIt = true;
                //Color_Checked();
                chk_color.Visibility = Visibility.Visible;
            }
            else if (CheckIt == true)
            {
                CheckIt = false;
                //Color_UnChecked();
                chk_color.Visibility = Visibility.Hidden;
            }
        }

        public void Check_GreenRed()
        {
            if (CheckIt == false)
            {
                chk_color.Visibility = Visibility.Hidden;
                chk_colorRed.Visibility = Visibility.Visible;
            }
            else if (CheckIt == true)
            {
                chk_color.Visibility = Visibility.Visible;
                chk_colorRed.Visibility = Visibility.Hidden;
            }
        }

        #endregion

        #region Colors

        private void Color_UnChecked()
        {
            var coldef = new LinearGradientBrush();
            coldef.StartPoint = new Point(1, 0.75);
            coldef.EndPoint = new Point(1, 0);


            GradientStop first = new GradientStop();
            first.Color = Color.FromArgb(100, 11, 10, 10);
            first.Offset = 0;
            coldef.GradientStops.Add(first);

            GradientStop second = new GradientStop();
            second.Color = Color.FromArgb(100, 104, 101, 101);
            second.Offset = 1;
            coldef.GradientStops.Add(second);

            ellipse.Fill = coldef;
        }

        private void Color_Checked()
        {
            var colchkd = new LinearGradientBrush();
            colchkd.StartPoint = new Point(1, 0.75);
            colchkd.EndPoint = new Point(1, 0);


            GradientStop first = new GradientStop();
            first.Color = Color.FromArgb(100, 11, 10, 10);
            first.Offset = 0;
            colchkd.GradientStops.Add(first);

            GradientStop second = new GradientStop();
            second.Color = Color.FromArgb(100, 89, 217, 40);
            second.Offset = 1;
            colchkd.GradientStops.Add(second);

            ellipse.Fill = colchkd;

        }

        #endregion

        private void chk_colorRed_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Check();
        }
    }
}
