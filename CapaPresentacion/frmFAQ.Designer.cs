namespace CapaPresentacion
{
    partial class frmFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFAQ));
            panel1 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 25);
            label1.Name = "label1";
            label1.Size = new Size(462, 45);
            label1.TabIndex = 0;
            label1.Text = "PREGUNTAS FRECUENTES";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(0, 26, 87);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Leelawadee UI", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "1. Problemas de Acceso al Sistema.", "", "No puedo iniciar sesión en el sistema, ¿Qué debo hacer?", "", "• Asegúrate de que el bloqueo de mayúsculas (Caps Lock) no esté activado.", "", "• Si olvidaste la contraseña, utiliza la opción “¿Olvidó su contraseña?” para restablecerla.", "", "• Verifica que el nombre de usuario y la contraseña sean correctos.", "", "", "2. Problemas con el Registro de Productos.", "", "¿Por qué no puedo guardar un nuevo producto?", "", "• Asegúrate de completar todos los campos obligatorios, como nombre, precio y cantidad.", "", "• Verifica que el precio y la cantidad tengan valores numéricos válidos.", "", "• Si el SKU o código de producto ya existe, el sistema no lo permitirá. Verifica el código.", "", " •Reinicia la aplicación para asegurarte de que no haya errores de conexión con la base de datos.", "", "", "3. Problemas con el Módulo de Ventas.", "", "¿Por qué no puedo realizar una venta?", "", "• Verifica que el producto seleccionado tenga suficiente stock disponible.", "\t", "• Asegúrate de que el cliente esté registrado en la base de datos.", " ", "• Revisa si el sistema muestra algún mensaje de error o advertencia.", "\t", "• Si el sistema se congela al procesar la venta, intenta reiniciarlo y realizar la operación nuevamente.", "", "", "4. Problemas de Actualización de Inventario.", "", " ¿Por qué la cantidad de stock no se actualiza después de una venta?", "\t", "• Verifica si hay errores en el módulo de ventas que impidan el registro de la transacción.", "\t", "• Asegúrate de que la venta se haya completado correctamente y no haya sido cancelada.", "", "• Si el problema persiste, intenta sincronizar el inventario manualmente desde el módulo de inventario.", "", "", "5. Problemas de Reportes.", "", "No se generan los reportes correctamente ¿Qué hago?", "", "• Revisa la configuración del formato de los reportes en el menú de opciones.", " ", "• Verifica que los filtros seleccionados sean correctos y que las fechas sean válidas.", "\t", "• Reinicia el sistema y vuelve a generar el reporte.", "\t", "• Comprueba que el sistema tenga acceso a la carpeta donde se guardan los archivos.", "", "", "6. Problemas de Conectividad.", "", "El sistema no puede conectarse a la base de datos ¿Qué hago?", "", "• Asegúrate de que el servidor esté en funcionamiento y accesible.", " ", "• Verifica la configuración de la cadena de conexión en el archivo de configuración.", " ", "• Revisa la conexión a Internet o la red local.", " ", "• Reinicia el servidor de la base de datos para restablecer la conexión.", "", "", "7. Problemas con la Impresión de Facturas.", "", "¿Por qué la factura no se imprime después de una venta?", "", "• Verifica que la impresora esté conectada y encendida.", "", "• Asegúrate de que la impresora esté configurada como predeterminada en el sistema.", "", "• Comprueba el estado de la cola de impresión en Windows.", "\t", "• Si el problema continúa, reinstala el controlador de la impresora.", "", "", "", "8.  Problemas de Actualización del Sistema.", "", "¿El sistema no se actualiza automáticamente?", "", "• Asegúrate de que la opción de actualización automática esté habilitada.", "\t", "• Verifica la conexión a Internet para asegurar que el sistema pueda descargar actualizaciones.", "\t", "• Si el sistema está bloqueado en la actualización, intenta hacerlo manualmente desde el menú de configuración." });
            listBox1.Location = new Point(12, 127);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1114, 357);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            btnRegresar.TabIndex = 30;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmFAQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 26, 87);
            ClientSize = new Size(1138, 496);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Font = new Font("Leelawadee UI", 9F);
            Name = "frmFAQ";
            Text = "frmFAQ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private Button btnRegresar;
    }
}