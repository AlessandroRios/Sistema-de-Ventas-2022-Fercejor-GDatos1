namespace FercejorSV
{
    partial class FormEmpleados
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
            this.dtGridEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ibtnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            this.iActualizarEmpleado = new FontAwesome.Sharp.IconButton();
            this.iEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridEmpleados
            // 
            this.dtGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmpleados.Location = new System.Drawing.Point(295, 12);
            this.dtGridEmpleados.Name = "dtGridEmpleados";
            this.dtGridEmpleados.Size = new System.Drawing.Size(538, 353);
            this.dtGridEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEFONO";
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
            this.ibtnGuardarEmpleado.TabIndex = 5;
            this.ibtnGuardarEmpleado.UseVisualStyleBackColor = true;
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
            this.iActualizarEmpleado.TabIndex = 6;
            this.iActualizarEmpleado.UseVisualStyleBackColor = true;
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
            this.iEliminarEmpleado.TabIndex = 7;
            this.iEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "ROL";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 50);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(124, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(122, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(101, 187);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(101, 230);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(121, 21);
            this.cbRol.TabIndex = 13;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 377);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iEliminarEmpleado);
            this.Controls.Add(this.iActualizarEmpleado);
            this.Controls.Add(this.ibtnGuardarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridEmpleados);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ibtnGuardarEmpleado;
        private FontAwesome.Sharp.IconButton iActualizarEmpleado;
        private FontAwesome.Sharp.IconButton iEliminarEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbRol;
    }
}