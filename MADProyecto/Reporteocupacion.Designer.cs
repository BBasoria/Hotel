
namespace MADProyectoEneJun2023
{
    partial class Reporteocupacion
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
            this.dgv_reportehotel = new System.Windows.Forms.DataGridView();
            this.rbtn_pais = new System.Windows.Forms.RadioButton();
            this.rbtn_ciudad = new System.Windows.Forms.RadioButton();
            this.rbtn_hotel = new System.Windows.Forms.RadioButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtbx_filtrohotel = new System.Windows.Forms.TextBox();
            this.dgv_reportehotel2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_fitroanohotel = new System.Windows.Forms.TextBox();
            this.btn_filtroanohotel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportehotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportehotel2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reportehotel
            // 
            this.dgv_reportehotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportehotel.Location = new System.Drawing.Point(24, 144);
            this.dgv_reportehotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_reportehotel.Name = "dgv_reportehotel";
            this.dgv_reportehotel.ReadOnly = true;
            this.dgv_reportehotel.RowHeadersWidth = 51;
            this.dgv_reportehotel.RowTemplate.Height = 24;
            this.dgv_reportehotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reportehotel.Size = new System.Drawing.Size(626, 176);
            this.dgv_reportehotel.TabIndex = 34;
            this.dgv_reportehotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reportehotel_CellContentClick);
            // 
            // rbtn_pais
            // 
            this.rbtn_pais.AutoSize = true;
            this.rbtn_pais.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_pais.Location = new System.Drawing.Point(24, 82);
            this.rbtn_pais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_pais.Name = "rbtn_pais";
            this.rbtn_pais.Size = new System.Drawing.Size(58, 21);
            this.rbtn_pais.TabIndex = 35;
            this.rbtn_pais.TabStop = true;
            this.rbtn_pais.Text = "País";
            this.rbtn_pais.UseVisualStyleBackColor = true;
            this.rbtn_pais.CheckedChanged += new System.EventHandler(this.rbtn_pais_CheckedChanged);
            // 
            // rbtn_ciudad
            // 
            this.rbtn_ciudad.AutoSize = true;
            this.rbtn_ciudad.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_ciudad.Location = new System.Drawing.Point(86, 82);
            this.rbtn_ciudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_ciudad.Name = "rbtn_ciudad";
            this.rbtn_ciudad.Size = new System.Drawing.Size(74, 21);
            this.rbtn_ciudad.TabIndex = 37;
            this.rbtn_ciudad.TabStop = true;
            this.rbtn_ciudad.Text = "Ciudad";
            this.rbtn_ciudad.UseVisualStyleBackColor = true;
            this.rbtn_ciudad.CheckedChanged += new System.EventHandler(this.rbtn_ciudad_CheckedChanged);
            // 
            // rbtn_hotel
            // 
            this.rbtn_hotel.AutoSize = true;
            this.rbtn_hotel.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.rbtn_hotel.Location = new System.Drawing.Point(160, 82);
            this.rbtn_hotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_hotel.Name = "rbtn_hotel";
            this.rbtn_hotel.Size = new System.Drawing.Size(66, 21);
            this.rbtn_hotel.TabIndex = 38;
            this.rbtn_hotel.TabStop = true;
            this.rbtn_hotel.Text = "Hotel";
            this.rbtn_hotel.UseVisualStyleBackColor = true;
            this.rbtn_hotel.CheckedChanged += new System.EventHandler(this.rbtn_hotel_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(584, 23);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 24);
            this.btn_exit.TabIndex = 72;
            this.btn_exit.Text = "Volver";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtbx_filtrohotel
            // 
            this.txtbx_filtrohotel.Location = new System.Drawing.Point(24, 106);
            this.txtbx_filtrohotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_filtrohotel.Name = "txtbx_filtrohotel";
            this.txtbx_filtrohotel.Size = new System.Drawing.Size(392, 20);
            this.txtbx_filtrohotel.TabIndex = 73;
            this.txtbx_filtrohotel.TextChanged += new System.EventHandler(this.txtbx_filtrohotel_TextChanged);
            // 
            // dgv_reportehotel2
            // 
            this.dgv_reportehotel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportehotel2.Location = new System.Drawing.Point(24, 366);
            this.dgv_reportehotel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_reportehotel2.Name = "dgv_reportehotel2";
            this.dgv_reportehotel2.ReadOnly = true;
            this.dgv_reportehotel2.RowHeadersWidth = 51;
            this.dgv_reportehotel2.RowTemplate.Height = 24;
            this.dgv_reportehotel2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reportehotel2.Size = new System.Drawing.Size(626, 184);
            this.dgv_reportehotel2.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Reporte de ocupación de hoteles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label3.Location = new System.Drawing.Point(21, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Reporte de hoteles resumido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Año:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbx_fitroanohotel
            // 
            this.txtbx_fitroanohotel.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_fitroanohotel.Location = new System.Drawing.Point(59, 47);
            this.txtbx_fitroanohotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_fitroanohotel.Name = "txtbx_fitroanohotel";
            this.txtbx_fitroanohotel.Size = new System.Drawing.Size(212, 23);
            this.txtbx_fitroanohotel.TabIndex = 87;
            // 
            // btn_filtroanohotel
            // 
            this.btn_filtroanohotel.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.btn_filtroanohotel.Location = new System.Drawing.Point(303, 47);
            this.btn_filtroanohotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtroanohotel.Name = "btn_filtroanohotel";
            this.btn_filtroanohotel.Size = new System.Drawing.Size(112, 22);
            this.btn_filtroanohotel.TabIndex = 88;
            this.btn_filtroanohotel.Text = "Filtrar año";
            this.btn_filtroanohotel.UseVisualStyleBackColor = true;
            this.btn_filtroanohotel.Click += new System.EventHandler(this.btn_filtroanohotel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "Refrescar tablas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Poner año y algún filtro para ver un hotel.";
            // 
            // Reporteocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_filtroanohotel);
            this.Controls.Add(this.txtbx_fitroanohotel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_reportehotel2);
            this.Controls.Add(this.txtbx_filtrohotel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.rbtn_hotel);
            this.Controls.Add(this.rbtn_ciudad);
            this.Controls.Add(this.rbtn_pais);
            this.Controls.Add(this.dgv_reportehotel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reporteocupacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | Reporte ocupación";
            this.Load += new System.EventHandler(this.Reportehotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportehotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportehotel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reportehotel;
        private System.Windows.Forms.RadioButton rbtn_pais;
        private System.Windows.Forms.RadioButton rbtn_ciudad;
        private System.Windows.Forms.RadioButton rbtn_hotel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtbx_filtrohotel;
        private System.Windows.Forms.DataGridView dgv_reportehotel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_fitroanohotel;
        private System.Windows.Forms.Button btn_filtroanohotel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}