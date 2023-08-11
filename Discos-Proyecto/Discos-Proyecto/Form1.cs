using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discos_Proyecto
{
    public partial class frmDiscos : Form
    {
        private List<Disco> listDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosDatos data = new DiscosDatos();
            listDiscos = data.datos();
            dgvDiscos.DataSource = listDiscos;
            loadImg(listDiscos[0].UrlImagenTapa);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco selected = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            loadImg(selected.UrlImagenTapa);
        }

        private void loadImg(string img)
        {
            try
            {
                pbxDiscos.Load(img);

            }
            catch (Exception ex)
            {
                pbxDiscos.Load("https://img.freepik.com/vecteurs-premium/icone-photo-icone-photo-signe-symbole-image-illustration-vectorielle_64749-4409.jpg");
            }
        }
    }
}
