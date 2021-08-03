using MarketManager.models;
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

namespace MarketManager
{
    public partial class PROVEDORES : Form
    {

        String CNPJ = "";
        String PROVEDOR = "";

        // ADD CLIENTE = 0
        // EDIT CLIENTE  = 1

        public PROVEDORES()
        {
            InitializeComponent();
            TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();
            CONFIG_TABLE_PROVEDORES();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public void CONFIG_TABLE_PROVEDORES()
        {
            // Nome, SKU, QTD, Marca, V_Compra, V_Venda, Date
            TABLE_PROVEDORES.Columns[0].HeaderText = "Nome";
            TABLE_PROVEDORES.Columns[1].HeaderText = "CNPJ";
            TABLE_PROVEDORES.Columns[2].HeaderText = "Email";
            TABLE_PROVEDORES.Columns[3].HeaderText = "Telefone";

            TABLE_PROVEDORES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_PROVEDORES.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //TABLE_CLIENTES.Columns[4].DefaultCellStyle.Format = "C2";
        }

        public DataTable SEARCH_CLIENTES_TXT()
        {
            string provedores = "%" + TXT_SEARCH_PROVEDORES.Text + "%";

            SqlCeDataAdapter SEARCH_PRODUCTS_SEM_SN = new SqlCeDataAdapter("SELECT Nome, CNPJ, Email, Telefone " +
                "FROM PROVEDORES " +
                "WHERE " +
                "Nome LIKE '" + provedores + "' OR " +
                "CNPJ LIKE '" + provedores + "' OR " +
                "Telefone LIKE '" + provedores + "' ORDER By id DESC ", con);

            DataSet SP = new DataSet();

            SEARCH_PRODUCTS_SEM_SN.Fill(SP);

            return SP.Tables[0];
        }

        public DataTable SEARCH_PROVEDORES()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT Nome, CNPJ, Email, Telefone FROM PROVEDORES ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        private void BTN_ADICIONAR_PROVEDORES_Click(object sender, EventArgs e)
        {
            {
                LABEL_TITTLE.Text = "Cadastrar Novo Provedor";

                // HIDE
                PANEL_PROVEDORES.Hide();

                // SHOW
                PANEL_CONTROL_PROVEDORES.Show();
                LABEL_RETURN_PROVEDORES.Show();

                // ACTION
                LABEL_TITTLE.Location = new Point(370, 30);

                PROVEDOR = "0";
            }
        }

        private void TXT_SEARCH_PROVEDORES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TABLE_PROVEDORES.DataSource = SEARCH_CLIENTES_TXT();
            }
            else if (e.KeyChar == (char)27)
            {
                BTN_RESET_TABLE_PROVEDORES.PerformClick();
                TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();
            }
        }
        private void BTN_RESET_TABLE_PROVEDORES_Click(object sender, EventArgs e)
        {
            TXT_SEARCH_PROVEDORES.ResetText();
            TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();
        }

        private void LABEL_CLOSE_PROVEDORES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LABEL_RETURN_PROVEDORES_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL_PROVEDORES.Hide();
            LABEL_RETURN_PROVEDORES.Hide();


            // SHOW
            PANEL_PROVEDORES.Show();

            // CONTROL
            LABEL_TITTLE.Text = "Provedores";
            LABEL_TITTLE.Location = new Point(446, 7);

            TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();
        }

        private void BTN_EXCLUIR_PROVEDORES_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TABLE_PROVEDORES.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_PROVEDORES.CurrentRow;

                CNPJ = Convert.ToString((linhaAtual.Cells[1]).Value);

                con.Close();
                con.Open();
                SqlCeCommand SEARCH_PROVEDOR_DELETE = new SqlCeCommand("SELECT * FROM PROVEDORES WHERE CNPJ = '" + CNPJ + "' ", con);
                SqlCeDataReader SPD = SEARCH_PROVEDOR_DELETE.ExecuteReader();
                if (SPD.Read())
                {
                    if (MessageBox.Show("Deseja mesmo deletar este provedor \n\n CNPJ: '" + SPD["CNPJ"].ToString() + "' \n Nome: '" + SPD["Nome"].ToString() + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCeCommand DELETE_PROVEDOR = new SqlCeCommand("DELETE FROM PROVEDORES WHERE CNPJ = '" + CNPJ + "' ", con);
                        DELETE_PROVEDOR.ExecuteReader();

                        MessageBox.Show("provedor deletado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();
                    }
                    else
                    {

                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Nenhum provedor selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_EDITAR_PROVEDORES_Click(object sender, EventArgs e)
        {
            LABEL_TITTLE.Text = "Editar Provedor";

            // HIDE
            PANEL_PROVEDORES.Hide();

            // SHOW
            PANEL_CONTROL_PROVEDORES.Show();
            LABEL_RETURN_PROVEDORES.Show();

            // ACTION

            if (Convert.ToInt32(TABLE_PROVEDORES.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_PROVEDORES.CurrentRow;

                CNPJ = Convert.ToString((linhaAtual.Cells[1]).Value);
                con.Close();
                con.Open();
                SqlCeCommand SEARCH_PROVEDOR_EDIT = new SqlCeCommand("SELECT * FROM PROVEDORES WHERE CNPJ = '" + CNPJ + "' ", con);
                SqlCeDataReader SPE = SEARCH_PROVEDOR_EDIT.ExecuteReader();
                if (SPE.Read())
                {
                    TXT_ADD_NOME_PROVEDOR.Text = SPE["Nome"].ToString();
                    TXT_ADD_CNPJ_PROVEDOR.Text = SPE["CNPJ"].ToString();
                    TXT_ADD_TELEFONE_PROVEDOR.Text = SPE["Telefone"].ToString();
                    TXT_ADD_ENDERECO_PROVEDOR.Text = SPE["Endereco"].ToString();
                    TXT_ADD_NUMERO_PROVEDOR.Text = SPE["N_Endereco"].ToString();
                    TXT_ADD_COMPLEMENTO_PROVEDOR.Text = SPE["Complemento"].ToString();
                    TXT_ADD_BAIRRO_PROVEDOR.Text = SPE["Bairro"].ToString();
                    TXT_ADD_CEP_PROVEDOR.Text = SPE["CEP"].ToString();
                    TXT_ADD_UF_PROVEDOR.Text = SPE["Estado"].ToString();
                    TXT_ADD_CIDADE_PROVEDOR.Text = SPE["Cidade"].ToString();
                    TXT_ADD_EMAIL_PROVEDOR.Text = SPE["Email"].ToString();
                }
            }

            LABEL_TITTLE.Location = new Point(427, 30);
            con.Close();

            PROVEDOR = "1";
        }

        private void BTN_SALVAR_ADD_PROVEDOR_Click(object sender, EventArgs e)
        {
            if (PROVEDOR == "0")
            {

                if (TXT_ADD_NOME_PROVEDOR.Text != "" && TXT_ADD_TELEFONE_PROVEDOR.Text != "(  )       -" && TXT_ADD_CNPJ_PROVEDOR.Text != "")
                {
                    con.Close();
                    con.Open();
                    SqlCeCommand VERY_PROVEDOR = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM PROVEDORES WHERE CNPJ = '" + TXT_ADD_CNPJ_PROVEDOR.Text + "' ", con);
                    SqlCeDataReader VP = VERY_PROVEDOR.ExecuteReader();

                    if (VP.Read())
                    {
                        int VP_COUNT = Convert.ToInt32(VP["TOTAL"].ToString());

                        if (VP_COUNT < 1)
                        {

                            Variables variables = new Variables();

                            variables.NOME_ADD_PROVEDOR = TXT_ADD_NOME_PROVEDOR.Text;
                            variables.CEP_ADD_PROVEDOR = TXT_ADD_CEP_PROVEDOR.Text;
                            variables.TELEFONE_ADD_PROVEDOR = TXT_ADD_TELEFONE_PROVEDOR.Text;
                            variables.CNPJ_ADD_PROVEDOR = TXT_ADD_CNPJ_PROVEDOR.Text;
                            variables.RUA_ADD_PROVEDOR = TXT_ADD_ENDERECO_PROVEDOR.Text;
                            variables.NUMERO_CASA_ADD_PROVEDOR = TXT_ADD_NUMERO_PROVEDOR.Text;
                            variables.BAIRRO_ADD_PROVEDOR = TXT_ADD_BAIRRO_PROVEDOR.Text;
                            variables.CIDADE_ADD_PROVEDOR = TXT_ADD_CIDADE_PROVEDOR.Text;
                            variables.ESTADO_ADD_PROVEDOR = TXT_ADD_UF_PROVEDOR.Text;
                            variables.COMPLEMENTO_ADD_PROVEDOR = TXT_ADD_COMPLEMENTO_PROVEDOR.Text;
                            variables.EMAIL_ADD_PROVEDOR = TXT_ADD_EMAIL_PROVEDOR.Text;

                            if (ADD.NEW_PROVEDOR(variables))
                            {
                                // HIDE
                                PANEL_CONTROL_PROVEDORES.Hide();
                                LABEL_RETURN_PROVEDORES.Hide();

                                // SHOW
                                PANEL_PROVEDORES.Show();

                                // ACTION
                                TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();

                                TXT_ADD_NOME_PROVEDOR.ResetText();
                                TXT_ADD_CEP_PROVEDOR.ResetText();
                                TXT_ADD_TELEFONE_PROVEDOR.ResetText();
                                TXT_ADD_CNPJ_PROVEDOR.ResetText();
                                TXT_ADD_ENDERECO_PROVEDOR.ResetText();
                                TXT_ADD_NUMERO_PROVEDOR.ResetText();
                                TXT_ADD_BAIRRO_PROVEDOR.ResetText();
                                TXT_ADD_CIDADE_PROVEDOR.ResetText();
                                TXT_ADD_UF_PROVEDOR.ResetText();
                                TXT_ADD_COMPLEMENTO_PROVEDOR.ResetText();
                                TXT_ADD_EMAIL_PROVEDOR.ResetText();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível realizar o cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LABEL_ERRO_PROVEDOR.Show();
                    LABEL_ERRO_PROVEDOR1.Show();
                    LABEL_ERRO_PROVEDOR2.Show();
                }
            }
            else // EDITAR PROVEDOR
            {
                if (TXT_ADD_NOME_PROVEDOR.Text != "" && TXT_ADD_TELEFONE_PROVEDOR.Text != "(  )       -" && TXT_ADD_CNPJ_PROVEDOR.Text != "")
                {

                    Variables variables = new Variables();

                    variables.NOME_ADD_PROVEDOR = TXT_ADD_NOME_PROVEDOR.Text;
                    variables.CEP_ADD_PROVEDOR = TXT_ADD_CEP_PROVEDOR.Text;
                    variables.TELEFONE_ADD_PROVEDOR = TXT_ADD_TELEFONE_PROVEDOR.Text;
                    variables.CNPJ_ADD_PROVEDOR = TXT_ADD_CNPJ_PROVEDOR.Text;
                    variables.RUA_ADD_PROVEDOR = TXT_ADD_ENDERECO_PROVEDOR.Text;
                    variables.NUMERO_CASA_ADD_PROVEDOR = TXT_ADD_NUMERO_PROVEDOR.Text;
                    variables.BAIRRO_ADD_PROVEDOR = TXT_ADD_BAIRRO_PROVEDOR.Text;
                    variables.CIDADE_ADD_PROVEDOR = TXT_ADD_CIDADE_PROVEDOR.Text;
                    variables.ESTADO_ADD_PROVEDOR = TXT_ADD_UF_PROVEDOR.Text;
                    variables.COMPLEMENTO_ADD_PROVEDOR = TXT_ADD_COMPLEMENTO_PROVEDOR.Text;
                    variables.EMAIL_ADD_PROVEDOR = TXT_ADD_EMAIL_PROVEDOR.Text;
                    variables.CNPJ_VERYF = TXT_ADD_CNPJ_PROVEDOR.Text;

                    if (ADD.EDIT_PROVEDOR(variables))
                    {
                        // HIDE
                        PANEL_CONTROL_PROVEDORES.Hide();
                        LABEL_RETURN_PROVEDORES.Hide();

                        // SHOW
                        PANEL_PROVEDORES.Show();

                        // ACTION
                        TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();

                        TXT_ADD_NOME_PROVEDOR.ResetText();
                        TXT_ADD_CEP_PROVEDOR.ResetText();
                        TXT_ADD_TELEFONE_PROVEDOR.ResetText();
                        TXT_ADD_CNPJ_PROVEDOR.ResetText();
                        TXT_ADD_ENDERECO_PROVEDOR.ResetText();
                        TXT_ADD_NUMERO_PROVEDOR.ResetText();
                        TXT_ADD_BAIRRO_PROVEDOR.ResetText();
                        TXT_ADD_CIDADE_PROVEDOR.ResetText();
                        TXT_ADD_UF_PROVEDOR.ResetText();
                        TXT_ADD_COMPLEMENTO_PROVEDOR.ResetText();
                        TXT_ADD_EMAIL_PROVEDOR.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar o cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LABEL_ERRO_PROVEDOR.Show();
                    LABEL_ERRO_PROVEDOR1.Show();
                    LABEL_ERRO_PROVEDOR2.Show();
                }
            }
        }

        private void BTN_CANCELAR_ADD_PROVEDOR_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL_PROVEDORES.Hide();
            LABEL_RETURN_PROVEDORES.Hide();

            // SHOW
            PANEL_PROVEDORES.Show();

            // ACTION
            LABEL_TITTLE.Text = "Provedores";
            LABEL_TITTLE.Location = new Point(446, 7);

            TABLE_PROVEDORES.DataSource = SEARCH_PROVEDORES();

            TXT_ADD_NOME_PROVEDOR.ResetText();
            TXT_ADD_CEP_PROVEDOR.ResetText();
            TXT_ADD_TELEFONE_PROVEDOR.ResetText();
            TXT_ADD_CNPJ_PROVEDOR.ResetText();
            TXT_ADD_ENDERECO_PROVEDOR.ResetText();
            TXT_ADD_NUMERO_PROVEDOR.ResetText();
            TXT_ADD_BAIRRO_PROVEDOR.ResetText();
            TXT_ADD_CIDADE_PROVEDOR.ResetText();
            TXT_ADD_UF_PROVEDOR.ResetText();
            TXT_ADD_COMPLEMENTO_PROVEDOR.ResetText();
            TXT_ADD_EMAIL_PROVEDOR.ResetText();
        }
    }
}
