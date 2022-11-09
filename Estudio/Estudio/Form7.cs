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
    public partial class consModalidade : Form
    {
        public consModalidade()
        {
            InitializeComponent();
            carregaCombo();
            this.Text = "Estúdio - [Atualizar Modalidade]";
        }

        public consModalidade(int a)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button1.Visible = false;
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

        private void consModalidade_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text);
            MySqlDataReader r = m.consultarModalidade();
            r.Read();
            textBox1.Text = r["precoModalidade"].ToString();
            textBox2.Text = r["qtdeAlunos"].ToString();
            textBox3.Text = r["qtdeAulas"].ToString();
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text, float.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            if(m.atualizarModalidade())
                MessageBox.Show("Atualizado com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro de atualização!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
