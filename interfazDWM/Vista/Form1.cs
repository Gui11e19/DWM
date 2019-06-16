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


namespace interfazDWM
{
    public partial class menuDWM : Form
    {
        public menuDWM()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void Sendmessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 60;
            }
            else
                menuVertical.Width = 250;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMax.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            Sendmessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();

        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new panelContenedor();
            home.Show();
            //abrirFormInPanel(new Home());
            //var Form = new menuDWM();
            //Form.FormClosed += (s, args) => this.Close();
            //Form.Show();
        }

        private void menuDWM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

       
}
