
namespace MADProyectoEneJun2023
{
    partial class HistorialCliente
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_clientehistorial = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_correo = new System.Windows.Forms.RadioButton();
            this.rbtn_rfc = new System.Windows.Forms.RadioButton();
            this.rbtn_apellidos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_am = new System.Windows.Forms.TextBox();
            this.txtbx_ap = new System.Windows.Forms.TextBox();
            this.txtbx_filtrocliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtraranocliente = new System.Windows.Forms.Button();
            this.txtbx_filtroanocliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientehistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(981, 30);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 30);
            this.btn_exit.TabIndex = 80;
            this.btn_exit.Text = "Volver";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label14.Location = new System.Drawing.Point(33, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 89;
            this.label14.Text = "Clientes:";
            // 
            // dgv_clientehistorial
            // 
            this.dgv_clientehistorial.AllowUserToAddRows = false;
            this.dgv_clientehistorial.AllowUserToDeleteRows = false;
            this.dgv_clientehistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientehistorial.Location = new System.Drawing.Point(36, 290);
            this.dgv_clientehistorial.Name = "dgv_clientehistorial";
            this.dgv_clientehistorial.ReadOnly = true;
            this.dgv_clientehistorial.RowHeadersWidth = 51;
            this.dgv_clientehistorial.RowTemplate.Height = 24;
            this.dgv_clientehistorial.Size = new System.Drawing.Size(1032, 318);
            this.dgv_clientehistorial.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Año:";
            // 
            // rbtn_correo
            // 
            this.rbtn_correo.AutoSize = true;
            this.rbtn_correo.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_correo.Location = new System.Drawing.Point(126, 174);
            this.rbtn_correo.Name = "rbtn_correo";
            this.rbtn_correo.Size = new System.Drawing.Size(192, 24);
            this.rbtn_correo.TabIndex = 104;
            this.rbtn_correo.TabStop = true;
            this.rbtn_correo.Text = "Correo electrónico";
            this.rbtn_correo.UseVisualStyleBackColor = true;
            this.rbtn_correo.CheckedChanged += new System.EventHandler(this.rbtn_correo_CheckedChanged);
            // 
            // rbtn_rfc
            // 
            this.rbtn_rfc.AutoSize = true;
            this.rbtn_rfc.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_rfc.Location = new System.Drawing.Point(45, 174);
            this.rbtn_rfc.Name = "rbtn_rfc";
            this.rbtn_rfc.Size = new System.Drawing.Size(57, 24);
            this.rbtn_rfc.TabIndex = 103;
            this.rbtn_rfc.TabStop = true;
            this.rbtn_rfc.Text = "RFC";
            this.rbtn_rfc.UseVisualStyleBackColor = true;
            this.rbtn_rfc.CheckedChanged += new System.EventHandler(this.rbtn_rfc_CheckedChanged);
            // 
            // rbtn_apellidos
            // 
            this.rbtn_apellidos.AutoSize = true;
            this.rbtn_apellidos.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_apellidos.Location = new System.Drawing.Point(46, 104);
            this.rbtn_apellidos.Name = "rbtn_apellidos";
            this.rbtn_apellidos.Size = new System.Drawing.Size(111, 24);
            this.rbtn_apellidos.TabIndex = 102;
            this.rbtn_apellidos.TabStop = true;
            this.rbtn_apellidos.Text = "Apellidos";
            this.rbtn_apellidos.UseVisualStyleBackColor = true;
            this.rbtn_apellidos.CheckedChanged += new System.EventHandler(this.rbtn_apellidos_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label4.Location = new System.Drawing.Point(473, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txtbx_am
            // 
            this.txtbx_am.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_am.Location = new System.Drawing.Point(668, 133);
            this.txtbx_am.Name = "txtbx_am";
            this.txtbx_am.Size = new System.Drawing.Size(212, 27);
            this.txtbx_am.TabIndex = 99;
            // 
            // txtbx_ap
            // 
            this.txtbx_ap.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_ap.Location = new System.Drawing.Point(241, 133);
            this.txtbx_ap.Name = "txtbx_ap";
            this.txtbx_ap.Size = new System.Drawing.Size(212, 27);
            this.txtbx_ap.TabIndex = 98;
            this.txtbx_ap.TextChanged += new System.EventHandler(this.txtbx_ap_TextChanged);
            // 
            // txtbx_filtrocliente
            // 
            this.txtbx_filtrocliente.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_filtrocliente.Location = new System.Drawing.Point(46, 213);
            this.txtbx_filtrocliente.Name = "txtbx_filtrocliente";
            this.txtbx_filtrocliente.Size = new System.Drawing.Size(447, 27);
            this.txtbx_filtrocliente.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Filtros:";
            // 
            // btn_filtraranocliente
            // 
            this.btn_filtraranocliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtraranocliente.Location = new System.Drawing.Point(668, 69);
            this.btn_filtraranocliente.Name = "btn_filtraranocliente";
            this.btn_filtraranocliente.Size = new System.Drawing.Size(164, 30);
            this.btn_filtraranocliente.TabIndex = 95;
            this.btn_filtraranocliente.Text = "Filtrar año";
            this.btn_filtraranocliente.UseVisualStyleBackColor = true;
            this.btn_filtraranocliente.Click += new System.EventHandler(this.btn_filtraranocliente_Click_1);
            // 
            // txtbx_filtroanocliente
            // 
            this.txtbx_filtroanocliente.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_filtroanocliente.Location = new System.Drawing.Point(101, 69);
            this.txtbx_filtroanocliente.Name = "txtbx_filtroanocliente";
            this.txtbx_filtroanocliente.Size = new System.Drawing.Size(241, 27);
            this.txtbx_filtroanocliente.TabIndex = 94;
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_correo);
            this.Controls.Add(this.rbtn_rfc);
            this.Controls.Add(this.rbtn_apellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_am);
            this.Controls.Add(this.txtbx_ap);
            this.Controls.Add(this.txtbx_filtrocliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_filtraranocliente);
            this.Controls.Add(this.txtbx_filtroanocliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgv_clientehistorial);
            this.Controls.Add(this.btn_exit);
            this.Name = "HistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | Historial del cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientehistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_clientehistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_correo;
        private System.Windows.Forms.RadioButton rbtn_rfc;
        private System.Windows.Forms.RadioButton rbtn_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_am;
        private System.Windows.Forms.TextBox txtbx_ap;
        private System.Windows.Forms.TextBox txtbx_filtrocliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtraranocliente;
        private System.Windows.Forms.TextBox txtbx_filtroanocliente;
    }
}