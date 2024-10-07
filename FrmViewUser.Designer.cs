namespace FusionSystem
{
    partial class FrmViewUser
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
            txtNome = new TextBox();
            lbNome = new Label();
            btnPesquisar = new Button();
            listClientes = new ListView();
            gbAcoes = new GroupBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            gbAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(40, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(40, 41);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(164, 59);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // listClientes
            // 
            listClientes.Location = new Point(40, 112);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(700, 309);
            listClientes.TabIndex = 5;
            listClientes.UseCompatibleStateImageBehavior = false;
            // 
            // gbAcoes
            // 
            gbAcoes.Controls.Add(btnAlterar);
            gbAcoes.Controls.Add(btnExcluir);
            gbAcoes.Location = new Point(510, 12);
            gbAcoes.Name = "gbAcoes";
            gbAcoes.Size = new Size(230, 78);
            gbAcoes.TabIndex = 7;
            gbAcoes.TabStop = false;
            gbAcoes.Text = "Ações";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(33, 29);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 30);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(126, 29);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 30);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(268, 59);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(gbAcoes);
            Controls.Add(listClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Name = "FrmViewUser";
            Text = "Consultar Clientes";
            Load += FrmViewUser_Load;
            gbAcoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lbNome;
        private Button btnPesquisar;
        private ListView listClientes;
        private GroupBox gbAcoes;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
    }
}