using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using ProductionSystem.Models;

namespace ProductionSystem.Views
{
    public partial class frmDec : Form
    {
        Estoque es;
        double total;
        public frmDec()
        {
            InitializeComponent();
        }

        public string Valor { get; set; }
        public string idDEC { get; set; }

        private void frmDec_Load(object sender, EventArgs e)
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
                if (txtDec.Text == String.Empty) return;

                es = new Estoque()
                {
                    id = Convert.ToInt32(idDEC),
                    quantidade = lblQtde.Text
                };
                es.IncDec();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insira uma quantidade para retirar ou cancele.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDec_TextChanged(object sender, EventArgs e)
        {

            lblQtde.Text = String.Format(this.Valor);

            if (txtDec.Text != "")
            {
                if(Convert.ToDouble(txtDec.Text) > Convert.ToDouble(this.Valor))
                {
                    MessageBox.Show("Quantidade a ser retirada maior que a quantidade em estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDec.Text = "";
                    return;
                } else
                {
                    total = Convert.ToDouble(this.Valor) - Convert.ToDouble(txtDec.Text);
                    lblQtde.Text = total.ToString();
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
