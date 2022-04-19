using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class Venda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_DATA = "DATA";
        public const string ATRIBUTO_HORA = "HORA";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_TOTAL_VENDA = "TOTAL_VENDA";
        public const string ATRIBUTO_SITUACAO_VENDA = "SITUACAO_VENDA";

        public int idVenda                             { get; set; }
        public string data                             { get; set; }
        public string hora                             { get; set; }
        public int idCliente                           { get; set; }
        public double totalVenda                       { get; set; }
        public string situacaoVenda                    { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_DATA].Value = data;
            comando.Parameters[ATRIBUTO_HORA].Value = hora;
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_TOTAL_VENDA].Value = totalVenda;
            comando.Parameters[ATRIBUTO_SITUACAO_VENDA].Value = situacaoVenda;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idVenda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            data = leitorDados[ATRIBUTO_DATA].ToString();
            hora = leitorDados[ATRIBUTO_HORA].ToString();
            idCliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            totalVenda = double.Parse(leitorDados[ATRIBUTO_TOTAL_VENDA].ToString());
            situacaoVenda = leitorDados[ATRIBUTO_SITUACAO_VENDA].ToString();
        }
    }
}
