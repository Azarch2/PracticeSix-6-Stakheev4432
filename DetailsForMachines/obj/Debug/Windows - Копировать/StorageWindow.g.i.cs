#pragma checksum "..\..\..\Windows - Копировать\StorageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CFDA2D789CE29FC8DD9098B3A06D8B723FFFD16A36D3889A8B92319CCA77CC99"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DetailsForMachines;
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


namespace DetailsForMachines {
    
    
    /// <summary>
    /// StorageWindow
    /// </summary>
    public partial class StorageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows - Копировать\StorageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderUp;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows - Копировать\StorageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderDown;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows - Копировать\StorageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows - Копировать\StorageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows - Копировать\StorageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StorageList;
        
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
            System.Uri resourceLocater = new System.Uri("/DetailsForMachines;component/windows%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be%" +
                    "d0%b2%d0%b0%d1%82%d1%8c/storagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows - Копировать\StorageWindow.xaml"
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
            
            #line 8 "..\..\..\Windows - Копировать\StorageWindow.xaml"
            ((DetailsForMachines.StorageWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BorderUp = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.BorderDown = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Windows - Копировать\StorageWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackToMainWindow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Windows - Копировать\StorageWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddDeliveryNote);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StorageList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

