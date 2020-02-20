using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir a caixa de "Abrir Arquivo"
            openFileDialog1.Filter = "Todas as Imagens (*.png)|*.png|Todos os Arquivos|*.*";
            openFileDialog1.ShowDialog();
            //Para ajustar a figura ao tamanho do controle
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //Selecionar uma imagem.
            pictureBox1.ImageLocation = openFileDialog1.FileName.ToString();
        }
    }
}
