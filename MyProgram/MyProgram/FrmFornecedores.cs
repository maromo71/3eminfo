using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class FrmFornecedores: Form
    {
        //Definir a Collection (Coleção)
        ICollection<Fornecedor> lista;
        public FrmFornecedores()
        {
            InitializeComponent();
            //Carregar a grade
            lista = new List<Fornecedor>();
            dataGridFornecedores.DataSource = lista;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();
            fornecedor.IdForn = int.Parse(txtIdForn.Text);
            fornecedor.NomeFornecedor = txtNomeFornecedor.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Contato = txtContato.Text;
            lista.Add(fornecedor);
            dataGridFornecedores.DataSource = null;
            dataGridFornecedores.DataSource = lista;
            //Limpar a tela
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox texto = (TextBox)item;
                    texto.Text = "";
                }
            }
        }
    }
}
