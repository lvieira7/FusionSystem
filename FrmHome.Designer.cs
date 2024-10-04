namespace FusionSystem
{
    partial class FrmHome
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
            menuHome = new MenuStrip();
            menuCheckout = new ToolStripMenuItem();
            menuPDV = new ToolStripMenuItem();
            menuRelatorio = new ToolStripMenuItem();
            menuEstoque = new ToolStripMenuItem();
            menuAddProduto = new ToolStripMenuItem();
            menuConsultProduto = new ToolStripMenuItem();
            menuUsuarios = new ToolStripMenuItem();
            menuAdicionar = new ToolStripMenuItem();
            menuConsultar = new ToolStripMenuItem();
            menuSuporte = new ToolStripMenuItem();
            menuContato = new ToolStripMenuItem();
            menuDocumentacao = new ToolStripMenuItem();
            menuTermo = new ToolStripMenuItem();
            menuFusionSystem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuHome
            // 
            menuHome.ImageScalingSize = new Size(20, 20);
            menuHome.Items.AddRange(new ToolStripItem[] { menuCheckout, menuEstoque, menuUsuarios, menuSuporte, menuDocumentacao });
            menuHome.Location = new Point(0, 0);
            menuHome.Name = "menuHome";
            menuHome.Size = new Size(800, 24);
            menuHome.TabIndex = 0;
            menuHome.Text = "menuStrip1";
            // 
            // menuCheckout
            // 
            menuCheckout.DropDownItems.AddRange(new ToolStripItem[] { menuPDV, menuRelatorio });
            menuCheckout.Name = "menuCheckout";
            menuCheckout.Size = new Size(48, 20);
            menuCheckout.Text = "Caixa";
            // 
            // menuPDV
            // 
            menuPDV.Name = "menuPDV";
            menuPDV.Size = new Size(157, 22);
            menuPDV.Text = "Ponto de Venda";
            menuPDV.Click += menuPDV_Click;
            // 
            // menuRelatorio
            // 
            menuRelatorio.Name = "menuRelatorio";
            menuRelatorio.Size = new Size(157, 22);
            menuRelatorio.Text = "Relatório";
            // 
            // menuEstoque
            // 
            menuEstoque.DropDownItems.AddRange(new ToolStripItem[] { menuAddProduto, menuConsultProduto });
            menuEstoque.Name = "menuEstoque";
            menuEstoque.Size = new Size(61, 20);
            menuEstoque.Text = "Estoque";
            // 
            // menuAddProduto
            // 
            menuAddProduto.Name = "menuAddProduto";
            menuAddProduto.Size = new Size(180, 22);
            menuAddProduto.Text = "Adicionar Produto";
            menuAddProduto.Click += menuProdutos_Click;
            // 
            // menuConsultProduto
            // 
            menuConsultProduto.Name = "menuConsultProduto";
            menuConsultProduto.Size = new Size(180, 22);
            menuConsultProduto.Text = "Consultar Estoque";
            // 
            // menuUsuarios
            // 
            menuUsuarios.DropDownItems.AddRange(new ToolStripItem[] { menuAdicionar, menuConsultar });
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(64, 20);
            menuUsuarios.Text = "Usuários";
            // 
            // menuAdicionar
            // 
            menuAdicionar.Name = "menuAdicionar";
            menuAdicionar.Size = new Size(125, 22);
            menuAdicionar.Text = "Adicionar";
            menuAdicionar.Click += menuAdicionar_Click;
            // 
            // menuConsultar
            // 
            menuConsultar.Name = "menuConsultar";
            menuConsultar.Size = new Size(125, 22);
            menuConsultar.Text = "Consultar";
            // 
            // menuSuporte
            // 
            menuSuporte.DropDownItems.AddRange(new ToolStripItem[] { menuContato });
            menuSuporte.Name = "menuSuporte";
            menuSuporte.Size = new Size(60, 20);
            menuSuporte.Text = "Suporte";
            // 
            // menuContato
            // 
            menuContato.Name = "menuContato";
            menuContato.Size = new Size(117, 22);
            menuContato.Text = "Contato";
            // 
            // menuDocumentacao
            // 
            menuDocumentacao.DropDownItems.AddRange(new ToolStripItem[] { menuTermo, menuFusionSystem });
            menuDocumentacao.Name = "menuDocumentacao";
            menuDocumentacao.Size = new Size(100, 20);
            menuDocumentacao.Text = "Documentação";
            // 
            // menuTermo
            // 
            menuTermo.Name = "menuTermo";
            menuTermo.Size = new Size(150, 22);
            menuTermo.Text = "Termo de uso";
            // 
            // menuFusionSystem
            // 
            menuFusionSystem.Name = "menuFusionSystem";
            menuFusionSystem.Size = new Size(150, 22);
            menuFusionSystem.Text = "Fusion System";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.luxa_org_opacity_changed_logotipoFrmHome;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuHome);
            MainMenuStrip = menuHome;
            Name = "FrmHome";
            Text = "Página Inicial";
            menuHome.ResumeLayout(false);
            menuHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHome;
        private ToolStripMenuItem menuCheckout;
        private ToolStripMenuItem menuRelatorio;
        private ToolStripMenuItem menuEstoque;
        private ToolStripMenuItem menuAddProduto;
        private ToolStripMenuItem menuUsuarios;
        private ToolStripMenuItem menuAdicionar;
        private ToolStripMenuItem menuSuporte;
        private ToolStripMenuItem menuContato;
        private ToolStripMenuItem menuDocumentacao;
        private ToolStripMenuItem menuTermo;
        private ToolStripMenuItem menuFusionSystem;
        private ToolStripMenuItem menuConsultar;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuPDV;
        private ToolStripMenuItem menuConsultProduto;
    }
}