﻿#pragma checksum "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D618EB1DE7EDE255EFB6BEB7350A8ED35FE62F4C"
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
using PharmacyHajiawa.Views.Store.Buy;
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


namespace PharmacyHajiawa.Views.Store.Buy {
    
    
    /// <summary>
    /// PacketWindow
    /// </summary>
    public partial class PacketWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inPacket;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inPacketBuyPrice;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inPacketSellPrice;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inPacketQuantity;
        
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
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;component/views/store/buy/packetwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
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
            
            #line 10 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            ((PharmacyHajiawa.Views.Store.Buy.PacketWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inPacket = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            this.inPacket.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inPacket_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.inPacketBuyPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            this.inPacketBuyPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inPacketPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inPacketSellPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            this.inPacketSellPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inSellPacketPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.inPacketQuantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            this.inPacketQuantity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inPacketQuantity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 36 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCheckClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\..\..\..\..\..\Views\Store\Buy\PacketWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

