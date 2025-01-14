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
            tabControl = new TabControl();
            tabEstoque = new TabPage();
            dgvEstoque = new DataGridView();
            tabPage2 = new TabPage();
            tabEstoqueTNT = new TabPage();
            tabRendimento = new TabPage();
            label1 = new Label();
            txtPesquisa = new TextBox();
            grbEstoque = new GroupBox();
            textBox1 = new TextBox();
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
            tabControl.SuspendLayout();
            tabEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            grbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEstoque).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabEstoque);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabEstoqueTNT);
            tabControl.Controls.Add(tabRendimento);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.Location = new Point(0, 0);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(850, 507);
            tabControl.TabIndex = 0;
            // 
            // tabEstoque
            // 
            tabEstoque.Controls.Add(grbEstoque);
            tabEstoque.Controls.Add(txtPesquisa);
            tabEstoque.Controls.Add(label1);
            tabEstoque.Controls.Add(dgvEstoque);
            tabEstoque.Location = new Point(4, 30);
            tabEstoque.Name = "tabEstoque";
            tabEstoque.Padding = new Padding(3);
            tabEstoque.Size = new Size(842, 473);
            tabEstoque.TabIndex = 0;
            tabEstoque.Text = "Estoque";
            tabEstoque.UseVisualStyleBackColor = true;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(6, 58);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.Size = new Size(522, 407);
            dgvEstoque.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabEstoqueTNT
            // 
            tabEstoqueTNT.Location = new Point(4, 30);
            tabEstoqueTNT.Name = "tabEstoqueTNT";
            tabEstoqueTNT.Padding = new Padding(3);
            tabEstoqueTNT.Size = new Size(842, 473);
            tabEstoqueTNT.TabIndex = 2;
            tabEstoqueTNT.Text = "Estoque TNT";
            tabEstoqueTNT.UseVisualStyleBackColor = true;
            // 
            // tabRendimento
            // 
            tabRendimento.Location = new Point(4, 30);
            tabRendimento.Name = "tabRendimento";
            tabRendimento.Padding = new Padding(3);
            tabRendimento.Size = new Size(842, 473);
            tabRendimento.TabIndex = 3;
            tabRendimento.Text = "Rendimento";
            tabRendimento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar produto:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(8, 23);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(520, 29);
            txtPesquisa.TabIndex = 2;
            // 
            // grbEstoque
            // 
            grbEstoque.Controls.Add(textBox1);
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
            grbEstoque.Location = new Point(534, 12);
            grbEstoque.Name = "grbEstoque";
            grbEstoque.Size = new Size(305, 394);
            grbEstoque.TabIndex = 3;
            grbEstoque.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 29);
            textBox1.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(111, 333);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 31;
            label8.Text = "Quantidade:";
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(173, 301);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(102, 29);
            txtLargura.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(196, 279);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 29;
            label7.Text = "Largura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(30, 301);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(102, 29);
            txtAltura.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(57, 279);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 27;
            label6.Text = "Altura:";
            // 
            // cboAlca
            // 
            cboAlca.FormattingEnabled = true;
            cboAlca.Location = new Point(173, 247);
            cboAlca.Name = "cboAlca";
            cboAlca.Size = new Size(102, 29);
            cboAlca.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(209, 225);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 25;
            label5.Text = "Alça:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(30, 247);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(102, 29);
            txtCor.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(64, 225);
            label4.Name = "label4";
            label4.Size = new Size(34, 19);
            label4.TabIndex = 23;
            label4.Text = "Cor:";
            // 
            // cboModelo
            // 
            cboModelo.FormattingEnabled = true;
            cboModelo.Location = new Point(173, 194);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(102, 29);
            cboModelo.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(196, 172);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 21;
            label3.Text = "Modelo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(30, 194);
            txtID.Name = "txtID";
            txtID.Size = new Size(102, 29);
            txtID.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(55, 172);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 19;
            label2.Text = "Código:";
            // 
            // picEstoque
            // 
            picEstoque.Location = new Point(82, 23);
            picEstoque.Name = "picEstoque";
            picEstoque.Size = new Size(147, 146);
            picEstoque.TabIndex = 18;
            picEstoque.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 507);
            Controls.Add(tabControl);
            Name = "frmMenu";
            Text = "Controle de Produção";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabEstoque.ResumeLayout(false);
            tabEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            grbEstoque.ResumeLayout(false);
            grbEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabEstoque;
        private TabPage tabPage2;
        private TabPage tabEstoqueTNT;
        private TabPage tabRendimento;
        private DataGridView dgvEstoque;
        private GroupBox grbEstoque;
        private TextBox txtPesquisa;
        private Label label1;
        private TextBox textBox1;
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
    }
}
