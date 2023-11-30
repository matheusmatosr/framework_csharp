using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace novo_projeto_anker
{
    internal class Banco
    {
        // Variável para armazenar a conexão com o Banco de Dados SQLite
        private static SQLiteConnection conexao;

        // Iniciar conexão com o Banco de Dados
        private static SQLiteConnection ConexaoBanco()
        {
            // Define e abre a conexão com o banco de dados SQLite
            conexao = new SQLiteConnection("Data Source=C:\\OneDrive-Personal\\Documentos\\novo_projeto_anker\\banco\\banco_projeto.db");
            conexao.Open();
            return conexao;
        }

        // Função para realizar consultas (select) no banco de dados
        public static DataTable dql(string sql, Dictionary<string, object> parametros = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;

                // Adicione os parâmetros, se existirem
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                // Preenche o DataTable com os resultados da consulta
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para realizar operações de modificação (insert, update, delete) no banco de dados
        public static void dml(string q, Dictionary<string, object> parametros = null, string msgOK = null, string msgERRO = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();

            try
            {
                cmd.CommandText = q;

                // Adicione os parâmetros, se existirem
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                // Executa a operação no banco de dados
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso, se fornecida
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro, se fornecida, e lança a exceção
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
            finally
            {
                // Garante que a conexão seja fechada, mesmo em caso de exceção
                if (vcon.State == ConnectionState.Open)
                {
                    vcon.Close();
                }
            }
        }

        // Função para obter todos os usuários do banco de dados
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Seleciona todos os usuários da tabela 'usuarios'
                cmd.CommandText = "SELECT * FROM usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para obter ID e nomes de todos os usuários
        public static DataTable ObterTodosUsuariosIdNomes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Seleciona ID e NOME da tabela 'usuarios'
                cmd.CommandText = "SELECT N_IDUSUARIO AS ID, T_NOMEUSUARIO AS NOME FROM usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para obter dados de um usuário específico pelo ID
        public static DataTable ObterDadosUsuários(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Seleciona todos os dados de um usuário específico pelo ID
                cmd.CommandText = "SELECT * FROM usuarios WHERE N_IDUSUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para atualizar os dados de um usuário no banco de dados
        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Atualiza os dados do usuário na tabela 'usuarios'
                cmd.CommandText = "UPDATE usuarios SET T_NOMEUSUARIO='" + u.nome + "', T_SENHA='" + u.senha + "', T_STATUSUSUARIO='" + u.status + "', N_NIVELUSUARIO=" + u.nivel + " WHERE N_IDUSUARIO=" + u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para deletar um usuário do banco de dados pelo ID
        public static void DeletarUsuario(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Deleta o usuário da tabela 'usuarios' pelo ID
                cmd.CommandText = "DELETE FROM usuarios WHERE N_IDUSUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Função para adicionar um novo usuário ao banco de dados
        public static void NovoUsuario(Usuario u)
        {
            // Verifica se o nome de usuário já existe
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                // Insere um novo usuário na tabela 'usuarios'
                cmd.CommandText = "INSERT INTO usuarios (T_NOMEUSUARIO, T_SENHA, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo usuário inserido com sucesso!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!");
            }
        }

        // Função para verificar se um nome de usuário já existe no banco de dados
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_NOMEUSUARIO FROM usuarios WHERE T_NOMEUSUARIO='" + u.nome + "' AND T_SENHA='" + u.senha + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);

            // Verifica se o resultado da consulta tem linhas (se o nome de usuário já existe)
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
    }
}

