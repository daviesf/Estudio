using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201278", "cl201278", "cl*03082005"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtUser.Text, txtPsw.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
            }
        }
    }
}
