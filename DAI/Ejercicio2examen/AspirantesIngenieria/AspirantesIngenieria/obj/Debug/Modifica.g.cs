﻿#pragma checksum "..\..\Modifica.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E57A4E3EAD6DA60B019E2D39A7F444C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace AspirantesIngenieria {
    
    
    /// <summary>
    /// Modifica
    /// </summary>
    public partial class Modifica : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_aspirante;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Grado;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_correo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rdBtn_4;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rdBtn_6;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rdBtn_5;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Ingeniería;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_programa;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio3;
        
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
            System.Uri resourceLocater = new System.Uri("/AspirantesIngenieria;component/modifica.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modifica.xaml"
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
            
            #line 5 "..\..\Modifica.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 6 "..\..\Modifica.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cb_aspirante = ((System.Windows.Controls.ComboBox)(target));
            
            #line 8 "..\..\Modifica.xaml"
            this.cb_aspirante.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_aspirante_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Grado = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.tb_correo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.rdBtn_4 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.rdBtn_6 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.rdBtn_5 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.Ingeniería = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.cb_programa = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            
            #line 17 "..\..\Modifica.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            this.radio1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 13:
            this.radio2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            this.radio3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

