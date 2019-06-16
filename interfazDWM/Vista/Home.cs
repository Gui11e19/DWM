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
using interfazDWM.Vista;

namespace interfazDWM
{
    public partial class panelContenedor : Form
    {
        public panelContenedor()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void Sendmessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 50;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void abrirFormInPanel(object formHijo)
        {
            if (this.panelControlador.Controls.Count > 0)
                this.panelControlador.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControlador.Controls.Add(fh);
            this.panelControlador.Tag = fh;
            fh.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form home = new panelContenedor();
            //home.Show();
            Form menu = new menuDWM();
            menu.Show();
        }

        private void barra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            Sendmessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Movimientos());
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Cuentas());
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Operaciones());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new panCategoria());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //EN ESTA PARTE SE MANDA A ABRRI EL PDF
        }

        private void panelControlador_Paint(object sender, PaintEventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void barra_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Ingreso_MouseDown(object sender, MouseEventArgs e)
        {
            vtnIngreso ingreso = new vtnIngreso();
            ingreso.Show();
        }
    }
}
