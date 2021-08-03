
namespace MarketManager
{
    partial class VENDAS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PANEL_ADD_VENDA = new System.Windows.Forms.Panel();
            this.LABEL_TITTLE = new System.Windows.Forms.Label();
            this.LABEL_CLOSE = new System.Windows.Forms.Label();
            this.PANEL_PRODUTOS = new System.Windows.Forms.Panel();
            this.TXT_SEARCH_VENDAS = new System.Windows.Forms.TextBox();
            this.TABLE_VENDAS = new System.Windows.Forms.DataGridView();
            this.BTN_RESET_TABLE_VENDAS = new System.Windows.Forms.Button();
            this.BTN_TODAS_VENDAS = new System.Windows.Forms.Button();
            this.BTN_SEARCH_FIDELIDADE = new System.Windows.Forms.Button();
            this.PANEL_ADD_VENDA.SuspendLayout();
            this.PANEL_PRODUTOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_VENDAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_ADD_VENDA
            // 
            this.PANEL_ADD_VENDA.Controls.Add(this.PANEL_PRODUTOS);
            this.PANEL_ADD_VENDA.Controls.Add(this.LABEL_CLOSE);
            this.PANEL_ADD_VENDA.Controls.Add(this.LABEL_TITTLE);
            this.PANEL_ADD_VENDA.Location = new System.Drawing.Point(0, 0);
            this.PANEL_ADD_VENDA.Name = "PANEL_ADD_VENDA";
            this.PANEL_ADD_VENDA.Size = new System.Drawing.Size(1385, 729);
            this.PANEL_ADD_VENDA.TabIndex = 0;
            // 
            // LABEL_TITTLE
            // 
            this.LABEL_TITTLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LABEL_TITTLE.AutoSize = true;
            this.LABEL_TITTLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITTLE.Location = new System.Drawing.Point(636, 11);
            this.LABEL_TITTLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_TITTLE.Name = "LABEL_TITTLE";
            this.LABEL_TITTLE.Size = new System.Drawing.Size(133, 39);
            this.LABEL_TITTLE.TabIndex = 9;
            this.LABEL_TITTLE.Text = "Vendas";
            // 
            // LABEL_CLOSE
            // 
            this.LABEL_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_CLOSE.AutoSize = true;
            this.LABEL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LABEL_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CLOSE.Location = new System.Drawing.Point(1355, 9);
            this.LABEL_CLOSE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_CLOSE.Name = "LABEL_CLOSE";
            this.LABEL_CLOSE.Size = new System.Drawing.Size(20, 20);
            this.LABEL_CLOSE.TabIndex = 10;
            this.LABEL_CLOSE.Text = "X";
            // 
            // PANEL_PRODUTOS
            // 
            this.PANEL_PRODUTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_RESET_TABLE_VENDAS);
            this.PANEL_PRODUTOS.Controls.Add(this.TXT_SEARCH_VENDAS);
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_TODAS_VENDAS);
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_SEARCH_FIDELIDADE);
            this.PANEL_PRODUTOS.Controls.Add(this.TABLE_VENDAS);
            this.PANEL_PRODUTOS.Location = new System.Drawing.Point(0, 114);
            this.PANEL_PRODUTOS.Margin = new System.Windows.Forms.Padding(4);
            this.PANEL_PRODUTOS.Name = "PANEL_PRODUTOS";
            this.PANEL_PRODUTOS.Size = new System.Drawing.Size(1385, 612);
            this.PANEL_PRODUTOS.TabIndex = 15;
            // 
            // TXT_SEARCH_VENDAS
            // 
            this.TXT_SEARCH_VENDAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SEARCH_VENDAS.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH_VENDAS.Location = new System.Drawing.Point(16, 12);
            this.TXT_SEARCH_VENDAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_SEARCH_VENDAS.Name = "TXT_SEARCH_VENDAS";
            this.TXT_SEARCH_VENDAS.Size = new System.Drawing.Size(486, 30);
            this.TXT_SEARCH_VENDAS.TabIndex = 19;
            this.TXT_SEARCH_VENDAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_SEARCH_VENDAS_KeyPress);
            // 
            // TABLE_VENDAS
            // 
            this.TABLE_VENDAS.AllowUserToAddRows = false;
            this.TABLE_VENDAS.AllowUserToDeleteRows = false;
            this.TABLE_VENDAS.AllowUserToResizeColumns = false;
            this.TABLE_VENDAS.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.TABLE_VENDAS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.TABLE_VENDAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_VENDAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLE_VENDAS.BackgroundColor = System.Drawing.Color.White;
            this.TABLE_VENDAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TABLE_VENDAS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TABLE_VENDAS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TABLE_VENDAS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLE_VENDAS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TABLE_VENDAS.ColumnHeadersHeight = 35;
            this.TABLE_VENDAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TABLE_VENDAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TABLE_VENDAS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TABLE_VENDAS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TABLE_VENDAS.Location = new System.Drawing.Point(16, 57);
            this.TABLE_VENDAS.Margin = new System.Windows.Forms.Padding(4);
            this.TABLE_VENDAS.MultiSelect = false;
            this.TABLE_VENDAS.Name = "TABLE_VENDAS";
            this.TABLE_VENDAS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLE_VENDAS.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.TABLE_VENDAS.RowHeadersVisible = false;
            this.TABLE_VENDAS.RowHeadersWidth = 120;
            this.TABLE_VENDAS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TABLE_VENDAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_VENDAS.ShowCellErrors = false;
            this.TABLE_VENDAS.ShowCellToolTips = false;
            this.TABLE_VENDAS.ShowEditingIcon = false;
            this.TABLE_VENDAS.ShowRowErrors = false;
            this.TABLE_VENDAS.Size = new System.Drawing.Size(1356, 532);
            this.TABLE_VENDAS.TabIndex = 13;
            // 
            // BTN_RESET_TABLE_VENDAS
            // 
            this.BTN_RESET_TABLE_VENDAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_RESET_TABLE_VENDAS.FlatAppearance.BorderSize = 0;
            this.BTN_RESET_TABLE_VENDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESET_TABLE_VENDAS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET_TABLE_VENDAS.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET_TABLE_VENDAS.Image = global::MarketManager.Properties.Resources.clear;
            this.BTN_RESET_TABLE_VENDAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RESET_TABLE_VENDAS.Location = new System.Drawing.Point(515, 10);
            this.BTN_RESET_TABLE_VENDAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_RESET_TABLE_VENDAS.Name = "BTN_RESET_TABLE_VENDAS";
            this.BTN_RESET_TABLE_VENDAS.Size = new System.Drawing.Size(120, 34);
            this.BTN_RESET_TABLE_VENDAS.TabIndex = 20;
            this.BTN_RESET_TABLE_VENDAS.Text = "LIMPAR";
            this.BTN_RESET_TABLE_VENDAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_RESET_TABLE_VENDAS.UseVisualStyleBackColor = false;
            this.BTN_RESET_TABLE_VENDAS.Click += new System.EventHandler(this.BTN_RESET_TABLE_VENDAS_Click);
            // 
            // BTN_TODAS_VENDAS
            // 
            this.BTN_TODAS_VENDAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_TODAS_VENDAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_TODAS_VENDAS.FlatAppearance.BorderSize = 0;
            this.BTN_TODAS_VENDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TODAS_VENDAS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TODAS_VENDAS.ForeColor = System.Drawing.Color.White;
            this.BTN_TODAS_VENDAS.Image = global::MarketManager.Properties.Resources.cubes;
            this.BTN_TODAS_VENDAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_TODAS_VENDAS.Location = new System.Drawing.Point(1070, 12);
            this.BTN_TODAS_VENDAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_TODAS_VENDAS.Name = "BTN_TODAS_VENDAS";
            this.BTN_TODAS_VENDAS.Size = new System.Drawing.Size(113, 34);
            this.BTN_TODAS_VENDAS.TabIndex = 18;
            this.BTN_TODAS_VENDAS.Text = "TODAS";
            this.BTN_TODAS_VENDAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_TODAS_VENDAS.UseVisualStyleBackColor = false;
            this.BTN_TODAS_VENDAS.Click += new System.EventHandler(this.BTN_TODAS_VENDAS_Click);
            // 
            // BTN_SEARCH_FIDELIDADE
            // 
            this.BTN_SEARCH_FIDELIDADE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SEARCH_FIDELIDADE.BackColor = System.Drawing.Color.Goldenrod;
            this.BTN_SEARCH_FIDELIDADE.FlatAppearance.BorderSize = 0;
            this.BTN_SEARCH_FIDELIDADE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_FIDELIDADE.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH_FIDELIDADE.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH_FIDELIDADE.Image = global::MarketManager.Properties.Resources.fidelidade;
            this.BTN_SEARCH_FIDELIDADE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH_FIDELIDADE.Location = new System.Drawing.Point(1213, 12);
            this.BTN_SEARCH_FIDELIDADE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SEARCH_FIDELIDADE.Name = "BTN_SEARCH_FIDELIDADE";
            this.BTN_SEARCH_FIDELIDADE.Size = new System.Drawing.Size(159, 34);
            this.BTN_SEARCH_FIDELIDADE.TabIndex = 17;
            this.BTN_SEARCH_FIDELIDADE.Text = "FIDELIDADE";
            this.BTN_SEARCH_FIDELIDADE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH_FIDELIDADE.UseVisualStyleBackColor = false;
            this.BTN_SEARCH_FIDELIDADE.Click += new System.EventHandler(this.BTN_SEARCH_FIDELIDADE_Click);
            // 
            // VENDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 729);
            this.Controls.Add(this.PANEL_ADD_VENDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VENDAS";
            this.Text = "VENDAS";
            this.PANEL_ADD_VENDA.ResumeLayout(false);
            this.PANEL_ADD_VENDA.PerformLayout();
            this.PANEL_PRODUTOS.ResumeLayout(false);
            this.PANEL_PRODUTOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_VENDAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_ADD_VENDA;
        private System.Windows.Forms.Label LABEL_TITTLE;
        private System.Windows.Forms.Label LABEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_PRODUTOS;
        private System.Windows.Forms.Button BTN_RESET_TABLE_VENDAS;
        private System.Windows.Forms.TextBox TXT_SEARCH_VENDAS;
        private System.Windows.Forms.Button BTN_TODAS_VENDAS;
        private System.Windows.Forms.Button BTN_SEARCH_FIDELIDADE;
        private System.Windows.Forms.DataGridView TABLE_VENDAS;
    }
}