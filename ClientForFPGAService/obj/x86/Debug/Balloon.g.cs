﻿#pragma checksum "..\..\..\Balloon.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C21E013EFDB1E4E12854D1B9860260A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hardcodet.Wpf.TaskbarNotification;
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


namespace ClientForFPGAService {
    
    
    /// <summary>
    /// Balloon
    /// </summary>
    public partial class Balloon : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ClientForFPGAService.Balloon me;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard FadeIn_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard HighlightCloseButton_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard FadeCloseButton_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard FadeBack_BeginStoryboard1;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard FadeOut_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgClose;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientForFPGAService;component/balloon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Balloon.xaml"
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
            this.me = ((ClientForFPGAService.Balloon)(target));
            return;
            case 2:
            
            #line 53 "..\..\..\Balloon.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).Completed += new System.EventHandler(this.OnFadeOutCompleted);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FadeIn_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 4:
            this.HighlightCloseButton_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 5:
            this.FadeCloseButton_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 6:
            this.FadeBack_BeginStoryboard1 = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 7:
            this.FadeOut_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 8:
            this.grid = ((System.Windows.Controls.Grid)(target));
            
            #line 90 "..\..\..\Balloon.xaml"
            this.grid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.grid_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 9:
            this.imgClose = ((System.Windows.Controls.Image)(target));
            
            #line 158 "..\..\..\Balloon.xaml"
            this.imgClose.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgClose_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

