// Updated by XamlIntelliSenseFileGenerator 4/25/2024 9:17:27 PM
#pragma checksum "..\..\..\CreateJob.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F7864C9A3D8F2ADEEAE89C38E141DFAC2058BCA"
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


namespace FinalProject
{


    /// <summary>
    /// CreateJob
    /// </summary>
    public partial class CreateJob : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 30 "..\..\..\CreateJob.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbCompanyName;

#line default
#line hidden


#line 34 "..\..\..\CreateJob.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbName;

#line default
#line hidden


#line 46 "..\..\..\CreateJob.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbLocation;

#line default
#line hidden


#line 101 "..\..\..\CreateJob.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;

#line default
#line hidden


#line 102 "..\..\..\CreateJob.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPost;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FinalProject;component/createjob.xaml", System.UriKind.Relative);

#line 1 "..\..\..\CreateJob.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.txtbCompanyName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.txtbName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.txtbLocation = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.cbbSalary = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.btnSave = ((System.Windows.Controls.Button)(target));

#line 101 "..\..\..\CreateJob.xaml"
                    this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btnPost = ((System.Windows.Controls.Button)(target));

#line 102 "..\..\..\CreateJob.xaml"
                    this.btnPost.Click += new System.Windows.RoutedEventHandler(this.btnPost_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtbSalary;
        internal System.Windows.Controls.TextBox txtbExperience;
    }
}

