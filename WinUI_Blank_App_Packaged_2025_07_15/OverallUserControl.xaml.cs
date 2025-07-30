using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.Json.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_Blank_App_Packaged_2025_07_15
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(TestingNewtonSoft))]
    internal partial class SourceGenerationContext : JsonSerializerContext
    {
    }

    public class TestingNewtonSoft
    {
        public string Name { get; set; } = "myname";
        public string Description { get; set; } = "mydescription";
    }
    public sealed partial class OverallUserControl : UserControl
    {
        public OverallUserControl()
        {
            InitializeComponent();
            this.Loaded += OverallUserControl_Loaded;
        }

        private void OverallUserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var t = new TestingNewtonSoft();
            var json = System.Text.Json.JsonSerializer.Serialize(t, SourceGenerationContext.Default.TestingNewtonSoft);
            uiJson.Text = json;
        }
    }
}
