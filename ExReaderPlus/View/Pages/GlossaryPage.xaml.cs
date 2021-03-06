﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace ExReaderPlus.View.Pages {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class GlossaryPage : Page {
        public GlossaryPage() {
            this.InitializeComponent();
            Loaded += GlossaryPage_Loaded;
        }
        private void GlossaryPage_Loaded(object sender, RoutedEventArgs e) {
            (App.Current.Resources["OverSettingService"] as OverSettingService).SetStateBarButtonFg((Color)App.Current.Resources["MainThemeFGColorDark"]);
        }
    }
}
