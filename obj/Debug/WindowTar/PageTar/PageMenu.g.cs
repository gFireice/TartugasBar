﻿#pragma checksum "..\..\..\..\WindowTar\PageTar\PageMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0EBE23FD6CA3759D61BA2FCBB7CEEA03894F3424F0246870912ABE030D99B703"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BarTargu.WindowTar.PageTar;
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


namespace BarTargu.WindowTar.PageTar {
    
    
    /// <summary>
    /// PageMenu
    /// </summary>
    public partial class PageMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 288 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FoodCategoryBtn;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasketBtn;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MenuListView;
        
        #line default
        #line hidden
        
        
        #line 462 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SearchCategoryFood;
        
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
            System.Uri resourceLocater = new System.Uri("/BarTargu;component/windowtar/pagetar/pagemenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
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
            this.FoodCategoryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 289 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            this.FoodCategoryBtn.Click += new System.Windows.RoutedEventHandler(this.FoodCategoryBtn_Click);
            
            #line default
            #line hidden
            
            #line 290 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            this.FoodCategoryBtn.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FoodCategoryBtn_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BasketBtn = ((System.Windows.Controls.Button)(target));
            
            #line 303 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            this.BasketBtn.Click += new System.Windows.RoutedEventHandler(this.BasketBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenuListView = ((System.Windows.Controls.ListView)(target));
            
            #line 321 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            this.MenuListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MenuListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SearchCategoryFood = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 329 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseRightButtonDown);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 406 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddToCart_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 420 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMinus_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 433 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnPlus_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 482 "..\..\..\..\WindowTar\PageTar\PageMenu.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

