﻿#pragma checksum "..\..\..\Teoryas\t6Zvet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4AB03B77145547CD4DB1DD22F913141D2224B20296348D793A1A7B22D85C861"
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
using УМК_Цифра.Teoryas;


namespace УМК_Цифра.Teoryas {
    
    
    /// <summary>
    /// t6Zvet
    /// </summary>
    public partial class t6Zvet : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Teoryas\t6Zvet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myGif;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Teoryas\t6Zvet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button P1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Teoryas\t6Zvet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button P2;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Teoryas\t6Zvet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button P3;
        
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
            System.Uri resourceLocater = new System.Uri("/УМК_Цифра;component/teoryas/t6zvet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teoryas\t6Zvet.xaml"
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
            this.myGif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 20 "..\..\..\Teoryas\t6Zvet.xaml"
            this.myGif.MediaEnded += new System.Windows.RoutedEventHandler(this.myGif_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.P1 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Teoryas\t6Zvet.xaml"
            this.P1.Click += new System.Windows.RoutedEventHandler(this.Proiz1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.P2 = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Teoryas\t6Zvet.xaml"
            this.P2.Click += new System.Windows.RoutedEventHandler(this.Proiz2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.P3 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Teoryas\t6Zvet.xaml"
            this.P3.Click += new System.Windows.RoutedEventHandler(this.Proiz3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

