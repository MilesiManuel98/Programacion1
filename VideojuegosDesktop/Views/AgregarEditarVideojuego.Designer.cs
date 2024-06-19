namespace VideojuegosDesktop.Views
{
    partial class AgregarEditarVideojuego
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            Nombre = new Label();
            txtGenero = new TextBox();
            Genero = new Label();
            txtDescripcion = new TextBox();
            Descripcion = new Label();
            txtPortadaUrl = new TextBox();
            PortadoUrl = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(76, 346);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(381, 27);
            txtNombre.TabIndex = 19;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(25, 25);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(67, 20);
            Nombre.TabIndex = 18;
            Nombre.Text = "Nombre:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(121, 145);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(381, 27);
            txtGenero.TabIndex = 25;
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Location = new Point(25, 148);
            Genero.Name = "Genero";
            Genero.Size = new Size(60, 20);
            Genero.TabIndex = 24;
            Genero.Text = "Genero:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(121, 201);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(381, 96);
            txtDescripcion.TabIndex = 23;
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(25, 204);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(87, 20);
            Descripcion.TabIndex = 22;
            Descripcion.Text = "Descripcion";
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(121, 88);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(381, 27);
            txtPortadaUrl.TabIndex = 21;
            // 
            // PortadoUrl
            // 
            PortadoUrl.AutoSize = true;
            PortadoUrl.Location = new Point(25, 91);
            PortadoUrl.Name = "PortadoUrl";
            PortadoUrl.Size = new Size(86, 20);
            PortadoUrl.TabIndex = 20;
            PortadoUrl.Text = "Portada Url:";
            // 
            // AgregarEditarVideojuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(538, 387);
            Controls.Add(txtGenero);
            Controls.Add(Genero);
            Controls.Add(txtDescripcion);
            Controls.Add(Descripcion);
            Controls.Add(txtPortadaUrl);
            Controls.Add(PortadoUrl);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "AgregarEditarVideojuego";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarVideojuego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label Nombre;
        private TextBox txtGenero;
        private Label Genero;
        private TextBox txtDescripcion;
        private Label Descripcion;
        private TextBox txtPortadaUrl;
        private Label PortadoUrl;
    }
}