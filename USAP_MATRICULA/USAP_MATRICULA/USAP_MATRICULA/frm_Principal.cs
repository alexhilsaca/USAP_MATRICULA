using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USAP_MATRICULA
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void lbl_SisMatric_Click(object sender, EventArgs e)
        {

        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_identificate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login frm = new frm_Login();
            frm.Show();
        }
    }
}
