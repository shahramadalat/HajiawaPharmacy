﻿#pragma checksum "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7B90E0AC9FD09ED2A1B02F1EE059073A0A2DB78A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PharmacyHajiawa.Views.Message;
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


namespace PharmacyHajiawa.Views.Message {
    
    
    /// <summary>
    /// DisplayAlert
    /// </summary>
    public partial class DisplayAlert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTitle;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMessage;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFirst;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button secondbutton;
        
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
            System.Uri resourceLocater = new System.Uri("/PharmacyHajiawa;V1.0.0.0;component/views/message/displayalert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
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
            this.txtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
            this.btnFirst.Click += new System.Windows.RoutedEventHandler(this.OnOkClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.secondbutton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\..\Views\Message\DisplayAlert.xaml"
            this.secondbutton.Click += new System.Windows.RoutedEventHandler(this.OnSecondClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

