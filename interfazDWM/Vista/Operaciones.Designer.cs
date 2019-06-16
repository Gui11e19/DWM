namespace interfazDWM
{
    partial class Operaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operaciones));
            this.tituloOpe = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Label();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloOpe
            // 
            this.tituloOpe.AutoSize = true;
            this.tituloOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloOpe.Location = new System.Drawing.Point(280, 24);
            this.tituloOpe.Name = "tituloOpe";
            this.tituloOpe.Size = new System.Drawing.Size(247, 46);
            this.tituloOpe.TabIndex = 8;
            this.tituloOpe.Text = "Operaciones";
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(766, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(22, 22);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "X";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnOperaciones.Image")));
            this.btnOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.Location = new System.Drawing.Point(280, 378);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(247, 45);
            this.btnOperaciones.TabIndex = 10;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = false;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tituloOpe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloOpe;
        private System.Windows.Forms.Label btnReturn;
        private System.Windows.Forms.Button btnOperaciones;
    }
}