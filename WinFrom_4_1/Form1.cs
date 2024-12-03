using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFrom_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtaNhanVien.DataSource = nhanViens;
        }

        BindingList<NhanVien> nhanViens = new BindingList<NhanVien>();

        private void Form1_Load(object sender, EventArgs e)
        {
            dtaNhanVien.DataSource = nhanViens;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK) 
            {
                nhanViens.Add(form2.NhanVien);
            }
        }

        private void dtaNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtaNhanVien.SelectedRows.Count > 0)
            {
                var selectedRow = dtaNhanVien.SelectedRows[0];
                var nhanVien = (NhanVien)selectedRow.DataBoundItem;

               
                var form = new Form2(nhanVien);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dtaNhanVien.Refresh();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtaNhanVien.SelectedRows.Count > 0)
            {
                var selectedRow = dtaNhanVien.SelectedRows[0];
                var nhanVien = (NhanVien)selectedRow.DataBoundItem;

                nhanViens.Remove(nhanVien);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát", "Câu hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
