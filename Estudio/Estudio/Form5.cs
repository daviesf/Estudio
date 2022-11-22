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
    public partial class cadModalidade : Form
    {
        public cadModalidade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(txtDesc.Text, float.Parse(txtPreco.Text), int.Parse(txtAluno.Text), int.Parse(txtAula.Text));
            if (mod.cadastrarModalidade())
            {
                MessageBox.Show("Cadastro feito com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAluno.Clear();
                txtAula.Clear();
                txtDesc.Clear();
                txtPreco.Clear();
                txtDesc.Focus();
            }
            else
                MessageBox.Show("Erro de cadastro!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
