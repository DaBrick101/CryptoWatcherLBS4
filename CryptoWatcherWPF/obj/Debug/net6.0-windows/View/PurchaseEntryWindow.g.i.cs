﻿#pragma checksum "..\..\..\..\View\PurchaseEntryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6648C2760214CA64B70ECC369D95EB26A1CFAAD0"
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


namespace CryptoWatcherWPF.View {
    
    
    /// <summary>
    /// PurchaseEntryWindow
    /// </summary>
    public partial class PurchaseEntryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPayedEurAmount;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPayedEURAmount;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCurrency;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Bitcoin;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Ethereum;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem DogeCoin;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\View\PurchaseEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateEntry;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CryptoWatcherWPF;component/view/purchaseentrywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\PurchaseEntryWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\View\PurchaseEntryWindow.xaml"
            ((CryptoWatcherWPF.View.PurchaseEntryWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\PurchaseEntryWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\View\PurchaseEntryWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblPayedEurAmount = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtPayedEURAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbCurrency = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Bitcoin = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.Ethereum = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.DogeCoin = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            this.btnCreateEntry = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\..\..\View\PurchaseEntryWindow.xaml"
            this.btnCreateEntry.Click += new System.Windows.RoutedEventHandler(this.btnCreateEntry_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

