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
    public partial class DatePicker_dark : UserControl
    {
        #region Variablen

        //////////////////////////////////////////////////
        /// Public

        public DateTime dt_Datum { get; set; }

        public string str_Year { get; set; }
        public string str_Month { get; set; }
        public string str_Day { get; set; }
        public string str_Hour { get; set; }
        public string str_Minute { get; set; }
        public string str_Seconds { get; set; }

        //////////////////////////////////////////////////

        //////////////////////////////////////////////////
        /// Private

        private int i_year;
        private int i_month;
        private int i_day;
        private int i_hour;
        private int i_minute;
        private int i_second;
        private string str_Sec;
        private bool bcb_fail;
        private int i_turns = 0;

        ///////////////////////////////////////////////////

        #endregion

        #region Constructor

        public DatePicker_dark()
        {
            InitializeComponent();
            this.Width = 195;
            this.Height = 175;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            init();
        }

        private void init()
        {
            int i, i1, m, y;

            switch (i_turns)
            {
                case 0:     // Year Combo Box Items

                    i = DateTime.Now.Year;
                    i = i - 51;
                    y = i + 101;
                    while (i++ < y)
                    {
                        cb_year.Items.Add(i);
                    }
                    cb_year.SelectedIndex = 50;
                    i_turns++;
                    break;

                case 1:     // Month Combo Box Items

                    i = 0;
                    while (i++ < 12)
                    {
                        if (i < 10)
                        {
                            cb_month.Items.Add("0" + i);
                        }
                        else
                        {
                            cb_month.Items.Add(i);
                        }
                    }
                    cb_month.IsEnabled = true;
                    i_turns++;
                    break;

                case 2:     // Day Combo Box Items

                    i = 0;
                    m = Convert.ToInt32(str_Month);
                    y = Convert.ToInt32(str_Year);
                    i1 = DateTime.DaysInMonth(y, m);

                    while (i++ < i1)
                    {
                        if (i < 10)
                        {
                            cb_day.Items.Add("0" + i);
                        }
                        else
                        {
                            cb_day.Items.Add(i);
                        }
                    }
                    cb_day.IsEnabled = true;
                    i_turns++;
                    break;

                case 3:     // Hours, Minutes and Seconds Combo Box Items

                    i = 0;          //Hours
                    while (i++ < 23)
                    {
                        if (i < 10)
                        {
                            cb_hour.Items.Add("0" + i);
                        }
                        else
                        {
                            cb_hour.Items.Add(i);
                        }
                    }
                    cb_hour.Items.Add("00");

                    i = -1;         //Minutes
                    while (i++ < 59)
                    {
                        if (i < 10)
                        {
                            cb_minute_Copy.Items.Add("0" + i);
                        }
                        else
                        {
                            cb_minute_Copy.Items.Add(i);
                        }
                    }

                    i = -1;         //Seconds
                    while (i++ < 59)
                    {
                        if (i < 10)
                        {
                            cb_seconds.Items.Add("0" + i);
                        }
                        else
                        {
                            cb_seconds.Items.Add(i);
                        }
                    }
                    cb_hour.IsEnabled = true;
                    break;
            }
        }

        #endregion

        #region Events

        private void cb_year_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_year.SelectedIndex != -1)
            {
                str_Year = cb_year.Text;
                init();
            }
        }

        private void cb_month_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_month.SelectedIndex != -1)
            {
                str_Month = cb_month.Text;
                init();
            }
        }

        private void cb_day_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_day.SelectedIndex != -1)
            {
                str_Day = cb_day.Text;
                init();
            }
        }

        private void cb_hour_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_hour.SelectedIndex != -1)
            {
                str_Hour = cb_hour.Text;
                cb_minute_Copy.IsEnabled = true;
            }
        }

        private void cb_minute_Copy_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_minute_Copy.SelectedIndex != -1)
            {
                str_Minute = cb_minute_Copy.Text;
                cb_seconds.IsEnabled = true;
            }
        }

        private void cb_seconds_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_seconds.SelectedIndex != -1)
            {
                str_Seconds = cb_seconds.Text;
                Get_Data();
            }
        }

        #endregion

        #region Funktionen

        private void Get_Data()
        {
            try
            {
                i_year = Convert.ToInt32(str_Year);
                i_month = Convert.ToInt32(str_Month);
                i_day = Convert.ToInt32(str_Day);

                i_hour = Convert.ToInt32(str_Hour);
                i_minute = Convert.ToInt32(str_Minute);
                i_second = Convert.ToInt32(str_Seconds);

            }

            catch (Exception) { Console.WriteLine("Exept. in Get_Data!"); }

            finally
            {
                lbl_date.Content = str_Day + "." + str_Month + "." + str_Year;
                lbl_time.Content = str_Hour + ":" + str_Minute + "." + str_Seconds;

                Build_Time(i_year, i_month, i_day, i_hour, i_minute, i_second);
            }

        }

        private void Build_Time(int year, int month, int day, int hour, int minute, int second)
        {
            dt_Datum = new DateTime(year, month, day, hour, minute, second);

            Aufräumen();
        }

        private void Aufräumen()
        {
            var dp = new DatePicker_dark();

            i_turns = 1;

            cb_year.SelectedIndex = 50;
            cb_month.SelectedIndex = -1;
            cb_day.SelectedIndex = -1;
            cb_hour.SelectedIndex = -1;
            cb_minute_Copy.SelectedIndex = -1;
            cb_seconds.SelectedIndex = -1;

            cb_month.IsEnabled = false;
            cb_day.IsEnabled = false;
            cb_hour.IsEnabled = false;
            cb_minute_Copy.IsEnabled = false;
            cb_seconds.IsEnabled = false;

            cb_month.Items.Clear();
            cb_day.Items.Clear();
            cb_hour.Items.Clear();
            cb_minute_Copy.Items.Clear();
            cb_seconds.Items.Clear();


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
            int s = cb_minute_Copy.SelectedIndex;

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

            //Get_Data();
        }



        #endregion

    }
}
