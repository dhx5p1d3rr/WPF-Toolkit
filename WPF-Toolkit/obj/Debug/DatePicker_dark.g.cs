﻿#pragma checksum "..\..\DatePicker_dark.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CACFEFE0F04A745118A58C1F4637AA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF_Toolkit;


namespace WPF_Toolkit {
    
    
    /// <summary>
    /// DatePicker_dark
    /// </summary>
    public partial class DatePicker_dark : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_month;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_year;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_day;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_date;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_hour;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_time;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_minute_Copy;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\DatePicker_dark.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_seconds;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-Toolkit;component/datepicker_dark.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DatePicker_dark.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\DatePicker_dark.xaml"
            ((WPF_Toolkit.DatePicker_dark)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.cb_month = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\DatePicker_dark.xaml"
            this.cb_month.DropDownClosed += new System.EventHandler(this.cb_month_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cb_year = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\DatePicker_dark.xaml"
            this.cb_year.DropDownClosed += new System.EventHandler(this.cb_year_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb_day = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\DatePicker_dark.xaml"
            this.cb_day.DropDownClosed += new System.EventHandler(this.cb_day_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_date = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.groupBox_Copy = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.cb_hour = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\DatePicker_dark.xaml"
            this.cb_hour.DropDownClosed += new System.EventHandler(this.cb_hour_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_time = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.cb_minute_Copy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\DatePicker_dark.xaml"
            this.cb_minute_Copy.DropDownClosed += new System.EventHandler(this.cb_minute_Copy_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cb_seconds = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\DatePicker_dark.xaml"
            this.cb_seconds.DropDownClosed += new System.EventHandler(this.cb_seconds_DropDownClosed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

