// Updated by XamlIntelliSenseFileGenerator 03.11.2022 10:32:44
#pragma checksum "..\..\..\..\View\GraphWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9084AC280FB41BD87DF6DC1E40F85BEFCD055F7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using CryptoWatcherWPF.View;
using LiveCharts.Wpf;
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


namespace CryptoWatcherWPF.View
{


    /// <summary>
    /// GraphWindow
    /// </summary>
    public partial class GraphWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 70 "..\..\..\..\View\GraphWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Minimizer;

#line default
#line hidden


#line 105 "..\..\..\..\View\GraphWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close;

#line default
#line hidden


#line 140 "..\..\..\..\View\GraphWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart CryptoCourse;

#line default
#line hidden


#line 160 "..\..\..\..\View\GraphWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Logo;

#line default
#line hidden


#line 162 "..\..\..\..\View\GraphWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Logo_black;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CryptoWatcherWPF;component/view/graphwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\View\GraphWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 15 "..\..\..\..\View\GraphWindow.xaml"
                    ((CryptoWatcherWPF.View.GraphWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.btn_Minimizer = ((System.Windows.Controls.Button)(target));

#line 78 "..\..\..\..\View\GraphWindow.xaml"
                    this.btn_Minimizer.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_Close = ((System.Windows.Controls.Button)(target));

#line 113 "..\..\..\..\View\GraphWindow.xaml"
                    this.btn_Close.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.CryptoCourse = ((LiveCharts.Wpf.CartesianChart)(target));
                    return;
                case 5:
                    this.txt_Logo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.Logo_black = ((System.Windows.Controls.StackPanel)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnDashboardWindow;
    }
}

