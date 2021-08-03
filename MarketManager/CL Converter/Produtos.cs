using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Runtime.InteropServices;
using System.IO;
using MarketManager.models;

namespace MarketManager
{
    public partial class Produtos : Form
    {

        String sku_value = "";
        String file_name = "";
        String Delete_Photo_Edit = "";
        String SV = "";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Produtos()
        {
            InitializeComponent();

            // RELOAD BRANDS
            RELOAD_BRAND_PRODUTOS();
            RELOAD_PROVEDOR_PRODUTOS();
            RELOAD_BRAND_PRODUTOS_EDIT();
            RELOAD_PROVEDOR_PRODUTOS_EDIT();

            // LOAD TBALE_PRODUTOS
            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
            try
            {
                CONFIG_TABLE_PRODUTOS();
            }
            catch
            {

            }
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");
        public void CONFIG_TABLE_PRODUTOS()
        {
            // Nome, SKU, QTD, Marca, V_Compra, V_Venda, Date
            TABLE_PRODUTOS.Columns[0].HeaderText = "SKU";
            TABLE_PRODUTOS.Columns[1].HeaderText = "Nome";
            TABLE_PRODUTOS.Columns[2].HeaderText = "Quantidade";
            TABLE_PRODUTOS.Columns[3].HeaderText = "Marca";
            TABLE_PRODUTOS.Columns[4].HeaderText = "Valor R$ (compra)";
            TABLE_PRODUTOS.Columns[5].HeaderText = "Valor R$ (venda)";
            TABLE_PRODUTOS.Columns[6].HeaderText = "Data Cadastro";
            TABLE_PRODUTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_PRODUTOS.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TABLE_PRODUTOS.Columns[4].DefaultCellStyle.Format = "C2";
            TABLE_PRODUTOS.Columns[5].DefaultCellStyle.Format = "C2";
        }

        private void LABEL_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
 
        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void BTN_ADICIONAR_Click_1(object sender, EventArgs e)
        {
            LABEL_TITTLE.Text = "Cadastrar Novo Produto";

            // HIDE
            PANEL_PRODUTOS.Hide();

            // SHOW
            PANEL_CONTROL.Show();
            LABEL_RETURN.Show();

            // ACTION
            LABEL_TITTLE.Location = new Point(370, 30);
        }

        private void LABEL_RETURN_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL.Hide();
            LABEL_RETURN.Hide();
            PANEL_EDIT_PRODUCT.Hide();

            // SHOW
            PANEL_PRODUTOS.Show();

            // CONTROL
            LABEL_TITTLE.Text = "Produtos";
            LABEL_TITTLE.Location = new Point(447, 30);

            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }
        private void TXT_QTD_PRODUTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TXT_QTD_PRODUTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CANCELAR_ADD_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL.Hide();
            LABEL_RETURN.Hide();

            // SHOW
            PANEL_PRODUTOS.Show();

            // CONTROL
            LABEL_TITTLE.Text = "Produtos";
            LABEL_TITTLE.Location = new Point(447, 30);

            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }

        private void BTN_NOVA_MARCA_Click(object sender, EventArgs e)
        {
            // SHOW
            panel_brand.Show();
        }

        private void BTN_SALVAR_ADD_Click(object sender, EventArgs e)
        {
            if (TXT_SKU_PRODUTO.Text != "" || TXT_NOME_PRODUTO.Text != "" || TXT_QTD_PRODUTO.Text != "")
            {
                con.Close();
                con.Open();
                SqlCeCommand VERY_PRODUCT = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM produto WHERE SKU = '" + TXT_SKU_PRODUTO.Text + "' ", con);
                SqlCeDataReader VP = VERY_PRODUCT.ExecuteReader();

                if (VP.Read())
                {
                    int VP_COUNT = Convert.ToInt32(VP["TOTAL"].ToString());

                    if (VP_COUNT < 1)
                    {

                        //FileInfo teste = new FileInfo();

                        string target_img = file_name;

                        Variables variables = new Variables();

                        variables.NOME_PRODUTO_ADD = TXT_NOME_PRODUTO.Text;
                        variables.SKU_PRODUTO_ADD = TXT_SKU_PRODUTO.Text;
                        variables.MARCA_PRODUTO_ADD = TXT_BRANDS_PRODUTOS.Text;
                        variables.QUANTIDADE_PRODUTO_ADD = TXT_QTD_PRODUTO.Text;
                        variables.VALOR_COMPRA_PRODUTO_ADD = TXT_VALOR_COMPRA.Text;
                        variables.VALOR_VENDA_PRODUTO_ADD = TXT_VALOR_VENDA.Text;
                        variables.IMAGEM_PRODUTO_ADD = target_img;
                        variables.DATE_PRODUTO_ADD = DateTime.Now.ToLongDateString();
                        variables.CODIGO_DE_BARRAS_ADD = TXT_CODIGO_DE_BARRAS.Text;
                        variables.PROVEDOR = TXT_PROVEDOR_PRODUTOS.Text;

                        if (ADD.NEW_PRODUCT(variables))
                        {
                            // HIDE
                            panel_brand.Hide();
                            PANEL_CONTROL.Hide();
                            PANEL_CONTROL.Hide();
                            LABEL_RETURN.Hide();

                            // SHOW
                            PANEL_PRODUTOS.Show();

                            LABEL_ERRO_NEW_BRAND.Visible = false;
                            LB_ERROR_PRODUCT.Visible = false;
                            LB_ERROR_PRODUCT_1.Visible = false;
                            LB_ERROR_PRODUCT_2.Visible = false;
                            LB_ERROR_PRODUCT_3.Visible = false;

                            // CONTROLS
                            TXT_BRANDS_PRODUTOS.ResetText();
                            TXT_NOME_PRODUTO.ResetText();
                            TXT_QTD_PRODUTO.ResetText();
                            TXT_SKU_PRODUTO.ResetText();
                            TXT_VALOR_COMPRA.ResetText();
                            TXT_VALOR_VENDA.ResetText();
                            TXT_CODIGO_DE_BARRAS.ResetText();

                            LABEL_TITTLE.Text = "Produtos";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto com SKU já cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Ops, tivemos um problema, verifique os dados preenchidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LB_ERROR_PRODUCT.Visible = true;
                LB_ERROR_PRODUCT_1.Visible = true;
                LB_ERROR_PRODUCT_2.Visible = true;
                LB_ERROR_PRODUCT_3.Visible = true;
            }
            con.Close();

            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }

        private void PIC_ADD_PHOTO_PRODUTO_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            try
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName;
                string result = Path.GetFileName(file_name);
                string targetPath = @"C:\Users\Lima\Desktop\MarketManager\MarketManager\CL Converter\Resources\" + result;
                try
                {
                    File.Copy(openFileDialog1.FileName, targetPath + file_name);
                }
                catch
                {

                }

                PIC_ADD_PHOTO_PRODUTO.Image = Image.FromFile(targetPath);
                PIC_ADD_PHOTO_PRODUTO.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

            }
        }

        private void btn_close_brand_Click(object sender, EventArgs e)
        {
            // HIDE
            panel_brand.Hide();
        }

        private void BTN_CANCELAR_NEW_BRAND_Click(object sender, EventArgs e)
        {
            // HIDE
            panel_brand.Hide();
        }

        private void BTN_SALVAR_NEW_BRAND_Click(object sender, EventArgs e)
        {
            Update();
            Refresh();
            if (TXT_NEW_BRAND.Text != "")
            {
                con.Close();
                con.Open();

                // VERIFICAR DE JA EXISTE MARCA
                SqlCeCommand SEARCH_EXIST = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM MARCAS WHERE Nome = '" + TXT_NEW_BRAND.Text + "' ", con);
                SqlCeDataReader SE = SEARCH_EXIST.ExecuteReader();

                if (SE.Read())
                {
                    int op = Convert.ToInt32(SE["TOTAL"].ToString());

                    if (op < 1)
                    {
                        string new_brand = TXT_NEW_BRAND.Text;

                        Variables variables = new Variables();

                        variables.NEW_BRAND = new_brand;
                        variables.DATE_BRAND = DateTime.Now.ToLongDateString();

                        if (ADD.NEW_BRAND(variables))
                        {
                            // HIDE
                            panel_brand.Hide();
                            LABEL_ERRO_NEW_BRAND.Visible = false;

                            // CONTROLS
                            TXT_NEW_BRAND.ResetText();
                            RELOAD_BRAND_PRODUTOS();
                            RELOAD_PROVEDOR_PRODUTOS();
                            //EXCLUIR_BRANDS_DUPLICADAS();
                        }
                        else
                        {
                            LABEL_ERRO_NEW_BRAND.Visible = true;
                            LABEL_ERRO_NEW_BRAND.Text = "Ops! Ocorreu um erro, tente novamente!";
                        }
                    }
                    else
                    {
                        LABEL_ERRO_NEW_BRAND.Visible = true;
                        LABEL_ERRO_NEW_BRAND.Text = "Marca já cadastrada!";
                    }
                }
                else
                {
                    LABEL_ERRO_NEW_BRAND.Visible = true;
                    LABEL_ERRO_NEW_BRAND.Text = "Ops! Ocorreu um erro, tente novamente!";
                }
            }
            else
            {
                LABEL_ERRO_NEW_BRAND.Visible = true;
                LABEL_ERRO_NEW_BRAND.Text = "Ops! Ocorreu um erro, tente novamente!";
            }

            TXT_NEW_BRAND.ResetText();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void RELOAD_PROVEDOR_PRODUTOS()
        {
            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_PROVEDORES = new SqlCeCommand("SELECT Nome FROM PROVEDORES", con);
            SqlCeDataReader RP = RELOAD_PROVEDORES.ExecuteReader();

            try
            {
                DataTable table = new DataTable();
                table.Load(RP);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_PROVEDOR_PRODUTOS.DataSource = table;
                this.TXT_PROVEDOR_PRODUTOS.ValueMember = "Nome";
                this.TXT_PROVEDOR_PRODUTOS.DisplayMember = "Nome";
                RP.Close();
                RP.Dispose();
            }
            catch
            {

            }
            TXT_PROVEDOR_PRODUTOS.Update();
            Update();
            Refresh();
            con.Close();
        }

        public void RELOAD_PROVEDOR_PRODUTOS_EDIT()
        {
            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_PROVEDORES = new SqlCeCommand("SELECT Nome FROM PROVEDORES", con);
            SqlCeDataReader RP = RELOAD_PROVEDORES.ExecuteReader();

            try
            {
                DataTable table = new DataTable();
                table.Load(RP);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_PROVEDOR_PRODUTOS_EDIT.DataSource = table;
                this.TXT_PROVEDOR_PRODUTOS_EDIT.ValueMember = "Nome";
                this.TXT_PROVEDOR_PRODUTOS_EDIT.DisplayMember = "Nome";
                RP.Close();
                RP.Dispose();
            }
            catch
            {

            }
            TXT_PROVEDOR_PRODUTOS_EDIT.Update();
            Update();
            Refresh();
            con.Close();
        }

        public void RELOAD_BRAND_PRODUTOS_EDIT()
        {
            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_BRANDS = new SqlCeCommand("SELECT Nome FROM MARCAS", con);
            SqlCeDataReader RLB = RELOAD_BRANDS.ExecuteReader();

            try
            {
                DataTable table = new DataTable();
                table.Load(RLB);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_BRANDS_PRODUTOS.DataSource = table;
                this.TXT_BRANDS_PRODUTOS_EDIT.ValueMember = "Nome";
                this.TXT_BRANDS_PRODUTOS_EDIT.DisplayMember = "Nome";
                RLB.Close();
                RLB.Dispose();
            }
            catch
            {

            }
            TXT_BRANDS_PRODUTOS_EDIT.Update();
            Update();
            Refresh();
            con.Close();
        }

        public void RELOAD_BRAND_PRODUTOS()
        {
            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_BRANDS = new SqlCeCommand("SELECT Nome FROM MARCAS", con);
            SqlCeDataReader RLB = RELOAD_BRANDS.ExecuteReader();

            try
            {       
                DataTable table = new DataTable();
                table.Load(RLB);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_BRANDS_PRODUTOS.DataSource = table;
                this.TXT_BRANDS_PRODUTOS.ValueMember = "Nome";
                this.TXT_BRANDS_PRODUTOS.DisplayMember = "Nome";
                RLB.Close();
                RLB.Dispose();
            }
            catch
            {

            }
            TXT_BRANDS_PRODUTOS.Update();
            Update();
            Refresh();
            con.Close();
        }

        private void TXT_BRANDS_PRODUTOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_NOME_PRODUTO_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable SEARCH_PRODUCTS()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT SKU, Nome, QTD, Marca, V_Compra, V_Venda, Date FROM produto ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        private void BTN_EXCLUIR_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TABLE_PRODUTOS.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_PRODUTOS.CurrentRow;

                sku_value = Convert.ToString((linhaAtual.Cells[0]).Value);

                con.Close();
                con.Open();
                SqlCeCommand SEARCH_PRODUCT_DELETE = new SqlCeCommand("SELECT * FROM produto WHERE SKU = '" + sku_value + "' ", con);
                SqlCeDataReader SPD = SEARCH_PRODUCT_DELETE.ExecuteReader();
                if (SPD.Read())
                {
                    if (MessageBox.Show("Deseja mesmo deletar o produto \n\n SKU: '" + SPD["SKU"].ToString() + "' \n Produto: '" + SPD["Nome"].ToString() + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCeCommand DELETE_PRODUCT = new SqlCeCommand("DELETE FROM produto WHERE SKU = '" + sku_value + "' ", con);
                        DELETE_PRODUCT.ExecuteReader();

                        MessageBox.Show("Produto deletado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
                    }
                    else
                    {

                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TABLE_PRODUTOS.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_PRODUTOS.CurrentRow;

                sku_value = Convert.ToString((linhaAtual.Cells[0]).Value);

                LABEL_TITTLE.Text = "Editar Produto";

                // HIDE
                PANEL_PRODUTOS.Hide();
                PANEL_CONTROL.Hide();

                // SHOW
                PANEL_EDIT_PRODUCT.Show();
                LABEL_RETURN.Show();

                // RELOAD BRANDS
                RELOAD_BRAND_PRODUTOS_EDIT();
                RELOAD_PROVEDOR_PRODUTOS_EDIT();
                // ACTION
                LABEL_TITTLE.Location = new Point(430, 30);
                SV = "";
                con.Close();
                con.Open();
                SqlCeCommand SEARCH_EDIT_PRODUCT = new SqlCeCommand("SELECT * FROM produto WHERE SKU = '" + sku_value + "' ", con);
                SqlCeDataReader SEP = SEARCH_EDIT_PRODUCT.ExecuteReader();

                if (SEP.Read())
                {
                    string targetPath = SEP["Img"].ToString();

                    TXT_NOME_PRODUTO_EDIT.Text = SEP["Nome"].ToString();
                    TXT_SKU_PRODUTO_EDIT.Text = SEP["SKU"].ToString();
                    TXT_BRANDS_PRODUTOS_EDIT.Text = SEP["Marca"].ToString();
                    TXT_QTD_PRODUTO_EDIT.Text = SEP["QTD"].ToString();
                    TXT_VALOR_COMPRA_EDIT.Text = SEP["V_Compra"].ToString();
                    TXT_VALOR_VENDA_EDIT.Text = SEP["V_Venda"].ToString();
                    TXT_CODIGOS_DE_BARRA_EDIT.Text = SEP["SN"].ToString();
                    TXT_PROVEDOR_PRODUTOS_EDIT.Text = SEP["Provedor"].ToString();
                    SV = SEP["SKU"].ToString();
                    try
                    {
                        PIC_ADD_PHOTO_PRODUTO_EDIT.Image = Image.FromFile(targetPath);
                        PIC_ADD_PHOTO_PRODUTO_EDIT.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {

                    }
                }
                else
                {

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_CANCEL_EDIT_PRODUCT_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL.Hide();
            LABEL_RETURN.Hide();
            PANEL_EDIT_PRODUCT.Hide();

            // SHOW
            PANEL_PRODUTOS.Show();

            // CONTROL
            LABEL_TITTLE.Text = "Produtos";
            LABEL_TITTLE.Location = new Point(447, 30);

            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }

        private void BTN_EDIT_PRODUCT_Click(object sender, EventArgs e)
        {
            if (TXT_SKU_PRODUTO.Text != null || TXT_NOME_PRODUTO.Text != null || TXT_QTD_PRODUTO.Text != null)
            {
                if (MessageBox.Show("Deseja mesmo editar este produto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string target_img = @"C:\Users\LIMA\Desktop\MarketManager\MarketManager\CL Converter\Resources\" + PIC_ADD_PHOTO_PRODUTO.ImageLocation;

                    Variables variables = new Variables();

                    variables.NOME_PRODUTO_ADD = TXT_NOME_PRODUTO_EDIT.Text;
                    variables.SKU_PRODUTO_ADD = TXT_SKU_PRODUTO_EDIT.Text;
                    variables.MARCA_PRODUTO_ADD = TXT_BRANDS_PRODUTOS_EDIT.Text;
                    variables.QUANTIDADE_PRODUTO_ADD = TXT_QTD_PRODUTO_EDIT.Text;
                    variables.VALOR_COMPRA_PRODUTO_ADD = Convert.ToDouble(TXT_VALOR_COMPRA_EDIT.Text).ToString("F");
                    variables.VALOR_VENDA_PRODUTO_ADD = Convert.ToDouble(TXT_VALOR_VENDA_EDIT.Text).ToString("F");
                    variables.IMAGEM_PRODUTO_ADD = target_img;
                    variables.DATE_PRODUTO_ADD = DateTime.Now.ToLongDateString();
                    variables.CODIGO_DE_BARRAS_ADD = TXT_CODIGOS_DE_BARRA_EDIT.Text;
                    variables.SKU_VERIFY = SV;
                    variables.PROVEDOR = TXT_PROVEDOR_PRODUTOS_EDIT.Text;

                    if (ADD.EDIT_PRODUCT(variables))
                    {
                        // HIDE
                        panel_brand.Hide();
                        PANEL_CONTROL.Hide();
                        PANEL_EDIT_PRODUCT.Hide();
                        LABEL_RETURN.Hide();

                        // SHOW
                        PANEL_PRODUTOS.Show();

                        LABEL_ERRO_NEW_BRAND.Visible = false;
                        LB_ERROR_PRODUCT.Visible = false;
                        LB_ERROR_PRODUCT_1.Visible = false;
                        LB_ERROR_PRODUCT_2.Visible = false;
                        LB_ERROR_PRODUCT_3.Visible = false;

                        // CONTROLS
                        TXT_BRANDS_PRODUTOS.ResetText();
                        TXT_NOME_PRODUTO.ResetText();
                        TXT_QTD_PRODUTO.ResetText();
                        TXT_SKU_PRODUTO.ResetText();
                        TXT_VALOR_COMPRA.ResetText();
                        TXT_VALOR_VENDA.ResetText();
                        TXT_CODIGOS_DE_BARRA_EDIT.ResetText();

                        LABEL_TITTLE.Text = "Produtos";
                        LABEL_TITTLE.Location = new Point(447, 30);

                        TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
                    }
                    
                    if(Delete_Photo_Edit == "true")
                    {
                        Variables variables_foto = new Variables();

                        variables_foto.IMAGEM_PRODUTO_ADD = "";

                        if (ADD.DELETE_FOTO(variables_foto))
                        {
                            PIC_ADD_PHOTO_PRODUTO_EDIT.Image = null;
                        }

                        Delete_Photo_Edit = "";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_NEW_BRAND_EDIT_Click_1(object sender, EventArgs e)
        {
            // SHOW
            PANEL_NEW_BRAND_EDIT.Visible = true;
        }

        private void BTN_CLOSE_BRAND_EDIT_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_NEW_BRAND_EDIT.Hide();
        }

        private void BTN_SALVAR_NEW_BRAND_EDIT_Click(object sender, EventArgs e)
        {
            Update();
            Refresh();
            if (TXT_NEW_BRAND_EDIT.Text != "")
            {
                con.Close();
                con.Open();

                // VERIFICAR DE JA EXISTE MARCA
                SqlCeCommand SEARCH_EXIST = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM MARCAS WHERE Nome = '" + TXT_NEW_BRAND.Text + "' ", con);
                SqlCeDataReader SE = SEARCH_EXIST.ExecuteReader();

                if (SE.Read())
                {
                    int op = Convert.ToInt32(SE["TOTAL"].ToString());

                    if (op < 1)
                    {
                        string new_brand = TXT_NEW_BRAND_EDIT.Text;

                        Variables variables = new Variables();

                        variables.NEW_BRAND = new_brand;
                        variables.DATE_BRAND = DateTime.Now.ToLongDateString();

                        if (ADD.NEW_BRAND(variables))
                        {
                            // HIDE
                            PANEL_NEW_BRAND_EDIT.Hide();
                            LABEL_ERRO_NEW_BRAND_EDIT.Visible = false;

                            // CONTROLS
                            TXT_NEW_BRAND_EDIT.ResetText();
                            RELOAD_BRAND_PRODUTOS_EDIT();
                            RELOAD_PROVEDOR_PRODUTOS_EDIT();
                        }
                        else
                        {
                            LABEL_ERRO_NEW_BRAND_EDIT.Visible = true;
                            LABEL_ERRO_NEW_BRAND_EDIT.Text = "Ops! Ocorreu um erro, tente novamente!";
                        }
                    }
                    else
                    {
                        LABEL_ERRO_NEW_BRAND_EDIT.Visible = true;
                        LABEL_ERRO_NEW_BRAND_EDIT.Text = "Marca já cadastrada!";
                    }
                }
                else
                {
                    LABEL_ERRO_NEW_BRAND_EDIT.Visible = true;
                    LABEL_ERRO_NEW_BRAND_EDIT.Text = "Ops! Ocorreu um erro, tente novamente!";
                }
            }
            else
            {
                LABEL_ERRO_NEW_BRAND_EDIT.Visible = true;
                LABEL_ERRO_NEW_BRAND_EDIT.Text = "Ops! Ocorreu um erro, tente novamente!";
            }

            TXT_NEW_BRAND_EDIT.ResetText();
            con.Close();
        }

        private void BTN_CANCELAR_NEW_BRAND_EDIT_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_NEW_BRAND_EDIT.Hide();
        }

        private void BTN_UPDATE_FOTO_EXIST_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            try
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName;
                string result = Path.GetFileName(file_name);
                string targetPath = @"C:\Users\Lima\Desktop\MarketManager\MarketManager\CL Converter\Resources\" + result;
                try
                {
                    File.Copy(openFileDialog1.FileName, targetPath + file_name);
                }
                catch
                {

                }
                PIC_ADD_PHOTO_PRODUTO.Image = null;
                PIC_ADD_PHOTO_PRODUTO.Image = Image.FromFile(targetPath);
                PIC_ADD_PHOTO_PRODUTO.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

            }

        }
        private void BTN_EXCLUIR_FOTO_Click(object sender, EventArgs e)
        {

            PIC_ADD_PHOTO_PRODUTO.Image = null;
            PIC_ADD_PHOTO_PRODUTO.ResetText();
            PIC_ADD_PHOTO_PRODUTO.Update();
            PIC_ADD_PHOTO_PRODUTO.Refresh();
        }

        private void BTN_UPDATE_FOTO_EXIST_EDIT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            try
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName;
                string result = Path.GetFileName(file_name);
                string targetPath = @"C:\Users\Lima\Desktop\MarketManager\MarketManager\CL Converter\Resources\" + result;
                try
                {
                    File.Copy(openFileDialog1.FileName, targetPath + file_name);
                }
                catch
                {

                }
                PIC_ADD_PHOTO_PRODUTO_EDIT.Image = null;
                PIC_ADD_PHOTO_PRODUTO_EDIT.Image = Image.FromFile(targetPath);
                PIC_ADD_PHOTO_PRODUTO_EDIT.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

            }
        }

        private void BTN_EXCLUIR_FOTO_EDIT_Click(object sender, EventArgs e)
        {
            Delete_Photo_Edit = "true";
            PIC_ADD_PHOTO_PRODUTO_EDIT.Image = null;
        }

        private void PIC_ADD_PHOTO_PRODUTO_EDIT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            try
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName;
                string result = Path.GetFileName(file_name);
                string targetPath = @"C:\Users\Lima\Desktop\MarketManager\MarketManager\CL Converter\Resources\" + result;
                try
                {
                    File.Copy(openFileDialog1.FileName, targetPath + file_name);
                }
                catch
                {

                }
                PIC_ADD_PHOTO_PRODUTO_EDIT.Image = Image.FromFile(targetPath);
                PIC_ADD_PHOTO_PRODUTO_EDIT.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

            }
        }

        private void PANEL_ADD_PRODUTO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public DataTable SEARCH_PRODUCTS_SEM_SN()
        {
            
            string SN = "";
            SqlCeDataAdapter SEARCH_PRODUCTS_SEM_SN = new SqlCeDataAdapter("SELECT SKU, Nome, QTD, Marca, V_Compra, V_Venda, Date FROM produto WHERE SN = '' ORDER By id DESC ", con);

            DataSet SP = new DataSet();

            SEARCH_PRODUCTS_SEM_SN.Fill(SP);

            return SP.Tables[0];
        }

        private void BTN_SEARCH_SEM_SN_Click(object sender, EventArgs e)
        {
            TABLE_PRODUTOS.Update();
            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS_SEM_SN();
        }

        private void BTN_TODOS_PRODUTOS_Click(object sender, EventArgs e)
        {
            TABLE_PRODUTOS.Update();
            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }

        private void BTN_RESET_TABLE_PRODUTO_Click(object sender, EventArgs e)
        {
            TXT_SEARCH_PRODUT_NAME.ResetText();
            TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
        }

        public DataTable SEARCH_PRODUCTS_TXT()
        {
            string product = "%" + TXT_SEARCH_PRODUT_NAME.Text + "%";
            
            SqlCeDataAdapter SEARCH_PRODUCTS_SEM_SN = new SqlCeDataAdapter("SELECT SKU, Nome, QTD, Marca, V_Compra, V_Venda, Date " +
                "FROM produto " +
                "WHERE " +
                "Nome LIKE '" + product + "' OR " +
                "SKU LIKE '" + product + "' OR " + 
                "MARCA LIKE '" + product + "' ORDER By id DESC ", con);

            DataSet SP = new DataSet();

            SEARCH_PRODUCTS_SEM_SN.Fill(SP);

            return SP.Tables[0];
        }

        private void TXT_SEARCH_PRODUT_NAME_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXT_SEARCH_PRODUT_NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS_TXT();
            }
            else if(e.KeyChar == (char)27)
            {
                BTN_RESET_TABLE_PRODUTO.PerformClick();
                TABLE_PRODUTOS.DataSource = SEARCH_PRODUCTS();
            }
        }
    }
}
