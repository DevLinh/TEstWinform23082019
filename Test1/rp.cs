using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class rp : Form
    {
        public rp()
        {
            InitializeComponent();
        }

        private void rp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSV.SinhVien' table. You can move, or remove it, as needed.
            this.SinhVienTableAdapter.Fill(this.dsSV.SinhVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
