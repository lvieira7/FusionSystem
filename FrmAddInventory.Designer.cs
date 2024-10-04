namespace FusionSystem
{
    partial class FrmAddInventory
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
            txtNomeProd = new TextBox();
            button1 = new Button();
            lbNomeProd = new Label();
            LbDescProd = new Label();
            txtDescProd = new TextBox();
            lbQntProd = new Label();
            txtQntProd = new TextBox();
            lbTamProd = new Label();
            lbPrecoProd = new Label();
            txtPrecoProd = new TextBox();
            lbCorProd = new Label();
            txtCorProd = new TextBox();
            lbCatProd = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(241, 100);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(326, 23);
            txtNomeProd.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(362, 358);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbNomeProd
            // 
            lbNomeProd.AutoSize = true;
            lbNomeProd.Location = new Point(241, 82);
            lbNomeProd.Name = "lbNomeProd";
            lbNomeProd.Size = new Size(40, 15);
            lbNomeProd.TabIndex = 2;
            lbNomeProd.Text = "Nome";
            // 
            // LbDescProd
            // 
            LbDescProd.AutoSize = true;
            LbDescProd.Location = new Point(241, 141);
            LbDescProd.Name = "LbDescProd";
            LbDescProd.Size = new Size(58, 15);
            LbDescProd.TabIndex = 4;
            LbDescProd.Text = "Descrição";
            // 
            // txtDescProd
            // 
            txtDescProd.Location = new Point(241, 159);
            txtDescProd.Name = "txtDescProd";
            txtDescProd.Size = new Size(326, 23);
            txtDescProd.TabIndex = 3;
            // 
            // lbQntProd
            // 
            lbQntProd.AutoSize = true;
            lbQntProd.Location = new Point(281, 211);
            lbQntProd.Name = "lbQntProd";
            lbQntProd.Size = new Size(69, 15);
            lbQntProd.TabIndex = 6;
            lbQntProd.Text = "Quantidade";
            // 
            // txtQntProd
            // 
            txtQntProd.Location = new Point(281, 229);
            txtQntProd.Name = "txtQntProd";
            txtQntProd.Size = new Size(69, 23);
            txtQntProd.TabIndex = 5;
            // 
            // lbTamProd
            // 
            lbTamProd.AutoSize = true;
            lbTamProd.Location = new Point(241, 198);
            lbTamProd.Name = "lbTamProd";
            lbTamProd.Size = new Size(56, 15);
            lbTamProd.TabIndex = 8;
            lbTamProd.Text = "Tamanho";
            // 
            // lbPrecoProd
            // 
            lbPrecoProd.AutoSize = true;
            lbPrecoProd.Location = new Point(244, 260);
            lbPrecoProd.Name = "lbPrecoProd";
            lbPrecoProd.Size = new Size(37, 15);
            lbPrecoProd.TabIndex = 10;
            lbPrecoProd.Text = "Preço";
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(241, 278);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(100, 23);
            txtPrecoProd.TabIndex = 9;
            // 
            // lbCorProd
            // 
            lbCorProd.AutoSize = true;
            lbCorProd.Location = new Point(332, 198);
            lbCorProd.Name = "lbCorProd";
            lbCorProd.Size = new Size(26, 15);
            lbCorProd.TabIndex = 12;
            lbCorProd.Text = "Cor";
            // 
            // txtCorProd
            // 
            txtCorProd.Location = new Point(332, 216);
            txtCorProd.Name = "txtCorProd";
            txtCorProd.Size = new Size(100, 23);
            txtCorProd.TabIndex = 11;
            // 
            // lbCatProd
            // 
            lbCatProd.AutoSize = true;
            lbCatProd.Location = new Point(250, 149);
            lbCatProd.Name = "lbCatProd";
            lbCatProd.Size = new Size(58, 15);
            lbCatProd.TabIndex = 16;
            lbCatProd.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 23);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(250, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(lbCatProd);
            groupBox1.Controls.Add(txtQntProd);
            groupBox1.Controls.Add(lbQntProd);
            groupBox1.Location = new Point(217, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 281);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Produto";
            // 
            // FrmAddInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(lbCorProd);
            Controls.Add(txtCorProd);
            Controls.Add(lbPrecoProd);
            Controls.Add(txtPrecoProd);
            Controls.Add(lbTamProd);
            Controls.Add(LbDescProd);
            Controls.Add(txtDescProd);
            Controls.Add(lbNomeProd);
            Controls.Add(button1);
            Controls.Add(txtNomeProd);
            Controls.Add(groupBox1);
            Name = "FrmAddInventory";
            Text = "Adicionar Produto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProd;
        private Button button1;
        private Label lbNomeProd;
        private Label LbDescProd;
        private TextBox txtDescProd;
        private Label lbQntProd;
        private TextBox txtQntProd;
        private Label lbTamProd;
        private Label lbPrecoProd;
        private TextBox txtPrecoProd;
        private Label lbCorProd;
        private TextBox txtCorProd;
        private Label lbCatProd;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
    }
}