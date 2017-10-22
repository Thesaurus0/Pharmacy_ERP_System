namespace Pharmacy_ERP_System
{
    partial class Rbn_Pharm_ERP_Menu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Rbn_Pharm_ERP_Menu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rbn_Pharm_ERP_Menu));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnImportSalesDetailFiles = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnImportSalesDetailFiles);
            this.group1.Label = "导入文件";
            this.group1.Name = "group1";
            // 
            // btnImportSalesDetailFiles
            // 
            this.btnImportSalesDetailFiles.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnImportSalesDetailFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnImportSalesDetailFiles.Image")));
            this.btnImportSalesDetailFiles.Label = "导入商业公司销售流向Excel文件";
            this.btnImportSalesDetailFiles.Name = "btnImportSalesDetailFiles";
            this.btnImportSalesDetailFiles.ShowImage = true;
            this.btnImportSalesDetailFiles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnImportSalesDetailFiles_Click);
            // 
            // Rbn_Pharm_ERP_Menu
            // 
            this.Name = "Rbn_Pharm_ERP_Menu";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Pharm_ERP_Menu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImportSalesDetailFiles;
    }

    partial class ThisRibbonCollection
    {
        internal Rbn_Pharm_ERP_Menu Pharm_ERP_Menu
        {
            get { return this.GetRibbon<Rbn_Pharm_ERP_Menu>(); }
        }
    }
}
