using System.Windows;

namespace DesignTimeBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty FooProperty = DependencyProperty.Register(
            "Foo", typeof (string), typeof (MainWindow), new PropertyMetadata(default(string)));

        public string Foo
        {
            get { return (string) GetValue(FooProperty); }
            set { SetValue(FooProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
