
namespace MADProyectoEneJun2023
{
    partial class Habitacion
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
            this.dgv_tipohabitacion = new System.Windows.Forms.DataGridView();
            this.dgv_hotel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrarnumhab = new System.Windows.Forms.Button();
            this.txtbx_tiphhabitacion = new System.Windows.Forms.TextBox();
            this.txtbx_hhabitacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_habitacion = new System.Windows.Forms.DataGridView();
            this.btn_editarnumhab = new System.Windows.Forms.Button();
            this.btn_eliminarnumhab = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_numhab = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RefrescarHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipohabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "El tipo de habitación:";
            // 
            // dgv_tipohabitacion
            // 
            this.dgv_tipohabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipohabitacion.Location = new System.Drawing.Point(26, 102);
            this.dgv_tipohabitacion.Name = "dgv_tipohabitacion";
            this.dgv_tipohabitacion.ReadOnly = true;
            this.dgv_tipohabitacion.RowHeadersWidth = 51;
            this.dgv_tipohabitacion.RowTemplate.Height = 24;
            this.dgv_tipohabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipohabitacion.Size = new System.Drawing.Size(684, 230);
            this.dgv_tipohabitacion.TabIndex = 1;
            this.dgv_tipohabitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tipohabitacion_CellClick);
            this.dgv_tipohabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tipohabitacion_CellContentClick);
            // 
            // dgv_hotel
            // 
            this.dgv_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hotel.Location = new System.Drawing.Point(26, 391);
            this.dgv_hotel.Name = "dgv_hotel";
            this.dgv_hotel.ReadOnly = true;
            this.dgv_hotel.RowHeadersWidth = 51;
            this.dgv_hotel.RowTemplate.Height = 24;
            this.dgv_hotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hotel.Size = new System.Drawing.Size(684, 230);
            this.dgv_hotel.TabIndex = 3;
            this.dgv_hotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hotel_CellClick);
            this.dgv_hotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hotel_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel al que pertenece la habitación:";
            // 
            // btn_registrarnumhab
            // 
            this.btn_registrarnumhab.Location = new System.Drawing.Point(731, 76);
            this.btn_registrarnumhab.Name = "btn_registrarnumhab";
            this.btn_registrarnumhab.Size = new System.Drawing.Size(138, 85);
            this.btn_registrarnumhab.TabIndex = 4;
            this.btn_registrarnumhab.Text = "Registrar Número de habitación";
            this.btn_registrarnumhab.UseVisualStyleBackColor = true;
            this.btn_registrarnumhab.Click += new System.EventHandler(this.btn_registrarnumhab_Click);
            // 
            // txtbx_tiphhabitacion
            // 
            this.txtbx_tiphhabitacion.Location = new System.Drawing.Point(212, 60);
            this.txtbx_tiphhabitacion.Name = "txtbx_tiphhabitacion";
            this.txtbx_tiphhabitacion.Size = new System.Drawing.Size(403, 23);
            this.txtbx_tiphhabitacion.TabIndex = 5;
            // 
            // txtbx_hhabitacion
            // 
            this.txtbx_hhabitacion.Location = new System.Drawing.Point(338, 354);
            this.txtbx_hhabitacion.Name = "txtbx_hhabitacion";
            this.txtbx_hhabitacion.Size = new System.Drawing.Size(277, 23);
            this.txtbx_hhabitacion.TabIndex = 6;
            this.txtbx_hhabitacion.TextChanged += new System.EventHandler(this.txtbx_hhabitacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registro del Número de habitación para la habitación del hotel";
            // 
            // dgv_habitacion
            // 
            this.dgv_habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitacion.Location = new System.Drawing.Point(731, 321);
            this.dgv_habitacion.Name = "dgv_habitacion";
            this.dgv_habitacion.ReadOnly = true;
            this.dgv_habitacion.RowHeadersWidth = 51;
            this.dgv_habitacion.RowTemplate.Height = 24;
            this.dgv_habitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_habitacion.Size = new System.Drawing.Size(426, 300);
            this.dgv_habitacion.TabIndex = 8;
            this.dgv_habitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_habitacion_CellClick);
            this.dgv_habitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_habitacion_CellContentClick);
            // 
            // btn_editarnumhab
            // 
            this.btn_editarnumhab.Location = new System.Drawing.Point(875, 76);
            this.btn_editarnumhab.Name = "btn_editarnumhab";
            this.btn_editarnumhab.Size = new System.Drawing.Size(138, 85);
            this.btn_editarnumhab.TabIndex = 9;
            this.btn_editarnumhab.Text = "Editar Número de habitación";
            this.btn_editarnumhab.UseVisualStyleBackColor = true;
            this.btn_editarnumhab.Click += new System.EventHandler(this.btn_editarnumhab_Click);
            // 
            // btn_eliminarnumhab
            // 
            this.btn_eliminarnumhab.Enabled = false;
            this.btn_eliminarnumhab.Location = new System.Drawing.Point(1019, 76);
            this.btn_eliminarnumhab.Name = "btn_eliminarnumhab";
            this.btn_eliminarnumhab.Size = new System.Drawing.Size(138, 85);
            this.btn_eliminarnumhab.TabIndex = 10;
            this.btn_eliminarnumhab.Text = "Eliminar Número de habitación";
            this.btn_eliminarnumhab.UseVisualStyleBackColor = true;
            this.btn_eliminarnumhab.Click += new System.EventHandler(this.btn_eliminarnumhab_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1070, 20);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 30);
            this.btn_exit.TabIndex = 69;
            this.btn_exit.Text = "Volver";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(727, 191);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(430, 45);
            this.label11.TabIndex = 72;
            this.label11.Text = "El número de habitación sirve para identificar que habitación se quiere modificar" +
    " o eliminar.";
            // 
            // txtbx_numhab
            // 
            this.txtbx_numhab.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_numhab.Location = new System.Drawing.Point(727, 268);
            this.txtbx_numhab.Name = "txtbx_numhab";
            this.txtbx_numhab.ReadOnly = true;
            this.txtbx_numhab.Size = new System.Drawing.Size(198, 23);
            this.txtbx_numhab.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(727, 245);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(176, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Número de Habitación:";
            // 
            // RefrescarHotel
            // 
            this.RefrescarHotel.Location = new System.Drawing.Point(621, 354);
            this.RefrescarHotel.Name = "RefrescarHotel";
            this.RefrescarHotel.Size = new System.Drawing.Size(90, 23);
            this.RefrescarHotel.TabIndex = 74;
            this.RefrescarHotel.Text = "Refrescar";
            this.RefrescarHotel.UseVisualStyleBackColor = true;
            this.RefrescarHotel.Click += new System.EventHandler(this.RefrescarHotel_Click);
            // 
            // Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 664);
            this.Controls.Add(this.RefrescarHotel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbx_numhab);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_eliminarnumhab);
            this.Controls.Add(this.btn_editarnumhab);
            this.Controls.Add(this.dgv_habitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_hhabitacion);
            this.Controls.Add(this.txtbx_tiphhabitacion);
            this.Controls.Add(this.btn_registrarnumhab);
            this.Controls.Add(this.dgv_hotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tipohabitacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel | Habitación";
            this.Load += new System.EventHandler(this.Habitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipohabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tipohabitacion;
        private System.Windows.Forms.DataGridView dgv_hotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrarnumhab;
        private System.Windows.Forms.TextBox txtbx_tiphhabitacion;
        private System.Windows.Forms.TextBox txtbx_hhabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_habitacion;
        private System.Windows.Forms.Button btn_editarnumhab;
        private System.Windows.Forms.Button btn_eliminarnumhab;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_numhab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RefrescarHotel;
    }
}