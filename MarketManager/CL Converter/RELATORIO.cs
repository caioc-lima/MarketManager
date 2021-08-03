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
    public partial class RELATORIO : Form
    {
        public RELATORIO()
        {
            InitializeComponent();

            TABLE_ULTIMAS_VENDAS.DataSource = SEARCH_ULTIMAS_VENDAS();
            CONFIG_TABLE_ULTIMAS_VENDAS();
            QTD_BRANDS();
            QTD_CLIENT();
            QTD_PROVEDORES();
            QTD_PRODUTOS();
            QTD_VENDAS();
            QTD_GASTOS();
            QTD_CAIXA();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public void CONFIG_TABLE_PRODUTOS()
        {
            // Nome, SKU, QTD, Marca, V_Compra, V_Venda, Date
            TABLE_PRODUTOS_HOME.Columns[0].HeaderText = "SKU";
            TABLE_PRODUTOS_HOME.Columns[1].HeaderText = "Nome";
            TABLE_PRODUTOS_HOME.Columns[2].HeaderText = "Quantidade";
            TABLE_PRODUTOS_HOME.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_PRODUTOS_HOME.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void QTD_CLIENT()
        {
            con.Close();
            con.Open();

            // CLIENTES
            SqlCeCommand client_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM CLIENT", con);
            SqlCeDataReader CC = client_count.ExecuteReader();

            if (CC.Read())
            {
                LABEL_CLIENTE_HOME.Text = CC["TOTAL"].ToString();
            }
            con.Close();
        }
        public void QTD_PROVEDORES()
        {
            con.Close();
            con.Open();

            // CLIENTES
            SqlCeCommand provedores_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM PROVEDORES", con);
            SqlCeDataReader PC = provedores_count.ExecuteReader();

            if (PC.Read())
            {
                LABEL_PROVEDORES_HOME.Text = PC["TOTAL"].ToString();
            }
            con.Close();
        }

        public void QTD_PRODUTOS()
        {
            con.Close();
            con.Open();

            // CLIENTES
            SqlCeCommand produtos_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM produto", con);
            SqlCeDataReader PC = produtos_count.ExecuteReader();

            if (PC.Read())
            {
                LABEL_PRODUTOS_HOME.Text = PC["TOTAL"].ToString();
            }
            con.Close();
        }

        public void QTD_BRANDS()
        {
            con.Close();
            con.Open();

            // MARCAS
            SqlCeCommand brands_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM MARCAS", con);
            SqlCeDataReader BC = brands_count.ExecuteReader();

            if (BC.Read())
            {
                LABEL_MARCAS_HOME.Text = BC["TOTAL"].ToString();
            }
            con.Close();
        }
        public void QTD_GASTOS()
        {
            con.Close();
            con.Open();

            // MARCAS
            SqlCeCommand gastos_count = new SqlCeCommand("SELECT SUM(V_Compra) AS TOTAL FROM produto", con);
            SqlCeDataReader GC = gastos_count.ExecuteReader();

            if (GC.Read())
            {
                try
                {
                    double v = Convert.ToDouble(GC["TOTAL"].ToString());
                    LABEL_GASTOS_HOME.Text = "R$ " + String.Format("{0:0,0.00}", v);
                }
                catch
                {
                    LABEL_GASTOS_HOME.Text = "R$ 0,00" ;
                }


            }
            con.Close();
        }

        public void QTD_VENDAS()
        {
            con.Close();
            con.Open();

            // MARCAS
            SqlCeCommand vendas_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM VENDAS", con);
            SqlCeDataReader VC = vendas_count.ExecuteReader();

            if (VC.Read())
            {
                LABEL_VENDAS_HOME.Text = VC["TOTAL"].ToString();
                SqlCeCommand vendas_fidelidade_count = new SqlCeCommand("SELECT COUNT(*) AS TOTAL FROM VENDAS", con);
                SqlCeDataReader VFC = vendas_fidelidade_count.ExecuteReader();
                if (VFC.Read())
                {
                    int result = Convert.ToInt32(VC["TOTAL"].ToString());

                    LABEL_VENDAS_HOME.Text = Convert.ToString(result);
                }
                
            }
            con.Close();
        }
        public void QTD_CAIXA()
        {
            con.Close();
            con.Open();
            double caixa = 0;
            double caixaf = 0;
            // CAIXA
            SqlCeCommand vendas_caixa_count = new SqlCeCommand("SELECT SUM(Total_a_pagar) AS TOTAL FROM VENDAS", con);
            SqlCeDataReader VCC = vendas_caixa_count.ExecuteReader();

            if (VCC.Read())
            {
                if (VCC["TOTAL"].ToString() != "")
                {
                double VCC_RESULT = Convert.ToDouble(VCC["TOTAL"].ToString());
                
                caixa = VCC_RESULT;
                }
                else
                {
                    caixa = 0;
                }
            }

            LABEL_CAIXA_HOME.Text = "R$ " + String.Format("{0:0,0.00}", caixa);

            con.Close();
        }

        public DataTable SEARCH_PRODUCTS_SEM_ESTOQUE()
        {

            int filter_qtd = Convert.ToInt32(TXT_FILTER_SEM_ESTOQUE.Text);
            string QUERY = "";
            if (filter_qtd == 5)
            {
                QUERY = "SELECT TOP 5 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }
            else if (filter_qtd == 10)
            {
                QUERY = "SELECT TOP 10 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }
            else if (filter_qtd == 15)
            {
                QUERY = "SELECT TOP 15 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }
            else if (filter_qtd == 20)
            {
                QUERY = "SELECT TOP 20 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }
            else if (filter_qtd == 25)
            {
                QUERY = "SELECT TOP 25 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }
            else if (filter_qtd == 30)
            {
                QUERY = "SELECT TOP 30 SKU, Nome, QTD FROM produto WHERE QTD <= 10 ";
            }

            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter(QUERY, con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }
        public void CONFIG_TABLE_ULTIMAS_VENDAS()
        {            
            TABLE_ULTIMAS_VENDAS.Columns[0].HeaderText = "Nome";
            TABLE_ULTIMAS_VENDAS.Columns[1].HeaderText = "Valor Pago";
            TABLE_ULTIMAS_VENDAS.Columns[2].HeaderText = "Data";
            TABLE_ULTIMAS_VENDAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in TABLE_ULTIMAS_VENDAS.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            TABLE_ULTIMAS_VENDAS.Columns[1].DefaultCellStyle.Format = "C2";
        }

        public DataTable SEARCH_ULTIMAS_VENDAS()
        {
            string QUERY = "";
            QUERY = "SELECT TOP 10 Nome, Total_a_pagar, date FROM VENDAS ORDER By id DESC";            

            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter(QUERY, con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        private void TXT_FILTER_SEM_ESTOQUE_SelectedIndexChanged(object sender, EventArgs e)
        {
            TABLE_PRODUTOS_HOME.Refresh();
            TABLE_PRODUTOS_HOME.Update();
            TABLE_PRODUTOS_HOME.DataSource = SEARCH_PRODUCTS_SEM_ESTOQUE();
            CONFIG_TABLE_PRODUTOS();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LABEL_DATA.Text = DateTime.Now.ToLongDateString().ToUpper();
            LABEL_RELOGIO.Text = DateTime.Now.ToLongTimeString().ToUpper();
        }

        private void LABEL_RETURN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LABEL_CLOSE_Click(object sender, EventArgs e)
        {

        }
    }
}
