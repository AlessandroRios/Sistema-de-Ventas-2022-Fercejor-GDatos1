namespace FercejorSV
{
    partial class FormPrincipal
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
            this.contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(3, 139);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(861, 424);
            this.contenedor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-18, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "SISTEMA DE VENTAS FERCEJOR";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVenta,
            this.menuProveedores,
            this.menuInventario,
            this.menuEmpleados,
            this.menuReportes});
            this.Menu.Location = new System.Drawing.Point(0, 63);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(864, 73);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // menuVenta
            // 
            this.menuVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVenta.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuVenta.IconColor = System.Drawing.Color.Black;
            this.menuVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVenta.Name = "menuVenta";
            this.menuVenta.Size = new System.Drawing.Size(62, 69);
            this.menuVenta.Text = "VENTA";
            this.menuVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVenta.Click += new System.EventHandler(this.menuVenta_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(111, 69);
            this.menuProveedores.Text = "PROVEEDORES";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuPedidos_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInventario.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.menuInventario.IconColor = System.Drawing.Color.Black;
            this.menuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(98, 69);
            this.menuInventario.Text = "INVENTARIO";
            this.menuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInventario.Click += new System.EventHandler(this.menuInventario_Click);
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(97, 69);
            this.menuEmpleados.Text = "EMPLEADOS";
            this.menuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEmpleados.Click += new System.EventHandler(this.menuEmpleados_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(83, 69);
            this.menuReportes.Text = "REPORTES";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(864, 63);
            this.MenuTitulo.TabIndex = 5;
            this.MenuTitulo.Text = "menuStrip2";
            this.MenuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuTitulo_ItemClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem menuVenta;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuInventario;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.MenuStrip MenuTitulo;
    }
}