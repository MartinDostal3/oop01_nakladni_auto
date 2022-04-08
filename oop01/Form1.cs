using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NakladniAuto nakladak = new NakladniAuto("ABC123", 3);

            //double zbytek = nakladak.NalozNaklad(4);
            nakladak.NalozNaklad(4);
            /* if (zbytek > 0)
              {
                  MessageBox.Show("Nebylo naloženo: " + zbytek + " t");
              }*/
            MessageBox.Show( nakladak.ToString());

            // double chybi = nakladak.VylozNaklad(7);
            nakladak.VylozNaklad(7);

            /*if (chybi > 0)
            {
                MessageBox.Show("Chybí materiálu: " + chybi + " t");
            }*/
            MessageBox.Show(nakladak.ToString());

        }
    }
}
