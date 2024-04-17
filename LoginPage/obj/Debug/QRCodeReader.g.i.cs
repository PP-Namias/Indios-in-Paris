﻿#pragma checksum "..\..\QRCodeReader.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A557CF59BE8527BCB15064D33F78BA1F2188D672B00097C7F7C796C6FF67EDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoginPage;
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


namespace LoginPage {
    
    
    /// <summary>
    /// QRCodeReader
    /// </summary>
    public partial class QRCodeReader : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image videoFrame;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QRTextBlock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FrameCounterTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QRCounterTextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartStopButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button helpButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button camSwitchButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button recordButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\QRCodeReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label camsLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginPage;component/qrcodereader.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QRCodeReader.xaml"
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
            
            #line 8 "..\..\QRCodeReader.xaml"
            ((LoginPage.QRCodeReader)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.videoFrame = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.QRTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.FrameCounterTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.QRCounterTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.StartStopButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\QRCodeReader.xaml"
            this.StartStopButton.Click += new System.Windows.RoutedEventHandler(this.StartStopButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.helpButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\QRCodeReader.xaml"
            this.helpButton.Click += new System.Windows.RoutedEventHandler(this.helpButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.camSwitchButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\QRCodeReader.xaml"
            this.camSwitchButton.Click += new System.Windows.RoutedEventHandler(this.camSwitchButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.recordButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\QRCodeReader.xaml"
            this.recordButton.Click += new System.Windows.RoutedEventHandler(this.recordButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.camsLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
