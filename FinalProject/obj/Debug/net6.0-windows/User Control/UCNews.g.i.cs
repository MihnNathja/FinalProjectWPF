﻿#pragma checksum "..\..\..\..\User Control\UCNews.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211252FB658CD52BF65B68F857841C7209EF9540"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalProject.User_Control;
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


namespace FinalProject.User_Control {
    
    
    /// <summary>
    /// UCNews
    /// </summary>
    public partial class UCNews : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Logo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetail;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock JobName;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteJob;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInterest;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon favorite;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Experience;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WorkTime;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Salary;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\User Control\UCNews.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Location;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalProject;V1.0.0.0;component/user%20control/ucnews.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\User Control\UCNews.xaml"
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
            
            #line 18 "..\..\..\..\User Control\UCNews.xaml"
            ((FinalProject.User_Control.UCNews)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Logo = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.btnDetail = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\User Control\UCNews.xaml"
            this.btnDetail.Click += new System.Windows.RoutedEventHandler(this.btnDetail_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.JobName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnDeleteJob = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\User Control\UCNews.xaml"
            this.btnDeleteJob.Click += new System.Windows.RoutedEventHandler(this.btnDeleteJob_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnInterest = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\User Control\UCNews.xaml"
            this.btnInterest.Click += new System.Windows.RoutedEventHandler(this.btnInterest_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.favorite = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 8:
            this.Experience = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.WorkTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Salary = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Location = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

