namespace FercejorSV
{
    partial class FormProveedores
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.iEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            this.iActualizarEmpleado = new FontAwesome.Sharp.IconButton();
            this.ibtnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridEmpleados = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(109, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 50);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(124, 20);
            this.txtId.TabIndex = 23;
            // 
            // iEliminarEmpleado
            // 
            this.iEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iEliminarEmpleado.IconColor = System.Drawing.Color.Black;
            this.iEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iEliminarEmpleado.IconSize = 30;
            this.iEliminarEmpleado.Location = new System.Drawing.Point(95, 297);
            this.iEliminarEmpleado.Name = "iEliminarEmpleado";
            this.iEliminarEmpleado.Size = new System.Drawing.Size(75, 34);
            this.iEliminarEmpleado.TabIndex = 21;
            this.iEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // iActualizarEmpleado
            // 
            this.iActualizarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.iActualizarEmpleado.IconColor = System.Drawing.Color.Black;
            this.iActualizarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iActualizarEmpleado.IconSize = 30;
            this.iActualizarEmpleado.Location = new System.Drawing.Point(176, 297);
            this.iActualizarEmpleado.Name = "iActualizarEmpleado";
            this.iActualizarEmpleado.Size = new System.Drawing.Size(75, 34);
            this.iActualizarEmpleado.TabIndex = 20;
            this.iActualizarEmpleado.UseVisualStyleBackColor = true;
            // 
            // ibtnGuardarEmpleado
            // 
            this.ibtnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnGuardarEmpleado.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardarEmpleado.IconSize = 30;
            this.ibtnGuardarEmpleado.Location = new System.Drawing.Point(12, 297);
            this.ibtnGuardarEmpleado.Name = "ibtnGuardarEmpleado";
            this.ibtnGuardarEmpleado.Size = new System.Drawing.Size(75, 34);
            this.ibtnGuardarEmpleado.TabIndex = 19;
            this.ibtnGuardarEmpleado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // dtGridEmpleados
            // 
            this.dtGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmpleados.Location = new System.Drawing.Point(295, 12);
            this.dtGridEmpleados.Name = "dtGridEmpleados";
            this.dtGridEmpleados.Size = new System.Drawing.Size(538, 353);
            this.dtGridEmpleados.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "CORREO";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.iEliminarEmpleado);
            this.Controls.Add(this.iActualizarEmpleado);
            this.Controls.Add(this.ibtnGuardarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridEmpleados);
            this.Name = "FormProveedores";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton iEliminarEmpleado;
        private FontAwesome.Sharp.IconButton iActualizarEmpleado;
        private FontAwesome.Sharp.IconButton ibtnGuardarEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridEmpleados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}