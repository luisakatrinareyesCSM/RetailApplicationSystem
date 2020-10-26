﻿#pragma checksum "..\..\..\Lists\CustomerList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB0703904DF8BE3DCBD0EBC7BC75056536CCE852490F7A1C8A70A4A8A42D7682"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuisaKatrinaReyes.RetailApplicationSystem.windows.Lists;
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


namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Lists {
    
    
    /// <summary>
    /// CustomerList
    /// </summary>
    public partial class CustomerList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboOrderBy;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSortOrder;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbSortOrder;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbOrderBy;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFirst;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLast;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrevious;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPageSize;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPageSize;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Lists\CustomerList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCustomer;
        
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
            System.Uri resourceLocater = new System.Uri("/LuisaKatrinaReyes.RetailApplicationSystem.windows;component/lists/customerlist.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lists\CustomerList.xaml"
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
            this.cboOrderBy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\Lists\CustomerList.xaml"
            this.cboOrderBy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboOrderBy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboSortOrder = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\Lists\CustomerList.xaml"
            this.cboSortOrder.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboOrderBy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LbSortOrder = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LbOrderBy = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Lists\CustomerList.xaml"
            this.btnFirst.Click += new System.Windows.RoutedEventHandler(this.btnFirst_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLast = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Lists\CustomerList.xaml"
            this.btnLast.Click += new System.Windows.RoutedEventHandler(this.btnLast_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Lists\CustomerList.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Lists\CustomerList.xaml"
            this.btnPrevious.Click += new System.Windows.RoutedEventHandler(this.btnPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtPageSize = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Lists\CustomerList.xaml"
            this.txtPageSize.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPageSize_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblPageSize = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.dgCustomer = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

