using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProductionSystem.Models;

namespace ProductionSystem.Views
{
    public partial class frmInc : Form
    {
        double total = 0;
        Estoque es;
        frmMenu me;

        public frmInc()
        {
            InitializeComponent();
        }

        public string Valor { get; set; }
        public string idINC { get; set; }

        private void frmInc_Load(object sender, EventArgs e)
        {
            if (!this.Valor.Equals(""))
            {
                lblQtde.Text = this.Valor;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInc.Text == String.Empty) return;

                es = new Estoque()
                {
                    id = Convert.ToInt32(idINC),
                    quantidade = lblQtde.Text
                };
                es.IncDec();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insira uma quantidade para adicionar ou cancele.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtInc_TextChanged(object sender, EventArgs e)
        {
            lblQtde.Text = String.Format(this.Valor);

            if (txtInc.Text != "")
            {
                total = Convert.ToDouble(this.Valor) + Convert.ToDouble(txtInc.Text);
                lblQtde.Text = total.ToString();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
