namespace FusionSystem
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            txtSenhaLogin = new TextBox();
            lbSenhaLogin = new Label();
            btnAcessar = new Button();
            txtUsuarioLogin = new TextBox();
            lbUsuarioLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logotipo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // txtSenhaLogin
            // 
            resources.ApplyResources(txtSenhaLogin, "txtSenhaLogin");
            txtSenhaLogin.Name = "txtSenhaLogin";
            // 
            // lbSenhaLogin
            // 
            resources.ApplyResources(lbSenhaLogin, "lbSenhaLogin");
            lbSenhaLogin.Name = "lbSenhaLogin";
            // 
            // btnAcessar
            // 
            resources.ApplyResources(btnAcessar, "btnAcessar");
            btnAcessar.Name = "btnAcessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txtUsuarioLogin
            // 
            resources.ApplyResources(txtUsuarioLogin, "txtUsuarioLogin");
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            // 
            // lbUsuarioLogin
            // 
            resources.ApplyResources(lbUsuarioLogin, "lbUsuarioLogin");
            lbUsuarioLogin.Name = "lbUsuarioLogin";
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(txtSenhaLogin);
            Controls.Add(lbSenhaLogin);
            Controls.Add(btnAcessar);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lbUsuarioLogin);
            Name = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtSenhaLogin;
        private Label lbSenhaLogin;
        private Button btnAcessar;
        private TextBox txtUsuarioLogin;
        private Label lbUsuarioLogin;
    }
}
