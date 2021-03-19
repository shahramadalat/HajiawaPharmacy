﻿#pragma checksum "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B36A93EB6E6227FB0117EAC16986C156FE2CC6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PharmacyHajiawa.Views.Store.Sell;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PharmacyHajiawa.Views.Store.Sell {
    
    
    /// <summary>
    /// PrintWindow
    /// </summary>
    public partial class PrintWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPrint;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrint;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvoiceNumber;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker timePicker;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mainDatagrid;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label inTotal;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label inDiscount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;component/views/store/sell/printwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
            ((PharmacyHajiawa.Views.Store.Sell.PrintWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridPrint = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
            this.btnPrint.Click += new System.Windows.RoutedEventHandler(this.OnPrintClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 91 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnBackClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 110 "..\..\..\..\..\..\..\..\Views\Store\Sell\PrintWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnIgnoreClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblInvoiceNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.timePicker = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 9:
            this.mainDatagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.inTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.inDiscount = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

