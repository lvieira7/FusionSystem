namespace FusionSystem
{
    partial class FrmEditUser
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
            txtTel = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            lbCpf = new Label();
            lbTel = new Label();
            txtNome = new TextBox();
            lbNome = new Label();
            txtEnd = new TextBox();
            lbEnd = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            lbId = new Label();
            SuspendLayout();
            // 
            // txtTel
            // 
            txtTel.Location = new Point(32, 104);
            txtTel.Mask = "(00) 00000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 23;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(150, 104);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 22;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(150, 86);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 21;
            lbCpf.Text = "CPF";
            // 
            // lbTel
            // 
            lbTel.AutoSize = true;
            lbTel.Location = new Point(32, 86);
            lbTel.Name = "lbTel";
            lbTel.Size = new Size(51, 15);
            lbTel.TabIndex = 20;
            lbTel.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(293, 23);
            txtNome.TabIndex = 19;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(32, 29);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 18;
            lbNome.Text = "Nome";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(32, 161);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(293, 23);
            txtEnd.TabIndex = 16;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Location = new Point(32, 143);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(56, 15);
            lbEnd.TabIndex = 15;
            lbEnd.Text = "Endereço";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(141, 217);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 35);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(32, 217);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 35);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(250, 217);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(280, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 28;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(280, 86);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 27;
            lbId.Text = "ID";
            // 
            // FrmEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 286);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtTel);
            Controls.Add(txtCpf);
            Controls.Add(lbCpf);
            Controls.Add(lbTel);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(txtEnd);
            Controls.Add(lbEnd);
            Name = "FrmEditUser";
            Text = "Informações do Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtTel;
        private MaskedTextBox txtCpf;
        private Label lbCpf;
        private Label lbTel;
        private TextBox txtNome;
        private Label lbNome;
        private TextBox txtEnd;
        private Label lbEnd;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnSalvar;
        private TextBox txtId;
        private Label lbId;
    }
}