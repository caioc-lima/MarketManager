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
    public partial class VENDAS : Form
    {
        public VENDAS()
        {
            InitializeComponent();
            TABLE_VENDAS.DataSource = SEARCH_VENDAS();
            CONFIG_TABLE_PRODUTOS();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public void CONFIG_TABLE_PRODUTOS()
        {
            TABLE_VENDAS.Columns[0].HeaderText = "Cliente";
            TABLE_VENDAS.Columns[1].HeaderText = "Desconto (%)";
            TABLE_VENDAS.Columns[2].HeaderText = "Valor Pago";
            TABLE_VENDAS.Columns[3].HeaderText = "Fidelidade";
            TABLE_VENDAS.Columns[4].HeaderText = "Data";
            TABLE_VENDAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_VENDAS.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewRow row in TABLE_VENDAS.Rows)
            {
                if (int.TryParse(row.Cells["TipoDeVenda"].Value.ToString(), out int value))
                {
                    if (value == 1)
                    {
                        row.Cells[3].Value = "Sim";
                    }
                    else if(value == 0)
                    {
                        row.Cells[3].Value = "Não";
                    }
                    else
                    {
                        row.Cells[3].Value = "";
                    }
                }

                if (row.Cells[0].Value.ToString().Trim() == "NULO" || row.Cells[0].Value.ToString().Trim() == "NULL")
                {
                   row.Cells[0].Value = "";
                }
            }

                TABLE_VENDAS.Columns[2].DefaultCellStyle.Format = "C2";
        }

        public DataTable SEARCH_VENDAS()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT Nome, Desconto, Total_a_pagar, TipoDeVenda, date FROM VENDAS ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }
        public DataTable SEARCH_VENDAS_FIDELIDADE()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT Nome, Desconto, Total_a_pagar, TipoDeVenda, date FROM VENDAS WHERE TipoDeVenda = '1' ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        public DataTable SEARCH_VENDAS_TXT()
        {
            string VENDAS = "%" + TXT_SEARCH_VENDAS.Text + "%";

            SqlCeDataAdapter SEARCH_VENDAS_NOME = new SqlCeDataAdapter("SELECT Nome, Desconto, Total_a_pagar, TipoDeVenda, date FROM VENDAS WHERE Nome LIKE '" + VENDAS + "' ", con);

            DataSet SP = new DataSet();

            SEARCH_VENDAS_NOME.Fill(SP);

            return SP.Tables[0];
        }

        private void TXT_SEARCH_VENDAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TABLE_VENDAS.DataSource = SEARCH_VENDAS_TXT();
                CONFIG_TABLE_PRODUTOS();
            }
            else if (e.KeyChar == (char)27)
            {
                BTN_RESET_TABLE_VENDAS.PerformClick();
                TABLE_VENDAS.DataSource = SEARCH_VENDAS();
                CONFIG_TABLE_PRODUTOS();
            }
        }

        private void BTN_RESET_TABLE_VENDAS_Click(object sender, EventArgs e)
        {
            TABLE_VENDAS.DataSource = SEARCH_VENDAS();
            TXT_SEARCH_VENDAS.ResetText();
            CONFIG_TABLE_PRODUTOS();
        }

        private void BTN_SEARCH_FIDELIDADE_Click(object sender, EventArgs e)
        {
            TABLE_VENDAS.DataSource =  SEARCH_VENDAS_FIDELIDADE();
            TXT_SEARCH_VENDAS.ResetText();
            CONFIG_TABLE_PRODUTOS();
        }

        private void BTN_TODAS_VENDAS_Click(object sender, EventArgs e)
        {
            TABLE_VENDAS.DataSource = SEARCH_VENDAS();
            TXT_SEARCH_VENDAS.ResetText();
            CONFIG_TABLE_PRODUTOS();
        }
    }
}
