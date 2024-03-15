using System.Text.RegularExpressions;

namespace Proyecto_Compilador_de_Lain
{
    public partial class MenuPrincipal : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private Archivo codigoFuente;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            DialogResult resultado = dialogoAbrirArchivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    string archivoRuta = dialogoAbrirArchivo.FileName;
                    string archivoContenido = File.ReadAllText(archivoRuta);

                    this.codigoFuente = new Archivo(Path.GetFileName(archivoRuta), archivoContenido);

                    // MessageBox.Show($"Se seleccionó el archivo: {codigoFuente.Nombre}\n\nContenido:\n{codigoFuente.Contenido}");
                } catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar abrir el archivo: " + ex.Message);
                }
            }
        }

        private void bttValidar_Click(object sender, EventArgs e)
        {
            string patron = @"LAIN\s+\w+\s*=\s*(?:""(\w*)""|[-+]?\d+);";

            MessageBox.Show("El código fuente " + (Regex.IsMatch(codigoFuente.Contenido, patron)? "" : "NO") + " es válido.");
        }
    }

    public partial class Archivo
    {
        public Archivo(string nombre, string contenido)
        {
            Nombre = nombre;
            Contenido = contenido;
        }

        public string Nombre { get; set; }
        public string Contenido { get; set; }
    }
}
