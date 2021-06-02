﻿using System;
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
    public partial class AufgabenverwaltungMain : Form
    {

        private List<Aufgabe> aufgaben = new List<Aufgabe>();

        public void AddAufgabe(Aufgabe a)
        {
            aufgaben.Add(a);
            listBoxAufgaben.Items.Add(a.ToString());
        }



        public AufgabenverwaltungMain()
        {
            InitializeComponent();
            // Testdaten
            // wie bekommt man das Format für ein echtes Datum? nachschauen, ersetzen
            // TODO entfernen (Platzhalter) 
            AddAufgabe(new Aufgabe("Fenster putzen", DateTime.Now, "ich", 0));
            AddAufgabe(new Aufgabe("Bewerbung schreiben", DateTime.Now, "ich", 20));
            AddAufgabe(new Aufgabe("Wäsche waschen", DateTime.Now, "jemand anders", 50));
        }




        private void listBoxAufgaben_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
