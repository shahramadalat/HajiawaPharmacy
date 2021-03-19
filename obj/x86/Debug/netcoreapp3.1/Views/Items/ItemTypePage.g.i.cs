﻿#pragma checksum "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA12144B407B39E7013B23B6FAFE8990C9A7AD8A"
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
using PharmacyHajiawa.Views.Items;
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


namespace PharmacyHajiawa.Views.Items {
    
    
    /// <summary>
    /// ItemTypePage
    /// </summary>
    public partial class ItemTypePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackTest;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemoveSearchText;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxSeatch;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;V1.0.0.0;component/views/items/itemtypepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
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
            
            #line 10 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            ((PharmacyHajiawa.Views.Items.ItemTypePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stackTest = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 41 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeletedClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 42 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAvailableClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 48 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemoveSearchText = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            this.buttonRemoveSearchText.Click += new System.Windows.RoutedEventHandler(this.OnRemoveTextboxSearch);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textboxSeatch = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            this.textboxSeatch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnItemTextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainDatagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 113 "..\..\..\..\..\..\Views\Items\ItemTypePage.xaml"
            this.mainDatagrid.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.mainDatagrid_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

