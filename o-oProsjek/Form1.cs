using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o_oProsjek
{
    public partial class Form1 : Form
    {
        private List<Ocjena> ocjene = new List<Ocjena>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            // Provjeri jesu li uneseni svi podaci
            if (string.IsNullOrEmpty(txtOcjena.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Molimo unesite sve podatke.");
                return;
            }

            // Kreiraj novi objekt Ocjena
            Ocjena novaOcjena = new Ocjena
            {
                Predmet = comboBox1.SelectedItem.ToString(),
                OcjenaValue = int.Parse(txtOcjena.Text),
                Datum = dateTimeOdabir.Value
            };

            // Dodaj ocjenu u listu
            ocjene.Add(novaOcjena);

            // Očisti polja za unos
            txtOcjena.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimeOdabir.Value = DateTime.Now;

            // Osviježi listbox
            OsvjeziListBox();

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabrana stavka u listboxu
            if (lstBoxIspis.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite ocjenu za brisanje.");
                return;
            }

            // Ukloni ocjenu iz liste
            ocjene.RemoveAt(lstBoxIspis.SelectedIndex);

            // Osviježi listbox
            OsvjeziListBox();
        }

        private void OsvjeziListBox()
        {
            lstBoxIspis.Items.Clear();
            foreach (Ocjena o in ocjene)
            {
                lstBoxIspis.Items.Add($"{o.Predmet} - {o.OcjenaValue} ({o.Datum.ToShortDateString()})");
            }
        }

        private void btnUkupniProsjek_Click(object sender, EventArgs e)
        {
            // Izračunaj ukupni prosjek koristeći LINQ Query metodu
            double ukupniProsjek = (from o in ocjene
                                    select o.OcjenaValue).Average();

            // Prikaži prosjek
            MessageBox.Show($"Ukupni prosjek ocjena: {ukupniProsjek:F2}");
        }

        private void btnProsjekPredmeta_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran predmet
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite predmet.");
                return;
            }

            string odabraniPredmet = comboBox2.SelectedItem.ToString();

            // Izračunaj prosjek za odabrani predmet koristeći LINQ Query metodu
            double prosjekPredmeta = (from o in ocjene
                                      where o.Predmet == odabraniPredmet
                                      select o.OcjenaValue).Average();

            // Prikaži prosjek
            MessageBox.Show($"Prosjek ocjena za {odabraniPredmet}: {prosjekPredmeta:F2}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabrana opcija za sortiranje
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite kriterij za sortiranje.");
                return;
            }

            string kriterij = comboBox3.SelectedItem.ToString();
            bool silazno = checkBox1.Checked;

            // Sortiraj listu ocjena koristeći LINQ
            List<Ocjena> sortiraneOcjene = null;

            switch (kriterij)
            {
                case "Predmet":
                    sortiraneOcjene = silazno
                        ? ocjene.OrderByDescending(o => o.Predmet).ToList()
                        : ocjene.OrderBy(o => o.Predmet).ToList();
                    break;
                case "Ocjena":
                    sortiraneOcjene = silazno
                        ? ocjene.OrderByDescending(o => o.OcjenaValue).ToList()
                        : ocjene.OrderBy(o => o.OcjenaValue).ToList();
                    break;
                case "Datum":
                    sortiraneOcjene = silazno
                        ? ocjene.OrderByDescending(o => o.Datum).ToList()
                        : ocjene.OrderBy(o => o.Datum).ToList();
                    break;
            }

            // Osviježi listbox s sortiranim ocjenama
            OsvjeziListBox(sortiraneOcjene);
        }
        private void OsvjeziListBox(List<Ocjena> ocjeneZaPrikaz = null)
        {
            lstBoxIspis.Items.Clear();

            // Ako nije proslijeđena lista, koristi originalnu listu ocjena
            if (ocjeneZaPrikaz == null)
            {
                ocjeneZaPrikaz = ocjene;
            }

            foreach (Ocjena o in ocjeneZaPrikaz)
            {
                lstBoxIspis.Items.Add($"{o.Predmet} - {o.OcjenaValue} ({o.Datum.ToShortDateString()})");
            }
        }
    }
}
