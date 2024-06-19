namespace VideojuegosDesktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void videojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarVideojuegoView gestionarVideojuegoView = new GestionarVideojuegoView();
            gestionarVideojuegoView.ShowDialog();
        }
    }
}
