using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTest16._05._18
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfAppTest16._05._18"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfAppTest16._05._18;assembly=WpfAppTest16._05._18"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class CustomControl1 : Control
    {
        Button btn;
        public event EventHandler<RoutedEventArgs> customClick;
        static CustomControl1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));
        }
        public override void OnApplyTemplate()
        {
            btn = GetTemplateChild("btnBack") as Button;
            if (btn != null)
                btn.Click += (s, e) => customClick.Invoke(s, e);
            else
                new NullReferenceException();
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImagePath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImagePathProperty =
            DependencyProperty.Register("ImagePath", typeof(ImageSource), typeof(CustomControl1), new PropertyMetadata());


        public string btnText
        {
            get { return (string)GetValue(btnTextProperty); }
            set { SetValue(btnTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for btnText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty btnTextProperty =
            DependencyProperty.Register("btnText", typeof(string), typeof(CustomControl1), new PropertyMetadata());



        public string tbText
        {
            get { return (string)GetValue(tbTextProperty); }
            set { SetValue(tbTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for tbText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tbTextProperty =
            DependencyProperty.Register("tbText", typeof(string), typeof(CustomControl1), new PropertyMetadata());



    }
}
