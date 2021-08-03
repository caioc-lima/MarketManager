
namespace MarketManager
{
    partial class COMPRAS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PANEL_ADD_PRODUTO = new System.Windows.Forms.Panel();
            this.LABEL_TITTLE = new System.Windows.Forms.Label();
            this.LABEL_CLOSE = new System.Windows.Forms.Label();
            this.PANEL_PRODUTOS = new System.Windows.Forms.Panel();
            this.TXT_SEARCH_PRODUT_COMPRAS = new System.Windows.Forms.TextBox();
            this.BTN_EXCLUIR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_ADICIONAR = new System.Windows.Forms.Button();
            this.TABLE_PRODUTOS = new System.Windows.Forms.DataGridView();
            this.BTN_RESET_TABLE_COMPRAS = new System.Windows.Forms.Button();
            this.PANEL_ADD_PRODUTO.SuspendLayout();
            this.PANEL_PRODUTOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_PRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_ADD_PRODUTO
            // 
            this.PANEL_ADD_PRODUTO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_ADD_PRODUTO.Controls.Add(this.LABEL_TITTLE);
            this.PANEL_ADD_PRODUTO.Controls.Add(this.LABEL_CLOSE);
            this.PANEL_ADD_PRODUTO.Controls.Add(this.PANEL_PRODUTOS);
            this.PANEL_ADD_PRODUTO.Location = new System.Drawing.Point(0, 0);
            this.PANEL_ADD_PRODUTO.Name = "PANEL_ADD_PRODUTO";
            this.PANEL_ADD_PRODUTO.Size = new System.Drawing.Size(1039, 592);
            this.PANEL_ADD_PRODUTO.TabIndex = 5;
            // 
            // LABEL_TITTLE
            // 
            this.LABEL_TITTLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LABEL_TITTLE.AutoSize = true;
            this.LABEL_TITTLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITTLE.Location = new System.Drawing.Point(477, 9);
            this.LABEL_TITTLE.Name = "LABEL_TITTLE";
            this.LABEL_TITTLE.Size = new System.Drawing.Size(124, 31);
            this.LABEL_TITTLE.TabIndex = 8;
            this.LABEL_TITTLE.Text = "Compras";
            // 
            // LABEL_CLOSE
            // 
            this.LABEL_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_CLOSE.AutoSize = true;
            this.LABEL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LABEL_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CLOSE.Location = new System.Drawing.Point(1016, 7);
            this.LABEL_CLOSE.Name = "LABEL_CLOSE";
            this.LABEL_CLOSE.Size = new System.Drawing.Size(16, 16);
            this.LABEL_CLOSE.TabIndex = 3;
            this.LABEL_CLOSE.Text = "X";
            // 
            // PANEL_PRODUTOS
            // 
            this.PANEL_PRODUTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_RESET_TABLE_COMPRAS);
            this.PANEL_PRODUTOS.Controls.Add(this.TXT_SEARCH_PRODUT_COMPRAS);
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_EXCLUIR);
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_EDITAR);
            this.PANEL_PRODUTOS.Controls.Add(this.BTN_ADICIONAR);
            this.PANEL_PRODUTOS.Controls.Add(this.TABLE_PRODUTOS);
            this.PANEL_PRODUTOS.Location = new System.Drawing.Point(0, 74);
            this.PANEL_PRODUTOS.Name = "PANEL_PRODUTOS";
            this.PANEL_PRODUTOS.Size = new System.Drawing.Size(1027, 497);
            this.PANEL_PRODUTOS.TabIndex = 14;
            // 
            // TXT_SEARCH_PRODUT_COMPRAS
            // 
            this.TXT_SEARCH_PRODUT_COMPRAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SEARCH_PRODUT_COMPRAS.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH_PRODUT_COMPRAS.Location = new System.Drawing.Point(12, 10);
            this.TXT_SEARCH_PRODUT_COMPRAS.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_SEARCH_PRODUT_COMPRAS.Name = "TXT_SEARCH_PRODUT_COMPRAS";
            this.TXT_SEARCH_PRODUT_COMPRAS.Size = new System.Drawing.Size(365, 25);
            this.TXT_SEARCH_PRODUT_COMPRAS.TabIndex = 19;
            // 
            // BTN_EXCLUIR
            // 
            this.BTN_EXCLUIR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_EXCLUIR.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_EXCLUIR.FlatAppearance.BorderSize = 0;
            this.BTN_EXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXCLUIR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXCLUIR.ForeColor = System.Drawing.Color.White;
            this.BTN_EXCLUIR.Location = new System.Drawing.Point(452, 420);
            this.BTN_EXCLUIR.Name = "BTN_EXCLUIR";
            this.BTN_EXCLUIR.Size = new System.Drawing.Size(134, 35);
            this.BTN_EXCLUIR.TabIndex = 16;
            this.BTN_EXCLUIR.Text = "Excluir";
            this.BTN_EXCLUIR.UseVisualStyleBackColor = false;
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_EDITAR.BackColor = System.Drawing.Color.Goldenrod;
            this.BTN_EDITAR.FlatAppearance.BorderSize = 0;
            this.BTN_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDITAR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDITAR.ForeColor = System.Drawing.Color.White;
            this.BTN_EDITAR.Location = new System.Drawing.Point(605, 420);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(134, 35);
            this.BTN_EDITAR.TabIndex = 15;
            this.BTN_EDITAR.Text = "Editar";
            this.BTN_EDITAR.UseVisualStyleBackColor = false;
            // 
            // BTN_ADICIONAR
            // 
            this.BTN_ADICIONAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_ADICIONAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_ADICIONAR.FlatAppearance.BorderSize = 0;
            this.BTN_ADICIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADICIONAR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADICIONAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ADICIONAR.Location = new System.Drawing.Point(297, 420);
            this.BTN_ADICIONAR.Name = "BTN_ADICIONAR";
            this.BTN_ADICIONAR.Size = new System.Drawing.Size(134, 35);
            this.BTN_ADICIONAR.TabIndex = 14;
            this.BTN_ADICIONAR.Text = "Adicionar";
            this.BTN_ADICIONAR.UseVisualStyleBackColor = false;
            // 
            // TABLE_PRODUTOS
            // 
            this.TABLE_PRODUTOS.AllowUserToAddRows = false;
            this.TABLE_PRODUTOS.AllowUserToDeleteRows = false;
            this.TABLE_PRODUTOS.AllowUserToResizeColumns = false;
            this.TABLE_PRODUTOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.TABLE_PRODUTOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TABLE_PRODUTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_PRODUTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLE_PRODUTOS.BackgroundColor = System.Drawing.Color.White;
            this.TABLE_PRODUTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TABLE_PRODUTOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TABLE_PRODUTOS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TABLE_PRODUTOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLE_PRODUTOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TABLE_PRODUTOS.ColumnHeadersHeight = 35;
            this.TABLE_PRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TABLE_PRODUTOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TABLE_PRODUTOS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TABLE_PRODUTOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TABLE_PRODUTOS.Location = new System.Drawing.Point(12, 46);
            this.TABLE_PRODUTOS.MultiSelect = false;
            this.TABLE_PRODUTOS.Name = "TABLE_PRODUTOS";
            this.TABLE_PRODUTOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLE_PRODUTOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TABLE_PRODUTOS.RowHeadersVisible = false;
            this.TABLE_PRODUTOS.RowHeadersWidth = 120;
            this.TABLE_PRODUTOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TABLE_PRODUTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_PRODUTOS.ShowCellErrors = false;
            this.TABLE_PRODUTOS.ShowCellToolTips = false;
            this.TABLE_PRODUTOS.ShowEditingIcon = false;
            this.TABLE_PRODUTOS.ShowRowErrors = false;
            this.TABLE_PRODUTOS.Size = new System.Drawing.Size(1005, 358);
            this.TABLE_PRODUTOS.TabIndex = 13;
            // 
            // BTN_RESET_TABLE_COMPRAS
            // 
            this.BTN_RESET_TABLE_COMPRAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_RESET_TABLE_COMPRAS.FlatAppearance.BorderSize = 0;
            this.BTN_RESET_TABLE_COMPRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESET_TABLE_COMPRAS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET_TABLE_COMPRAS.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET_TABLE_COMPRAS.Image = global::MarketManager.Properties.Resources.clear;
            this.BTN_RESET_TABLE_COMPRAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RESET_TABLE_COMPRAS.Location = new System.Drawing.Point(386, 8);
            this.BTN_RESET_TABLE_COMPRAS.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RESET_TABLE_COMPRAS.Name = "BTN_RESET_TABLE_COMPRAS";
            this.BTN_RESET_TABLE_COMPRAS.Size = new System.Drawing.Size(90, 28);
            this.BTN_RESET_TABLE_COMPRAS.TabIndex = 20;
            this.BTN_RESET_TABLE_COMPRAS.Text = "LIMPAR";
            this.BTN_RESET_TABLE_COMPRAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_RESET_TABLE_COMPRAS.UseVisualStyleBackColor = false;
            // 
            // COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 592);
            this.Controls.Add(this.PANEL_ADD_PRODUTO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COMPRAS";
            this.Text = "COMPRAS";
            this.PANEL_ADD_PRODUTO.ResumeLayout(false);
            this.PANEL_ADD_PRODUTO.PerformLayout();
            this.PANEL_PRODUTOS.ResumeLayout(false);
            this.PANEL_PRODUTOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_PRODUTOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_ADD_PRODUTO;
        private System.Windows.Forms.Label LABEL_TITTLE;
        private System.Windows.Forms.Label LABEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_PRODUTOS;
        private System.Windows.Forms.Button BTN_RESET_TABLE_COMPRAS;
        private System.Windows.Forms.TextBox TXT_SEARCH_PRODUT_COMPRAS;
        private System.Windows.Forms.Button BTN_EXCLUIR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_ADICIONAR;
        private System.Windows.Forms.DataGridView TABLE_PRODUTOS;
    }
}