﻿#pragma checksum "..\..\..\..\UIModule\SelectedDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F569F8460A6E56183EF8B39A5EB3BCEE9519B8E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using K5E_Memory_Map.UIModule;
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


namespace K5E_Memory_Map.UIModule {
    
    
    /// <summary>
    /// SelectedDetails
    /// </summary>
    public partial class SelectedDetails : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextInput;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EdgeButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IMB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button K5EB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WCB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel O2States;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel O1States;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\UIModule\SelectedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel O3States;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/K5E Memory Map;component/uimodule/selecteddetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UIModule\SelectedDetails.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 18 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveText);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 20 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddUnder);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 21 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelBelow);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 22 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelNode);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EdgeButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\UIModule\SelectedDetails.xaml"
            this.EdgeButton.Click += new System.Windows.RoutedEventHandler(this.DelEdge);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IMB = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\UIModule\SelectedDetails.xaml"
            this.IMB.Click += new System.Windows.RoutedEventHandler(this.IM);
            
            #line default
            #line hidden
            return;
            case 9:
            this.K5EB = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\UIModule\SelectedDetails.xaml"
            this.K5EB.Click += new System.Windows.RoutedEventHandler(this.K5E);
            
            #line default
            #line hidden
            return;
            case 10:
            this.WCB = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\UIModule\SelectedDetails.xaml"
            this.WCB.Click += new System.Windows.RoutedEventHandler(this.WC);
            
            #line default
            #line hidden
            return;
            case 11:
            this.O2States = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            
            #line 35 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 36 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 37 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 38 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 39 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 40 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 41 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 42 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 43 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 21:
            this.O1States = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 22:
            
            #line 47 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 48 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 49 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 50 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 51 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 52 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 53 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 54 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 55 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 31:
            this.O3States = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 32:
            
            #line 59 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 60 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 61 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 62 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 63 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 64 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 65 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 66 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 67 "..\..\..\..\UIModule\SelectedDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadState);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
