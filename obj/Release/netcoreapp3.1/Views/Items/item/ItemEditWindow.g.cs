﻿#pragma checksum "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EC53DAA7B7FF94A6132B75B66B3994A3893FA7DC"
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
    /// ItemEditWindow
    /// </summary>
    public partial class ItemEditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxBarcode;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxScienceName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxCommericalName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxPublicName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxPwoer;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;component/views/items/item/itemeditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
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
            
            #line 10 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
            ((PharmacyHajiawa.Views.Items.item.ItemEditWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textboxBarcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textboxScienceName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textboxCommericalName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textboxPublicName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textboxPwoer = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
            this.textboxPwoer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textboxPwoer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 61 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCheckClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.OnDeleteClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\..\..\..\..\Views\Items\item\ItemEditWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

