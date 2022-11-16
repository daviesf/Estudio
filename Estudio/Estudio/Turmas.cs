using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turmas
    {
        int id_turma;
        int id_modalidade;
        String professor;
        String dia_semana;
        String hora;
        int n_alunos_matriculados;
        int ativo;

        public Turmas(int id_turma, int id_modalidade, string professor, string dia_semana, string hora, int n_alunos_matriculados, int ativo)
        {
            this.id_turma = id_turma;
            this.id_modalidade = id_modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.n_alunos_matriculados = n_alunos_matriculados;
            this.ativo = ativo;
        }

        public Turmas(int id_modalidade)
        {
            this.id_modalidade = id_modalidade;
        }

        public Turmas(int id_modalidade, string dia_semana)
        {
            this.dia_semana = dia_semana;
            this.id_modalidade = id_modalidade;
        }

        public int Id_turma { get => id_turma; set => id_turma = value; }
        public int Id_modalidade { get => id_modalidade; set => id_modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int N_alunos_matriculados { get => n_alunos_matriculados; set => n_alunos_matriculados = value; }
        public int Ativo { get => ativo; set => ativo = value; }

        public bool cadastrarTurma()
        {
            bool cd = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Turma (id_turma, id_modalidade, dia_semana, hora, n_alunos_matriculados) VALUES ('" + Id_turma + "'," + Id_modalidade + "," + Professor + "," + Dia_semana + "," + Hora + "," + N_alunos_matriculados +")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cd = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cd;
        }
    }
}
