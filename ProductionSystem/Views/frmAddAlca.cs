using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProductionSystem.Models;

namespace ProductionSystem.Views
{
    public partial class frmAddAlca : Form
    {
        Estoque es;
        frmMenu me = new frmMenu();

        public frmAddAlca()
        {
            InitializeComponent();
            dgvAlca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            atualizarGrid();
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

        public void atualizarGrid()
        {
            string sqlstm = "SELECT * FROM alcas";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, Banco.Conexao);
            DataSet DS = new();
            SDA.Fill(DS, "alcas");
            dgvAlca.DataSource = DS.Tables[0];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtAddAlca.Text == String.Empty)
            {
                MessageBox.Show("Insira um modelo de alça para adicionar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                es = new Estoque()
                {
                    modelo = txtAddAlca.Text
                };
                es.AdicionarAlca();
                atualizarGrid();
                txtAddAlca.Clear();
                me.atualizaAlcas();

                MessageBox.Show("Modelo de alça adicionado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAlca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAlca.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgvAlca.Columns)
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

        private void dgvAlca_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvAlca.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvAlca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlca.Columns[e.ColumnIndex] == dgvAlca.Columns["excluir"])
            {
                if (MessageBox.Show("Deseja excluir essa linha?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    es = new Estoque()
                    {
                        id_alca = Convert.ToInt32(dgvAlca.CurrentRow.Cells["id"].Value.ToString())
                    };
                    es.ExcluirAlca();

                    atualizarGrid();
                }
            }
        }
    }
}
