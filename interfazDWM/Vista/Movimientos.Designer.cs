namespace interfazDWM
{
    partial class Movimientos
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
            this.tituloMov = new System.Windows.Forms.Label();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloMov
            // 
            this.tituloMov.AutoSize = true;
            this.tituloMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMov.Location = new System.Drawing.Point(295, 9);
            this.tituloMov.Name = "tituloMov";
            this.tituloMov.Size = new System.Drawing.Size(244, 46);
            this.tituloMov.TabIndex = 0;
            this.tituloMov.Text = "Movimientos";
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimiento.FlatAppearance.BorderSize = 0;
            this.btnMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovimiento.Location = new System.Drawing.Point(289, 374);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(250, 45);
            this.btnMovimiento.TabIndex = 2;
            this.btnMovimiento.Text = "Guardar";
            this.btnMovimiento.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(766, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(22, 22);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "X";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMovimiento);
            this.Controls.Add(this.tituloMov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloMov;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Label btnReturn;
    }
}