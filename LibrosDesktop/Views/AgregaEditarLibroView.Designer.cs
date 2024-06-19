namespace LibrosDesktop.Views
{
    partial class AgregaEditarLibroView
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
            Nombre = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            Autor = new Label();
            Paginas = new Label();
            txtEditorial = new TextBox();
            Editorial = new Label();
            txtPortadaUrl = new TextBox();
            PortadoUrl = new Label();
            txtSinopsis = new TextBox();
            Sinopsis = new Label();
            Genero = new Label();
            txtGenero = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            numericPaginas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericPaginas).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(60, 59);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(67, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(381, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(141, 109);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(381, 27);
            txtAutor.TabIndex = 3;
            // 
            // Autor
            // 
            Autor.AutoSize = true;
            Autor.Location = new Point(60, 112);
            Autor.Name = "Autor";
            Autor.Size = new Size(49, 20);
            Autor.TabIndex = 2;
            Autor.Text = "Autor:";
            // 
            // Paginas
            // 
            Paginas.AutoSize = true;
            Paginas.Location = new Point(60, 164);
            Paginas.Name = "Paginas";
            Paginas.Size = new Size(62, 20);
            Paginas.TabIndex = 4;
            Paginas.Text = "Paginas:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(141, 214);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(381, 27);
            txtEditorial.TabIndex = 7;
            // 
            // Editorial
            // 
            Editorial.AutoSize = true;
            Editorial.Location = new Point(60, 217);
            Editorial.Name = "Editorial";
            Editorial.Size = new Size(68, 20);
            Editorial.TabIndex = 6;
            Editorial.Text = "Editorial:";
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(141, 268);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(381, 27);
            txtPortadaUrl.TabIndex = 9;
            // 
            // PortadoUrl
            // 
            PortadoUrl.AutoSize = true;
            PortadoUrl.Location = new Point(60, 271);
            PortadoUrl.Name = "PortadoUrl";
            PortadoUrl.Size = new Size(86, 20);
            PortadoUrl.TabIndex = 8;
            PortadoUrl.Text = "Portada Url:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(141, 381);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(381, 96);
            txtSinopsis.TabIndex = 11;
            // 
            // Sinopsis
            // 
            Sinopsis.AutoSize = true;
            Sinopsis.Location = new Point(60, 384);
            Sinopsis.Name = "Sinopsis";
            Sinopsis.Size = new Size(66, 20);
            Sinopsis.TabIndex = 10;
            Sinopsis.Text = "Sinopsis:";
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Location = new Point(60, 328);
            Genero.Name = "Genero";
            Genero.Size = new Size(60, 20);
            Genero.TabIndex = 12;
            Genero.Text = "Genero:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(141, 325);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(381, 27);
            txtGenero.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(101, 555);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(381, 555);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(141, 162);
            numericPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(150, 27);
            numericPaginas.TabIndex = 16;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // AgregaEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(586, 596);
            Controls.Add(numericPaginas);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtGenero);
            Controls.Add(Genero);
            Controls.Add(txtSinopsis);
            Controls.Add(Sinopsis);
            Controls.Add(txtPortadaUrl);
            Controls.Add(PortadoUrl);
            Controls.Add(txtEditorial);
            Controls.Add(Editorial);
            Controls.Add(Paginas);
            Controls.Add(txtAutor);
            Controls.Add(Autor);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Name = "AgregaEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregaEditarLibroView";
            ((System.ComponentModel.ISupportInitialize)numericPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private Label Autor;
        private Label Paginas;
        private TextBox txtEditorial;
        private Label Editorial;
        private TextBox txtPortadaUrl;
        private Label PortadoUrl;
        private TextBox txtSinopsis;
        private Label Sinopsis;
        private Label Genero;
        private TextBox txtGenero;
        private Button btnGuardar;
        private Button btnCancelar;
        private NumericUpDown numericPaginas;
    }
}