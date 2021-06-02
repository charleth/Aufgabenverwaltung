using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabenliste
{
    public partial class FensterAufgabeHinzufuegen : Form
    {
        public FensterAufgabeHinzufuegen()
        {
            InitializeComponent();
        }

        private void AbgabedatumWaehlen_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonAufgabeHinzufuegen_Click(object sender, EventArgs e)
        {
            // Aufgabe hinzufügen (Bezeichnung, Mitarbeiter, Abgabedatum, Erledigungsgrad)

            // Eingabefelder leeren
        }
    }
}
