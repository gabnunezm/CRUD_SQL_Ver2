namespace CapaPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pIcono = new Panel();
            btnAcceder = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // pIcono
            // 
            pIcono.BackColor = SystemColors.HotTrack;
            pIcono.BackgroundImage = (Image)resources.GetObject("pIcono.BackgroundImage");
            pIcono.BackgroundImageLayout = ImageLayout.Center;
            pIcono.Location = new Point(2, -1);
            pIcono.Name = "pIcono";
            pIcono.Size = new Size(247, 316);
            pIcono.TabIndex = 0;
            // 
            // btnAcceder
            // 
            btnAcceder.BackgroundImage = (Image)resources.GetObject("btnAcceder.BackgroundImage");
            btnAcceder.BackgroundImageLayout = ImageLayout.Zoom;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = Color.FromArgb(0, 26, 87);
            btnAcceder.Location = new Point(429, 237);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(57, 50);
            btnAcceder.TabIndex = 1;
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(366, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(366, 132);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(366, 80);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de Usuario";
            txtUsuario.Size = new Size(186, 31);
            txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(366, 177);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "*******";
            txtContrasena.Size = new Size(186, 31);
            txtContrasena.TabIndex = 7;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(0, 26, 87);
            btnCerrar.Location = new Point(637, -1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(42, 38);
            btnCerrar.TabIndex = 8;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 26, 87);
            ClientSize = new Size(675, 315);
            Controls.Add(btnCerrar);
            Controls.Add(btnAcceder);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pIcono);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pIcono;
        private Button btnAcceder;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnCerrar;
    }
}