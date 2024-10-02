namespace FusionSystem
{
    partial class FrmAddUser
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
            txtEndAdd = new TextBox();
            button1 = new Button();
            txtNomeAdd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCpfAdd = new MaskedTextBox();
            txtTelAdd = new MaskedTextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 363);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Endereço";
            // 
            // txtEndAdd
            // 
            txtEndAdd.Location = new Point(321, 388);
            txtEndAdd.Margin = new Padding(4);
            txtEndAdd.Name = "txtEndAdd";
            txtEndAdd.Size = new Size(376, 29);
            txtEndAdd.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(467, 560);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 3;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNomeAdd
            // 
            txtNomeAdd.Location = new Point(321, 228);
            txtNomeAdd.Margin = new Padding(4);
            txtNomeAdd.Name = "txtNomeAdd";
            txtNomeAdd.Size = new Size(376, 29);
            txtNomeAdd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 203);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 283);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 8;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 283);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 10;
            label4.Text = "CPF";
            // 
            // txtCpfAdd
            // 
            txtCpfAdd.Location = new Point(570, 308);
            txtCpfAdd.Margin = new Padding(4);
            txtCpfAdd.Mask = "000.000.000-00";
            txtCpfAdd.Name = "txtCpfAdd";
            txtCpfAdd.Size = new Size(127, 29);
            txtCpfAdd.TabIndex = 12;
            // 
            // txtTelAdd
            // 
            txtTelAdd.Location = new Point(321, 308);
            txtTelAdd.Margin = new Padding(4);
            txtTelAdd.Mask = "(00) 00000-0000";
            txtTelAdd.Name = "txtTelAdd";
            txtTelAdd.Size = new Size(127, 29);
            txtTelAdd.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(288, 137);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(451, 377);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // FrmAddUser
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(button1);
            Controls.Add(txtTelAdd);
            Controls.Add(txtCpfAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNomeAdd);
            Controls.Add(label2);
            Controls.Add(txtEndAdd);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "FrmAddUser";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEndAdd;
        private Button button1;
        private TextBox txtNomeAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtCpfAdd;
        private MaskedTextBox txtTelAdd;
        private GroupBox groupBox1;
    }
}