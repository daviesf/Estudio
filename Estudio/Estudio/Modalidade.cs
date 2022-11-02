using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {

        private String Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            Descricao = descricao;
            Preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            Descricao = descricao;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool cd = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) VALUES ('" + Descricao + "'," + Preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
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

        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader res = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            MySqlDataReader res = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE ativa=0 ORDER BY descricaoModalidade", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }

        public bool atualizarModalidade()
        {
            bool flag = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand att = new MySqlCommand("UPDATE Estudio_Modalidade SET precoModalidade =" + Preco + ", qtdeAlunos =" + qtde_alunos + ", qtdeAulas = " + qtde_aulas + " WHERE descricaoModalidade like '" + Descricao + "'", DAO_Conexao.con);
                att.ExecuteNonQuery();
                flag = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
            } finally
            {
                DAO_Conexao.con.Close();
            }
            return flag;
        }

        public bool excluirModalidade()
        {
            bool flag = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Modalidade SET ativa=1 WHERE descricaoModalidade like '" + Descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return flag;
        }
    }
}
