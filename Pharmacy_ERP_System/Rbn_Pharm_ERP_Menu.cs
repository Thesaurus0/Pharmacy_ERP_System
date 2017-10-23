using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Pharmacy_ERP_System
{
    public partial class Rbn_Pharm_ERP_Menu
    {
        private void Pharm_ERP_Menu_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnImportSalesDetailFiles_Click(object sender, RibbonControlEventArgs e)
        {
            new Form_ImportSalesFiles().Show();
        }
    }
}
