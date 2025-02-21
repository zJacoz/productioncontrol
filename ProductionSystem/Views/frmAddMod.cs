using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProductionSystem.Models;

namespace ProductionSystem.Views
{
    public partial class frmAddMod : Form
    {
        Estoque es;
        frmMenu me = new frmMenu();

       

        public frmAddMod()
        {
            InitializeComponent();
            atualizarGrid();
        }

        public void atualizarGrid()
        {
            string sqlstm = "SELECT * FROM modelos";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, Banco.Conexao);
            DataSet DS = new();
            SDA.Fill(DS, "modelos");
            dgvModelo.DataSource = DS.Tables[0];
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtAddMod.Text == String.Empty)
            {
                MessageBox.Show("Insira um modelo de alça para adicionar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                es = new Estoque()
                {
                    modelo = txtAddMod.Text
                };
                es.AdicionarModelo();
                atualizarGrid();
                txtAddMod.Clear();
                me.atualizaModelos();

                MessageBox.Show("Modelo de alça adicionado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvModelo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModelo.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgvModelo.Columns)
            {
                switch (col.Name)
                {
                    case "modelo":
                        col.HeaderText = "Modelo";
                        col.Width = 180;
                        break;
                    case "excluir":
                        col.Width = 51;
                        col.DisplayIndex = 2;
                        col.HeaderText = "Excluir";
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void dgvModelo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvModelo.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModelo.Columns[e.ColumnIndex] == dgvModelo.Columns["excluir"])
            {
                if (MessageBox.Show("Deseja excluir essa linha?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    es = new Estoque()
                    {
                        id_modelo = Convert.ToInt32(dgvModelo.CurrentRow.Cells["id"].Value.ToString())
                    };
                    es.ExcluirModelo();

                    atualizarGrid();
                }
            }
        }
    }
}
