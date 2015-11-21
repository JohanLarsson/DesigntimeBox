using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
            if (identifier == BackgroundPropertyIdentifier)
            {
                return Brushes.Lavender;
            }

            return base.TranslatePropertyValue(item, identifier, value);
        }
    }
}