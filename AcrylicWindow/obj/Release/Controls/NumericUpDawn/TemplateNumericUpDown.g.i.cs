﻿#pragma checksum "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F0BACC441C63AC62D48737C135696A636B968413FFFC4970FB6538B22A68A9DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UserControlTemplate;


namespace UserControlTemplate {
    
    
    /// <summary>
    /// TemplateNumericUpDown
    /// </summary>
    public partial class TemplateNumericUpDown : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox txtNum;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button cmdUp;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button cmdDown;
        
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
            System.Uri resourceLocater = new System.Uri("/KalkulatorOcen;component/controls/numericupdawn/templatenumericupdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
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
            this.txtNum = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
            this.txtNum.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtNum_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmdUp = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
            this.cmdUp.Click += new System.Windows.RoutedEventHandler(this.CmdUp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmdDown = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Controls\NumericUpDawn\TemplateNumericUpDown.xaml"
            this.cmdDown.Click += new System.Windows.RoutedEventHandler(this.CmdDown_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

