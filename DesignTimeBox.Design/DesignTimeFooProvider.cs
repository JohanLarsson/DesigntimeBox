using System.Windows;
using System.Windows.Controls;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.Model;

namespace DesignTimeBox.Design
{
    public class DesignTimeFooProvider : DesignModeValueProvider
    {
        private static readonly PropertyIdentifier BackgroundPropertyIdentifier =
            new PropertyIdentifier(typeof(Button), "Foo");

        public DesignTimeFooProvider()
        {
            Properties.Add(BackgroundPropertyIdentifier);
        }

        public override object TranslatePropertyValue(ModelItem item, PropertyIdentifier identifier, object value)
        {
            MessageBox.Show("foo");
            if (identifier.DeclaringType == BackgroundPropertyIdentifier.DeclaringType)
            {
                return value;
            }

            return base.TranslatePropertyValue(item, identifier, value);
        }
    }
}