
namespace MADProyectoEneJun2023
{
    partial class Factura
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
            this.dgv_reservacionfactura = new System.Windows.Forms.DataGridView();
            this.txtbx_codigoreserv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacionfactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reservacionfactura
            // 
            this.dgv_reservacionfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservacionfactura.Location = new System.Drawing.Point(25, 108);
            this.dgv_reservacionfactura.Name = "dgv_reservacionfactura";
            this.dgv_reservacionfactura.ReadOnly = true;
            this.dgv_reservacionfactura.RowHeadersWidth = 51;
            this.dgv_reservacionfactura.RowTemplate.Height = 24;
            this.dgv_reservacionfactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reservacionfactura.Size = new System.Drawing.Size(988, 497);
            this.dgv_reservacionfactura.TabIndex = 2;
            this.dgv_reservacionfactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservacionfactura_CellClick);
            this.dgv_reservacionfactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservacionfactura_CellContentClick);
            // 
            // txtbx_codigoreserv
            // 
            this.txtbx_codigoreserv.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.txtbx_codigoreserv.Location = new System.Drawing.Point(336, 68);
            this.txtbx_codigoreserv.Name = "txtbx_codigoreserv";
            this.txtbx_codigoreserv.ReadOnly = true;
            this.txtbx_codigoreserv.Size = new System.Drawing.Size(450, 27);
            this.txtbx_codigoreserv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escriba el código de la reservación para pedir una factura:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(926, 24);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 30);
            this.btn_exit.TabIndex = 70;
            this.btn_exit.Text = "Volver";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.Location = new System.Drawing.Point(802, 63);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(211, 36);
            this.btn_factura.TabIndex = 71;
            this.btn_factura.Text = "Imprimir factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 635);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtbx_codigoreserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_reservacionfactura);
            this.Name = "Factura";
            this.Text = "Hotel | Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacionfactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reservacionfactura;
        private System.Windows.Forms.TextBox txtbx_codigoreserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_factura;
    }
}