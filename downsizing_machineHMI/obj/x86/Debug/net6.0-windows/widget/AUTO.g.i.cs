﻿#pragma checksum "..\..\..\..\..\widget\AUTO.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669205B95E9C3FE327E085A6C6B4CA6477A4D598"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using downsizing_machineHMI.widget;


namespace downsizing_machineHMI.widget {
    
    
    /// <summary>
    /// AUTO
    /// </summary>
    public partial class AUTO : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDTextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button List;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Detail;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Option;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DetailStatus;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\..\..\widget\AUTO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Log;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/downsizing_machineHMI;component/widget/auto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\widget\AUTO.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.List = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\..\widget\AUTO.xaml"
            this.List.Click += new System.Windows.RoutedEventHandler(this.List_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Detail = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\..\..\widget\AUTO.xaml"
            this.Detail.Click += new System.Windows.RoutedEventHandler(this.Detail_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Option = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.DetailStatus = ((System.Windows.Controls.Button)(target));
            
            #line 235 "..\..\..\..\..\widget\AUTO.xaml"
            this.DetailStatus.Click += new System.Windows.RoutedEventHandler(this.Detail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Log = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

