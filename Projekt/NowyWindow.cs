using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class NowyWindow : Form
    {
        public BronBiala bronB;
        public BronStrzelnicza bronS;
        public bool czyBiala = false;

        public bool b_tmp3
        { 
            get { return czyBiala; }
            set { }
        }


        public BronBiala tmp1
        {
            get { return bronB; }
            set { }
        }

        public BronStrzelnicza tmp2
        {
            get { return bronS; }
            set { }
        }

        public NowyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioBiala.Checked == true)
            {
                czyBiala = true;
                bronB = new BronBiala("440C", "nóż", "1", txtCzyDst.Text, txtWaga.Text,
                                txtCena.Text, txtFirma.Text, txtModel.Text, txtObrazek.Text, txtOpis.Text);
            }
            else
            {
                czyBiala = false;
                bronS = new BronStrzelnicza("karabin", "30", "1", txtCzyDst.Text, txtWaga.Text,
                                txtCena.Text, txtFirma.Text, txtModel.Text, txtObrazek.Text, txtOpis.Text);
            }


        }
    }
}
