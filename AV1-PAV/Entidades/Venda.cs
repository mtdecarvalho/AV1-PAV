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

        private int idVenda;
        private string data;
        private string hora;
        private int idCliente;
        private double totalVenda;
        private string situacaoVenda;

        public int getIdVenda()                             { return idVenda;                       }
        public string getData()                             { return data;                          }
        public string getHora()                             { return hora;                          }
        public int getIdCliente()                           { return idCliente;                     }
        public double getTotalVenda()                       { return totalVenda;                    }
        public string getSituacaoVenda()                    { return situacaoVenda;                 }

        public void setIdVenda(int idVenda)                 { this.idVenda = idVenda;               }
        public void setData(string data)                    { this.data = data;                     }
        public void setHora(string hora)                    { this.hora = hora;                     }
        public void setIdCliente(int idCliente)             { this.idCliente = idCliente;           }
        public void setTotalVenda(double totalVenda)        { this.totalVenda = totalVenda;         }
        public void setSituacaoVenda(string situacaoVenda)  { this.situacaoVenda = situacaoVenda;   }

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
