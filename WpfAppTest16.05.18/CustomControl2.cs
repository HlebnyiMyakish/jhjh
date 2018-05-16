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
    public class CustomControl2 : Control
    {
        Button btnBack, btnExit;
        public event EventHandler<RoutedEventArgs> customClick;
        public event EventHandler<RoutedEventArgs> ExitcustomClick;
        static CustomControl2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl2), new FrameworkPropertyMetadata(typeof(CustomControl2)));
        }
        public override void OnApplyTemplate()
        {
            btnBack = GetTemplateChild("btnBack2") as Button;
            if (btnBack != null)
                btnBack.Click += (s, e) => customClick.Invoke(s, e);
            else
                new NullReferenceException();

            btnExit = GetTemplateChild("btnExit") as Button;
            if (btnExit != null)
                btnExit.Click += (s, e) => ExitcustomClick.Invoke(s, e);
            else
                new NullReferenceException();
        }


        public ImageSource ImagePath2
        {
            get { return (ImageSource)GetValue(ImagePath2Property); }
            set { SetValue(ImagePath2Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImagePath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImagePath2Property =
            DependencyProperty.Register("ImagePath2", typeof(ImageSource), typeof(CustomControl1), new PropertyMetadata());


        public string btnText2
        {
            get { return (string)GetValue(btnText2Property); }
            set { SetValue(btnText2Property, value); }
        }

        // Using a DependencyProperty as the backing store for btnText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty btnText2Property =
            DependencyProperty.Register("btnText2", typeof(string), typeof(CustomControl1), new PropertyMetadata());



        public string tbText2
        {
            get { return (string)GetValue(tbText2Property); }
            set { SetValue(tbText2Property, value); }
        }

        // Using a DependencyProperty as the backing store for tbText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tbText2Property =
            DependencyProperty.Register("tbText2", typeof(string), typeof(CustomControl1), new PropertyMetadata());



        public string btnExitText
        {
            get { return (string)GetValue(btnExitTextProperty); }
            set { SetValue(btnExitTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for btnExitText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty btnExitTextProperty =
            DependencyProperty.Register("btnExitText", typeof(string), typeof(CustomControl2), new PropertyMetadata());



    }
}
