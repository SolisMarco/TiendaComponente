namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menusalida = new FontAwesome.Sharp.IconMenuItem();
            this.menuentradas = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedor = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.submenuregistrarsalida = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallesalida = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarentrada = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleentrada = new FontAwesome.Sharp.IconMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menumantenedor,
            this.menusalida,
            this.menuentradas,
            this.menuclientes,
            this.menuproveedor,
            this.menureportes,
            this.menuacercade});
            this.Menu.Location = new System.Drawing.Point(0, 46);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(871, 68);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 45;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(80, 64);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 45;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(80, 64);
            this.menumantenedor.Text = "Mantenedor";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(125, 22);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(125, 22);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menusalida
            // 
            this.menusalida.AutoSize = false;
            this.menusalida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarsalida,
            this.submenuverdetallesalida});
            this.menusalida.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menusalida.IconColor = System.Drawing.Color.Black;
            this.menusalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusalida.IconSize = 45;
            this.menusalida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusalida.Name = "menusalida";
            this.menusalida.Size = new System.Drawing.Size(80, 64);
            this.menusalida.Text = "Salida";
            this.menusalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuentradas
            // 
            this.menuentradas.AutoSize = false;
            this.menuentradas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarentrada,
            this.submenuverdetalleentrada});
            this.menuentradas.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuentradas.IconColor = System.Drawing.Color.Black;
            this.menuentradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuentradas.IconSize = 45;
            this.menuentradas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuentradas.Name = "menuentradas";
            this.menuentradas.Size = new System.Drawing.Size(80, 64);
            this.menuentradas.Text = "Entrada";
            this.menuentradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 45;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(80, 64);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedor
            // 
            this.menuproveedor.AutoSize = false;
            this.menuproveedor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedor.IconColor = System.Drawing.Color.Black;
            this.menuproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedor.IconSize = 45;
            this.menuproveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedor.Name = "menuproveedor";
            this.menuproveedor.Size = new System.Drawing.Size(80, 64);
            this.menuproveedor.Text = "Proveedor";
            this.menuproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedor.Click += new System.EventHandler(this.menuproveedor_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 45;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(80, 64);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 45;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 64);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.DarkViolet;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(871, 46);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tienda de Componente";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 114);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(871, 473);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkViolet;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(715, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.DarkViolet;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(774, 20);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 15);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // submenuregistrarsalida
            // 
            this.submenuregistrarsalida.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarsalida.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarsalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarsalida.Name = "submenuregistrarsalida";
            this.submenuregistrarsalida.Size = new System.Drawing.Size(180, 22);
            this.submenuregistrarsalida.Text = "Registrar";
            this.submenuregistrarsalida.Click += new System.EventHandler(this.submenuregistrarsalida_Click);
            // 
            // submenuverdetallesalida
            // 
            this.submenuverdetallesalida.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallesalida.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallesalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallesalida.Name = "submenuverdetallesalida";
            this.submenuverdetallesalida.Size = new System.Drawing.Size(180, 22);
            this.submenuverdetallesalida.Text = "Ver detalle";
            this.submenuverdetallesalida.Click += new System.EventHandler(this.submenuverdetallesalida_Click);
            // 
            // submenuregistrarentrada
            // 
            this.submenuregistrarentrada.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarentrada.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarentrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarentrada.Name = "submenuregistrarentrada";
            this.submenuregistrarentrada.Size = new System.Drawing.Size(180, 22);
            this.submenuregistrarentrada.Text = "Registrar";
            this.submenuregistrarentrada.Click += new System.EventHandler(this.submenuregistrarentrada_Click);
            // 
            // submenuverdetalleentrada
            // 
            this.submenuverdetalleentrada.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleentrada.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleentrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleentrada.Name = "submenuverdetalleentrada";
            this.submenuverdetalleentrada.Size = new System.Drawing.Size(180, 22);
            this.submenuverdetalleentrada.Text = "Ver Detalle";
            this.submenuverdetalleentrada.Click += new System.EventHandler(this.submenuverdetalleentrada_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 587);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.Menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menusalida;
        private FontAwesome.Sharp.IconMenuItem menuentradas;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedor;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarsalida;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallesalida;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarentrada;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleentrada;
    }
}

