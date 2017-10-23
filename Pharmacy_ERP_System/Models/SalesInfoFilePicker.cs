using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Form = System.Windows.Forms;

namespace Pharmacy_ERP_System.Models
{
    class SalesInfoFilePicker
    {
        public void FileChooseAndSet(TextBox tbParam)
        {
            var dialog = new Form.OpenFileDialog();
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == Form.DialogResult.OK)
            {
                tbParam.Text = dialog.FileName;
            }

        }
    }
}
