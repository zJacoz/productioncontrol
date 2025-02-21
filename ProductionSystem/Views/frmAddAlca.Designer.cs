namespace ProductionSystem.Views
{
    partial class frmAddAlca
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
            label1 = new Label();
            txtAddAlca = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            dgvAlca = new DataGridView();
            excluir = new DataGridViewImageColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlca).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(62, 212);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o modelo que quer adicionar:";
            // 
            // txtAddAlca
            // 
            txtAddAlca.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddAlca.Location = new Point(43, 230);
            txtAddAlca.Name = "txtAddAlca";
            txtAddAlca.Size = new Size(234, 23);
            txtAddAlca.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionar.Image = Properties.Resources.floppy_disk_4408708;
            btnAdicionar.Location = new Point(163, 267);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(80, 35);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Image = Properties.Resources.ad_blocker;
            btnCancelar.Location = new Point(79, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvAlca
            // 
            dgvAlca.AllowUserToAddRows = false;
            dgvAlca.AllowUserToDeleteRows = false;
            dgvAlca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlca.Columns.AddRange(new DataGridViewColumn[] { excluir });
            dgvAlca.Location = new Point(22, 27);
            dgvAlca.Name = "dgvAlca";
            dgvAlca.ReadOnly = true;
            dgvAlca.Size = new Size(274, 167);
            dgvAlca.TabIndex = 4;
            dgvAlca.CellContentClick += dgvAlca_CellContentClick;
            dgvAlca.CellFormatting += dgvAlca_CellFormatting;
            dgvAlca.DataBindingComplete += dgvAlca_DataBindingComplete;
            // 
            // excluir
            // 
            excluir.HeaderText = "";
            excluir.Image = Properties.Resources.delete;
            excluir.Name = "excluir";
            excluir.ReadOnly = true;
            excluir.Resizable = DataGridViewTriState.False;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Modelos de alça:";
            // 
            // frmAddAlca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 306);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(dgvAlca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtAddAlca);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddAlca";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar alça";
            ((System.ComponentModel.ISupportInitialize)dgvAlca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddAlca;
        private Button btnAdicionar;
        private Button btnCancelar;
        private DataGridView dgvAlca;
        private DataGridViewImageColumn excluir;
        private Label label2;
    }
}