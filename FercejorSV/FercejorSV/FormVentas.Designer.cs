namespace FercejorSV
{
    partial class FormVentas
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.ibtnVender = new FontAwesome.Sharp.IconButton();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.txtDatoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridDatosVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(629, 344);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 20);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(359, 344);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(91, 20);
            this.lblSubTotal.TabIndex = 30;
            this.lblSubTotal.Text = "lblSubtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "SUB TOTAL:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(17, 258);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(46, 20);
            this.txtCantidad.TabIndex = 27;
            // 
            // ibtnVender
            // 
            this.ibtnVender.BackColor = System.Drawing.Color.LimeGreen;
            this.ibtnVender.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnVender.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ibtnVender.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVender.Location = new System.Drawing.Point(12, 301);
            this.ibtnVender.Name = "ibtnVender";
            this.ibtnVender.Size = new System.Drawing.Size(146, 65);
            this.ibtnVender.TabIndex = 26;
            this.ibtnVender.Text = "VENDER";
            this.ibtnVender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnVender.UseVisualStyleBackColor = false;
            this.ibtnVender.Click += new System.EventHandler(this.ibtnVender_Click);
            // 
            // cbComprobante
            // 
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Location = new System.Drawing.Point(16, 116);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(148, 21);
            this.cbComprobante.TabIndex = 25;
            // 
            // txtProducto
            // 
            this.txtProducto.FormattingEnabled = true;
            this.txtProducto.Location = new System.Drawing.Point(16, 186);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(147, 21);
            this.txtProducto.TabIndex = 24;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Red;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.Location = new System.Drawing.Point(172, 40);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(43, 23);
            this.btnAgregarCliente.TabIndex = 23;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // txtDatoCliente
            // 
            this.txtDatoCliente.Location = new System.Drawing.Point(12, 42);
            this.txtDatoCliente.Name = "txtDatoCliente";
            this.txtDatoCliente.Size = new System.Drawing.Size(151, 20);
            this.txtDatoCliente.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo Comprobante";
            // 
            // dtGridDatosVenta
            // 
            this.dtGridDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDatosVenta.Location = new System.Drawing.Point(243, 10);
            this.dtGridDatosVenta.Name = "dtGridDatosVenta";
            this.dtGridDatosVenta.Size = new System.Drawing.Size(590, 320);
            this.dtGridDatosVenta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 377);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.ibtnVender);
            this.Controls.Add(this.cbComprobante);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtDatoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGridDatosVenta);
            this.Controls.Add(this.label1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private FontAwesome.Sharp.IconButton ibtnVender;
        private System.Windows.Forms.ComboBox cbComprobante;
        private System.Windows.Forms.ComboBox txtProducto;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private System.Windows.Forms.TextBox txtDatoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGridDatosVenta;
        private System.Windows.Forms.Label label1;
    }
}