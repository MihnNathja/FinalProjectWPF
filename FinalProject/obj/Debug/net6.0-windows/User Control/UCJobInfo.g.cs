﻿#pragma checksum "..\..\..\..\User Control\UCJobInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63B4C2EBD2CA6C1A44D21FDF7192BD699761041B"
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
    /// UCJobInfo
    /// </summary>
    public partial class UCJobInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Logo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label JobName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteJob;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CompanyName;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Salary;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\User Control\UCJobInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock JobLocation;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalProject;component/user%20control/ucjobinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\User Control\UCJobInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            
            #line 12 "..\..\..\..\User Control\UCJobInfo.xaml"
            ((FinalProject.UCJobInfo)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UCJobInfo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Logo = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.JobName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnDeleteJob = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\User Control\UCJobInfo.xaml"
            this.btnDeleteJob.Click += new System.Windows.RoutedEventHandler(this.btnDeleteJob_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CompanyName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Salary = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.JobLocation = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

