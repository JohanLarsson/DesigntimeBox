using System.Windows;
using System.Windows.Controls;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.Model;

namespace DesignTimeBox.Design
{
    public class DesignTimeBackgroundProvider : DesignModeValueProvider
    {
        private static readonly PropertyIdentifier BackgroundPropertyIdentifier =
            new PropertyIdentifier(typeof(Button), Control.BackgroundProperty.Name);

        public DesignTimeBackgroundProvider()
        {
            Properties.Add(BackgroundPropertyIdentifier);
        }

        public override object TranslatePropertyValue(ModelItem item, PropertyIdentifier identifier, object value)
        {
            MessageBox.Show($"name: {identifier.Name}\r\n" +
                            $"value: {value}\r\n" +
                            $"type: {value?.GetType()}\r\n" +
                            $"item.View: {item.View}\r\n" +
                            $"item.GetCurrentValue(): {item.GetCurrentValue()}");
            if (identifier.DeclaringType == BackgroundPropertyIdentifier.DeclaringType)
            {
                using (var editingScope = item.BeginEdit())
                {
                    var button = item.GetCurrentValue() as Button;
                    button?.SetValue(Control.BackgroundProperty, value);
                }

                return value;
            }

            return base.TranslatePropertyValue(item, identifier, value);
        }
    }
}