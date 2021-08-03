namespace MarketManager
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MENU_VERTICAL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MENU_SUPERIOR = new System.Windows.Forms.Panel();
            this.PANEL_CONTENT = new System.Windows.Forms.Panel();
            this.ICON_MINIMIZED = new System.Windows.Forms.PictureBox();
            this.ICON_RESTORE = new System.Windows.Forms.PictureBox();
            this.ICON_MAXIMIZED = new System.Windows.Forms.PictureBox();
            this.ICON_CLOSE = new System.Windows.Forms.PictureBox();
            this.BTN_SLIDE = new System.Windows.Forms.PictureBox();
            this.BTN_RELATORIO = new System.Windows.Forms.Button();
            this.BTN_HOME = new System.Windows.Forms.Button();
            this.BTN_OUTROS = new System.Windows.Forms.Button();
            this.BTN_COMPRAS = new System.Windows.Forms.Button();
            this.BTN_CLIENTES = new System.Windows.Forms.Button();
            this.BTN_FORNECEDORES = new System.Windows.Forms.Button();
            this.BTN_VENDAS = new System.Windows.Forms.Button();
            this.BTN_PRODUCTS = new System.Windows.Forms.Button();
            this.PICTURE_LOGO = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MENU_VERTICAL.SuspendLayout();
            this.MENU_SUPERIOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MINIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_RESTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MAXIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_LOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_VERTICAL
            // 
            this.MENU_VERTICAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MENU_VERTICAL.Controls.Add(this.label1);
            this.MENU_VERTICAL.Controls.Add(this.BTN_RELATORIO);
            this.MENU_VERTICAL.Controls.Add(this.BTN_HOME);
            this.MENU_VERTICAL.Controls.Add(this.BTN_OUTROS);
            this.MENU_VERTICAL.Controls.Add(this.BTN_COMPRAS);
            this.MENU_VERTICAL.Controls.Add(this.BTN_CLIENTES);
            this.MENU_VERTICAL.Controls.Add(this.BTN_FORNECEDORES);
            this.MENU_VERTICAL.Controls.Add(this.BTN_VENDAS);
            this.MENU_VERTICAL.Controls.Add(this.BTN_PRODUCTS);
            this.MENU_VERTICAL.Controls.Add(this.PICTURE_LOGO);
            this.MENU_VERTICAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU_VERTICAL.Location = new System.Drawing.Point(0, 0);
            this.MENU_VERTICAL.Name = "MENU_VERTICAL";
            this.MENU_VERTICAL.Size = new System.Drawing.Size(250, 650);
            this.MENU_VERTICAL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "MarketManager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MENU_SUPERIOR
            // 
            this.MENU_SUPERIOR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MENU_SUPERIOR.Controls.Add(this.ICON_MINIMIZED);
            this.MENU_SUPERIOR.Controls.Add(this.ICON_RESTORE);
            this.MENU_SUPERIOR.Controls.Add(this.ICON_MAXIMIZED);
            this.MENU_SUPERIOR.Controls.Add(this.ICON_CLOSE);
            this.MENU_SUPERIOR.Controls.Add(this.BTN_SLIDE);
            this.MENU_SUPERIOR.Dock = System.Windows.Forms.DockStyle.Top;
            this.MENU_SUPERIOR.Location = new System.Drawing.Point(250, 0);
            this.MENU_SUPERIOR.Name = "MENU_SUPERIOR";
            this.MENU_SUPERIOR.Size = new System.Drawing.Size(1050, 50);
            this.MENU_SUPERIOR.TabIndex = 221;
            this.MENU_SUPERIOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MENU_SUPERIOR_MouseDown);
            // 
            // PANEL_CONTENT
            // 
            this.PANEL_CONTENT.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CONTENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PANEL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENT.Location = new System.Drawing.Point(250, 50);
            this.PANEL_CONTENT.Name = "PANEL_CONTENT";
            this.PANEL_CONTENT.Size = new System.Drawing.Size(1050, 600);
            this.PANEL_CONTENT.TabIndex = 2;
            this.PANEL_CONTENT.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_CONTENT_Paint);
            // 
            // ICON_MINIMIZED
            // 
            this.ICON_MINIMIZED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_MINIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_MINIMIZED.Image = global::MarketManager.Properties.Resources.e629486b00b62fe708ffb795eca820b2_removebg_preview;
            this.ICON_MINIMIZED.Location = new System.Drawing.Point(966, 6);
            this.ICON_MINIMIZED.Name = "ICON_MINIMIZED";
            this.ICON_MINIMIZED.Size = new System.Drawing.Size(20, 20);
            this.ICON_MINIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_MINIMIZED.TabIndex = 4;
            this.ICON_MINIMIZED.TabStop = false;
            this.ICON_MINIMIZED.Click += new System.EventHandler(this.ICON_MINIMIZED_Click);
            // 
            // ICON_RESTORE
            // 
            this.ICON_RESTORE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_RESTORE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_RESTORE.Image = global::MarketManager.Properties.Resources.squares__1_;
            this.ICON_RESTORE.Location = new System.Drawing.Point(993, 6);
            this.ICON_RESTORE.Name = "ICON_RESTORE";
            this.ICON_RESTORE.Size = new System.Drawing.Size(20, 20);
            this.ICON_RESTORE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_RESTORE.TabIndex = 3;
            this.ICON_RESTORE.TabStop = false;
            this.ICON_RESTORE.Visible = false;
            this.ICON_RESTORE.Click += new System.EventHandler(this.ICON_RESTORE_Click);
            // 
            // ICON_MAXIMIZED
            // 
            this.ICON_MAXIMIZED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_MAXIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_MAXIMIZED.Image = global::MarketManager.Properties.Resources.squares;
            this.ICON_MAXIMIZED.Location = new System.Drawing.Point(993, 6);
            this.ICON_MAXIMIZED.Name = "ICON_MAXIMIZED";
            this.ICON_MAXIMIZED.Size = new System.Drawing.Size(20, 20);
            this.ICON_MAXIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_MAXIMIZED.TabIndex = 2;
            this.ICON_MAXIMIZED.TabStop = false;
            this.ICON_MAXIMIZED.Click += new System.EventHandler(this.ICON_MAXIMIZED_Click);
            // 
            // ICON_CLOSE
            // 
            this.ICON_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_CLOSE.Image = global::MarketManager.Properties.Resources.close;
            this.ICON_CLOSE.Location = new System.Drawing.Point(1019, 6);
            this.ICON_CLOSE.Name = "ICON_CLOSE";
            this.ICON_CLOSE.Size = new System.Drawing.Size(20, 20);
            this.ICON_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_CLOSE.TabIndex = 178;
            this.ICON_CLOSE.TabStop = false;
            this.ICON_CLOSE.Click += new System.EventHandler(this.ICON_CLOSE_Click);
            // 
            // BTN_SLIDE
            // 
            this.BTN_SLIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SLIDE.Image = global::MarketManager.Properties.Resources.botao_de_menu_de_tres_linhas_horizontais;
            this.BTN_SLIDE.Location = new System.Drawing.Point(6, 8);
            this.BTN_SLIDE.Name = "BTN_SLIDE";
            this.BTN_SLIDE.Size = new System.Drawing.Size(35, 35);
            this.BTN_SLIDE.TabIndex = 90;
            this.BTN_SLIDE.TabStop = false;
            this.BTN_SLIDE.Click += new System.EventHandler(this.BTN_SLIDE_Click);
            // 
            // BTN_RELATORIO
            // 
            this.BTN_RELATORIO.FlatAppearance.BorderSize = 0;
            this.BTN_RELATORIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_RELATORIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RELATORIO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RELATORIO.ForeColor = System.Drawing.Color.White;
            this.BTN_RELATORIO.Image = global::MarketManager.Properties.Resources.graphic__1_;
            this.BTN_RELATORIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RELATORIO.Location = new System.Drawing.Point(0, 192);
            this.BTN_RELATORIO.Name = "BTN_RELATORIO";
            this.BTN_RELATORIO.Size = new System.Drawing.Size(250, 40);
            this.BTN_RELATORIO.TabIndex = 4;
            this.BTN_RELATORIO.Text = "Relatórios";
            this.BTN_RELATORIO.UseVisualStyleBackColor = true;
            this.BTN_RELATORIO.Click += new System.EventHandler(this.BTN_RELATORIO_Click);
            // 
            // BTN_HOME
            // 
            this.BTN_HOME.FlatAppearance.BorderSize = 0;
            this.BTN_HOME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HOME.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HOME.ForeColor = System.Drawing.Color.White;
            this.BTN_HOME.Image = global::MarketManager.Properties.Resources.pagina_inicial;
            this.BTN_HOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_HOME.Location = new System.Drawing.Point(0, 146);
            this.BTN_HOME.Name = "BTN_HOME";
            this.BTN_HOME.Size = new System.Drawing.Size(250, 40);
            this.BTN_HOME.TabIndex = 3;
            this.BTN_HOME.Text = "Home";
            this.BTN_HOME.UseVisualStyleBackColor = true;
            this.BTN_HOME.Click += new System.EventHandler(this.BTN_HOME_Click);
            // 
            // BTN_OUTROS
            // 
            this.BTN_OUTROS.FlatAppearance.BorderSize = 0;
            this.BTN_OUTROS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_OUTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OUTROS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OUTROS.ForeColor = System.Drawing.Color.White;
            this.BTN_OUTROS.Image = global::MarketManager.Properties.Resources.provider;
            this.BTN_OUTROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_OUTROS.Location = new System.Drawing.Point(0, 472);
            this.BTN_OUTROS.Name = "BTN_OUTROS";
            this.BTN_OUTROS.Size = new System.Drawing.Size(250, 40);
            this.BTN_OUTROS.TabIndex = 10;
            this.BTN_OUTROS.Text = "Outros";
            this.BTN_OUTROS.UseVisualStyleBackColor = true;
            this.BTN_OUTROS.Visible = false;
            // 
            // BTN_COMPRAS
            // 
            this.BTN_COMPRAS.FlatAppearance.BorderSize = 0;
            this.BTN_COMPRAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_COMPRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_COMPRAS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COMPRAS.ForeColor = System.Drawing.Color.White;
            this.BTN_COMPRAS.Image = global::MarketManager.Properties.Resources.cart;
            this.BTN_COMPRAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_COMPRAS.Location = new System.Drawing.Point(0, 426);
            this.BTN_COMPRAS.Name = "BTN_COMPRAS";
            this.BTN_COMPRAS.Size = new System.Drawing.Size(250, 40);
            this.BTN_COMPRAS.TabIndex = 9;
            this.BTN_COMPRAS.Text = "Compras";
            this.BTN_COMPRAS.UseVisualStyleBackColor = true;
            this.BTN_COMPRAS.Visible = false;
            this.BTN_COMPRAS.Click += new System.EventHandler(this.BTN_COMPRAS_Click);
            // 
            // BTN_CLIENTES
            // 
            this.BTN_CLIENTES.FlatAppearance.BorderSize = 0;
            this.BTN_CLIENTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_CLIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLIENTES.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLIENTES.ForeColor = System.Drawing.Color.White;
            this.BTN_CLIENTES.Image = global::MarketManager.Properties.Resources.customer;
            this.BTN_CLIENTES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLIENTES.Location = new System.Drawing.Point(0, 330);
            this.BTN_CLIENTES.Name = "BTN_CLIENTES";
            this.BTN_CLIENTES.Size = new System.Drawing.Size(250, 40);
            this.BTN_CLIENTES.TabIndex = 7;
            this.BTN_CLIENTES.Text = "Clientes";
            this.BTN_CLIENTES.UseVisualStyleBackColor = true;
            this.BTN_CLIENTES.Click += new System.EventHandler(this.BTN_CLIENTES_Click);
            // 
            // BTN_FORNECEDORES
            // 
            this.BTN_FORNECEDORES.FlatAppearance.BorderSize = 0;
            this.BTN_FORNECEDORES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_FORNECEDORES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FORNECEDORES.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FORNECEDORES.ForeColor = System.Drawing.Color.White;
            this.BTN_FORNECEDORES.Image = global::MarketManager.Properties.Resources.delivery_truck;
            this.BTN_FORNECEDORES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FORNECEDORES.Location = new System.Drawing.Point(0, 376);
            this.BTN_FORNECEDORES.Name = "BTN_FORNECEDORES";
            this.BTN_FORNECEDORES.Size = new System.Drawing.Size(250, 40);
            this.BTN_FORNECEDORES.TabIndex = 8;
            this.BTN_FORNECEDORES.Text = "Provedores";
            this.BTN_FORNECEDORES.UseVisualStyleBackColor = true;
            this.BTN_FORNECEDORES.Click += new System.EventHandler(this.BTN_FORNECEDORES_Click);
            // 
            // BTN_VENDAS
            // 
            this.BTN_VENDAS.FlatAppearance.BorderSize = 0;
            this.BTN_VENDAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_VENDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VENDAS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VENDAS.ForeColor = System.Drawing.Color.White;
            this.BTN_VENDAS.Image = global::MarketManager.Properties.Resources.shopping_bag__1_;
            this.BTN_VENDAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_VENDAS.Location = new System.Drawing.Point(0, 284);
            this.BTN_VENDAS.Name = "BTN_VENDAS";
            this.BTN_VENDAS.Size = new System.Drawing.Size(250, 40);
            this.BTN_VENDAS.TabIndex = 6;
            this.BTN_VENDAS.Text = "Vendas";
            this.BTN_VENDAS.UseVisualStyleBackColor = true;
            this.BTN_VENDAS.Click += new System.EventHandler(this.BTN_VENDAS_Click);
            // 
            // BTN_PRODUCTS
            // 
            this.BTN_PRODUCTS.FlatAppearance.BorderSize = 0;
            this.BTN_PRODUCTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_PRODUCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCTS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRODUCTS.ForeColor = System.Drawing.Color.White;
            this.BTN_PRODUCTS.Image = global::MarketManager.Properties.Resources.ecommerce__1_;
            this.BTN_PRODUCTS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRODUCTS.Location = new System.Drawing.Point(0, 238);
            this.BTN_PRODUCTS.Name = "BTN_PRODUCTS";
            this.BTN_PRODUCTS.Size = new System.Drawing.Size(250, 40);
            this.BTN_PRODUCTS.TabIndex = 5;
            this.BTN_PRODUCTS.TabStop = false;
            this.BTN_PRODUCTS.Text = "Produtos";
            this.BTN_PRODUCTS.UseVisualStyleBackColor = true;
            this.BTN_PRODUCTS.Click += new System.EventHandler(this.BTN_PRODUCTS_Click);
            // 
            // PICTURE_LOGO
            // 
            this.PICTURE_LOGO.Image = global::MarketManager.Properties.Resources.logo_market;
            this.PICTURE_LOGO.Location = new System.Drawing.Point(5, 5);
            this.PICTURE_LOGO.Name = "PICTURE_LOGO";
            this.PICTURE_LOGO.Size = new System.Drawing.Size(50, 50);
            this.PICTURE_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICTURE_LOGO.TabIndex = 80;
            this.PICTURE_LOGO.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 879;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PANEL_CONTENT);
            this.Controls.Add(this.MENU_SUPERIOR);
            this.Controls.Add(this.MENU_VERTICAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MENU_VERTICAL.ResumeLayout(false);
            this.MENU_SUPERIOR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MINIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_RESTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MAXIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_LOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MENU_VERTICAL;
        private System.Windows.Forms.Panel MENU_SUPERIOR;
        private System.Windows.Forms.PictureBox BTN_SLIDE;
        private System.Windows.Forms.Panel PANEL_CONTENT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PICTURE_LOGO;
        private System.Windows.Forms.PictureBox ICON_CLOSE;
        private System.Windows.Forms.PictureBox ICON_RESTORE;
        private System.Windows.Forms.PictureBox ICON_MAXIMIZED;
        private System.Windows.Forms.PictureBox ICON_MINIMIZED;
        private System.Windows.Forms.Button BTN_PRODUCTS;
        private System.Windows.Forms.Button BTN_OUTROS;
        private System.Windows.Forms.Button BTN_COMPRAS;
        private System.Windows.Forms.Button BTN_CLIENTES;
        private System.Windows.Forms.Button BTN_FORNECEDORES;
        private System.Windows.Forms.Button BTN_VENDAS;
        private System.Windows.Forms.Button BTN_HOME;
        private System.Windows.Forms.Button BTN_RELATORIO;
        private System.Windows.Forms.Label label1;
    }
}

