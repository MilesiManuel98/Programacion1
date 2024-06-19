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
    public partial class GestionLibrosView : Form
    {
        LibrosRepository repo = new LibrosRepository();
        public GestionLibrosView()
        {
            InitializeComponent();
            CargarLibrosALaGrilla();

        }

        public async void CargarLibrosALaGrilla()
        {
            dataGridLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregaEditarLibroView agregaEditarLibroView = new AgregaEditarLibroView();
            agregaEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }
    }
}
