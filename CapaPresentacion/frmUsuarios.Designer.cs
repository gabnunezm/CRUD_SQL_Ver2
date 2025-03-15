namespace CapaPresentacion
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            btnRegresar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtTipo = new TextBox();
            label4 = new Label();
            txtContrasena = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.HotTrack;
            btnRegresar.Location = new Point(7, 11);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(41, 29);
            btnRegresar.TabIndex = 29;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.HotTrack;
            btnEliminar.Location = new Point(109, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(45, 33);
            btnEliminar.TabIndex = 28;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.HotTrack;
            btnEditar.Location = new Point(54, 368);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(49, 33);
            btnEditar.TabIndex = 27;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.HotTrack;
            btnGuardar.Location = new Point(845, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 65);
            btnGuardar.TabIndex = 26;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(797, 235);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(194, 23);
            txtTipo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(738, 238);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 22;
            label4.Text = "Tipo";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(797, 193);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(194, 23);
            txtContrasena.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(725, 196);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 20;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(797, 149);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(194, 23);
            txtUsuario.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(729, 152);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 18;
            label2.Text = "Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(797, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(729, 110);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Location = new Point(45, 41);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(656, 319);
            dgvUsuarios.TabIndex = 15;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1026, 426);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTipo);
            Controls.Add(label4);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtTipo;
        private Label label4;
        private TextBox txtContrasena;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvUsuarios;
    }
}