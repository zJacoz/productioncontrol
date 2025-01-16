namespace ProductionSystem.Views
{
    partial class frmDec
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
            btnCancelar = new Button();
            btnConfirmar = new Button();
            txtDec = new TextBox();
            label1 = new Label();
            lblQtde = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(74, 77);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 10;
            label2.Text = "Final:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(26, 106);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 44);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(128, 106);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 44);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(68, 51);
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(100, 23);
            txtDec.TabIndex = 7;
            txtDec.TextChanged += txtDec_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 6;
            label1.Text = "Quanto deseja adicionar?";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Font = new Font("Segoe UI", 10F);
            lblQtde.Location = new Point(112, 77);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(0, 19);
            lblQtde.TabIndex = 11;
            // 
            // frmDec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 170);
            Controls.Add(lblQtde);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDec);
            Controls.Add(label1);
            Name = "frmDec";
            Load += frmDec_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtDec;
        private Label label1;
        private Label lblQtde;
    }
}