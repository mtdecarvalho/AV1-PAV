using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace AV1_PAV.Dados
{
    public abstract class Entidade
    {
            public abstract void transferirDados(MySqlCommand comando);
            public abstract void lerDados(MySqlCommand comando);
    }
}
