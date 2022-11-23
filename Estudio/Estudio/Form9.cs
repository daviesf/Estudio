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
            cbDia.Enabled = false;
            cbHora.Enabled = false;
            btnExcluir.Enabled = false;
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
            cbDia.Items.Clear();
            cbHora.Items.Clear();
            cbHora.Text = String.Empty;
            cbDia.Text = String.Empty;
            btnExcluir.Enabled = false;
            cbHora.Enabled = false;
            cbDia.Enabled = true;
            Modalidade m = new Modalidade(cbModalidade.Text);
            Turma t = new Turma(m.buscaId());
            MySqlDataReader reader = t.buscaTurma1();
            while (reader.Read())
            {
                cbDia.Items.Add(reader["Dia_semana"]);
            }
            DAO_Conexao.con.Close();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHora.Items.Clear();
            cbHora.Text = String.Empty;
            btnExcluir.Enabled = false;
            cbHora.Enabled = true;
            Modalidade m = new Modalidade(cbModalidade.Text);
            Turma t = new Turma(m.buscaId(), cbDia.Text);
            MySqlDataReader reader = t.buscaTurma2();
            while (reader.Read())
            {
                cbHora.Items.Add(reader["Hora"]);
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(cbModalidade.Text);
            Turma t = new Turma(m.buscaId(), cbDia.Text, cbHora.Text);
            if (t.excluirTurma())
            {
                MessageBox.Show("Exclusão realizada com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbModalidade.Items.Clear();
                cbModalidade.Text = String.Empty;
                cbDia.Items.Clear();
                cbDia.Text = String.Empty;
                cbHora.Items.Clear();
                cbHora.Text = String.Empty;
                carregaCombo();
            }
            else
                MessageBox.Show("Erro de exclusão!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
        }
    }
}
