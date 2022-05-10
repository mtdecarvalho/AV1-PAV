using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Entidades
{
    public abstract class Transacao : Entidade
    {
        public const string ATRIBUTO_DATA = "DATA";
        public const string ATRIBUTO_HORA = "HORA";

        public string data { get; set; }
        public string hora { get; set; }

    }
}