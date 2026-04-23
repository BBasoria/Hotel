
namespace MADProyectoEneJun2023
{
    partial class NuevaContrasena
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_contranueva = new System.Windows.Forms.TextBox();
            this.txtbx_repetircontra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Escriba la nueva contraseña para su cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Contraseña nueva:";
            // 
            // txtbx_contranueva
            // 
            this.txtbx_contranueva.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contranueva.Location = new System.Drawing.Point(56, 107);
            this.txtbx_contranueva.Name = "txtbx_contranueva";
            this.txtbx_contranueva.Size = new System.Drawing.Size(272, 27);
            this.txtbx_contranueva.TabIndex = 53;
            // 
            // txtbx_repetircontra
            // 
            this.txtbx_repetircontra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_repetircontra.Location = new System.Drawing.Point(56, 184);
            this.txtbx_repetircontra.Name = "txtbx_repetircontra";
            this.txtbx_repetircontra.Size = new System.Drawing.Size(272, 27);
            this.txtbx_repetircontra.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label3.Location = new System.Drawing.Point(52, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Repetir contraseña:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(373, 122);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(154, 73);
            this.btn_aceptar.TabIndex = 56;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click_1);
            // 
            // NuevaContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 277);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txtbx_repetircontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_contranueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevaContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | Nueva Contraseña";
            this.Load += new System.EventHandler(this.NuevaContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_contranueva;
        private System.Windows.Forms.TextBox txtbx_repetircontra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
    }
}