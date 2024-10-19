﻿#pragma checksum "..\..\..\Pages\Tower.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92B72011E715169A794B09661C202C4746FA63E89B5E134B360FF64669DAAB8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Tower_of_Hanoi.Pages {
    
    
    /// <summary>
    /// Tower
    /// </summary>
    public partial class Tower : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tower_of_Hanoi.Pages.Tower TowerPage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToStartPageButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas TowerCanvas;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ControlsGrid;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FastReverseButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrevMoveButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayPauseButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextMoveButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\Tower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FastForwardButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Tower of Hanoi;component/pages/tower.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Tower.xaml"
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
            this.TowerPage = ((Tower_of_Hanoi.Pages.Tower)(target));
            return;
            case 2:
            this.BackToStartPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\Tower.xaml"
            this.BackToStartPageButton.Click += new System.Windows.RoutedEventHandler(this.BackToStartPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TowerCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.ControlsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.SpeedSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 57 "..\..\..\Pages\Tower.xaml"
            this.SpeedSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SpeedSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FastReverseButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\Tower.xaml"
            this.FastReverseButton.Click += new System.Windows.RoutedEventHandler(this.FastReverseButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PrevMoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Pages\Tower.xaml"
            this.PrevMoveButton.Click += new System.Windows.RoutedEventHandler(this.PrevMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PlayPauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\Tower.xaml"
            this.PlayPauseButton.Click += new System.Windows.RoutedEventHandler(this.PlayPauseButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NextMoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Pages\Tower.xaml"
            this.NextMoveButton.Click += new System.Windows.RoutedEventHandler(this.NextMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FastForwardButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Pages\Tower.xaml"
            this.FastForwardButton.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.FastForwardButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

