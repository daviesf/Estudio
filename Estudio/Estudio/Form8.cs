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
        public static int id;
        public Cad_Turma()
        {
            InitializeComponent();
            carregaCombo();
            id = 0;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public String giveSplit()
        {
            String toret="";
            if (chSegunda.Checked == true)
                toret = toret + "Segunda,";
            if (chTerca.Checked == true)
                toret = toret + "Terça,";
            if (chQuarta.Checked == true)
                toret = toret + "Quarta,";
            if (chQuinta.Checked == true)
                toret = toret + "Quinta,";
            if (chSexta.Checked == true)
                toret = toret + "Sexta,";
            if (chSabado.Checked == true)
                toret = toret + "Sábado,";
            if (chDomingo.Checked == true)
                toret = toret + "Domingo,";
            String[] words = toret.Split(',');
            toret = "a[-+";
            foreach (var word in words)
            {
                toret = toret + ", " + word;
            }
            toret = toret + "wd+!";
            toret = toret.Replace("a[-+, ","");
            toret = toret.Replace(", wd+!", "");
            return toret;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String semana;
            semana = giveSplit();

            if (id == -1)
            {
                MessageBox.Show("Modalidade inválida.");
            }
            else
            {
                Turma t = new Turma(id, txtProfessor.Text, semana, dtpHora.Text);
                if (t.cadastrarTurma())
                {
                    MessageBox.Show("Cadastro feito com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProfessor.Clear();
                    chDomingo.Checked = false;
                    chSegunda.Checked = false;
                    chTerca.Checked = false;
                    chQuarta.Checked = false;
                    chQuinta.Checked = false;
                    chSexta.Checked = false;
                    chSabado.Checked = false;
                }
                else
                    MessageBox.Show("Erro de cadastro!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(cbModalidade.Text);
            int a = m.buscaId();
            if (a == -1)
            {
                MessageBox.Show("Erro interno. (ID não encontrado)", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                id = a;
            }
        }

        private void Cad_Turma_Load(object sender, EventArgs e)
        {

        }
    }
}
