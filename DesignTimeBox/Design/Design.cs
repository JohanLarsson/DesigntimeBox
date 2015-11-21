using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

[assembly: XmlnsDefinition("http://schemas.microsoft.com/expression/blend/2008", "DesignTimeBox.Design")]
[assembly: XmlnsPrefix("http://schemas.microsoft.com/expression/blend/2008", "d")]
namespace DesignTimeBox.Design
{
    public static class Design
    {
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            "Background",
            typeof(Brush),
            typeof(Design),
            new PropertyMetadata(default(Brush), OnDesignBackgroundChanged));

        private static void OnDesignBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d))
            {
                d.SetValue(Control.BackgroundProperty, e.NewValue);
            }
        }
    }
}
