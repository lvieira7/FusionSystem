namespace FusionSystem
{
    partial class FrmPDV
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 63);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Código";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 92);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 13;
            label5.Text = "Preço Total";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 49);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 31);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "Preço Unit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 63);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 9;
            label7.Text = "Quantidade";
            // 
            // button1
            // 
            button1.Location = new Point(12, 403);
            button1.Name = "button1";
            button1.Size = new Size(138, 35);
            button1.TabIndex = 0;
            button1.Text = "Cancelar Compra";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logotipo;
            pictureBox1.Location = new Point(631, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(243, 403);
            button3.Name = "button3";
            button3.Size = new Size(138, 35);
            button3.TabIndex = 18;
            button3.Text = "Adicionar Desconto";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(470, 403);
            button4.Name = "button4";
            button4.Size = new Size(138, 35);
            button4.TabIndex = 17;
            button4.Text = "Finalizar Compra";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(596, 273);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Location = new Point(631, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 165);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saída";
            // 
            // FrmPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FrmPDV";
            Text = "Ponto de Venda";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private TextBox textBox3;
        private GroupBox groupBox1;
    }
}