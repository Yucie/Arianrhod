﻿#pragma checksum "..\..\..\LoginWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AD41864A0880C398A81130DBF4DAE43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bama.Controls;
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


namespace InstanceAnswerPro {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.StackPanel inputFrame;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.ComboBox accounts;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.CheckBox rememberPasswordCheckBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.Button Enter;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.Button Setup;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\LoginWindow.xaml"
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InstanceAnswerPro;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.inputFrame = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.accounts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.rememberPasswordCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.Enter = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\LoginWindow.xaml"
            this.Enter.Click += new System.Windows.RoutedEventHandler(this.Enter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Setup = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\LoginWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Enter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

