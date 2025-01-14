using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProductionSystem.Models
{
    public class Estoque
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string altura { get; set; }
        public string largura { get; set; }
        public string modelo_alca { get; set; }
        public string foto { get; set; }
        public string quantidade { get; set; }

        public void Adicionar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("INSERT INTO estoque (modelo, cor, altura, largura, modelo_alca, foto, quantidade) " +
                    "VALUES (@modelo, @cor, @altura, @largura, @modelo_alca, @foto, @quantidade)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@altura", altura);
                Banco.Comando.Parameters.AddWithValue("@largura", largura);
                Banco.Comando.Parameters.AddWithValue("@modelo_alca", modelo_alca);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("UPDATE estoque SET modelo = @modelo, cor = @cor, altura = @altura, largura = @largura, modelo_alca = @modelo_alca, foto = @foto, quantidade = @quantidade WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@altura", altura);
                Banco.Comando.Parameters.AddWithValue("@largura", largura);
                Banco.Comando.Parameters.AddWithValue("@modelo_alca", modelo_alca);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IncDec()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("UPDATE estoque SET quantidade = @quantidade WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("DELETE FROM estoque WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT * FROM estoque WHERE modelo LIKE @modelo " +
                "ORDER BY modelo", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.dataTable = new DataTable();
                Banco.Adaptador.Fill(Banco.dataTable);
                Banco.FecharConexao();
                return Banco.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
