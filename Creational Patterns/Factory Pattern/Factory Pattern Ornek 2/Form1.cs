using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Pattern_Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SekilFactory sf = new SekilFactory();
            ISekil sekil = sf.GetSekil(SekilFactory.enSekilTur.enKare);
            sekil.Ciz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SekilFactory sf = new SekilFactory();
            ISekil sekil = sf.GetSekil(SekilFactory.enSekilTur.enCember);
            sekil.Ciz();
        }
    }
}
