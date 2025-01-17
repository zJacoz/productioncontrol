namespace ProductionSystem.Views
{
    partial class frmInc
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
            txtInc = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            lblQtde = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 0;
            label1.Text = "Quanto deseja adicionar?";
            // 
            // txtInc
            // 
            txtInc.Location = new Point(72, 45);
            txtInc.Name = "txtInc";
            txtInc.Size = new Size(100, 23);
            txtInc.TabIndex = 1;
            txtInc.TextChanged += txtInc_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(133, 100);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 44);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(31, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 44);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(78, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 4;
            label2.Text = "Final:";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Font = new Font("Segoe UI", 10F);
            lblQtde.Location = new Point(116, 72);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(0, 19);
            lblQtde.TabIndex = 5;
            // 
            // frmInc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 158);
            Controls.Add(lblQtde);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtInc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmInc";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmInc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInc;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label2;
        private Label lblQtde;
    }
}