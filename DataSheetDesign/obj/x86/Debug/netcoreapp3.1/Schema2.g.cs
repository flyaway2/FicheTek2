﻿#pragma checksum "..\..\..\..\Schema2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3FBB41B90082EB0BB14FECCAFB3CCC51F00621F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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


namespace DataSheetDesign {
    
    
    /// <summary>
    /// Schema2
    /// </summary>
    public partial class Schema2 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 116 "..\..\..\..\Schema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FicheTec;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\..\Schema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Board;
        
        #line default
        #line hidden
        
        
        #line 300 "..\..\..\..\Schema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ChaineBoard;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DataSheetDesign;component/schema2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Schema2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 20 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 38 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 110 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 111 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FicheTec = ((System.Windows.Controls.Grid)(target));
            
            #line 116 "..\..\..\..\Schema2.xaml"
            this.FicheTec.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Board_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Board = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 9:
            this.ChaineBoard = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 214 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Primitives.UniformGrid)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.UniformGrid_GotFocus);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 233 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.Border_GotFocus);
            
            #line default
            #line hidden
            
            #line 234 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.Border_LostFocus);
            
            #line default
            #line hidden
            
            #line 235 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 326 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown_1);
            
            #line default
            #line hidden
            
            #line 327 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.Border_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 328 "..\..\..\..\Schema2.xaml"
            ((System.Windows.Controls.Border)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.Border_GotFocus_1);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

