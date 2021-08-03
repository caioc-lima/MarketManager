using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManager.models;

namespace MarketManager
{
    public partial class HOME : Form
    {
        String SN = "";
        String sku_value = "";
        int FIDELIDADE;

        // Tipo de Venda 0 = Venda Normal
        // Tipo de Venda 1 = Cliente Fidelidade

        public HOME()
        {
            InitializeComponent();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");
        public void CONFIG_TABLE_NEW_VENDA()
        {
            TABLE_NEW_VENDA.Columns[0].HeaderText = "SKU";
            TABLE_NEW_VENDA.Columns[1].HeaderText = "Nome";
            TABLE_NEW_VENDA.Columns[2].HeaderText = "Marca";
            TABLE_NEW_VENDA.Columns[3].HeaderText = "Valor R$ (compra)";

            TABLE_NEW_VENDA.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void BTN_NEW_COMPRA_Click(object sender, EventArgs e)
        {
            // SHOW
            TXT_PRODUCT_VENDA.Visible = true;
            TABLE_NEW_VENDA.Visible = true;
            LABEL_QTD_ITENS.Visible = true;
            LABEL_VALOR_TOTAL.Visible = true;
            BTN_CANCELAR_COMPRA.Visible = true;
            BTN_EXCLUIR_ITEM.Visible = true;
            BTN_FINALIZAR_COMPRA.Visible = true;
            LABEL_VALOR_TOTAL_RESULT.Visible = true;

            // HIDE
            BTN_NEW_COMPRA.Visible = false;
        }

        private void TXT_PRODUCT_VENDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SN = TXT_PRODUCT_VENDA.Text;

                con.Open();
                SqlCeCommand search_product = new SqlCeCommand("SELECT * FROM produto WHERE SN = '" + SN + "'", con);
                SqlCeDataReader SP = search_product.ExecuteReader();
                if (SP.Read())
                {
                    TABLE_NEW_VENDA.Rows.Add(new object[] { SP["SKU"], SP["Nome"], SP["V_Venda"] });
                    TABLE_NEW_VENDA.Columns[2].DefaultCellStyle.Format = "C2";
                }

                con.Close();

                LABEL_QTD_ITENS.Text = "Quantidade de itens:   " + TABLE_NEW_VENDA.RowCount.ToString();
                LABEL_VALOR_TOTAL.Text = "Valor Total (R$): ";
                LABEL_VALOR_TOTAL_RESULT.Text = "R$ " + TABLE_NEW_VENDA.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[2].Value)).ToString("N2");
                TXT_PRODUCT_VENDA.ResetText();
            }
        }

        private void TXT_PRODUCT_VENDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_EXCLUIR_ITEM_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TABLE_NEW_VENDA.RowCount.ToString()) >= 1)
            {
                if (TABLE_NEW_VENDA.SelectedRows.Count > 0)
                {
                    DataGridViewRow linhaAtual = TABLE_NEW_VENDA.CurrentRow;

                    TABLE_NEW_VENDA.Rows.Remove(linhaAtual);
                    TABLE_NEW_VENDA.Refresh();
                    TABLE_NEW_VENDA.Update();

                    LABEL_QTD_ITENS.Text = "Quantidade de itens:   " + TABLE_NEW_VENDA.RowCount.ToString();
                    LABEL_VALOR_TOTAL_RESULT.Text = "R$ " + TABLE_NEW_VENDA.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[2].Value)).ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BTN_CANCELAR_COMPRA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LABEL_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_FINALIZAR_COMPRA_Click(object sender, EventArgs e)
        {
            // SHOW
            PANEL_FINALIZAR_COMPRA.Visible = true;
        }

        private void PANEL_FINALIZAR_COMPRA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_PERGUNTA_SIM_Click(object sender, EventArgs e)
        {
            // HIDE
            LABEL_CLIENTE_PERGUNTA.Visible = false;
            BTN_PERGUNTA_SIM.Visible = false;
            BTN_PERGUNTA_NAO.Visible = false;

            // SHOW
            LABEL_N_ITENS.Visible = true;
            LABEL_N_ITENS_RESULT.Visible = true;
            LABEL_T_PAGAR.Visible = true;
            LABEL_T_PAGAR_RESULT.Visible = true;
            LABEL_SELEC_FIDELIDADE.Visible = true;
            TXT_SELECT_FIDELIDADE.Visible = true;
            LABEL_DESCONTO.Visible = true;
            TXT_DESCONTO.Visible = true;
            LABEL_PORCENTAGEM.Visible = true;
            BTN_FINALIZAR_COMPRA_GERAL.Visible = true;
            LABEL_RETURN_COMPRA.Visible = true;

            // CONTROL
            FIDELIDADE = 0;

            // ACTION
            LABEL_N_ITENS_RESULT.Text = TABLE_NEW_VENDA.RowCount.ToString();
            LABEL_T_PAGAR_RESULT.Text = "R$ " + TABLE_NEW_VENDA.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[2].Value)).ToString("N2");

            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_BRANDS = new SqlCeCommand("SELECT Nome FROM CLIENT", con);
            SqlCeDataReader RLB = RELOAD_BRANDS.ExecuteReader();

            try
            {
                DataTable table = new DataTable();
                table.Load(RLB);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_SELECT_FIDELIDADE.DataSource = table;
                this.TXT_SELECT_FIDELIDADE.ValueMember = "Nome";
                this.TXT_SELECT_FIDELIDADE.DisplayMember = "Nome";
                RLB.Close();
                RLB.Dispose();
            }
            catch
            {

            }
            TXT_SELECT_FIDELIDADE.Update();
            Update();
            Refresh();
            con.Close(); 
        }

        private void LABEL_CLOSE_FINALIZAR_COMPRA_Click(object sender, EventArgs e)
        {
            // HIDE
            LABEL_N_ITENS.Visible = false;
            LABEL_N_ITENS_RESULT.Visible = false;
            LABEL_T_PAGAR.Visible = false;
            LABEL_T_PAGAR_RESULT.Visible = false;
            LABEL_SELEC_FIDELIDADE.Visible = false;
            TXT_SELECT_FIDELIDADE.Visible = false;
            LABEL_DESCONTO.Visible = false;
            TXT_DESCONTO.Visible = false;
            LABEL_PORCENTAGEM.Visible = false;
            BTN_FINALIZAR_COMPRA_GERAL.Visible = false;
            LABEL_RETURN_COMPRA.Visible = false;

            // SHOW
            LABEL_CLIENTE_PERGUNTA.Visible = true;
            BTN_PERGUNTA_SIM.Visible = true;
            BTN_PERGUNTA_NAO.Visible = true;

            // ACTION
            LABEL_N_ITENS_RESULT.ResetText();
            LABEL_T_PAGAR_RESULT.ResetText();
            TXT_DESCONTO.ResetText();

            PANEL_FINALIZAR_COMPRA.Visible = false;
        }

        private void LABEL_RETURN_COMPRA_Click(object sender, EventArgs e)
        {
            // HIDE
            LABEL_N_ITENS.Visible = false;
            LABEL_N_ITENS_RESULT.Visible = false;
            LABEL_T_PAGAR.Visible = false;
            LABEL_T_PAGAR_RESULT.Visible = false;
            LABEL_SELEC_FIDELIDADE.Visible = false;
            TXT_SELECT_FIDELIDADE.Visible = false;
            LABEL_DESCONTO.Visible = false;
            TXT_DESCONTO.Visible = false;
            LABEL_PORCENTAGEM.Visible = false;
            BTN_FINALIZAR_COMPRA_GERAL.Visible = false;
            LABEL_RETURN_COMPRA.Visible = false;

            // SHOW
            LABEL_CLIENTE_PERGUNTA.Visible = true;
            BTN_PERGUNTA_SIM.Visible = true;
            BTN_PERGUNTA_NAO.Visible = true;

            // ACTION
            LABEL_N_ITENS_RESULT.ResetText();
            LABEL_T_PAGAR_RESULT.ResetText();
            TXT_DESCONTO.ResetText();
        }

        private void BTN_PERGUNTA_NAO_Click(object sender, EventArgs e)
        {
            // HIDE
            LABEL_CLIENTE_PERGUNTA.Visible = false;
            BTN_PERGUNTA_SIM.Visible = false;
            BTN_PERGUNTA_NAO.Visible = false;

            // SHOW
            LABEL_N_ITENS.Visible = true;
            LABEL_N_ITENS_RESULT.Visible = true;
            LABEL_T_PAGAR.Visible = true;
            LABEL_T_PAGAR_RESULT.Visible = true;            
            BTN_FINALIZAR_COMPRA_GERAL.Visible = true;
            LABEL_RETURN_COMPRA.Visible = true;

            // CONTROL
            FIDELIDADE = 1;

            // ACTION
            LABEL_N_ITENS_RESULT.Text = TABLE_NEW_VENDA.RowCount.ToString();
            LABEL_T_PAGAR_RESULT.Text = "R$ " + TABLE_NEW_VENDA.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[2].Value)).ToString("N2");

            con.Close();
            con.Open();
            Update();
            Refresh();
            SqlCeCommand RELOAD_BRANDS = new SqlCeCommand("SELECT Nome FROM CLIENT", con);
            SqlCeDataReader RLB = RELOAD_BRANDS.ExecuteReader();

            try
            {
                DataTable table = new DataTable();
                table.Load(RLB);
                DataRow row = table.NewRow();
                row["Nome"] = "Selecionar...";
                table.Rows.InsertAt(row, 0);
                this.TXT_SELECT_FIDELIDADE.DataSource = table;
                this.TXT_SELECT_FIDELIDADE.ValueMember = "Nome";
                this.TXT_SELECT_FIDELIDADE.DisplayMember = "Nome";
                RLB.Close();
                RLB.Dispose();
            }
            catch
            {

            }
            TXT_SELECT_FIDELIDADE.Update();
            Update();
            Refresh();
            con.Close();

        }

        private void BTN_FINALIZAR_COMPRA_GERAL_Click(object sender, EventArgs e)
        {
            if(FIDELIDADE == 0)
            {
                //MessageBox.Show("Cliente Fidelidade!");

                if (TXT_SELECT_FIDELIDADE.Text != "" && TXT_DESCONTO.Text != "" && TXT_SELECT_FIDELIDADE.Text != "Selecionar...")
                {
                    string QTD_ITEM = LABEL_N_ITENS_RESULT.Text;
                    string TOTAL_A_PAGAR = LABEL_VALOR_TOTAL_RESULT.Text;
                    string SELECT_FIDELIDADE = TXT_SELECT_FIDELIDADE.Text;
                    string DESCONTO = TXT_DESCONTO.Text;
                    if (TXT_DESCONTO.Text != "")
                    {
                        double desc = Convert.ToInt32(DESCONTO.ToString());
                        double total = Convert.ToDouble(TOTAL_A_PAGAR.ToString().Substring(3));
                        double div = desc / 100;
                        double result_porcent = total * div;
                        double result = total - result_porcent;
                        Convert.ToDecimal(result.ToString("N2"));

                        LABEL_VALOR_TOTAL_RESULT.Text = result.ToString();
                        MessageBox.Show("Desconto de '" + DESCONTO + "'% aplicado com sucesso! \n\n R$: '" + result.ToString("F") + "' ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TOTAL_A_PAGAR = result.ToString("F");                      
                    }

                    Variables variables = new Variables();

                    variables.NOME_VENDA_CLIENTE = SELECT_FIDELIDADE.ToString();
                    variables.QUANTIDADE_VENDA_CLIENTE = QTD_ITEM.ToString();
                    variables.DESCONTO_VENDA_CLIENTE = DESCONTO.ToString();
                    variables.TOTAL_VENDA_CLIENTE = TOTAL_A_PAGAR.ToString();
                    variables.TIPO_DE_VENDA = "1";

                    if (ADD.NEW_VENDA(variables))
                    {
                        PANEL_FINALIZAR_COMPRA.Visible = false;
                        LABEL_VALOR_TOTAL_RESULT.Text = "R$ 0,00";
                        LABEL_QTD_ITENS.Text = "Quantidade de itens: ";
                        TXT_SELECT_FIDELIDADE.ResetText();
                        TXT_DESCONTO.ResetText();
                        TABLE_NEW_VENDA.Rows.Clear();
                        TABLE_NEW_VENDA.Refresh();
                    }
                    else
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Ops! Verifique se o cliente e o desconto foram preenchidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //MessageBox.Show("Cliente Nao Fidelidade!");

                string QTD_ITEM = LABEL_N_ITENS_RESULT.Text;
                string TOTAL_A_PAGAR = LABEL_VALOR_TOTAL_RESULT.Text;

                double total = Convert.ToDouble(TOTAL_A_PAGAR.ToString().Substring(3));
                double result = total;
                Convert.ToDecimal(result.ToString("N2"));

                MessageBox.Show("\n\n Valor Pago: R$: '" + result.ToString("F") + "' ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TOTAL_A_PAGAR = result.ToString("F");

                Variables variables = new Variables();
                string nulo = "NULL";
                string nulo_desc = "0";
                variables.QUANTIDADE_VENDA_CLIENTE = QTD_ITEM.ToString();
                variables.TOTAL_VENDA_CLIENTE = TOTAL_A_PAGAR.ToString();
                variables.TIPO_DE_VENDA = "0";
                variables.NOME_VENDA_CLIENTE = nulo.ToString();
                variables.DESCONTO_VENDA_CLIENTE = nulo_desc.ToString();


                if (ADD.NEW_VENDA_NAO_FIDELIDADE(variables))
                {
                    PANEL_FINALIZAR_COMPRA.Visible = false;
                    LABEL_VALOR_TOTAL_RESULT.Text = "R$ 0,00";
                    LABEL_QTD_ITENS.Text = "Quantidade de itens: ";
                    TABLE_NEW_VENDA.Rows.Clear();
                    TABLE_NEW_VENDA.Refresh();
                }
                else
                {
                }
            }
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void TXT_SELECT_FIDELIDADE_SelectedIndexChanged(object sender, EventArgs e)
        {
            LABEL_COMPRAS_REALIZADAS.ResetText();
            if (TXT_SELECT_FIDELIDADE.SelectedIndex > 0)
            {
                con.Close();
                con.Open();
                SqlCeCommand SEARCH_COMPRAS = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM VENDAS WHERE Nome = '" + TXT_SELECT_FIDELIDADE.Text + "' ", con);
                SqlCeDataReader SC = SEARCH_COMPRAS.ExecuteReader();
                if (SC.Read())
                {
                    string total_compras = SC["TOTAL"].ToString();
                    LABEL_COMPRAS_REALIZADAS.Text = "N° de compras já realizadas: " + total_compras.ToString();
                }

                LABEL_COMPRAS_REALIZADAS.Show();                
            }
            con.Close();
        }
    }
}
