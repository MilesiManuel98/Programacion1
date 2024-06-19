using EjerciciosDePrueba.Models;
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

namespace VideojuegosDesktop.Views
{
    public partial class AgregarEditarVideojuego : Form
    {
        private string idVideojuegoSeleccionado;
        VideojuegosRepository repo = new VideojuegosRepository();
        public AgregarEditarVideojuego()
        {
            InitializeComponent();
        }
        public AgregarEditarVideojuego(string idVideojuegoSeleccionado)
        {
            this.idVideojuegoSeleccionado = idVideojuegoSeleccionado;
            InitializeComponent();
            CargarVideojuegoAPantlla();
        }

        private async void CargarVideojuegoAPantlla()
        {
            Videojuego? videojuegos = await repo.ObtenerPorIdAsync(this.idVideojuegoSeleccionado);
            if (videojuegos != null)
            {
                txtNombre.Text = videojuegos.nombre;
                txtGenero.Text = videojuegos.genero;
                txtPortadaUrl.Text = videojuegos.portada_url;
                txtDescripcion.Text = videojuegos.descripcion;
            }
            else
                MessageBox.Show("ERROR! No se encontro el Videojuego");
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (idVideojuegoSeleccionado != null)
            {
                await repo.ActualizarAsync(txtNombre.Text,txtPortadaUrl.Text,txtDescripcion.Text,txtGenero.Text,this.idVideojuegoSeleccionado);
            }
            else
            {
                await repo.AgregarAsync(txtNombre.Text, txtPortadaUrl.Text, txtDescripcion.Text, txtGenero.Text);
            } 

            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
