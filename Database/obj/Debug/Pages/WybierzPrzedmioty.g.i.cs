﻿#pragma checksum "..\..\..\Pages\WybierzPrzedmioty.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "573C0FB2668F97365DF1A1DB3558837C502B9548EFA17B78669090643C98023C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using KalkulatorOcen.Pages;
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


namespace KalkulatorOcen.Pages {
    
    
    /// <summary>
    /// WybierzPrzedmioty
    /// </summary>
    public partial class WybierzPrzedmioty : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Pages\WybierzPrzedmioty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WybierzPrzedmiotDalej;
        
        #line default
        #line hidden
        
        /// <summary>
        /// WybierzPrzedmiotyList Name Field
        /// </summary>
        
        #line 12 "..\..\..\Pages\WybierzPrzedmioty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.ListBox WybierzPrzedmiotyList;
        
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
            System.Uri resourceLocater = new System.Uri("/Database;component/pages/wybierzprzedmioty.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\WybierzPrzedmioty.xaml"
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
            this.WybierzPrzedmiotDalej = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Pages\WybierzPrzedmioty.xaml"
            this.WybierzPrzedmiotDalej.Click += new System.Windows.RoutedEventHandler(this.WybierzPrzedmiotDalej_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WybierzPrzedmiotyList = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\..\Pages\WybierzPrzedmioty.xaml"
            this.WybierzPrzedmiotyList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.WybierzPrzedmiotyList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

