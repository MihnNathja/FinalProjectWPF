﻿#pragma checksum "..\..\..\CompanyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14AF5734B55D62512C5AE0FFD485BD5F7A5CE395"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalProject;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace FinalProject {
    
    
    /// <summary>
    /// CompanyWindow
    /// </summary>
    public partial class CompanyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FinalProject.UCPopUp popupControl;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbName;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbLocation;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbExperience;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\CompanyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFarm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FinalProject;component/companywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CompanyWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\CompanyWindow.xaml"
            ((FinalProject.CompanyWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.CompanyWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\CompanyWindow.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\CompanyWindow.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.popupControl = ((FinalProject.UCPopUp)(target));
            return;
            case 6:
            this.txtbName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 98 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnViecLam_MouseEnter);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnViecLam_MouseLeave);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnViecLam_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 108 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnHoSo_MouseEnter);
            
            #line default
            #line hidden
            
            #line 109 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnHoSo_MouseLeave);
            
            #line default
            #line hidden
            
            #line 109 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHoSo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 117 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnCongty_MouseEnter);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnCongTy_MouseLeave);
            
            #line default
            #line hidden
            
            #line 119 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCongTy_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 126 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnQuanTam_MouseEnter);
            
            #line default
            #line hidden
            
            #line 127 "..\..\..\CompanyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnQuanTam_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\CompanyWindow.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.cbbLocation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.cbbExperience = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 203 "..\..\..\CompanyWindow.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.mainFarm = ((System.Windows.Controls.Frame)(target));
            
            #line 213 "..\..\..\CompanyWindow.xaml"
            this.mainFarm.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.mainFarm_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

