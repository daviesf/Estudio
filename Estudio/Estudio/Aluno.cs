using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        #region
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email) {
            DAO_Conexao.getConexao("143.106.241.3", "cl201278", "cl201278", "cl*03082005");
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            // setFoto(foto);
        }

        public Aluno(string cpf)
        {
            this.CPF = cpf;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setEstado(string estado)
        {
            this.Estado = estado;
        }

        public string getEstado()
        {
            return Estado;
        }

        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setCEP(string cep)
        {
            this.CEP = cep;
        }

        public string getCEP()
        {
            return CEP;
        }

        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;
        }

        public string getComplemento()
        {
            return Complemento;
        }

        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setNumero(string numero)
        {
            this.Numero = numero;
        }

        public string getNumero()
        {
            return Numero;
        }

        public void setRua(string rua)
        {
            this.Rua = rua;
        }

        public string getRua()
        {
            return Rua;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public string getCPF()
        {
            return CPF;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno='" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read()) 
                    existe = true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Aluno SET ativo=1 WHERE CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
#endregion