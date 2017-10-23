using Pharmacy_ERP_System.Models;
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

namespace Pharmacy_ERP_System
{
    /// <summary>
    /// Interaction logic for ImportSalesInfoFiles.xaml
    /// </summary>
    public partial class ImportSalesInfoFiles : UserControl
    {
        public ImportSalesInfoFiles()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            new SalesInfoFilePicker().FileChooseAndSet(fileFullPathTextBox1);
        }
    }
}
