using MySql.Data.MySqlClient;
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
    public partial class excModalidade : Form
    {
        public excModalidade()
        {
            InitializeComponent();
            carregaCombo();
        }

        public void carregaCombo()
        {
            Modalidade m = new Modalidade();
            MySqlDataReader r = m.consultarTodasModalidade();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void excModalidade_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text);
            if (m.excluirModalidade())
                MessageBox.Show("Exclusão realizada com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro de exclusão!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
