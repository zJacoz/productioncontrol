using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProductionSystem
{
    public class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable dataTable;

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=!Jaco*998445!");
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS estoque; USE estoque", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS modelos " +
                    "(id integer auto_increment primary key, " +
                    "modelo char(20))", Conexao);
                Comando.ExecuteNonQuery();

                //Comando = new MySqlCommand("INSERT INTO modelos (modelo) VALUES ('Sacola TNT'), ('Saco C/ Visor'), " +
                //    "('Saco Fundo Falso'), ('Saquinho-Presente')", Conexao);
                //Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS alcas " +
                    "(id integer auto_increment primary key, " +
                    "modelo char(20))", Conexao);
                Comando.ExecuteNonQuery();

                //Comando = new MySqlCommand("INSERT INTO alcas (modelo) VALUES ('Sem alça'), ('Alça'), " +
                //    "('Cordão')", Conexao);
                //Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS estoque " +
                    "(id integer auto_increment primary key,    " +
                    "modelo char(20), " +
                    "silk char(08), " +
                    "cor char(20), " +
                    "altura char(03), " +
                    "largura char(03), " +
                    "modelo_alca char(20), " +
                    "cor_alca char(20), " +
                    "gramatura char(03), " +
                    "quantidade char(08), " +
                    "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS pedidos " +
                    "(id integer auto_increment primary key, " +
                    "cliente char(40), " +
                    "modelo char(20), " +
                    "silk varchar(100), " +
                    "cor char(20), " +
                    "altura char(03), " +
                    "largura char(03), " +
                    "modelo_alca char(20), " +
                    "quantidade char(08), " +
                    "data_pedido date, " +
                    "data_entrega date)", Conexao);
                Comando.ExecuteNonQuery();


                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable dql(string sql)
        {
                MySqlDataAdapter da = null;
                dataTable = new DataTable();
            try
            {
                var vcon = Conexao;
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dataTable);
                vcon.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
