using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmi
{
    public partial class Form1 : Form
    {
        private string povNiz = @"Data Source = C:\Users\Payana\Desktop\Faks\PRO3 - vaje\AnaAnderlič_V9_2023\filmi.sqlite; Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void prikaziKlik(object sender, EventArgs e)
        {
            if (vnosLeto.Text == "" || vnosOcena.Text == "")
            {
                MessageBox.Show("Vnesite vsa polja!", "Napaka");
                return;
            }

            prikazRezultati.Text = "";

            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = povezava;
            ukaz.CommandText = "SELECT naslov, leto, ocena FROM filmi";

            int leto = int.Parse(vnosLeto.Text);
            double ocena = double.Parse(vnosOcena.Text);

            SQLiteDataReader rez = ukaz.ExecuteReader();
           
            while (rez.Read())
            {
                if (leto == rez.GetInt32(1) && rez.GetDouble(2) >= ocena)
                {
                    prikazRezultati.AppendText(String.Format("Film {0}, ustvarjen leta {1} z oceno {2}.", rez.GetString(0), rez.GetInt32(1), rez.GetDouble(2)));
                    prikazRezultati.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
