﻿#pragma checksum "..\..\ManageFlightSchedules.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B0FCD2DE5DF8973A14ACF1A145ACD50649C36E42E2C79FB682A0D3AE3D47FE7"
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
using lohovskayaProga;


namespace lohovskayaProga {
    
    
    /// <summary>
    /// ManageFlightSchedules
    /// </summary>
    public partial class ManageFlightSchedules : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFrom;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSortBy;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpOubound;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFlightNumber;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridSchedules;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ManageFlightSchedules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportButton;
        
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
            System.Uri resourceLocater = new System.Uri("/lohovskayaProga;component/manageflightschedules.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageFlightSchedules.xaml"
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
            this.cbFrom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cbTo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbSortBy = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dpOubound = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tbFlightNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ApplyButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\ManageFlightSchedules.xaml"
            this.ApplyButton.Click += new System.Windows.RoutedEventHandler(this.ApplyButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DGridSchedules = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\ManageFlightSchedules.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EditButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\ManageFlightSchedules.xaml"
            this.EditButton.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ImportButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ManageFlightSchedules.xaml"
            this.ImportButton.Click += new System.Windows.RoutedEventHandler(this.ImportButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

