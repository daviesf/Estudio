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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estudio
{
    public partial class Cad_Turma : Form
    {
        public Cad_Turma()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text);
            MySqlDataReader r = m.consultarModalidade();
            r.Read();
            txtDesc.Text = r["descricaoModalidade"].ToString();
            DAO_Conexao.con.Close();
        }
    }
}
