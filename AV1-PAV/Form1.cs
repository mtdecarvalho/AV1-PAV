using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AV1_PAV.Dados;

namespace AV1_PAV
{
    public partial class Form1 : Form
    {
        BancoDados bancoDados;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            BancoDados.obterInstancia().desconectar();
        }
    }
}
