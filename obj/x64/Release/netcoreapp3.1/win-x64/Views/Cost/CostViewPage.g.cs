﻿#pragma checksum "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5342A086D3FFFC41EE74210B00B183278B3DCC6"
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
using PharmacyHajiawa.Views.Cost;
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


namespace PharmacyHajiawa.Views.Cost {
    
    
    /// <summary>
    /// CostViewPage
    /// </summary>
    public partial class CostViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemoveSearchText;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxSeatch;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblockItemName;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;component/views/cost/costviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
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
            
            #line 9 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            ((PharmacyHajiawa.Views.Cost.CostViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 36 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeletedClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 37 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAvailableClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonRemoveSearchText = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            this.buttonRemoveSearchText.Click += new System.Windows.RoutedEventHandler(this.OnRemoveTextboxSearch);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textboxSeatch = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            this.textboxSeatch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnItemTextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textblockItemName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.mainDatagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 122 "..\..\..\..\..\..\..\Views\Cost\CostViewPage.xaml"
            this.mainDatagrid.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.mainDatagrid_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

