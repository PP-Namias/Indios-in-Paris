﻿#pragma checksum "..\..\ReportsandAnalytics.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7588DFD93DE87D7DC935B67975441F2D1723124B58C74ADDF6813CE1EF178A25"
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
using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// ReportsandAnalytics
    /// </summary>
    public partial class ReportsandAnalytics : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserPages;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid topgrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WelcomeMessage;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer mainscrollviewer;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AttendanceReports;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AbsenteeismAnalysisModule;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\ReportsandAnalytics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportList;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginPage;component/reportsandanalytics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReportsandAnalytics.xaml"
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
            this.UserPages = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.topgrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.WelcomeMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.mainscrollviewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.AttendanceReports = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\ReportsandAnalytics.xaml"
            this.AttendanceReports.Click += new System.Windows.RoutedEventHandler(this.AttendanceReports_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AbsenteeismAnalysisModule = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\ReportsandAnalytics.xaml"
            this.AbsenteeismAnalysisModule.Click += new System.Windows.RoutedEventHandler(this.AbsenteeismAnalysisModule_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReportList = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\ReportsandAnalytics.xaml"
            this.ReportList.Click += new System.Windows.RoutedEventHandler(this.ReportList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

