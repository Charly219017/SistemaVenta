using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cuadroIzquierdo_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == textdocumento.Text && u.Clave == textclave.Text).FirstOrDefault();


            Inicio form = new Inicio();//Crea una nueva instanica inicio

            form.Show();//muestra el inicio a darle click
            this.Hide();//oculta el login

            form.FormClosing += frm_closing;// este llama el frm_closing
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textdocumento.Text = "";//Limpia el cuadro N. Documento
            textclave.Text = "";//limpia el cuadro contraseña

            this.Show();//Volvemos a mostrar el login a darle en "X"
        }

    }
}
