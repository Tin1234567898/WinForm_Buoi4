using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom_4_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public NhanVien NhanVien { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {

        } 

        public Form2(NhanVien NhanVien) : this ()
        {
            this.NhanVien = NhanVien;

            if (NhanVien != null)
            {
                txtID.Text = NhanVien.ID.ToString();
                txtName.Text = NhanVien.Name;
                txtSalary.Text = NhanVien.Salary.ToString();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (NhanVien == null) 
            NhanVien = new NhanVien();
            NhanVien.ID = int.Parse(txtID.Text);
            NhanVien.Name = txtName.Text;
            NhanVien.Salary = int.Parse(txtSalary.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
