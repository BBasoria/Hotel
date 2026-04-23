namespace MADProyectoEneJun2023
{
    partial class CheckOut
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.ACEPTAR = new System.Windows.Forms.Button();
            this.GUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbbx_tipodepagoreserv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.Cancelar.Location = new System.Drawing.Point(326, 253);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(128, 40);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ACEPTAR
            // 
            this.ACEPTAR.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.ACEPTAR.Location = new System.Drawing.Point(124, 253);
            this.ACEPTAR.Margin = new System.Windows.Forms.Padding(4);
            this.ACEPTAR.Name = "ACEPTAR";
            this.ACEPTAR.Size = new System.Drawing.Size(118, 40);
            this.ACEPTAR.TabIndex = 6;
            this.ACEPTAR.Text = "Aceptar";
            this.ACEPTAR.UseVisualStyleBackColor = true;
            this.ACEPTAR.Click += new System.EventHandler(this.ACEPTAR_Click);
            // 
            // GUID
            // 
            this.GUID.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.GUID.Location = new System.Drawing.Point(39, 71);
            this.GUID.Margin = new System.Windows.Forms.Padding(4);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(482, 27);
            this.GUID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el código único de Reservación para CheckOut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usos de servicios adicionales:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.checkBox1.Location = new System.Drawing.Point(381, 127);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sí consumio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbbx_tipodepagoreserv
            // 
            this.cbbx_tipodepagoreserv.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.cbbx_tipodepagoreserv.FormattingEnabled = true;
            this.cbbx_tipodepagoreserv.Location = new System.Drawing.Point(41, 195);
            this.cbbx_tipodepagoreserv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbx_tipodepagoreserv.Name = "cbbx_tipodepagoreserv";
            this.cbbx_tipodepagoreserv.Size = new System.Drawing.Size(360, 28);
            this.cbbx_tipodepagoreserv.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label10.Location = new System.Drawing.Point(35, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo de pago:";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 330);
            this.Controls.Add(this.cbbx_tipodepagoreserv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.ACEPTAR);
            this.Controls.Add(this.GUID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button ACEPTAR;
        private System.Windows.Forms.TextBox GUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbbx_tipodepagoreserv;
        private System.Windows.Forms.Label label10;
    }
}