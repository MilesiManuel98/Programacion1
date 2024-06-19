using LibrosDesktop.Views;

namespace LibrosDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionLibrosView gestionLibrosView = new GestionLibrosView();
            gestionLibrosView.ShowDialog();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
