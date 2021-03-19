﻿#pragma checksum "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD459620C06C0E807748F6B7631CEF7514D5DCC9"
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
using PharmacyHajiawa.Views.Items.item;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PharmacyHajiawa.Views.Items.item {
    
    
    /// <summary>
    /// ItemPage
    /// </summary>
    public partial class ItemPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemoveSearchText;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxSeatch;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblockItemName;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mainDatagrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;V1.0.0.0;component/views/items/item/itempage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            ((PharmacyHajiawa.Views.Items.item.ItemPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.OnBackClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 53 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeletedClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 54 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAvailableClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 63 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemoveSearchText = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            this.buttonRemoveSearchText.Click += new System.Windows.RoutedEventHandler(this.OnRemoveTextboxSearch);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textboxSeatch = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            this.textboxSeatch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnItemTextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textblockItemName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.mainDatagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 139 "..\..\..\..\..\..\..\Views\Items\item\ItemPage.xaml"
            this.mainDatagrid.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.mainDatagrid_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
