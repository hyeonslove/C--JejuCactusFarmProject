﻿#pragma checksum "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F2758D67B28C0DBBA522428668C346238319AEA9F7C8E135B98EFF1FE95079B"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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


namespace JejuFarm_Receipt_Project.SubWindow.ContentWindow {
    
    
    /// <summary>
    /// SettingWindow
    /// </summary>
    public partial class SettingWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SettingListBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem PrinterSetting;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem BluetoothSetting;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem CactusSetting;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem ProgramSetting;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl SettingPage;
        
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
            System.Uri resourceLocater = new System.Uri("/JejuFarm Receipt Project;component/subwindow/contentwindow/settingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
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
            this.SettingListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 47 "..\..\..\..\SubWindow\ContentWindow\SettingWindow.xaml"
            this.SettingListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SettingListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PrinterSetting = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 3:
            this.BluetoothSetting = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 4:
            this.CactusSetting = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 5:
            this.ProgramSetting = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 6:
            this.SettingPage = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

