﻿#pragma checksum "..\..\LogInWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "537AB8AB1771CD9E9F017ED99864ABE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace CIOETsketch1 {
    
    
    /// <summary>
    /// LogInWindow
    /// </summary>
    public partial class LogInWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CIOETsketch1.LogInWindow Window;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonHelp;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot_Copy;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btLogin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbuser;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbpass;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblog;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing progressRingLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/CIOETsketch1;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogInWindow.xaml"
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
            this.Window = ((CIOETsketch1.LogInWindow)(target));
            return;
            case 2:
            this.ButtonHelp = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.LayoutRoot_Copy = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btLogin = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\LogInWindow.xaml"
            this.btLogin.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbpass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 35 "..\..\LogInWindow.xaml"
            this.tbpass.GotFocus += new System.Windows.RoutedEventHandler(this.tbpass_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblog = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.progressRingLogin = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

