﻿#pragma checksum "..\..\MainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6497EF94B8377196A8ABE371A0B641076590146C0CFFBB63531DB89990B21F17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// MainMenu
    /// </summary>
    public partial class MainMenu : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 248 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton MenuToggleButton;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Home;
        
        #line default
        #line hidden
        
        
        #line 277 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_StudentAttendance;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LoginLogs;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Reports;
        
        #line default
        #line hidden
        
        
        #line 298 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SystemAdministration;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LogOut;
        
        #line default
        #line hidden
        
        
        #line 318 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserPages;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Snackbar MainSnackbar;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginPage;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainMenu.xaml"
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
            
            #line 23 "..\..\MainMenu.xaml"
            ((LoginPage.MainMenu)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 58 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_Home_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 81 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_AttendanceAdd_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 93 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_AttendanceEdit_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 117 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_LoginList_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 129 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_LoginAdd_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 141 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_LoginEdit_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 165 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_ReportsAdd_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 177 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_ReportsEdit_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 189 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_ReportsList_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 213 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_SystemAdd_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 225 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_SystemEdit_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 237 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeItem_SystemList_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.MenuToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 248 "..\..\MainMenu.xaml"
            this.MenuToggleButton.Checked += new System.Windows.RoutedEventHandler(this.MenuToggleButton_Checked);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 251 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuPopupLogoutButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 254 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuPopupAboutButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btn_Home = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            
            #line 273 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_0);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btn_StudentAttendance = ((System.Windows.Controls.Button)(target));
            return;
            case 20:
            
            #line 280 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btn_LoginLogs = ((System.Windows.Controls.Button)(target));
            return;
            case 22:
            
            #line 287 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_2);
            
            #line default
            #line hidden
            return;
            case 23:
            this.btn_Reports = ((System.Windows.Controls.Button)(target));
            return;
            case 24:
            
            #line 294 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_3);
            
            #line default
            #line hidden
            return;
            case 25:
            this.btn_SystemAdministration = ((System.Windows.Controls.Button)(target));
            return;
            case 26:
            
            #line 301 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_4);
            
            #line default
            #line hidden
            return;
            case 27:
            this.btn_LogOut = ((System.Windows.Controls.Button)(target));
            return;
            case 28:
            
            #line 308 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown_5);
            
            #line default
            #line hidden
            return;
            case 29:
            this.UserPages = ((System.Windows.Controls.Grid)(target));
            return;
            case 30:
            this.MainSnackbar = ((MaterialDesignThemes.Wpf.Snackbar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

