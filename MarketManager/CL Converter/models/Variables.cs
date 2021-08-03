using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.models;

namespace MarketManager.models
{
    class Variables
    {
        // Produtos
        public String id { get; set; }
        public String NOME_PRODUTO_ADD { get; set; }
        public String SKU_PRODUTO_ADD { get; set; }
        public String IMAGEM_PRODUTO_ADD { get; set; }
        public String MARCA_PRODUTO_ADD { get; set; }
        public String VALOR_COMPRA_PRODUTO_ADD { get; set; }
        public String CODIGO_DE_BARRAS_ADD { get; set; }
        public String VALOR_VENDA_PRODUTO_ADD { get; set; }
        public String QUANTIDADE_PRODUTO_ADD { get; set; }
        public String DATE_PRODUTO_ADD { get; set; }
        public String SKU_VERIFY { get; set; }
        public String PROVEDOR { get; set; }

        // New Brand
        public String NEW_BRAND { get; set; }
        public String DATE_BRAND { get; set; }

        // Vendas
        public String NOME_VENDA_CLIENTE { get; set; }
        public String TOTAL_VENDA_CLIENTE { get; set; }
        public String DESCONTO_VENDA_CLIENTE { get; set; }
        public String QUANTIDADE_VENDA_CLIENTE { get; set; }
        public String COMPRAS_REALIZADAS { get; set; }
        public String TIPO_DE_VENDA { get; set; }

        // New Client
        public String NOME_ADD_CLIENTE { get; set; }
        public String CEP_ADD_CLIENTE { get; set; }
        public String TELEFONE_ADD_CLIENTE { get; set; }
        public String CPF_ADD_CLIENTE { get; set; }
        public String DATA_NASCIMENTO_ADD_CLIENTE { get; set; }
        public String RUA_ADD_CLIENTE { get; set; }
        public String NUMERO_CASA_ADD_CLIENTE { get; set; }
        public String BAIRRO_ADD_CLIENTE { get; set; }
        public String CIDADE_ADD_CLIENTE { get; set; }
        public String ESTADO_ADD_CLIENTE { get; set; }
        public String GENERO_ADD_CLIENTE { get; set; }
        public String COMPLEMENTO_ADD_CLIENTE { get; set; }
        public String EMAIL_ADD_CLIENTE { get; set; }
        public String CPF_VERYF { get; set; }

        // New Provedor
        public String NOME_ADD_PROVEDOR { get; set; }
        public String CEP_ADD_PROVEDOR { get; set; }
        public String TELEFONE_ADD_PROVEDOR { get; set; }
        public String CNPJ_ADD_PROVEDOR { get; set; }
        public String RUA_ADD_PROVEDOR { get; set; }
        public String NUMERO_CASA_ADD_PROVEDOR { get; set; }
        public String BAIRRO_ADD_PROVEDOR { get; set; }
        public String CIDADE_ADD_PROVEDOR { get; set; }
        public String ESTADO_ADD_PROVEDOR { get; set; }
        public String COMPLEMENTO_ADD_PROVEDOR { get; set; }
        public String EMAIL_ADD_PROVEDOR { get; set; }
        public String CNPJ_VERYF { get; set; }


    }
}
