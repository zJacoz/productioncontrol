using System.Data;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using ProductionSystem.Models;
using ProductionSystem.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProductionSystem
{
    public partial class frmMenu : Form
    {
        Estoque es;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
            inicio();
            txtID.Enabled = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carregarGrid("");
            limpaControles();

            string vqueryModelos = @"
                SELECT 
                    id,
                    modelo
                FROM modelos
                ORDER BY
                id";

            cboModelo.DataSource = Banco.dql(vqueryModelos);
            cboModelo.DisplayMember = "modelo";
            cboModelo.ValueMember = "id";
            cboModelo.SelectedIndex = -1;

            string vqueryAlcas = @"
                SELECT 
                    id,
                    modelo
                FROM alcas
                ORDER BY
                id";

            cboAlca.DataSource = Banco.dql(vqueryAlcas);
            cboAlca.DisplayMember = "modelo";
            cboAlca.ValueMember = "id";
            cboAlca.SelectedIndex = -1;
        }

        public frmMenu()
        {
            InitializeComponent();

        }

        void inicio()
        {
            cboModelo.Enabled = false;
            txtSilk.Enabled = false;
            txtCor.Enabled = false;
            cboAlca.Enabled = false;
            txtAltura.Enabled = false;
            txtLargura.Enabled = false;
            picEstoque.Enabled = false;
            txtGrama.Enabled = false;
            txtQuantidade.Enabled = false;
            btnIncremento.Visible = true;
            btnDecremento.Visible = true;
            btnIncremento.Enabled = false;
            btnDecremento.Enabled = false;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnAdicionar.Visible = true;
        }

        public void atualizarGrid()
        {
            string sqlstm = "SELECT * FROM estoque";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, Banco.Conexao);
            DataSet DS = new();
            SDA.Fill(DS, "estoque");
            dgvEstoque.DataSource = DS.Tables[0];
        }

        public void limpaControles()
        {
            txtID.Clear();
            cboModelo.SelectedIndex = -1;
            txtSilk.Clear();
            txtCor.Clear();
            txtAltura.Clear();
            txtLargura.Clear();
            txtQuantidade.Clear();
            txtGrama.Clear();
            cboAlca.SelectedIndex = -1;
            picEstoque.ImageLocation = "";
            txtQuantidade.Clear();
        }

        // carregarGrid ESTOQUE

        public void carregarGrid(string pesquisa)
        {
            es = new Estoque()
            {
                modelo = pesquisa,
                altura = pesquisa,
                largura = pesquisa
            };
            dgvEstoque.DataSource = es.Consultar();
            inicio();
        }

        // Estoque BUTTONS

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            
            grbEstoque.Enabled = true;
            cboModelo.Enabled = true;
            txtSilk.Enabled = true;
            txtCor.Enabled = true;
            cboAlca.Enabled = true;
            txtAltura.Enabled = true;
            txtLargura.Enabled = true;
            txtGrama.Enabled = true;
            picEstoque.Enabled = true;
            txtQuantidade.Enabled = true;
            btnAdicionar.Visible = false;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            btnIncremento.Visible = false;
            btnDecremento.Visible = false;
            limpaControles();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpaControles();
            inicio();
            btnIncremento.Visible = true;
            btnDecremento.Visible = true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (cboModelo.TabIndex == -1 || txtCor.Text == "" ||
                cboAlca.TabIndex == -1 || txtAltura.Text == "" || txtLargura.Text == "" || txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                es = new Estoque()
                {
                    modelo = cboModelo.Text,
                    silk = txtSilk.Text,
                    cor = txtCor.Text,
                    altura = txtAltura.Text,
                    largura = txtLargura.Text,
                    modelo_alca = cboAlca.Text,
                    gramatura = txtGrama.Text,
                    foto = picEstoque.ImageLocation,
                    quantidade = txtQuantidade.Text
                };
                es.Adicionar();
                inicio();
            }
            btnIncremento.Visible = true;
            btnDecremento.Visible = true;
        }

        private void picEstoque_Click_1(object sender, EventArgs e)
        {
            ofdEstoque.InitialDirectory = "C:\\";
            ofdEstoque.FileName = "";
            ofdEstoque.ShowDialog();
            picEstoque.ImageLocation = ofdEstoque.FileName;
        }

        private void btnIncremento_Click_1(object sender, EventArgs e)
        {
            frmInc form = new frmInc();
            form.idINC = dgvEstoque.CurrentRow.Cells["id"].Value.ToString();
            form.Valor = dgvEstoque.CurrentRow.Cells["quantidade"].Value.ToString();
            form.Show();
        }

        private void btnDecremento_Click_1(object sender, EventArgs e)
        {
            frmDec form = new frmDec();
            form.idDEC = dgvEstoque.CurrentRow.Cells["id"].Value.ToString();
            form.Valor = dgvEstoque.CurrentRow.Cells["quantidade"].Value.ToString();
            form.Show();
        }

        private void dgvEstoque_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEstoque.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["silk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["cor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["modelo_alca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["altura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["largura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["gramatura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dgvEstoque.Columns)
            {
                switch (coluna.Name)
                {
                    case "modelo":
                        coluna.Width = 180;
                        coluna.HeaderText = "Modelo";
                        break;
                    case "silk":
                        coluna.Width = 140;
                        coluna.HeaderText = "Silk";
                        break;
                    case "cor":
                        coluna.Width = 120;
                        coluna.HeaderText = "Cor";
                        break;
                    case "altura":
                        coluna.Width = 75;
                        coluna.HeaderText = "Altura";
                        break;
                    case "largura":
                        coluna.Width = 75;
                        coluna.HeaderText = "Largura";
                        break;
                    case "modelo_alca":
                        coluna.Width = 100;
                        coluna.HeaderText = "Alça";
                        break;
                    case "gramatura":
                        coluna.Width = 70;
                        coluna.HeaderText = "Gramatura";
                        break;
                    case "quantidade":
                        coluna.Width = 135;
                        coluna.HeaderText = "Quantidade";
                        break;
                    case "foto":
                        coluna.Width = 246;
                        coluna.HeaderText = "Imagem";
                        break;
                    case "excluir":
                        coluna.Width = 60;
                        coluna.DisplayIndex = 10;
                        coluna.HeaderText = "Excluir";
                        break;
                    default:
                        coluna.Visible = false;
                        break;
                }
            }
        }

        private void dgvEstoque_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.RowCount > 0)
            {
                txtID.Text = dgvEstoque.CurrentRow.Cells["id"].Value.ToString();
                cboModelo.Text = dgvEstoque.CurrentRow.Cells["modelo"].Value.ToString();
                txtSilk.Text = dgvEstoque.CurrentRow.Cells["silk"].Value.ToString();
                txtCor.Text = dgvEstoque.CurrentRow.Cells["cor"].Value.ToString();
                txtAltura.Text = dgvEstoque.CurrentRow.Cells["altura"].Value.ToString();
                txtLargura.Text = dgvEstoque.CurrentRow.Cells["largura"].Value.ToString();
                cboAlca.Text = dgvEstoque.CurrentRow.Cells["modelo_alca"].Value.ToString();
                picEstoque.ImageLocation = dgvEstoque.CurrentRow.Cells["foto"].Value.ToString();
                txtQuantidade.Text = dgvEstoque.CurrentRow.Cells["quantidade"].Value.ToString();
                btnIncremento.Enabled = true;
                btnDecremento.Enabled = true;
                btnAdicionar.Visible = true;
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;

            }
        }

        private void dgvEstoque_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.Columns[e.ColumnIndex] == dgvEstoque.Columns["excluir"])
            {
                if (MessageBox.Show("Deseja excluir essa linha?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    es = new Estoque()
                    {
                        id = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["id"].Value.ToString())
                    };
                    es.Excluir();

                    limpaControles();
                    dgvEstoque.Refresh();
                }
            }
        }

        private void dgvEstoque_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvEstoque.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            atualizarGrid();
            carregarGrid("");
            limpaControles();
            inicio();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Format(txtPesquisa.Text);

            if(txtPesquisa.Text != "")
            {
                carregarGrid(txtPesquisa.Text);
            }
            else
            {
                carregarGrid("");
            }
        }



        // TABELA PEDIDOS >>>>>>


    }
}
