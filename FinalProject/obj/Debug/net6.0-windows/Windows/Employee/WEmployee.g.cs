﻿#pragma checksum "..\..\..\..\..\Windows\Employee\WEmployee.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D321D0F490601609270F9FA8E50134A6032334D2"
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
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// WEmployee
    /// </summary>
    public partial class WEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FinalProject.UCPopUp popupControl;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbName;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
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
            System.Uri resourceLocater = new System.Uri("/FinalProject;component/windows/employee/wemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
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
            
            #line 18 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((FinalProject.WEmployee)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
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
            
            #line 116 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnViecLam_MouseEnter);
            
            #line default
            #line hidden
            
            #line 117 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnViecLam_MouseLeave);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnViecLam_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 126 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnHoSo_MouseEnter);
            
            #line default
            #line hidden
            
            #line 127 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnHoSo_MouseLeave);
            
            #line default
            #line hidden
            
            #line 127 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHoSo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 135 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnCongty_MouseEnter);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnCongTy_MouseLeave);
            
            #line default
            #line hidden
            
            #line 137 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCongTy_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 144 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnTin_MouseEnter);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnTin_MouseLeave);
            
            #line default
            #line hidden
            
            #line 146 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnTin_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 153 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnQuanTam_MouseEnter);
            
            #line default
            #line hidden
            
            #line 154 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnQuanTam_MouseLeave);
            
            #line default
            #line hidden
            
            #line 155 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnQuanTam_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 164 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnThongBao_MouseEnter);
            
            #line default
            #line hidden
            
            #line 165 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnThongBao_MouseLeave);
            
            #line default
            #line hidden
            
            #line 166 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnThongBao_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 173 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLichHen_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.mainFarm = ((System.Windows.Controls.Frame)(target));
            
            #line 217 "..\..\..\..\..\Windows\Employee\WEmployee.xaml"
            this.mainFarm.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.mainFarm_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

