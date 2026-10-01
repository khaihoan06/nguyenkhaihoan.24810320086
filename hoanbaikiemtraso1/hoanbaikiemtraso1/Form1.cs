using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace hoanbaikiemtraso1
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private string currentImagePath = null;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // initialize categories with DisplayMember/ValueMember
            var categories = new List<Category>
            {
                new Category { Name = "Điện thoại", Value = "phone" },
                new Category { Name = "Laptop", Value = "laptop" },
                new Category { Name = "Phụ kiện", Value = "accessory" }
            };
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Value";
            cboCategory.DataSource = categories;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // binding
            bsProducts.DataSource = products;
            dgvProducts.DataSource = bsProducts;

            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            toolStripStatusLabelCount.Text = $"Tổng số sản phẩm: {products.Count}";
        }

        private void BtnChooseImage_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentImagePath = ofd.FileName;
                    picAvatar.Image?.Dispose();
                    picAvatar.Image = Image.FromFile(currentImagePath);
                }
                catch
                {
                    MessageBox.Show("Không thể nạp ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            errorProvider.Clear();
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Tên SP không được để trống");
                ok = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var price) || price <= 0)
            {
                errorProvider.SetError(txtUnitPrice, "Đơn giá phải > 0");
                ok = false;
            }

            if (!int.TryParse(txtQuantity.Text, out var qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải >= 0");
                ok = false;
            }

            return ok;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var p = new Product()
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text, NumberStyles.Number),
                Quantity = int.Parse(txtQuantity.Text),
                ImagePath = currentImagePath
            };
            products.Add(p);
            ClearInputs();
            UpdateStatusCount();
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            currentImagePath = null;
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;
        }

        private void DgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            var p = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (p == null) return;
            txtProductId.Text = p.ProductId;
            txtProductName.Text = p.ProductName;
            cboCategory.Text = p.Category;
            txtUnitPrice.Text = p.UnitPrice.ToString(CultureInfo.CurrentCulture);
            txtQuantity.Text = p.Quantity.ToString();
            currentImagePath = p.ImagePath;
            try
            {
                picAvatar.Image?.Dispose();
                picAvatar.Image = string.IsNullOrEmpty(p.ImagePath) ? null : Image.FromFile(p.ImagePath);
            }
            catch { picAvatar.Image = null; }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            if (!ValidateInputs()) return;
            var p = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (p == null) return;
            p.ProductId = txtProductId.Text.Trim();
            p.ProductName = txtProductName.Text.Trim();
            p.Category = cboCategory.Text;
            p.UnitPrice = decimal.Parse(txtUnitPrice.Text, NumberStyles.Number);
            p.Quantity = int.Parse(txtQuantity.Text);
            p.ImagePath = currentImagePath;
            // notify list changed
            var idx = products.IndexOf(p);
            products.ResetItem(idx);
            UpdateStatusCount();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            var p = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (p == null) return;
            var dr = MessageBox.Show($"Xác nhận xóa sản phẩm '{p.ProductName}'?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                products.Remove(p);
                ClearInputs();
                UpdateStatusCount();
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q))
            {
                bsProducts.DataSource = products;
                dgvProducts.DataSource = bsProducts;
                return;
            }
            var filtered = new BindingList<Product>(products.Where(x => x.ProductName.Contains(q, StringComparison.CurrentCultureIgnoreCase)).ToList());
            bsProducts.DataSource = filtered;
            dgvProducts.DataSource = bsProducts;
        }

        private void ExportCsvToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            ExportCsv();
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            ExportCsv();
        }

        private void ExportCsv()
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files|*.csv|All Files|*.*";
            sfd.FileName = "products.csv";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using var sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("ProductId,ProductName,Category,UnitPrice,Quantity");
                foreach (var p in products)
                {
                    var line = string.Join(",",
                        EscapeCsv(p.ProductId), EscapeCsv(p.ProductName), EscapeCsv(p.Category), p.UnitPrice.ToString(CultureInfo.InvariantCulture), p.Quantity.ToString());
                    sw.WriteLine(line);
                }
                MessageBox.Show("Export thành công", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string? v)
        {
            if (v == null) return string.Empty;
            if (v.Contains(',') || v.Contains('"') || v.Contains('\n'))
            {
                return '"' + v.Replace("\"", "\"\"") + '"';
            }
            return v;
        }

        private void ExitToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void DgvProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice" && e.Value is decimal dec)
            {
                e.Value = string.Format(CultureInfo.CurrentCulture, "{0:N0} VNĐ", dec);
                e.FormattingApplied = true;
            }
        }

        private void DgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // same as selection changed: load details
            DgvProducts_SelectionChanged(sender, EventArgs.Empty);
        }
    }
}
