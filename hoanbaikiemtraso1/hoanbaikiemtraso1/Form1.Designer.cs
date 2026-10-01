namespace hoanbaikiemtraso1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanelMain;
        private GroupBox groupBoxInput;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private PictureBox picAvatar;
        private Button btnChooseImage;
        private FlowLayoutPanel flowButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExport;
        private DataGridView dgvProducts;
        private BindingSource bsProducts;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCsvToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelCount;
        private TextBox txtSearch;
        private Label lblSearch;
        private ErrorProvider errorProvider;
        private TableLayoutPanel tblLeft;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanelMain = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            groupBoxInput = new GroupBox();
            tblLeft = new TableLayoutPanel();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            picAvatar = new PictureBox();
            flowButtons = new FlowLayoutPanel();
            btnExport = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnChooseImage = new Button();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            statusStrip = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            bsProducts = new BindingSource(components);
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanelMain.SuspendLayout();
            groupBoxInput.SuspendLayout();
            tblLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            flowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsProducts).BeginInit();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelMain.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanelMain.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxInput, 0, 1);
            tableLayoutPanelMain.Controls.Add(dgvProducts, 1, 1);
            tableLayoutPanelMain.Controls.Add(statusStrip, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 33);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(6);
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1000, 567);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(9, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(339, 37);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            lblSearch.UseCompatibleTextRendering = true;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(354, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(637, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(tblLeft);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(9, 46);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(339, 480);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Nhập thông tin sản phẩm";
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 3;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblLeft.Controls.Add(lblProductId, 0, 0);
            tblLeft.Controls.Add(txtProductId, 1, 0);
            tblLeft.Controls.Add(lblProductName, 0, 1);
            tblLeft.Controls.Add(txtProductName, 1, 1);
            tblLeft.Controls.Add(lblCategory, 0, 2);
            tblLeft.Controls.Add(cboCategory, 1, 2);
            tblLeft.Controls.Add(lblUnitPrice, 0, 3);
            tblLeft.Controls.Add(txtUnitPrice, 1, 3);
            tblLeft.Controls.Add(lblQuantity, 0, 4);
            tblLeft.Controls.Add(txtQuantity, 1, 4);
            tblLeft.Controls.Add(picAvatar, 0, 5);
            tblLeft.Controls.Add(flowButtons, 0, 6);
            tblLeft.Controls.Add(btnChooseImage, 2, 5);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(3, 27);
            tblLeft.Name = "tblLeft";
            tblLeft.Padding = new Padding(6);
            tblLeft.RowCount = 7;
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLeft.RowStyles.Add(new RowStyle());
            tblLeft.Size = new Size(333, 450);
            tblLeft.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Dock = DockStyle.Fill;
            lblProductId.Font = new Font("Segoe UI", 9F);
            lblProductId.Location = new Point(9, 12);
            lblProductId.Margin = new Padding(3, 6, 3, 6);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(106, 30);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            lblProductId.TextAlign = ContentAlignment.MiddleLeft;
            lblProductId.UseCompatibleTextRendering = true;
            // 
            // txtProductId
            // 
            tblLeft.SetColumnSpan(txtProductId, 2);
            txtProductId.Dock = DockStyle.Fill;
            txtProductId.Font = new Font("Segoe UI", 9F);
            txtProductId.Location = new Point(121, 10);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(203, 31);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Font = new Font("Segoe UI", 9F);
            lblProductName.Location = new Point(9, 54);
            lblProductName.Margin = new Padding(3, 6, 3, 6);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(106, 30);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            lblProductName.UseCompatibleTextRendering = true;
            // 
            // txtProductName
            // 
            tblLeft.SetColumnSpan(txtProductName, 2);
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Font = new Font("Segoe UI", 9F);
            txtProductName.Location = new Point(121, 52);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(203, 31);
            txtProductName.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI", 9F);
            lblCategory.Location = new Point(9, 96);
            lblCategory.Margin = new Padding(3, 6, 3, 6);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(106, 30);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Danh mục:";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            lblCategory.UseCompatibleTextRendering = true;
            // 
            // cboCategory
            // 
            tblLeft.SetColumnSpan(cboCategory, 2);
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(121, 94);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(203, 33);
            cboCategory.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Font = new Font("Segoe UI", 9F);
            lblUnitPrice.Location = new Point(9, 138);
            lblUnitPrice.Margin = new Padding(3, 6, 3, 6);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(106, 30);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn giá:";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            lblUnitPrice.UseCompatibleTextRendering = true;
            // 
            // txtUnitPrice
            // 
            tblLeft.SetColumnSpan(txtUnitPrice, 2);
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Font = new Font("Segoe UI", 9F);
            txtUnitPrice.Location = new Point(121, 136);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 31);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Font = new Font("Segoe UI", 9F);
            lblQuantity.Location = new Point(9, 180);
            lblQuantity.Margin = new Padding(3, 6, 3, 6);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(106, 30);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            lblQuantity.UseCompatibleTextRendering = true;
            // 
            // txtQuantity
            // 
            tblLeft.SetColumnSpan(txtQuantity, 2);
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Font = new Font("Segoe UI", 9F);
            txtQuantity.Location = new Point(121, 178);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(203, 31);
            txtQuantity.TabIndex = 9;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            tblLeft.SetColumnSpan(picAvatar, 2);
            picAvatar.Dock = DockStyle.Fill;
            picAvatar.Location = new Point(9, 219);
            picAvatar.MinimumSize = new Size(120, 120);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(250, 120);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 10;
            picAvatar.TabStop = false;
            // 
            // flowButtons
            // 
            tblLeft.SetColumnSpan(flowButtons, 3);
            flowButtons.Controls.Add(btnExport);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Controls.Add(btnUpdate);
            flowButtons.Controls.Add(btnAdd);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(9, 341);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(0, 6, 0, 0);
            flowButtons.Size = new Size(315, 100);
            flowButtons.TabIndex = 12;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.Location = new Point(214, 12);
            btnExport.Margin = new Padding(6);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(95, 35);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất CSV";
            btnExport.Click += BtnExport_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(127, 12);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Location = new Point(22, 12);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(207, 59);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.AutoSize = true;
            btnChooseImage.Location = new Point(268, 222);
            btnChooseImage.Margin = new Padding(6);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(53, 48);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.Text = "Chọn ảnh ";
            btnChooseImage.Click += BtnChooseImage_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeight = 34;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colUnit, colQty });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Font = new Font("Segoe UI", 9F);
            dgvProducts.Location = new Point(354, 46);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(637, 480);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;
            dgvProducts.CellFormatting += DgvProducts_CellFormatting;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            // 
            // colId
            // 
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colName
            // 
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colCategory
            // 
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 150;
            // 
            // colUnit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colUnit.DefaultCellStyle = dataGridViewCellStyle1;
            colUnit.MinimumWidth = 8;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            colUnit.Width = 150;
            // 
            // colQty
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colQty.DefaultCellStyle = dataGridViewCellStyle2;
            colQty.MinimumWidth = 8;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 150;
            // 
            // statusStrip
            // 
            tableLayoutPanelMain.SetColumnSpan(statusStrip, 2);
            statusStrip.Font = new Font("Segoe UI", 9F);
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStrip.Location = new Point(6, 529);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(988, 32);
            statusStrip.TabIndex = 4;
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(179, 25);
            toolStripStatusLabelCount.Text = "Tổng số sản phẩm: 0";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1000, 33);
            menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCsvToolStripMenuItem
            // 
            exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            exportCsvToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportCsvToolStripMenuItem.Size = new Size(262, 34);
            exportCsvToolStripMenuItem.Text = "Export CSV";
            exportCsvToolStripMenuItem.Click += ExportCsvToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(262, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            tblLeft.ResumeLayout(false);
            tblLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            flowButtons.ResumeLayout(false);
            flowButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsProducts).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colQty;
    }
}
