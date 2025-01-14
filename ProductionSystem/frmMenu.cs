using ProductionSystem.Models;

namespace ProductionSystem
{
    public partial class frmMenu : Form
    {
        Estoque e;

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        public frmMenu()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            cboModelo.SelectedIndex = -1;
            txtCor.Clear();
            txtAltura.Clear();
            txtLargura.Clear();
            cboAlca.SelectedIndex = -1;
            picEstoque.ImageLocation = "";
            txtQuantidade.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            e = new Estoque()
            {
                modelo = pesquisa
            };
            dgvEstoque.DataSource = e.Consultar();
        }
    }
}
