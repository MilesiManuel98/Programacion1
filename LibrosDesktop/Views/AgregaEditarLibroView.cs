using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosDesktop.Views
{
    public partial class AgregaEditarLibroView : Form
    {
        public AgregaEditarLibroView()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            LibrosRepository repo = new LibrosRepository();
            await repo.AgregarAsync(txtNombre.Text,txtGenero.Text,(int)numericPaginas.Value,txtEditorial.Text,txtSinopsis.Text,txtPortadaUrl.Text,txtAutor.Text);
            this.Close();
        }
    }
}
