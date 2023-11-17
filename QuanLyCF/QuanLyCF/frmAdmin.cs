using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class frmAdmin : Form
    {
        FoodDAO fDAO = new FoodDAO();
        FoodCategoryDAO fcDAO = new FoodCategoryDAO();
        TableFoodDAO tbfDAo = new TableFoodDAO();
        BillInfoDAO bifDAO = new BillInfoDAO();
        string insertupdate = "";

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            insertupdate = "insert";
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            insertupdate = "update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id =int.Parse(txtId.Text);
                string name = txtFoodName.Text;
                int idcate = int.Parse(cbCategory.SelectedValue.ToString());
                float price = float.Parse(txtPrice.Text);
                Food f = new Food(id,name,idcate, price);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            fDAO.Insert(f);
                            dgvFood.DataSource = fDAO.LoadFoodList();
                            MessageBox.Show("Thêm thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                               
                            fDAO.Update(f);
                            dgvFood.DataSource = fDAO.LoadFoodList();
                            MessageBox.Show("Cập nhập thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvFood.DataSource = fDAO.LoadFoodList();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            loadFoodCate();
        }
        private void loadFoodCate()
        {
            cbCategory.DataSource = fcDAO.LoadTableList();
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "idCategory";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;
                fDAO.Delete(id);
                dgvFood.DataSource = fDAO.LoadFoodList();

                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvFood.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn thức ăn!");
                }
                txtId.Text = dgvFood.Rows[rowindex].Cells["idFood"].Value.ToString();
                txtFoodName.Text = dgvFood.Rows[rowindex].Cells["name"].Value.ToString();
                cbCategory.Text = dgvFood.Rows[rowindex].Cells["idCategory"].Value.ToString();
                txtPrice.Text = dgvFood.Rows[rowindex].Cells["price"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            txtIdCate.ReadOnly = false;
            insertupdate = "insert";
        }

        private void btnFixCate_Click(object sender, EventArgs e)
        {
            txtIdCate.ReadOnly = true;
            insertupdate = "update";
        }

        private void dgvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvCate.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn thức ăn!");
                }
                txtIdCate.Text = dgvCate.Rows[rowindex].Cells["idCategory"].Value.ToString();
                txtCate.Text = dgvCate.Rows[rowindex].Cells["name"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewCate_Click(object sender, EventArgs e)
        {
            dgvCate.DataSource = fcDAO.LoadTableList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdCate.Text);
                string name = txtCate.Text;
                FoodCategory fc = new FoodCategory(id,name);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            fcDAO.Insert(fc);
                            dgvFood.DataSource = fDAO.LoadFoodList();
                            MessageBox.Show("Thêm thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {

                            fcDAO.Update(fc);
                            dgvFood.DataSource = fDAO.LoadFoodList();
                            MessageBox.Show("Cập nhập thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelcate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdCate.Text;
                fcDAO.Delete(id);
                dgvCate.DataSource = fcDAO.LoadTableList();

                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = tbfDAo.LoadTableList();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            txtIdTable.ReadOnly = false;
            insertupdate = "insert";
        }

        private void btnFixTable_Click(object sender, EventArgs e)
        {
            txtIdTable.ReadOnly = true;
            insertupdate = "update";
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvTable.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn thức ăn!");
                }
                txtIdTable.Text = dgvTable.Rows[rowindex].Cells["idTable"].Value.ToString();
                txtTablename.Text = dgvTable.Rows[rowindex].Cells["name"].Value.ToString();
                cbStatusTable.Text = dgvTable.Rows[rowindex].Cells["status"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdTable.Text);
                string name = txtTablename.Text;
                string status = cbStatusTable.Text;
                TableFood tf = new TableFood(id, name,status);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            tbfDAo.Insert(tf);
                            dgvTable.DataSource = tbfDAo.LoadTableList();
                            MessageBox.Show("Thêm thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {

                            tbfDAo.Update(tf);
                            dgvTable.DataSource = tbfDAo.LoadTableList();
                            MessageBox.Show("Cập nhập thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeltable_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdTable.Text;
                tbfDAo.Delete(id);
                dgvTable.DataSource = tbfDAo.LoadTableList();

                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = bifDAO.LoadBInfoList();

        }
    }
}
