using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace Wosad.Dynamo.Common.Infra
{
    public partial class DataEntryElement : UserControl
    {
        public DataEntryElement()
        {
            InitializeComponent();
          
        }

        #region Description


        public string Description
        {
            get {
                return (string)GetValue(DescriptionProperty);
            }
            set 
            {
                SetValue(DescriptionProperty, value);
            }

        }


        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(DataEntryElement), new PropertyMetadata(""));

        #endregion


        #region DataPath

        private string dataPath;

        public string DataPath
        {
            get { return dataPath; }
            set { dataPath = value; }
        }
        

        public static readonly DependencyProperty DataPathProperty =
            DependencyProperty.Register("DataPath", typeof(string), typeof(DataEntryElement), new PropertyMetadata(dataPathChangedCallback));

        private static void dataPathChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SetNewBinding(e.NewValue, d);
        }

        private static void SetNewBinding(object args, DependencyObject dependencyObject)
        {
            string dp = args as string;
            if (dp != null)
            {

                
                Binding valBinding = new Binding();
                valBinding.Path = new PropertyPath(dp);
                valBinding.Mode = BindingMode.TwoWay;


                DataEntryElement ec = dependencyObject as DataEntryElement;
                if (ec!=null)
                {
                    ec.DataPath = dp;
                    ec.ValueBox.SetBinding(TextBox.TextProperty, valBinding);
                }
                
            }
        }




        #endregion

 

    }
}
