namespace CatAsService.View
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void btnBuscarRacas_Click(object sender, EventArgs e)
        {
            var buscarRacas = new frmFindBreed();
            buscarRacas.ShowDialog();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            var favoritos = new frmFavorites();
            favoritos.ShowDialog();
        }
    }
}