using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICatalogo
{
    public partial class Formulario : Form
    {
        Controller controller = new Controller();
        public Formulario()
        {
            InitializeComponent();
        }

        public TextBox getTitulo() { return this.txtBoxTitulo;  }
        public TextBox getSynopsis() { return this.txtBoxSynopsis; }
        public TextBox getCover() { return this.txtBoxCover; }
        public TextBox getGenero() { return this.txtBoxGenero; }
        public TextBox getEpisodio() { return this.txtBoxEpisodios; }
        public TextBox getTemporada() { return this.txtBoxTemporadas;  }
        public void setLabelHead(String mensaje) { this.labelHead.Text = mensaje; }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Close();

        }
    }
}
