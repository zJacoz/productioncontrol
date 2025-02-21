namespace ProductionSystem.Views
{
    partial class frmAddMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            dgvModelo = new DataGridView();
            excluir = new DataGridViewImageColumn();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            txtAddMod = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvModelo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 7);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 11;
            label2.Text = "Modelos de sacola:";
            // 
            // dgvModelo
            // 
            dgvModelo.AllowUserToAddRows = false;
            dgvModelo.AllowUserToDeleteRows = false;
            dgvModelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModelo.Columns.AddRange(new DataGridViewColumn[] { excluir });
            dgvModelo.Location = new Point(22, 25);
            dgvModelo.Name = "dgvModelo";
            dgvModelo.ReadOnly = true;
            dgvModelo.Size = new Size(274, 167);
            dgvModelo.TabIndex = 10;
            dgvModelo.CellContentClick += dgvModelo_CellContentClick;
            dgvModelo.CellFormatting += dgvModelo_CellFormatting;
            dgvModelo.DataBindingComplete += dgvModelo_DataBindingComplete;
            // 
            // excluir
            // 
            excluir.HeaderText = "";
            excluir.Image = Properties.Resources.delete;
            excluir.Name = "excluir";
            excluir.ReadOnly = true;
            excluir.Resizable = DataGridViewTriState.False;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Image = Properties.Resources.ad_blocker;
            btnCancelar.Location = new Point(79, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionar.Image = Properties.Resources.floppy_disk_4408708;
            btnAdicionar.Location = new Point(163, 265);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(80, 35);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtAddMod
            // 
            txtAddMod.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddMod.Location = new Point(43, 228);
            txtAddMod.Name = "txtAddMod";
            txtAddMod.Size = new Size(234, 23);
            txtAddMod.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(63, 210);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 6;
            label1.Text = "Digite o modelo que quer adicionar:";
            // 
            // frmAddMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 306);
            Controls.Add(label2);
            Controls.Add(dgvModelo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtAddMod);
            Controls.Add(label1);
            Name = "frmAddMod";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar modelo";
            ((System.ComponentModel.ISupportInitialize)dgvModelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvModelo;
        private DataGridViewImageColumn excluir;
        private Button btnCancelar;
        private Button btnAdicionar;
        private TextBox txtAddMod;
        private Label label1;
    }
}