using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1_PAV.Persistencia;

namespace AV1_PAV.Entidades
{
    public abstract class Conta : Entidade
    {
        
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_DATA_LANCAMENTO = "DATA_LANCAMENTO";
        public const string ATRIBUTO_DATA_VENCIMENTO = "DATA_VENCIMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";

       
        public string descricao { get; set; }
        public string dataLancamento { get; set; }
        public string dataVencimento { get; set; }
        public double valor { get; set; }

    }
}
