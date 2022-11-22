using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        int id_modalidade;
        String professor;
        String dia_semana;
        String hora;

        public Turma(int id_modalidade, string professor, string dia_semana, string hora)
        {
            this.id_modalidade = id_modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }

        public Turma(int id_modalidade)
        {
            this.id_modalidade = id_modalidade;
        }

        public Turma(int id_modalidade, string dia_semana)
        {
            this.dia_semana = dia_semana;
            this.id_modalidade = id_modalidade;
        }

        public Turma(int id_modalidade, string dia_semana, string hora)
        {
            this.id_modalidade = id_modalidade;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }

        public int Id_modalidade { get => id_modalidade; set => id_modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }

        public bool cadastrarTurma()
        {
            bool cd = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Turma (id_modalidade, Professor, Dia_semana, Hora) VALUES ('" + id_modalidade + "','" + professor + "','" + dia_semana + "','" + hora + "')", DAO_Conexao.con);
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

        public bool excluirTurma()
        {
            bool cd = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("DELETE FROM Estudio_Turma WHERE id_modalidade=" + id_modalidade + " AND Dia_semana like '" + dia_semana + "' AND Hora like '" + hora + "'", DAO_Conexao.con);
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

        public MySqlDataReader buscaTurma1()
        {
            MySqlDataReader res = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE id_modalidade=" + id_modalidade + "", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }

        public MySqlDataReader buscaTurma2()
        {
            MySqlDataReader res = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE id_modalidade=" + id_modalidade + " AND Dia_semana like '" + dia_semana + "'", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }
    }
}
