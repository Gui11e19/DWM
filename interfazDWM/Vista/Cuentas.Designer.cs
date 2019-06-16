namespace interfazDWM
{
    partial class Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuentas));
            this.tituloCue = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Label();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloCue
            // 
            this.tituloCue.AutoSize = true;
            this.tituloCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCue.Location = new System.Drawing.Point(298, 9);
            this.tituloCue.Name = "tituloCue";
            this.tituloCue.Size = new System.Drawing.Size(168, 46);
            this.tituloCue.TabIndex = 9;
            this.tituloCue.Text = "Cuentas";
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(766, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(22, 22);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "X";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentas.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentas.Image")));
            this.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.Location = new System.Drawing.Point(260, 393);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(250, 45);
            this.btnCuentas.TabIndex = 11;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tituloCue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCue;
        private System.Windows.Forms.Label btnReturn;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Label label1;
    }
}