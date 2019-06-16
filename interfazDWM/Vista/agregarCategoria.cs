using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazDWM
{
    public partial class agregarCategoria : Form
    {
        public agregarCategoria()
        {
            InitializeComponent();
        }

        private void AddDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
