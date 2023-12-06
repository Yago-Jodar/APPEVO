using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class museumToolGeneral : Form
    {
        public Boolean initializationMode { get; set; }
        public int numInventariSel { get; set; }

        public museumToolGeneral()
        {
            InitializeComponent();
        }

        private void museumToolGeneral_Load(object sender, EventArgs e)
        {

        }

        private void TransportPersonesMercaderies_Click(object sender, EventArgs e)
        {
            transportPersonesMercaderies p = new transportPersonesMercaderies();

            p.Show();
        }

        private void bombers_Click(object sender, EventArgs e)
        {
            bombers p = new bombers();

            p.Show();
        }

        private void motocicletesCatalanes_Click(object sender, EventArgs e)
        {
            motocicletesCatalanes p = new motocicletesCatalanes();

            p.Show();
        }

        private void microcotxesPrototipsElectrics_Click(object sender, EventArgs e)
        {
            microcotxesElectricsProtoipsUnics p = new microcotxesElectricsProtoipsUnics();

            p.Show();
        }

        private void revolucioUtilitari_Click(object sender, EventArgs e)
        {
            museumToolGeneral p = new museumToolGeneral();

            p.Show();
        }

        private void inicisAviacio_Click(object sender, EventArgs e)
        {
            inicisAviacio p = new inicisAviacio();

            p.Show();
        }

        private void tancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditarColleccions_Click(object sender, EventArgs e)
        {
            editorColleccions p = new editorColleccions();

            p.Show();
        }

        private void buttonCrearPreguna_Click(object sender, EventArgs e)
        {
            gestorPreguntes p = new gestorPreguntes();

            p.Show();
        }

        private void buttonMostrarInfoItemsMuseu_Click(object sender, EventArgs e)
        {
            visualizadorObjetos p = new visualizadorObjetos();

            p.Show();
        }
    }
}
