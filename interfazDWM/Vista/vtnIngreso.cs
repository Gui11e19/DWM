using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace interfazDWM.Vista
{
    public partial class vtnIngreso : Form
    {
        public vtnIngreso()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void vtnIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text == "$ Valor")
            {
                txtValor.Text = "";
                txtValor.ForeColor = Color.Black;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                txtValor.Text = "$ Valor";
                txtValor.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripción";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha dd/mm/nnnn")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Black;
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "Fecha dd/mm/nnnn";
                txtFecha.ForeColor = Color.Black;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void vtnIngreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
