namespace Proyecto_Compilador_de_Lain
{
    public partial class MenuPrincipal : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

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

    }
}
