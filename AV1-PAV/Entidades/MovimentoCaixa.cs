using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Entidades
{
    public class MovimentoCaixa : Entidade
    {
        public const string ATRIBUTO_ID_CAIXA = "ID_CAIXA";
        public const string ATRIBUTO_NUMERO_MOVIMENTO = "NUMERO_MOVIMENTO";
        public const string ATRIBUTO_ID_REFERENCIA = "ID_REFERENCIA";
        public const string ATRIBUTO_DATA_MOVIMENTO = "DATA_MOVIMENTO";
        public const string ATRIBUTO_HORA_MOVIMENTO = "HORA_MOVIMENTO";
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_TIPO_MOVIMENTO = "TIPO_MOVIMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";

        public int idCaixa             { get; set; }
        public int numeroMovimento      { get; set; }
        public int idReferencia         { get; set; }
        public string dataMovimento     { get; set; }
        public string horaMovimento     { get; set; }
        public string descricao         { get; set; }
        public string tipoMovimento     { get; set; }
        public double valor             { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
            comando.Parameters[ATRIBUTO_NUMERO_MOVIMENTO].Value = numeroMovimento;
            comando.Parameters[ATRIBUTO_ID_REFERENCIA].Value = idReferencia;
            comando.Parameters[ATRIBUTO_DATA_MOVIMENTO].Value = dataMovimento;
            comando.Parameters[ATRIBUTO_HORA_MOVIMENTO].Value = horaMovimento;
            comando.Parameters[ATRIBUTO_DESCRICAO].Value = descricao;
            comando.Parameters[ATRIBUTO_TIPO_MOVIMENTO].Value = tipoMovimento;
            comando.Parameters[ATRIBUTO_VALOR].Value = valor;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
            comando.Parameters[ATRIBUTO_NUMERO_MOVIMENTO].Value = numeroMovimento;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCaixa = int.Parse(leitorDados[ATRIBUTO_ID_CAIXA].ToString());
            numeroMovimento = int.Parse(leitorDados[ATRIBUTO_NUMERO_MOVIMENTO].ToString());
            idReferencia = int.Parse(leitorDados[ATRIBUTO_ID_REFERENCIA].ToString());
            dataMovimento = leitorDados[ATRIBUTO_DATA_MOVIMENTO].ToString();
            horaMovimento = leitorDados[ATRIBUTO_HORA_MOVIMENTO].ToString();
            descricao = leitorDados[ATRIBUTO_DESCRICAO].ToString();
            tipoMovimento = leitorDados[ATRIBUTO_TIPO_MOVIMENTO].ToString();
            valor = Double.Parse(leitorDados[ATRIBUTO_VALOR].ToString());
        }
    }
}
