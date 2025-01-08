using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace Form22ClasesMascota
{
    public partial class Form1 : Form
    {

        private HelperMascotas hm;
        public Form1()
        {
            InitializeComponent();
            HelperMascotas hm = new HelperMascotas("mascotas.txt");
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.hm.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.hm.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await this.hm.ReadMascotasAsync();
            this.lstMascotas = this.hm.Mascotas.;
        }
    }
}
