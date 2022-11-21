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
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
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
                cbModalidade.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void ExcluirTurma_Load(object sender, EventArgs e)
        {

        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
