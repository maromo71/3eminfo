using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCombo
{
    public partial class Form1 : Form
    {
        public ICollection<Cliente> listaClientes;

        public Form1()
        {
            InitializeComponent();
            //buscar a lista no banco
            listaClientes = new List<Cliente>();
            var cli = new Cliente();
            cli.Id = 1;
            cli.Nome = "Oscar";
            cli.Telefone = "11111";
            var cli2 = new Cliente();
            cli2.Id = 2;
            cli2.Nome = "Maria";
            cli2.Telefone = "333333";
            listaClientes.Add(cli);
            listaClientes.Add(cli2);

            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //varrer a lista e jogar o nome do cliente
            //no combobox1
            foreach (var item in listaClientes)
            {
                comboBox1.Items.Add(item.Nome);
            }
        }
    }
}
