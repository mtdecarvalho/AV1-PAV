using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Entidades
{
    public class Caixa : Entidade
    {
        public const string ATRIBUTO_ID_CAIXA = "ID_CAIXA";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_SALDO = "SALDO";

        public int id              { get; set; }
        public string nome              { get; set; }
        public double saldo             { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = id;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_SALDO].Value = saldo;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = id;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id = int.Parse(leitorDados[ATRIBUTO_ID_CAIXA].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            saldo = double.Parse(leitorDados[ATRIBUTO_SALDO].ToString());
        }
    }
}
