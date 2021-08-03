using MarketManager.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using MarketManager;
using System.Windows;
using System.Windows.Forms;

namespace MarketManager.models
{
    class ADD
    {
        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        // NEW BRAND
        public static bool NEW_BRAND(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_BRAND = "INSERT INTO [MARCAS] (Nome, Date) VALUES (@Nome, @Date)";

            SqlCeCommand NEW_BRAND = new SqlCeCommand(INSERT_NEW_BRAND, con);
            NEW_BRAND.Parameters.AddWithValue("@Nome", add.NEW_BRAND.ToString().ToUpper());
            NEW_BRAND.Parameters.AddWithValue("@Date", add.DATE_BRAND);
            con.Close();
            con.Open();

            if (NEW_BRAND.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cadastro da Marca realizada com sucesso!");
                con.Close();
                return true;

            }
            else
            {
                MessageBox.Show("Cadastro da Marca não realizada!");

                con.Close();


                return false;

            }
        }

        // NEW PRODUCT
        public static bool NEW_PRODUCT(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_BRAND = "INSERT INTO [produto] (Nome, SKU, QTD, Marca, V_Compra, V_Venda, Img, Date, SN, Provedor) VALUES (@Nome, @SKU, @QTD, @Marca, @V_Compra, @V_Venda, @Img, @Date, @SN, @Provedor)";

            SqlCeCommand NEW_BRAND = new SqlCeCommand(INSERT_NEW_BRAND, con);
            NEW_BRAND.Parameters.AddWithValue("@Nome", add.NOME_PRODUTO_ADD.ToString().ToUpper());
            NEW_BRAND.Parameters.AddWithValue("@SKU", add.SKU_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@QTD", add.QUANTIDADE_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Marca", add.MARCA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@V_Compra", add.VALOR_COMPRA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@V_Venda", add.VALOR_VENDA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Img", add.IMAGEM_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Date", add.DATE_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@SN", add.CODIGO_DE_BARRAS_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Provedor", add.PROVEDOR);

            con.Close();
            con.Open();

            if (NEW_BRAND.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cadastro de Produto realizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Cadastro de Produto não realizado!");
                con.Close();
                return false;
            }
        }

        // EDIT PRODUCT
        public static bool EDIT_PRODUCT(Variables add)
        {
     
            con.Close();
            con.Open();
            int SKU_VERY = Convert.ToInt32(add.SKU_VERIFY);
            string INSERT_NEW_BRAND = "update produto set Nome = @Nome, SKU = @SKU, QTD = @QTD, Marca = @Marca, V_Compra = @V_Compra, V_Venda = @V_Venda, Img = @Img, Date = @Date, SN = @SN, Provedor = @Provedor WHERE SKU = '" + SKU_VERY + "' ";

            SqlCeCommand NEW_BRAND = new SqlCeCommand(INSERT_NEW_BRAND, con);
            NEW_BRAND.Parameters.AddWithValue("@Nome", add.NOME_PRODUTO_ADD.ToString().ToUpper());
            NEW_BRAND.Parameters.AddWithValue("@SKU", add.SKU_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@QTD", add.QUANTIDADE_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Marca", add.MARCA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@V_Compra", add.VALOR_COMPRA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@V_Venda", add.VALOR_VENDA_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Img", add.IMAGEM_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Date", add.DATE_PRODUTO_ADD);
            NEW_BRAND.Parameters.AddWithValue("@SN", add.CODIGO_DE_BARRAS_ADD);
            NEW_BRAND.Parameters.AddWithValue("@Provedor", add.PROVEDOR);

            con.Close();
            con.Open();

            if (NEW_BRAND.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Produto não atualizado!");
                con.Close();
                return false;
            }
        }

        // DELETAR FOTO
        public static bool DELETE_FOTO(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_BRAND = "update produto set Img = @Img";

            SqlCeCommand NEW_BRAND = new SqlCeCommand(INSERT_NEW_BRAND, con);
            NEW_BRAND.Parameters.AddWithValue("@Img", add.IMAGEM_PRODUTO_ADD.ToString().ToUpper());
            
            con.Close();
            con.Open();

            if (NEW_BRAND.ExecuteNonQuery() > 0)
            {
                //MessageBox.Show("Foto Excluida com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                //MessageBox.Show("Produto não pode ser excluida!");
                con.Close();
                return false;
            }
        }

        // NEW VENDA FIDELIDADE
        public static bool NEW_VENDA(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_VENDA = "INSERT INTO [VENDAS] (Nome, Total_a_pagar, Desconto, Quantidade_itens, date, ComprasRealizadas, TipoDeVenda) VALUES (@Nome, @Total_a_pagar, @Desconto, @Quantidade_itens, @date, @ComprasRealziadas, @TipoDeVenda)";

            SqlCeCommand NEW_VENDA = new SqlCeCommand(INSERT_NEW_VENDA, con);
            NEW_VENDA.Parameters.AddWithValue("@Nome", add.NOME_VENDA_CLIENTE.ToString().ToUpper());
            NEW_VENDA.Parameters.AddWithValue("@Total_a_pagar", add.TOTAL_VENDA_CLIENTE);
            NEW_VENDA.Parameters.AddWithValue("@Desconto", add.DESCONTO_VENDA_CLIENTE);
            NEW_VENDA.Parameters.AddWithValue("@Quantidade_itens", add.QUANTIDADE_VENDA_CLIENTE);       
            NEW_VENDA.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());       
            NEW_VENDA.Parameters.AddWithValue("@ComprasRealziadas", 1);       
            NEW_VENDA.Parameters.AddWithValue("@TipoDeVenda", add.TIPO_DE_VENDA);       

            con.Close();
            con.Open();

            if (NEW_VENDA.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Venda realizada com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Venda não realizada!");
                con.Close();
                return false;
            }
        }
        public static bool NEW_VENDA_NAO_FIDELIDADE(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_VENDA_NAO_FIDELIDADE = "INSERT INTO [VENDAS] (Nome, Total_a_pagar, Desconto, Quantidade_itens, date, ComprasRealizadas, TipoDeVenda) VALUES (@Nome, @Total_a_pagar, @Desconto, @Quantidade_itens, @date, @ComprasRealziadas, @TipoDeVenda)";

            SqlCeCommand NEW_VENDA_NAO_FIDELIDADE = new SqlCeCommand(INSERT_NEW_VENDA_NAO_FIDELIDADE, con);
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@Nome", add.NOME_VENDA_CLIENTE.ToString().ToUpper());
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@Total_a_pagar", add.TOTAL_VENDA_CLIENTE);
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@Desconto", add.DESCONTO_VENDA_CLIENTE);
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@Quantidade_itens", add.QUANTIDADE_VENDA_CLIENTE);
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@ComprasRealziadas", 1);
            NEW_VENDA_NAO_FIDELIDADE.Parameters.AddWithValue("@TipoDeVenda", add.TIPO_DE_VENDA);

            con.Close();
            con.Open();

            if (NEW_VENDA_NAO_FIDELIDADE.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Venda realizada com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Venda não realizada!");
                con.Close();
                return false;
            }
        }


        // NEW CLIENTE
        public static bool NEW_CLIENT(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_CLIENT= "INSERT INTO [CLIENT] (" +
                "Nome, " +
                "CEP, " +
                "Telefone, " +
                "CPF, " +
                "Data_Nascimento, " +
                "Rua, " +
                "N_Casa, " +
                "Bairro, " +
                "Cidade, " +
                "Estado, " +
                "Genero, " +
                "Complemento, " +
                "Email, " +
                "DateCadastro) " +
                "VALUES (" +                
                "@Nome, " +
                "@CEP, " +
                "@Telefone, " +
                "@CPF, " +
                "@Data_Nascimento, " +
                "@Rua, " +
                "@N_Casa, " +
                "@Bairro, " +
                "@Cidade, " +
                "@Estado, " +
                "@Genero, " +
                "@Complemento, " +
                "@Email, " +
                "@DateCadastro)";

            SqlCeCommand NEW_CLIENT = new SqlCeCommand(INSERT_NEW_CLIENT, con);
            NEW_CLIENT.Parameters.AddWithValue("@Nome", add.NOME_ADD_CLIENTE.ToString().ToUpper());
            NEW_CLIENT.Parameters.AddWithValue("@CEP", add.CEP_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Telefone", add.TELEFONE_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@CPF", add.CPF_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Data_Nascimento", add.DATA_NASCIMENTO_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Rua", add.RUA_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@N_Casa", add.NUMERO_CASA_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Bairro", add.BAIRRO_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Cidade", add.CIDADE_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Estado", add.ESTADO_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Genero", add.GENERO_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Complemento", add.COMPLEMENTO_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@Email", add.EMAIL_ADD_CLIENTE);
            NEW_CLIENT.Parameters.AddWithValue("@DateCadastro", DateTime.Now.ToLongDateString());

            con.Close();
            con.Open();

            if (NEW_CLIENT.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cadastro de cliente realizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
                con.Close();
                return false;
            }
        }

        // EDIT CLIENTE
        public static bool EDIT_PACIENTE(Variables add)
        {
            con.Close();
            con.Open();
            string CPF_VERY = Convert.ToString(add.CPF_VERYF);
            string UPDATE_CLIENTE = "update CLIENT set " +
                "Nome = @Nome, " +
                "CEP = @CEP, " +
                "Telefone = @Telefone, " +
                "CPF = @CPF, " +
                "Data_Nascimento = @Data_Nascimento, " +
                "Rua = @Rua, " +
                "N_Casa = @N_Casa, " +
                "Bairro = @Bairro, " +
                "Cidade = @Cidade, " +
                "Estado = @Estado, " +
                "Genero = @Genero, " +
                "Complemento = @Complemento, " +
                "Email = @Email, " +
                "DateCadastro = @DateCadastro WHERE CPF = '" + CPF_VERY + "' ";

            SqlCeCommand UC = new SqlCeCommand(UPDATE_CLIENTE, con);
            UC.Parameters.AddWithValue("@Nome", add.NOME_ADD_CLIENTE.ToString().ToUpper());
            UC.Parameters.AddWithValue("@CEP", add.CEP_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Telefone", add.TELEFONE_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@CPF", add.CPF_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Data_Nascimento", add.DATA_NASCIMENTO_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Rua", add.RUA_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@N_Casa", add.NUMERO_CASA_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Bairro", add.BAIRRO_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Cidade", add.CIDADE_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Estado", add.ESTADO_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Genero", add.GENERO_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Complemento", add.COMPLEMENTO_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@Email", add.EMAIL_ADD_CLIENTE);
            UC.Parameters.AddWithValue("@DateCadastro", DateTime.Now.ToLongDateString());

            con.Close();
            con.Open();

            if (UC.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Paciente atualizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Paciente não atualizado!");
                con.Close();
                return false;
            }
        }

        // NEW PROVEDOR
        public static bool NEW_PROVEDOR(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_PROVEDOR = "INSERT INTO [PROVEDORES] (" +
                "Nome, " +
                "Telefone, " +
                "Email, " +
                "N_Endereco, " +
                "Endereco, " +
                "Cidade, " +
                "Estado, " +
                "CNPJ, " +
                "Bairro, " +
                "Complemento, " +
                "CEP, " +
                "date) " +
                "VALUES (" +
                "@Nome, " +
                "@Telefone, " +
                "@Email, " +
                "@N_Endereco, " +
                "@Endereco, " +
                "@Cidade, " +
                "@Estado, " +
                "@CNPJ, " +
                "@Bairro, " +
                "@Complemento, " +
                "@CEP, " +
                "@date)";

            SqlCeCommand NEW_PROVEDOR = new SqlCeCommand(INSERT_NEW_PROVEDOR, con);
            NEW_PROVEDOR.Parameters.AddWithValue("@Nome", add.NOME_ADD_PROVEDOR.ToString().ToUpper());
            NEW_PROVEDOR.Parameters.AddWithValue("@CEP", add.CEP_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Telefone", add.TELEFONE_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@CNPJ", add.CNPJ_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Endereco", add.RUA_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@N_Endereco", add.NUMERO_CASA_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Bairro", add.BAIRRO_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Cidade", add.CIDADE_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Estado", add.ESTADO_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Complemento", add.COMPLEMENTO_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@Email", add.EMAIL_ADD_PROVEDOR);
            NEW_PROVEDOR.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());

            con.Close();
            con.Open();

            if (NEW_PROVEDOR.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cadastro de provedor realizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
                con.Close();
                return false;
            }
        }

        // EDIT PROVEDOR
        public static bool EDIT_PROVEDOR(Variables add)
        {
            con.Close();
            con.Open();
            string CNPJ_VERY = Convert.ToString(add.CNPJ_VERYF);
            string UPDATE_PROVEDOR = "update PROVEDORES set " +
                "Nome = @Nome, " +
                "Telefone = @Telefone, " +
                "Email = @Email, " +
                "N_Endereco = @N_Endereco, " +
                "Endereco = @Endereco, " +
                "Cidade = @Cidade, " +
                "Estado = @Estado, " +
                "CNPJ = @CNPJ, " +
                "Bairro = @Bairro, " +
                "Complemento = @Complemento, " +
                "CEP = @CEP, " +
                "date = @date WHERE CNPJ = '" + CNPJ_VERY + "' ";

            SqlCeCommand UP = new SqlCeCommand(UPDATE_PROVEDOR, con);
            UP.Parameters.AddWithValue("@Nome", add.NOME_ADD_PROVEDOR.ToString().ToUpper());
            UP.Parameters.AddWithValue("@CEP", add.CEP_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Telefone", add.TELEFONE_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@CNPJ", add.CNPJ_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Endereco", add.RUA_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@N_Endereco", add.NUMERO_CASA_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Bairro", add.BAIRRO_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Cidade", add.CIDADE_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Estado", add.ESTADO_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Complemento", add.COMPLEMENTO_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@Email", add.EMAIL_ADD_PROVEDOR);
            UP.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());

            con.Close();
            con.Open();

            if (UP.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Provedor atualizado com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Provedor não atualizado!");
                con.Close();
                return false;
            }
        }

    }
}
