using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class ContaReceber : Entidade
    {
        public const string ATRIBUTO_ID_CONTA_RECEBER = "ID_CONTA_RECEBER";
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_DATA_LANCAMENTO = "DATA_LANCAMENTO";
        public const string ATRIBUTO_DATA_VENCIMENTO = "DATA_VENCIMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";
        public const string ATRIBUTO_RECEBIDO = "RECEBIDO";
        public const string ATRIBUTO_DATA_RECEBIMENTO = "DATA_RECEBIMENTO";
        public const string ATRIBUTO_VALOR_RECEBIMENTO = "VALOR_RECEBIMENTO";

        private int idContaReceber;
        private string descricao;
        private int idCliente;
        private string dataLancamento;
        private string dataVencimento;
        private double valor;
        private string recebido;
        private string dataRecebimento;
        private double valorRecebimento;

        public int getIdContaRecebr()                               { return idContaReceber;                        }
        public string getDescricao()                                { return descricao;                             }
        public int getIdCliente()                                   { return idCliente;                             }
        public string getDataLancamento()                           { return dataLancamento;                        }
        public string getDataVencimento()                           { return dataVencimento;                        }
        public double getValor()                                    { return valor;                                 }
        public string getRecebido()                                 { return recebido;                              }
        public string getDataRecebimento()                          { return dataRecebimento;                       }
        public double getValorRecebimento()                         { return valorRecebimento;                      }

        public void setIdContaReceber(int idContaReceber)           { this.idContaReceber = idContaReceber;         }
        public void setDescricao(string descricao)                  { this.descricao = descricao;                   }
        public void setIdCliente(int idCliente)                     { this.idCliente = idCliente;                   }
        public void setDataLancamento(string dataLancamento)        { this.dataLancamento = dataLancamento;         }
        public void setDataVencimento(string dataVencimento)        { this.dataVencimento = dataVencimento;         }
        public void setValor(double valor)                          { this.valor = valor;                           }
        public void setRecebido(string recebido)                    { this.recebido = recebido;                     }
        public void setDataRecebimento(string dataRecebimento)      { this.dataRecebimento = dataRecebimento;       }
        public void setValorRecebimento(double valorRecebimento)    { this.valorRecebimento = valorRecebimento;     }

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
            valorRecebimento = double.Parse(leitorDados[ATRIBUTO_VALOR_RECEBIMENTO].ToString());
        }
    }
}
