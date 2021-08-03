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
    public partial class Clientes : Form
    {

        String CPF = "";
        String CLIENTE = "";
        String CPF_CLIENT = "";

        // ADD CLIENTE = 0
        // EDIT CLIENTE = 1

        public Clientes()
        {
            InitializeComponent();
            TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();
            CONFIG_TABLE_CLIENTES();

        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public void CONFIG_TABLE_CLIENTES()
        {
            // Nome, SKU, QTD, Marca, V_Compra, V_Venda, Date
            TABLE_CLIENTES.Columns[0].HeaderText = "Nome";
            TABLE_CLIENTES.Columns[1].HeaderText = "CPF";
            TABLE_CLIENTES.Columns[2].HeaderText = "Data de Nascimento";
            TABLE_CLIENTES.Columns[3].HeaderText = "Telefone";

            TABLE_CLIENTES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_CLIENTES.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //TABLE_CLIENTES.Columns[4].DefaultCellStyle.Format = "C2";
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void TXT_SEARCH_CLIENTE_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable SEARCH_CLIENTES_TXT()
        {
            string cliente = "%" + TXT_SEARCH_CLIENTE.Text + "%";

            SqlCeDataAdapter SEARCH_PRODUCTS_SEM_SN = new SqlCeDataAdapter("SELECT Nome, CPF, Data_Nascimento, Telefone " +
                "FROM CLIENT " +
                "WHERE " +
                "Nome LIKE '" + cliente + "' OR " +
                "CPF LIKE '" + cliente + "' OR " +
                "Telefone LIKE '" + cliente + "' ORDER By id DESC ", con);

            DataSet SP = new DataSet();

            SEARCH_PRODUCTS_SEM_SN.Fill(SP);

            return SP.Tables[0];
        }

        public DataTable SEARCH_CLIENTES()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT Nome, CPF, Data_Nascimento, Telefone FROM CLIENT ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LABEL_RETURN_Click_1(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL_CLIENTE.Hide();
            LABEL_RETURN.Hide();
           

            // SHOW
            PANEL_CLIENTES.Show();

            // CONTROL
            LABEL_TITTLE.Text = "Clientes";
            LABEL_TITTLE.Location = new Point(447, 30);

            TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();
        }

        private void LABEL_CLOSE_CLIENTES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_SEARCH_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TABLE_CLIENTES.DataSource = SEARCH_CLIENTES_TXT();
            }
            else if (e.KeyChar == (char)27)
            {
                BTN_RESET_TABLE_CLIENTES.PerformClick();
                TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();
            }
        }

        private void BTN_RESET_TABLE_CLIENTES_Click(object sender, EventArgs e)
        {
            TXT_SEARCH_CLIENTE.ResetText();
            TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();
        }

        private void BTN_ADICIONAR_CLIENTE_Click(object sender, EventArgs e)
        {
            LABEL_TITTLE.Text = "Cadastrar Novo Cliente";

            // HIDE
            PANEL_CLIENTES.Hide();

            // SHOW
            PANEL_CONTROL_CLIENTE.Show();
            LABEL_RETURN.Show();

            // ACTION
            LABEL_TITTLE.Location = new Point(370, 30);
            CLIENTE = "0";
        }

        private void BTN_SALVAR_ADD_CLIENTE_Click(object sender, EventArgs e)
        {
            if (CLIENTE == "0")
            {

                if (TXT_ADD_NOME_CLIENTE.Text != "" && TXT_ADD_TELEFONE_PACIENTE.Text != "(  )       -" && TXT_ADD_CPF_PACIENTE.Text != "   .   .   -")
                {
                    con.Close();
                    con.Open();
                    SqlCeCommand VERY_PRODUCT = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM CLIENT WHERE CPF = '" + TXT_ADD_CPF_PACIENTE.Text + "' ", con);
                    SqlCeDataReader VP = VERY_PRODUCT.ExecuteReader();

                    if (VP.Read())
                    {
                        int VP_COUNT = Convert.ToInt32(VP["TOTAL"].ToString());

                        if (VP_COUNT < 1)
                        {

                            Variables variables = new Variables();

                            variables.NOME_ADD_CLIENTE = TXT_ADD_NOME_CLIENTE.Text;
                            variables.CEP_ADD_CLIENTE = TXT_ADD_CEP_PACIENTE.Text;
                            variables.TELEFONE_ADD_CLIENTE = TXT_ADD_TELEFONE_PACIENTE.Text;
                            variables.CPF_ADD_CLIENTE = TXT_ADD_CPF_PACIENTE.Text;
                            variables.DATA_NASCIMENTO_ADD_CLIENTE = TXT_ADD_DATA_NASC_PACIENTE.Text;
                            variables.RUA_ADD_CLIENTE = TXT_ADD_ENDERECO_PACIENTE.Text;
                            variables.NUMERO_CASA_ADD_CLIENTE = TXT_ADD_NUMERO_PACIENTE.Text;
                            variables.BAIRRO_ADD_CLIENTE = TXT_ADD_BAIRRO_PACIENTE.Text;
                            variables.CIDADE_ADD_CLIENTE = TXT_ADD_CIDADE_PACIENTE.Text;
                            variables.ESTADO_ADD_CLIENTE = TXT_ADD_UF_PACIENTE.Text;
                            variables.GENERO_ADD_CLIENTE = TXT_ADD_GENERO_PACIENTE.Text;
                            variables.COMPLEMENTO_ADD_CLIENTE = TXT_ADD_COMPLEMENTO_PACIENTE.Text;
                            variables.EMAIL_ADD_CLIENTE = TXT_ADD_EMAIL_PACIENTE.Text;

                            if (ADD.NEW_CLIENT(variables))
                            {
                                // HIDE
                                PANEL_CONTROL_CLIENTE.Hide();
                                LABEL_RETURN.Hide();

                                // SHOW
                                PANEL_CLIENTES.Show();

                                // ACTION
                                TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();

                                TXT_ADD_NOME_CLIENTE.ResetText();
                                TXT_ADD_CEP_PACIENTE.ResetText();
                                TXT_ADD_TELEFONE_PACIENTE.ResetText();
                                TXT_ADD_CPF_PACIENTE.ResetText();
                                TXT_ADD_DATA_NASC_PACIENTE.ResetText();
                                TXT_ADD_ENDERECO_PACIENTE.ResetText();
                                TXT_ADD_NUMERO_PACIENTE.ResetText();
                                TXT_ADD_BAIRRO_PACIENTE.ResetText();
                                TXT_ADD_CIDADE_PACIENTE.ResetText();
                                TXT_ADD_UF_PACIENTE.ResetText();
                                TXT_ADD_GENERO_PACIENTE.ResetText();
                                TXT_ADD_COMPLEMENTO_PACIENTE.ResetText();
                                TXT_ADD_EMAIL_PACIENTE.ResetText();
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
                    LABEL_ERRO_PACIENTE.Show();
                    LABEL_ERRO_PACIENTE1.Show();
                    LABEL_ERRO_PACIENTE2.Show();
                }
            }
            else // EDITAR PACIENTE
            {
                if (TXT_ADD_NOME_CLIENTE.Text != "" && TXT_ADD_TELEFONE_PACIENTE.Text != "(  )       -" && TXT_ADD_CPF_PACIENTE.Text != "   .   .   -")
                {

                    Variables variables = new Variables();

                    variables.NOME_ADD_CLIENTE = TXT_ADD_NOME_CLIENTE.Text;
                    variables.CEP_ADD_CLIENTE = TXT_ADD_CEP_PACIENTE.Text;
                    variables.TELEFONE_ADD_CLIENTE = TXT_ADD_TELEFONE_PACIENTE.Text;
                    variables.CPF_ADD_CLIENTE = TXT_ADD_CPF_PACIENTE.Text;
                    variables.DATA_NASCIMENTO_ADD_CLIENTE = TXT_ADD_DATA_NASC_PACIENTE.Text;
                    variables.RUA_ADD_CLIENTE = TXT_ADD_ENDERECO_PACIENTE.Text;
                    variables.NUMERO_CASA_ADD_CLIENTE = TXT_ADD_NUMERO_PACIENTE.Text;
                    variables.BAIRRO_ADD_CLIENTE = TXT_ADD_BAIRRO_PACIENTE.Text;
                    variables.CIDADE_ADD_CLIENTE = TXT_ADD_CIDADE_PACIENTE.Text;
                    variables.ESTADO_ADD_CLIENTE = TXT_ADD_UF_PACIENTE.Text;
                    variables.GENERO_ADD_CLIENTE = TXT_ADD_GENERO_PACIENTE.Text;
                    variables.COMPLEMENTO_ADD_CLIENTE = TXT_ADD_COMPLEMENTO_PACIENTE.Text;
                    variables.EMAIL_ADD_CLIENTE = TXT_ADD_EMAIL_PACIENTE.Text;
                    variables.CPF_VERYF = TXT_ADD_CPF_PACIENTE.Text;

                    if (ADD.EDIT_PACIENTE(variables))
                    {
                        // HIDE
                        PANEL_CONTROL_CLIENTE.Hide();
                        LABEL_RETURN.Hide();

                        // SHOW
                        PANEL_CLIENTES.Show();

                        // ACTION
                        TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();

                        TXT_ADD_NOME_CLIENTE.ResetText();
                        TXT_ADD_CEP_PACIENTE.ResetText();
                        TXT_ADD_TELEFONE_PACIENTE.ResetText();
                        TXT_ADD_CPF_PACIENTE.ResetText();
                        TXT_ADD_DATA_NASC_PACIENTE.ResetText();
                        TXT_ADD_ENDERECO_PACIENTE.ResetText();
                        TXT_ADD_NUMERO_PACIENTE.ResetText();
                        TXT_ADD_BAIRRO_PACIENTE.ResetText();
                        TXT_ADD_CIDADE_PACIENTE.ResetText();
                        TXT_ADD_UF_PACIENTE.ResetText();
                        TXT_ADD_GENERO_PACIENTE.ResetText();
                        TXT_ADD_COMPLEMENTO_PACIENTE.ResetText();
                        TXT_ADD_EMAIL_PACIENTE.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar o cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                      
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LABEL_ERRO_PACIENTE.Show();
                    LABEL_ERRO_PACIENTE1.Show();
                    LABEL_ERRO_PACIENTE2.Show();
                }

            }
        }
            
        

        private void BTN_CANCELAR_ADD_CLIENTE_Click(object sender, EventArgs e)
        {
            // HIDE
            PANEL_CONTROL_CLIENTE.Hide();
            LABEL_RETURN.Hide();

            // SHOW
            PANEL_CLIENTES.Show();

            // ACTION
            LABEL_TITTLE.Text = "Clientes";
            LABEL_TITTLE.Location = new Point(460, 9);

            TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();

            TXT_ADD_NOME_CLIENTE.ResetText();
            TXT_ADD_CEP_PACIENTE.ResetText();
            TXT_ADD_TELEFONE_PACIENTE.ResetText();
            TXT_ADD_CPF_PACIENTE.ResetText();
            TXT_ADD_DATA_NASC_PACIENTE.ResetText();
            TXT_ADD_ENDERECO_PACIENTE.ResetText();
            TXT_ADD_NUMERO_PACIENTE.ResetText();
            TXT_ADD_BAIRRO_PACIENTE.ResetText();
            TXT_ADD_CIDADE_PACIENTE.ResetText();
            TXT_ADD_UF_PACIENTE.ResetText();
            TXT_ADD_GENERO_PACIENTE.ResetText();
            TXT_ADD_COMPLEMENTO_PACIENTE.ResetText();
            TXT_ADD_EMAIL_PACIENTE.ResetText();

        }

        private void BTN_EXCLUIR_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TABLE_CLIENTES.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_CLIENTES.CurrentRow;

                CPF = Convert.ToString((linhaAtual.Cells[1]).Value);

                con.Close();
                con.Open();
                SqlCeCommand SEARCH_CLIENTE_DELETE = new SqlCeCommand("SELECT * FROM CLIENT WHERE CPF = '" + CPF + "' ", con);
                SqlCeDataReader SCD = SEARCH_CLIENTE_DELETE.ExecuteReader();
                if (SCD.Read())
                {
                    if (MessageBox.Show("Deseja mesmo deletar este usuário \n\n SKU: '" + SCD["CPF"].ToString() + "' \n Produto: '" + SCD["Nome"].ToString() + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCeCommand DELETE_CLIENTE = new SqlCeCommand("DELETE FROM CLIENT WHERE CPF = '" + CPF + "' ", con);
                        DELETE_CLIENTE.ExecuteReader();

                        MessageBox.Show("Usuário deletado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TABLE_CLIENTES.DataSource = SEARCH_CLIENTES();
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

        private void PANEL_ADD_CLIENTE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            LABEL_TITTLE.Text = "Editar Cliente";

            // HIDE
            PANEL_CLIENTES.Hide();

            // SHOW
            PANEL_CONTROL_CLIENTE.Show();
            LABEL_RETURN.Show();

            // ACTION

            if (Convert.ToInt32(TABLE_CLIENTES.RowCount.ToString()) >= 1)
            {
                DataGridViewRow linhaAtual = TABLE_CLIENTES.CurrentRow;

                CPF_CLIENT = Convert.ToString((linhaAtual.Cells[1]).Value);
                con.Close();
                con.Open();
                SqlCeCommand SEARCH_CLIENTE_EDIT = new SqlCeCommand("SELECT * FROM CLIENT WHERE CPF = '" + CPF_CLIENT + "' ", con);
                SqlCeDataReader SCE = SEARCH_CLIENTE_EDIT.ExecuteReader();
                if (SCE.Read())
                {
                    TXT_ADD_NOME_CLIENTE.Text = SCE["Nome"].ToString();
                    TXT_ADD_CPF_PACIENTE.Text = SCE["CPF"].ToString();
                    TXT_ADD_GENERO_PACIENTE.Text = SCE["Genero"].ToString();
                    TXT_ADD_DATA_NASC_PACIENTE.Text = SCE["Data_Nascimento"].ToString();
                    TXT_ADD_TELEFONE_PACIENTE.Text = SCE["Telefone"].ToString();
                    TXT_ADD_ENDERECO_PACIENTE.Text = SCE["Rua"].ToString();
                    TXT_ADD_NUMERO_PACIENTE.Text = SCE["N_Casa"].ToString();
                    TXT_ADD_COMPLEMENTO_PACIENTE.Text = SCE["Complemento"].ToString();
                    TXT_ADD_BAIRRO_PACIENTE.Text = SCE["Bairro"].ToString();
                    TXT_ADD_CEP_PACIENTE.Text = SCE["CEP"].ToString();
                    TXT_ADD_UF_PACIENTE.Text = SCE["Estado"].ToString();
                    TXT_ADD_CIDADE_PACIENTE.Text = SCE["Cidade"].ToString();
                    TXT_ADD_EMAIL_PACIENTE.Text = SCE["Email"].ToString();
                }
            }

            LABEL_TITTLE.Location = new Point(430, 30);
            CLIENTE = "1";
            con.Close();
        }

        private void TXT_SEARCH_CLIENTE_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
