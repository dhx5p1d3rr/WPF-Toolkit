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
    public partial class CheckBox_Hook : UserControl
    {
        #region Variablen

        public bool CheckIt { get; set; }

        #endregion

        #region Constructor

        public CheckBox_Hook()
        {
            InitializeComponent();

            this.Height = 30;
            this.Width = 30;

            CheckIt = false;
            chkHook.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Events

        private void ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Check();
        }

        private void chkHook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Check();
        }

        #endregion

        #region Funktionen       

        private void Check()
        {
            if (CheckIt == false)
            {
                CheckIt = true;
                chkHook.Visibility = Visibility.Visible;
            }
            else if (CheckIt == true)
            {
                CheckIt = false;
                chkHook.Visibility = Visibility.Hidden;
            }
        }

        #endregion
    }
}
