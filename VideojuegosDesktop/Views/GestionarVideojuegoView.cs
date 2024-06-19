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
    public partial class GestionarVideojuegoView : Form
    {
        VideojuegosRepository repo = new VideojuegosRepository();
        public GestionarVideojuegoView()
        {
            InitializeComponent();
            CargarVideojuegoALaGrilla();
        }
        public async void CargarVideojuegoALaGrilla()
        {
            dataGridVideojuegos.DataSource = await repo.ObtenerVideojuegoAsync();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarEditarVideojuego agregaEditarVideojuego = new AgregarEditarVideojuego();
            agregaEditarVideojuego.ShowDialog();
            CargarVideojuegoALaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string? idVideojuegoSeleccionado = (string)dataGridVideojuegos.CurrentRow.Cells[0].Value;

            AgregarEditarVideojuego agregarEditarVideojuego = new AgregarEditarVideojuego(idVideojuegoSeleccionado);
            agregarEditarVideojuego.ShowDialog();
            CargarVideojuegoALaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string? idVideojuegoSeleccionado = (string)dataGridVideojuegos.CurrentRow.Cells[0].Value;
            string? nombreVideojuegoSeleccionado = (string)dataGridVideojuegos.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"Esta seguro que desea borrar {nombreVideojuegoSeleccionado}?", "Eliminar Videojuego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idVideojuegoSeleccionado);
                CargarVideojuegoALaGrilla();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
