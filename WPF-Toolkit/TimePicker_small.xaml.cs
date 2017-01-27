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
    public partial class TimePicker_small : UserControl
    {
        #region Variablen

        public DateTime dt_Time { get; set; }
        public string str_Hour { get; set; }
        public string str_Minute { get; set; }

        private int iHour;
        private int iMinute;

        #endregion

        #region Constructor

        public TimePicker_small()
        {
            InitializeComponent();
            this.Height = 51;
            this.Width = 215;
        }

        #endregion

        #region Events

        private void cb_hour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_hour.SelectedIndex != -1)
            {
                cb_minute.IsEnabled = true;
            }
        }

        private void cb_minute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_minute.SelectedIndex != -1)
            {
                cb_Fail();
            }
        }

        #endregion

        #region Funktionen

        private void Get_Data()
        {
            try
            {
                str_Hour = cb_hour.Text;
                //str_Minute = cb_minute.Text;

                iHour = Convert.ToInt32(str_Hour);
                iMinute = Convert.ToInt32(str_Minute);
            }
            catch (Exception) { Console.WriteLine("Exept. in Get_Data"); }

            finally
            {
                lbl_Time.Content = str_Hour + ":" + str_Minute;

                Build_Time(iHour, iMinute);
            }
        }

        private void Build_Time(int hour, int minute)
        {
            int y = DateTime.Now.Year;
            int m = DateTime.Now.Month;
            int d = DateTime.Now.Month;

            dt_Time = new DateTime(y, m, d, hour, minute, 0);

            Aufräumen();
        }

        private void Aufräumen()
        {
            var tp = new TimePicker_small();

            cb_hour.SelectedIndex = -1;
            cb_minute.SelectedIndex = -1;

            cb_minute.IsEnabled = false;


            tp.UpdateLayout();
        }

        #endregion

        #region Bug_Beseitigung

        /// <summary>
        /// ComboBox Bug Beseitigung
        /// cb_minute Text ist Null?
        /// </summary>
        private void cb_Fail()
        {
            int s = cb_minute.SelectedIndex;

            switch (s)
            {
                case 0:
                    str_Minute = "00";
                    break;

                case 1:
                    str_Minute = "01";
                    break;

                case 2:
                    str_Minute = "02";
                    break;

                case 3:
                    str_Minute = "03";
                    break;

                case 4:
                    str_Minute = "04";
                    break;

                case 5:
                    str_Minute = "05";
                    break;

                case 6:
                    str_Minute = "06";
                    break;

                case 7:
                    str_Minute = "07";
                    break;

                case 8:
                    str_Minute = "08";
                    break;

                case 9:
                    str_Minute = "09";
                    break;

                case 10:
                    str_Minute = "10";
                    break;

                case 11:
                    str_Minute = "11";
                    break;

                case 12:
                    str_Minute = "12";
                    break;

                case 13:
                    str_Minute = "13";
                    break;

                case 14:
                    str_Minute = "14";
                    break;

                case 15:
                    str_Minute = "15";
                    break;

                case 16:
                    str_Minute = "16";
                    break;

                case 17:
                    str_Minute = "17";
                    break;

                case 18:
                    str_Minute = "18";
                    break;

                case 19:
                    str_Minute = "19";
                    break;

                case 20:
                    str_Minute = "20";
                    break;

                case 21:
                    str_Minute = "21";
                    break;

                case 22:
                    str_Minute = "22";
                    break;

                case 23:
                    str_Minute = "23";
                    break;

                case 24:
                    str_Minute = "24";
                    break;

                case 25:
                    str_Minute = "25";
                    break;

                case 26:
                    str_Minute = "26";
                    break;

                case 27:
                    str_Minute = "27";
                    break;

                case 28:
                    str_Minute = "28";
                    break;

                case 29:
                    str_Minute = "29";
                    break;

                case 30:
                    str_Minute = "30";
                    break;

                case 31:
                    str_Minute = "31";
                    break;

                case 32:
                    str_Minute = "32";
                    break;

                case 33:
                    str_Minute = "33";
                    break;

                case 34:
                    str_Minute = "34";
                    break;

                case 35:
                    str_Minute = "35";
                    break;

                case 36:
                    str_Minute = "36";
                    break;

                case 37:
                    str_Minute = "37";
                    break;

                case 38:
                    str_Minute = "38";
                    break;

                case 39:
                    str_Minute = "39";
                    break;

                case 40:
                    str_Minute = "40";
                    break;

                case 41:
                    str_Minute = "41";
                    break;

                case 42:
                    str_Minute = "42";
                    break;

                case 43:
                    str_Minute = "43";
                    break;

                case 44:
                    str_Minute = "44";
                    break;

                case 45:
                    str_Minute = "45";
                    break;

                case 46:
                    str_Minute = "46";
                    break;

                case 47:
                    str_Minute = "47";
                    break;

                case 48:
                    str_Minute = "48";
                    break;

                case 49:
                    str_Minute = "49";
                    break;

                case 50:
                    str_Minute = "50";
                    break;

                case 51:
                    str_Minute = "51";
                    break;

                case 52:
                    str_Minute = "52";
                    break;

                case 53:
                    str_Minute = "53";
                    break;

                case 54:
                    str_Minute = "54";
                    break;

                case 55:
                    str_Minute = "55";
                    break;

                case 56:
                    str_Minute = "56";
                    break;

                case 57:
                    str_Minute = "57";
                    break;

                case 58:
                    str_Minute = "58";
                    break;

                case 59:
                    str_Minute = "59";
                    break;

            }

            Get_Data();
        }

        #endregion
    }
}
