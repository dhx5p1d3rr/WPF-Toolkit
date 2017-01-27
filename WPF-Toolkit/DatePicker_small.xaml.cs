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
    public partial class DatePicker_small : UserControl
    {
        #region Variablen

        //////////////////////////////////////////////////
        /// Public

        public DateTime dt_Datum { get; set; }

        public string str_Year { get; set; }
        public string str_Month { get; set; }
        public string str_Day { get; set; }

        //////////////////////////////////////////////////

        //////////////////////////////////////////////////
        /// Private

        private int i_year;
        private int i_month;
        private int i_day;

        ///////////////////////////////////////////////////

        #endregion

        #region Constructor

        public DatePicker_small()
        {
            InitializeComponent();
            this.Width = 215;
            this.Height = 51;
        }

        #endregion

        #region Events

        private void cb_month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_month.SelectedIndex != -1)
            {
                cb_day.IsEnabled = true;

                if (cb_month.SelectedIndex == 1) //Februar
                {
                    i_29.Visibility = Visibility.Hidden;
                    i_30.Visibility = Visibility.Hidden;
                    i_31.Visibility = Visibility.Hidden;
                }
                else if (cb_month.SelectedIndex == 3) //April
                {
                    i_31.Visibility = Visibility.Hidden;
                }
                else if (cb_month.SelectedIndex == 5) //Juni
                {
                    i_31.Visibility = Visibility.Hidden;
                }
                else if (cb_month.SelectedIndex == 8) //September
                {
                    i_31.Visibility = Visibility.Hidden;
                }
                else if (cb_month.SelectedIndex == 10) //November
                {
                    i_31.Visibility = Visibility.Hidden;
                }
                else // Monate mit 31 Tage
                {
                    i_29.Visibility = Visibility.Visible;
                    i_30.Visibility = Visibility.Visible;
                    i_31.Visibility = Visibility.Visible;
                }
            }
        }

        private void cb_day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_day.SelectedIndex != -1)
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
                str_Year = DateTime.Now.Year.ToString();
                str_Month = cb_month.Text;
                //str_Day = cb_day.Text;

                i_year = Convert.ToInt32(str_Year);
                i_month = Convert.ToInt32(str_Month);
                i_day = Convert.ToInt32(str_Day);


            }

            catch (Exception) { Console.WriteLine("Exept. in Get_Data!"); }

            finally
            {
                lbl_Time.Content = str_Day + "." + str_Month + ".";

                Build_Time (i_year, i_month, i_day);
            }

        }

        private void Build_Time(int year, int month, int day)
        {
            dt_Datum = new DateTime(year, month, day);

            Aufräumen();
        }

        private void Aufräumen()
        {
            var dp = new DatePicker_dark();

            cb_month.SelectedIndex = -1;
            cb_day.SelectedIndex = -1;

            cb_day.IsEnabled = false;


            dp.UpdateLayout();
        }

        #endregion

        #region Bug_Beseitigung

        /// <summary>
        /// ComboBox Bug Beseitigung
        /// cb_minute Text ist Null?
        /// </summary>
        private void cb_Fail()
        {
            int s = cb_day.SelectedIndex;

            switch (s)
            {
                case 0:
                    str_Day = "01";
                    break;

                case 1:
                    str_Day = "02";
                    break;

                case 2:
                    str_Day = "03";
                    break;

                case 3:
                    str_Day = "04";
                    break;

                case 4:
                    str_Day = "05";
                    break;

                case 5:
                    str_Day = "06";
                    break;

                case 6:
                    str_Day = "07";
                    break;

                case 7:
                    str_Day = "08";
                    break;

                case 8:
                    str_Day = "09";
                    break;

                case 9:
                    str_Day = "10";
                    break;

                case 10:
                    str_Day = "11";
                    break;

                case 11:
                    str_Day = "12";
                    break;

                case 12:
                    str_Day = "13";
                    break;

                case 13:
                    str_Day = "14";
                    break;

                case 14:
                    str_Day = "15";
                    break;

                case 15:
                    str_Day = "16";
                    break;

                case 16:
                    str_Day = "17";
                    break;

                case 17:
                    str_Day = "18";
                    break;

                case 18:
                    str_Day = "19";
                    break;

                case 19:
                    str_Day = "20";
                    break;

                case 20:
                    str_Day = "21";
                    break;

                case 21:
                    str_Day = "22";
                    break;

                case 22:
                    str_Day = "23";
                    break;

                case 23:
                    str_Day = "24";
                    break;

                case 24:
                    str_Day = "25";
                    break;

                case 25:
                    str_Day = "26";
                    break;

                case 26:
                    str_Day = "27";
                    break;

                case 27:
                    str_Day = "28";
                    break;

                case 28:
                    str_Day = "29";
                    break;

                case 29:
                    str_Day = "30";
                    break;

                case 30:
                    str_Day = "31";
                    break;

            }

            Get_Data();
        }

        #endregion
    }
}
