﻿#pragma checksum "..\..\..\OtherForms\LightUpDownWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5C94503D8C569FE539B61B836F8A09A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApplicationPicture.OtherForms;


namespace WpfApplicationPicture.OtherForms {
    
    
    /// <summary>
    /// LightUpDownWindow
    /// </summary>
    public partial class LightUpDownWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\OtherForms\LightUpDownWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelLightUpDown;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\OtherForms\LightUpDownWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderLightUpDown;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\OtherForms\LightUpDownWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ValueLabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\OtherForms\LightUpDownWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplicationPicture;component/otherforms/lightupdownwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OtherForms\LightUpDownWindow.xaml"
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
            this.LabelLightUpDown = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.SliderLightUpDown = ((System.Windows.Controls.Slider)(target));
            
            #line 13 "..\..\..\OtherForms\LightUpDownWindow.xaml"
            this.SliderLightUpDown.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderLightUpDown_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ValueLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\OtherForms\LightUpDownWindow.xaml"
            this.ConfirmButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

