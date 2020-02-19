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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tela = new FrmProdutos();
            tela.MdiParent = this;
            tela.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tela = new FrmFornecedores();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var tela = new FrmProdutos();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var tela = new FrmFornecedores();
            tela.MdiParent = this;
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
