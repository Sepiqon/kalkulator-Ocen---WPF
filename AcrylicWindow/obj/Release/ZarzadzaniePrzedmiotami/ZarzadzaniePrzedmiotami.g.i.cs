﻿#pragma checksum "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2B0469E2B9E6C599DFF2A7732584A8A6B3B6282955620C091A250FEBCEB033CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using KalkulatorOcen.Zapisz;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SourceChord.FluentWPF;
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


namespace KalkulatorOcen.ZarzadzaniePrzedmiotami {
    
    
    /// <summary>
    /// ZarzadzaniePrzedmiotami
    /// </summary>
    public partial class ZarzadzaniePrzedmiotami : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsunButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListaPrzedmiotow;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwaPrzedmiotuTB;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZapiszButton;
        
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
            System.Uri resourceLocater = new System.Uri("/KalkulatorOcen;component/zarzadzanieprzedmiotami/zarzadzanieprzedmiotami.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
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
            
            #line 10 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
            ((KalkulatorOcen.ZarzadzaniePrzedmiotami.ZarzadzaniePrzedmiotami)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsunButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
            this.UsunButton.Click += new System.Windows.RoutedEventHandler(this.UsunButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DodajButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
            this.DodajButton.Click += new System.Windows.RoutedEventHandler(this.DodajButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListaPrzedmiotow = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.NazwaPrzedmiotuTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ZapiszButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\ZarzadzaniePrzedmiotami\ZarzadzaniePrzedmiotami.xaml"
            this.ZapiszButton.Click += new System.Windows.RoutedEventHandler(this.ZapiszButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

