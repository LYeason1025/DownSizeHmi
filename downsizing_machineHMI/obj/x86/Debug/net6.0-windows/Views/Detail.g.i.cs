﻿#pragma checksum "..\..\..\..\..\Views\Detail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9E72972A17106D6E89C2208C6C1A238EEA1E9E31"
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
    /// Detail
    /// </summary>
    public partial class Detail : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl DetailContent;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WaferResset;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TimeResset;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Detail_1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Detail_2;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\Views\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Detail_Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/downsizing_machineHMI;V1.0.0.0;component/views/detail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Detail.xaml"
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
            this.DetailContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.WaferResset = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.TimeResset = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Detail_1 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 47 "..\..\..\..\..\Views\Detail.xaml"
            this.Detail_1.Checked += new System.Windows.RoutedEventHandler(this.Detail_1_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Detail_2 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 57 "..\..\..\..\..\Views\Detail.xaml"
            this.Detail_2.Checked += new System.Windows.RoutedEventHandler(this.Detail_2_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Detail_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\Views\Detail.xaml"
            this.Detail_Exit.Click += new System.Windows.RoutedEventHandler(this.Detail_Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
