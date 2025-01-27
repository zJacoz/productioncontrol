
namespace ProductionSystem
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            label1 = new Label();
            btnCancelar = new Button();
            btnFechar = new Button();
            txtSilk = new TextBox();
            label10 = new Label();
            btnDecremento = new Button();
            btnIncremento = new Button();
            label9 = new Label();
            txtQuantidade = new TextBox();
            label8 = new Label();
            txtLargura = new TextBox();
            label7 = new Label();
            txtAltura = new TextBox();
            label6 = new Label();
            cboAlca = new ComboBox();
            label5 = new Label();
            txtCor = new TextBox();
            label4 = new Label();
            cboModelo = new ComboBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            picEstoque = new PictureBox();
            btnAtualizar = new Button();
            dgvEstoque = new DataGridView();
            excluir = new DataGridViewImageColumn();
            btnSalvar = new Button();
            txtPesquisa = new TextBox();
            btnAdicionar = new Button();
            grbEstoque = new GroupBox();
            txtGrama = new TextBox();
            label11 = new Label();
            ofdEstoque = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            grbEstoque.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 11;
            label1.Text = "Pesquisar produto:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Image = Properties.Resources.failed_4476475;
            btnCancelar.Location = new Point(850, 538);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 58);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFechar.Image = Properties.Resources.ad_blocker;
            btnFechar.Location = new Point(9, 536);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(98, 58);
            btnFechar.TabIndex = 19;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.BottomCenter;
            btnFechar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // txtSilk
            // 
            txtSilk.Anchor = AnchorStyles.Left;
            txtSilk.Location = new Point(191, 293);
            txtSilk.Name = "txtSilk";
            txtSilk.Size = new Size(125, 23);
            txtSilk.TabIndex = 28;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(232, 271);
            label10.Name = "label10";
            label10.Size = new Size(32, 19);
            label10.TabIndex = 27;
            label10.Text = "Silk:";
            // 
            // btnDecremento
            // 
            btnDecremento.Anchor = AnchorStyles.Left;
            btnDecremento.Image = Properties.Resources.minus;
            btnDecremento.Location = new Point(33, 372);
            btnDecremento.Name = "btnDecremento";
            btnDecremento.Size = new Size(69, 59);
            btnDecremento.TabIndex = 37;
            btnDecremento.UseVisualStyleBackColor = true;
            btnDecremento.Click += btnDecremento_Click_1;
            // 
            // btnIncremento
            // 
            btnIncremento.Anchor = AnchorStyles.Left;
            btnIncremento.Image = Properties.Resources.plus__2_;
            btnIncremento.Location = new Point(240, 372);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(76, 59);
            btnIncremento.TabIndex = 36;
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click_1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(165, 348);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 33;
            label9.Text = "X";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Left;
            txtQuantidade.Location = new Point(106, 387);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(131, 23);
            txtQuantidade.TabIndex = 35;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(128, 365);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 34;
            label8.Text = "Quantidade:";
            // 
            // txtLargura
            // 
            txtLargura.Anchor = AnchorStyles.Left;
            txtLargura.Location = new Point(192, 340);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(124, 23);
            txtLargura.TabIndex = 32;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(222, 318);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 31;
            label7.Text = "Largura:";
            // 
            // txtAltura
            // 
            txtAltura.Anchor = AnchorStyles.Left;
            txtAltura.Location = new Point(31, 340);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(122, 23);
            txtAltura.TabIndex = 30;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(68, 318);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 29;
            label6.Text = "Altura:";
            // 
            // cboAlca
            // 
            cboAlca.Anchor = AnchorStyles.Left;
            cboAlca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlca.FormattingEnabled = true;
            cboAlca.Items.AddRange(new object[] { "Sem", "Alça", "Cordão" });
            cboAlca.Location = new Point(192, 246);
            cboAlca.Name = "cboAlca";
            cboAlca.Size = new Size(124, 23);
            cboAlca.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(230, 224);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 23;
            label5.Text = "Alça:";
            // 
            // txtCor
            // 
            txtCor.Anchor = AnchorStyles.Left;
            txtCor.Location = new Point(31, 293);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(122, 23);
            txtCor.TabIndex = 26;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(74, 271);
            label4.Name = "label4";
            label4.Size = new Size(34, 19);
            label4.TabIndex = 25;
            label4.Text = "Cor:";
            // 
            // cboModelo
            // 
            cboModelo.Anchor = AnchorStyles.Left;
            cboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModelo.FormattingEnabled = true;
            cboModelo.Location = new Point(31, 246);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(124, 23);
            cboModelo.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(63, 224);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 21;
            label3.Text = "Modelo:";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Left;
            txtID.Location = new Point(115, 198);
            txtID.Name = "txtID";
            txtID.Size = new Size(104, 23);
            txtID.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(140, 176);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 19;
            label2.Text = "Código:";
            // 
            // picEstoque
            // 
            picEstoque.Anchor = AnchorStyles.Left;
            picEstoque.BorderStyle = BorderStyle.FixedSingle;
            picEstoque.Location = new Point(88, 27);
            picEstoque.Name = "picEstoque";
            picEstoque.Size = new Size(163, 146);
            picEstoque.SizeMode = PictureBoxSizeMode.StretchImage;
            picEstoque.TabIndex = 18;
            picEstoque.TabStop = false;
            picEstoque.Click += picEstoque_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAtualizar.Image = Properties.Resources.Custom_Icon_Design_Mono_General_4_Refresh_24;
            btnAtualizar.Location = new Point(673, 25);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(32, 34);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { excluir });
            dgvEstoque.Location = new Point(9, 65);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.Size = new Size(696, 466);
            dgvEstoque.TabIndex = 20;
            dgvEstoque.CellClick += dgvEstoque_CellClick_1;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick_1;
            dgvEstoque.CellFormatting += dgvEstoque_CellFormatting_1;
            dgvEstoque.DataBindingComplete += dgvEstoque_DataBindingComplete_1;
            // 
            // excluir
            // 
            excluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            excluir.FillWeight = 50F;
            excluir.HeaderText = "";
            excluir.Image = Properties.Resources.delete;
            excluir.Name = "excluir";
            excluir.ReadOnly = true;
            excluir.Width = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Image = Properties.Resources.floppy_disk_4408708;
            btnSalvar.Location = new Point(954, 538);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 58);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(9, 30);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(658, 23);
            txtPesquisa.TabIndex = 12;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionar.Image = Properties.Resources.folder_8892160;
            btnAdicionar.Location = new Point(954, 538);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 58);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // grbEstoque
            // 
            grbEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grbEstoque.Controls.Add(txtGrama);
            grbEstoque.Controls.Add(label11);
            grbEstoque.Controls.Add(txtSilk);
            grbEstoque.Controls.Add(label10);
            grbEstoque.Controls.Add(btnDecremento);
            grbEstoque.Controls.Add(btnIncremento);
            grbEstoque.Controls.Add(label9);
            grbEstoque.Controls.Add(txtQuantidade);
            grbEstoque.Controls.Add(label8);
            grbEstoque.Controls.Add(txtLargura);
            grbEstoque.Controls.Add(label7);
            grbEstoque.Controls.Add(txtAltura);
            grbEstoque.Controls.Add(label6);
            grbEstoque.Controls.Add(cboAlca);
            grbEstoque.Controls.Add(label5);
            grbEstoque.Controls.Add(txtCor);
            grbEstoque.Controls.Add(label4);
            grbEstoque.Controls.Add(cboModelo);
            grbEstoque.Controls.Add(label3);
            grbEstoque.Controls.Add(txtID);
            grbEstoque.Controls.Add(label2);
            grbEstoque.Controls.Add(picEstoque);
            grbEstoque.Location = new Point(711, 57);
            grbEstoque.Name = "grbEstoque";
            grbEstoque.Size = new Size(341, 476);
            grbEstoque.TabIndex = 15;
            grbEstoque.TabStop = false;
            // 
            // txtGrama
            // 
            txtGrama.Anchor = AnchorStyles.Left;
            txtGrama.Location = new Point(136, 434);
            txtGrama.Name = "txtGrama";
            txtGrama.Size = new Size(73, 23);
            txtGrama.TabIndex = 39;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(134, 412);
            label11.Name = "label11";
            label11.Size = new Size(78, 19);
            label11.TabIndex = 38;
            label11.Text = "Gramatura:";
            // 
            // ofdEstoque
            // 
            ofdEstoque.FileName = "openFileDialog1";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 606);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnFechar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvEstoque);
            Controls.Add(btnSalvar);
            Controls.Add(txtPesquisa);
            Controls.Add(btnAdicionar);
            Controls.Add(grbEstoque);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            Text = "Controle de Estoque";
            WindowState = FormWindowState.Maximized;
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)picEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            grbEstoque.ResumeLayout(false);
            grbEstoque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnFechar;
        private TextBox txtSilk;
        private Label label10;
        private Button btnDecremento;
        private Button btnIncremento;
        private Label label9;
        private TextBox txtQuantidade;
        private Label label8;
        private TextBox txtLargura;
        private Label label7;
        private TextBox txtAltura;
        private Label label6;
        private ComboBox cboAlca;
        private Label label5;
        private TextBox txtCor;
        private Label label4;
        private ComboBox cboModelo;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private PictureBox picEstoque;
        private Button btnAtualizar;
        private DataGridView dgvEstoque;
        private DataGridViewImageColumn excluir;
        private Button btnSalvar;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private GroupBox grbEstoque;
        private OpenFileDialog ofdEstoque;
        private TextBox txtGrama;
        private Label label11;
    }
}
