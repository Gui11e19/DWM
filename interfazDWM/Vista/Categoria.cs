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
    public partial class panCategoria : Form
    {
        public panCategoria()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SE GUARDA EL AVANCE
            this.Close();
            
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            agregarCategoria addCat = new agregarCategoria();
            this.Hide();
            addCat.Show();
        }

        private void panCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
