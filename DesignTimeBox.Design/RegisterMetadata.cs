using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;

namespace DesignTimeBox.Design
{
    public class RegisterMetadata : IProvideAttributeTable
    {
        public AttributeTable AttributeTable
        {
            get
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();
                builder.AddCustomAttributes(
                    typeof(Button),
                    new FeatureAttribute(typeof(DesignTimeBackgroundProvider)),
                    DesignOnlyAttribute.Yes);
                return builder.CreateTable();
            }
        }
    }
}
