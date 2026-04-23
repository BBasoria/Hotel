namespace MADProyectoEneJun2023
{
    partial class CheckIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.GUID = new System.Windows.Forms.TextBox();
            this.ACEPTAR = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el código único de Reservación:";
            // 
            // GUID
            // 
            this.GUID.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.GUID.Location = new System.Drawing.Point(49, 79);
            this.GUID.Margin = new System.Windows.Forms.Padding(4);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(388, 27);
            this.GUID.TabIndex = 1;
            // 
            // ACEPTAR
            // 
            this.ACEPTAR.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.ACEPTAR.Location = new System.Drawing.Point(99, 140);
            this.ACEPTAR.Margin = new System.Windows.Forms.Padding(4);
            this.ACEPTAR.Name = "ACEPTAR";
            this.ACEPTAR.Size = new System.Drawing.Size(120, 44);
            this.ACEPTAR.TabIndex = 2;
            this.ACEPTAR.Text = "Aceptar";
            this.ACEPTAR.UseVisualStyleBackColor = true;
            this.ACEPTAR.Click += new System.EventHandler(this.ACEPTAR_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.Cancelar.Location = new System.Drawing.Point(252, 140);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(118, 44);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 214);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.ACEPTAR);
            this.Controls.Add(this.GUID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckIn";
            this.Text = "Hotel | CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GUID;
        private System.Windows.Forms.Button ACEPTAR;
        private System.Windows.Forms.Button Cancelar;
    }
}