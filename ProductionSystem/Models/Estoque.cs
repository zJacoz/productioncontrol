﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProductionSystem.Models
{
    public class Estoque
    {
        public int id { get; set; }
        public int id_alca { get; set; }
        public int id_modelo { get; set; }
        public string modelo { get; set; }
        public string silk { get; set; }
        public string cor { get; set; }
        public string altura { get; set; }
        public string largura { get; set; }
        public string modelo_alca { get; set; }
        public string cor_alca { get; set; }
        public string foto { get; set; }
        public string quantidade { get; set; }
        public string gramatura { get; set; }

        public void Adicionar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("INSERT INTO estoque (modelo, silk, cor, altura, largura, modelo_alca, cor_alca, foto, gramatura, quantidade) " +
                    "VALUES (@modelo, @silk, @cor, @altura, @largura, @modelo_alca, @cor_alca, @foto, @gramatura, @quantidade)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@silk", silk);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@altura", altura);
                Banco.Comando.Parameters.AddWithValue("@largura", largura);
                Banco.Comando.Parameters.AddWithValue("@modelo_alca", modelo_alca);
                Banco.Comando.Parameters.AddWithValue("@cor_alca", cor_alca);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@gramatura", gramatura);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AdicionarAlca()
        {
            Banco.Conexao.Open();
            Banco.Comando = new MySqlCommand("INSERT INTO alcas (modelo) VALUES (@modelo)", Banco.Conexao);
            Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
            Banco.Comando.ExecuteNonQuery();
            Banco.Conexao.Close();
        }

        public void AdicionarModelo()
        {
            Banco.Conexao.Open();
            Banco.Comando = new MySqlCommand("INSERT INTO modelos (modelo) VALUES (@modelo)", Banco.Conexao);
            Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
            Banco.Comando.ExecuteNonQuery();
            Banco.Conexao.Close();
        }

        public void Alterar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("UPDATE estoque SET modelo = @modelo, silk = @silk, cor = @cor, altura = @altura, largura = @largura, modelo_alca = @modelo_alca, foto = @foto, quantidade = @quantidade WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@silk", silk);
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

        public void ExcluirAlca()
        {
            Banco.Conexao.Open();
            Banco.Comando = new MySqlCommand("DELETE FROM alcas WHERE id = @id", Banco.Conexao);
            Banco.Comando.Parameters.AddWithValue("@id", id_alca);
            Banco.Comando.ExecuteNonQuery();
            Banco.Conexao.Close();
        }

        public void ExcluirModelo()
        {
            Banco.Conexao.Open();
            Banco.Comando = new MySqlCommand("DELETE FROM modelos WHERE id = @id", Banco.Conexao);
            Banco.Comando.Parameters.AddWithValue("@id", id_modelo);
            Banco.Comando.ExecuteNonQuery();
            Banco.Conexao.Close();
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT * FROM estoque WHERE modelo like @modelo " +
                    "OR altura like @altura " +
                    "OR largura like @largura " +
                    "OR silk like @silk " +
                "ORDER BY modelo", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo + "%");
                Banco.Comando.Parameters.AddWithValue("@altura", altura + "%");
                Banco.Comando.Parameters.AddWithValue("@largura", largura + "%");
                Banco.Comando.Parameters.AddWithValue("@silk", silk + "%");
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
