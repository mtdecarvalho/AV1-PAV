﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class ContaReceber : Conta
    {
        public const string ATRIBUTO_ID_CONTA_RECEBER = "ID_CONTA_RECEBER";
        public const string ATRIBUTO_RECEBIDO = "RECEBIDO";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_DATA_RECEBIMENTO = "DATA_RECEBIMENTO";
        public const string ATRIBUTO_VALOR_RECEBIMENTO = "VALOR_RECEBIMENTO";

        public int idContaReceber                               { get; set; }
        public int idCliente                                    { get; set; }
        public string recebido                                  { get; set; }
        public string dataRecebimento                           { get; set; }
        public double valorRecebimento                          { get; set; }


        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = idContaReceber;
            comando.Parameters[ATRIBUTO_DESCRICAO].Value = descricao;
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_DATA_LANCAMENTO].Value = dataLancamento;
            comando.Parameters[ATRIBUTO_DATA_VENCIMENTO].Value = dataVencimento;
            comando.Parameters[ATRIBUTO_VALOR].Value = valor;
            comando.Parameters[ATRIBUTO_RECEBIDO].Value = recebido;
            comando.Parameters[ATRIBUTO_DATA_RECEBIMENTO].Value = dataRecebimento;
            comando.Parameters[ATRIBUTO_VALOR_RECEBIMENTO].Value = valorRecebimento;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = idContaReceber;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idContaReceber = int.Parse(leitorDados[ATRIBUTO_ID_CONTA_RECEBER].ToString());
            descricao = leitorDados[ATRIBUTO_DESCRICAO].ToString();
            idCliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            dataLancamento = leitorDados[ATRIBUTO_DATA_LANCAMENTO].ToString();
            dataVencimento = leitorDados[ATRIBUTO_DATA_VENCIMENTO].ToString();
            valor = double.Parse(leitorDados[ATRIBUTO_VALOR].ToString());
            recebido = leitorDados[ATRIBUTO_RECEBIDO].ToString();
            dataRecebimento = leitorDados[ATRIBUTO_DATA_RECEBIMENTO].ToString();
            if (leitorDados[ATRIBUTO_VALOR_RECEBIMENTO].ToString() != "")
                valorRecebimento = double.Parse(leitorDados[ATRIBUTO_VALOR_RECEBIMENTO].ToString());
            else
                valorRecebimento = 0;
        }
    }
}
