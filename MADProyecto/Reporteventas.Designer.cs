
namespace MADProyectoEneJun2023
{
    partial class Reporteventas
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
            this.btn_fitroanoventas = new System.Windows.Forms.Button();
            this.txtbx_fitroanoventas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_filtroventas = new System.Windows.Forms.TextBox();
            this.rbtn_hotelventas = new System.Windows.Forms.RadioButton();
            this.rbtn_ciudadvantas = new System.Windows.Forms.RadioButton();
            this.rbtn_paisventas = new System.Windows.Forms.RadioButton();
            this.dgv_reporteventas = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporteventas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fitroanoventas
            // 
            this.btn_fitroanoventas.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.btn_fitroanoventas.Location = new System.Drawing.Point(301, 46);
            this.btn_fitroanoventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fitroanoventas.Name = "btn_fitroanoventas";
            this.btn_fitroanoventas.Size = new System.Drawing.Size(112, 22);
            this.btn_fitroanoventas.TabIndex = 100;
            this.btn_fitroanoventas.Text = "Filtrar año";
            this.btn_fitroanoventas.UseVisualStyleBackColor = true;
            this.btn_fitroanoventas.Click += new System.EventHandler(this.btn_fitroanoventas_Click);
            // 
            // txtbx_fitroanoventas
            // 
            this.txtbx_fitroanoventas.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_fitroanoventas.Location = new System.Drawing.Point(57, 46);
            this.txtbx_fitroanoventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_fitroanoventas.Name = "txtbx_fitroanoventas";
            this.txtbx_fitroanoventas.Size = new System.Drawing.Size(212, 23);
            this.txtbx_fitroanoventas.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label5.Location = new System.Drawing.Point(19, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Reporte de ventas:";
            // 
            // txtbx_filtroventas
            // 
            this.txtbx_filtroventas.Location = new System.Drawing.Point(26, 107);
            this.txtbx_filtroventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_filtroventas.Name = "txtbx_filtroventas";
            this.txtbx_filtroventas.Size = new System.Drawing.Size(388, 20);
            this.txtbx_filtroventas.TabIndex = 96;
            // 
            // rbtn_hotelventas
            // 
            this.rbtn_hotelventas.AutoSize = true;
            this.rbtn_hotelventas.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_hotelventas.Location = new System.Drawing.Point(160, 76);
            this.rbtn_hotelventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_hotelventas.Name = "rbtn_hotelventas";
            this.rbtn_hotelventas.Size = new System.Drawing.Size(66, 21);
            this.rbtn_hotelventas.TabIndex = 95;
            this.rbtn_hotelventas.TabStop = true;
            this.rbtn_hotelventas.Text = "Hotel";
            this.rbtn_hotelventas.UseVisualStyleBackColor = true;
            this.rbtn_hotelventas.CheckedChanged += new System.EventHandler(this.rbtn_hotelventas_CheckedChanged);
            // 
            // rbtn_ciudadvantas
            // 
            this.rbtn_ciudadvantas.AutoSize = true;
            this.rbtn_ciudadvantas.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_ciudadvantas.Location = new System.Drawing.Point(84, 76);
            this.rbtn_ciudadvantas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_ciudadvantas.Name = "rbtn_ciudadvantas";
            this.rbtn_ciudadvantas.Size = new System.Drawing.Size(74, 21);
            this.rbtn_ciudadvantas.TabIndex = 94;
            this.rbtn_ciudadvantas.TabStop = true;
            this.rbtn_ciudadvantas.Text = "Ciudad";
            this.rbtn_ciudadvantas.UseVisualStyleBackColor = true;
            this.rbtn_ciudadvantas.CheckedChanged += new System.EventHandler(this.rbtn_ciudadvantas_CheckedChanged);
            // 
            // rbtn_paisventas
            // 
            this.rbtn_paisventas.AutoSize = true;
            this.rbtn_paisventas.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_paisventas.Location = new System.Drawing.Point(22, 76);
            this.rbtn_paisventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_paisventas.Name = "rbtn_paisventas";
            this.rbtn_paisventas.Size = new System.Drawing.Size(58, 21);
            this.rbtn_paisventas.TabIndex = 93;
            this.rbtn_paisventas.TabStop = true;
            this.rbtn_paisventas.Text = "País";
            this.rbtn_paisventas.UseVisualStyleBackColor = true;
            this.rbtn_paisventas.CheckedChanged += new System.EventHandler(this.rbtn_paisventas_CheckedChanged);
            // 
            // dgv_reporteventas
            // 
            this.dgv_reporteventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporteventas.Location = new System.Drawing.Point(22, 167);
            this.dgv_reporteventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_reporteventas.Name = "dgv_reporteventas";
            this.dgv_reporteventas.ReadOnly = true;
            this.dgv_reporteventas.RowHeadersWidth = 51;
            this.dgv_reporteventas.RowTemplate.Height = 24;
            this.dgv_reporteventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reporteventas.Size = new System.Drawing.Size(513, 257);
            this.dgv_reporteventas.TabIndex = 92;
            this.dgv_reporteventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reporteventas_CellContentClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(470, 18);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 24);
            this.btn_exit.TabIndex = 101;
            this.btn_exit.Text = "Volver";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 102;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Ingrese año y algún filtro para ver las ventas del hotel.";
            // 
            // Reporteventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_fitroanoventas);
            this.Controls.Add(this.txtbx_fitroanoventas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_filtroventas);
            this.Controls.Add(this.rbtn_hotelventas);
            this.Controls.Add(this.rbtn_ciudadvantas);
            this.Controls.Add(this.rbtn_paisventas);
            this.Controls.Add(this.dgv_reporteventas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reporteventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | Reporte ventas";
            this.Load += new System.EventHandler(this.Reporteventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporteventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fitroanoventas;
        private System.Windows.Forms.TextBox txtbx_fitroanoventas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_filtroventas;
        private System.Windows.Forms.RadioButton rbtn_hotelventas;
        private System.Windows.Forms.RadioButton rbtn_ciudadvantas;
        private System.Windows.Forms.RadioButton rbtn_paisventas;
        private System.Windows.Forms.DataGridView dgv_reporteventas;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}