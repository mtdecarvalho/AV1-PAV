using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1_PAV.Persistencia;

namespace AV1_PAV.Entidades
{
    public abstract class Item : Entidade
    {
        public const string ATRIBUTO_NUMERO_ITEM = "NUMERO_ITEM";
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_QUANTIDADE = "QUANTIDADE";
        public const string ATRIBUTO_VALOR_UNITARIO = "VALOR_UNITARIO";
        public const string ATRIBUTO_TOTAL_ITEM = "TOTAL_ITEM";

        public int numeroItem { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public double totalItem { get; set; }

    }
}
