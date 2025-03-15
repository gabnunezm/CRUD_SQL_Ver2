namespace CapaPresentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            label2 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(656, 319);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(721, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(793, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(793, 120);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(194, 23);
            txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(718, 123);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(793, 164);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(194, 23);
            txtMarca.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(721, 167);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Marca";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(793, 206);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(721, 209);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(793, 251);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(194, 23);
            txtStock.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(721, 254);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Stock";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(844, 298);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 46);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(41, 361);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 33);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(152, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 33);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "BORRAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.HotTrack;
            btnRegresar.Location = new Point(3, 6);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(41, 29);
            btnRegresar.TabIndex = 14;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1026, 409);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDesc;
        private Label label2;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRegresar;
    }
}
