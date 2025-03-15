namespace CapaPresentacion
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnFAQ = new Button();
            btnProductos = new Button();
            btnUsuarios = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 50);
            label1.TabIndex = 0;
            label1.Text = "INICIO";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(btnFAQ);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnUsuarios);
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 115);
            panel2.TabIndex = 1;
            // 
            // btnFAQ
            // 
            btnFAQ.BackColor = SystemColors.HotTrack;
            btnFAQ.BackgroundImage = (Image)resources.GetObject("btnFAQ.BackgroundImage");
            btnFAQ.BackgroundImageLayout = ImageLayout.Center;
            btnFAQ.FlatStyle = FlatStyle.Flat;
            btnFAQ.ForeColor = SystemColors.HotTrack;
            btnFAQ.Location = new Point(458, 16);
            btnFAQ.Name = "btnFAQ";
            btnFAQ.Size = new Size(87, 85);
            btnFAQ.TabIndex = 2;
            btnFAQ.UseVisualStyleBackColor = false;
            btnFAQ.Click += btnFAQ_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackgroundImage = (Image)resources.GetObject("btnProductos.BackgroundImage");
            btnProductos.BackgroundImageLayout = ImageLayout.Center;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = SystemColors.HotTrack;
            btnProductos.Location = new Point(328, 16);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(87, 85);
            btnProductos.TabIndex = 1;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackgroundImage = (Image)resources.GetObject("btnUsuarios.BackgroundImage");
            btnUsuarios.BackgroundImageLayout = ImageLayout.Center;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = SystemColors.HotTrack;
            btnUsuarios.Location = new Point(200, 16);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(87, 85);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(751, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmHome";
            Text = "frmHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnFAQ;
        private Button btnProductos;
        private Button btnUsuarios;
    }
}