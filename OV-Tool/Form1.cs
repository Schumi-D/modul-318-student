using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace OV_Tool
{
    public partial class FRMTransportSwiss : Form
    {
        public FRMTransportSwiss()
        {
            InitializeComponent();
        }

        //Transport Objekt für ganzes Form
        Transport trans = new Transport();

        //Suchen von Verbindungnen
        //*********************************************************************
        private void btSuchen_Click(object sender, EventArgs e)
        {
                //Fehlermeldung bei leeren Feldern
                if (tbVon.Text == "" || tbNach.Text == "")
                {
                    MessageBox.Show("Bitte alle Felder Füllen", "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Auslesen der gewünschten Zeit und suchen der Verbindungen
                    DateTime Zeitpunkt = Convert.ToDateTime(DTPDatumVonNach.Text).Date;
                    Zeitpunkt += Convert.ToDateTime(DTPZeitVonNach.Text).TimeOfDay;
                    Connections connections = trans.GetConnectionsByTime(tbVon.Text, tbNach.Text, Zeitpunkt);

                    //Abfüllen der ListView
                    LVResult.Items.Clear();
                    foreach (Connection currentConnection in connections.ConnectionList)
                    {
                        DateTime departure = Convert.ToDateTime(currentConnection.From.Departure);
                        string duration = currentConnection.Duration.Remove(0, 3);
                        duration = duration.Remove(5);
                        ListViewItem newConnection = new ListViewItem();
                        newConnection.Text = currentConnection.From.Station.Name;
                        newConnection.SubItems.Add(currentConnection.To.Station.Name);
                        newConnection.SubItems.Add(departure.ToString("HH:mm"));
                        newConnection.SubItems.Add(duration);
                        newConnection.SubItems.Add(currentConnection.From.Platform);

                        LVResult.Items.Add(newConnection);
                    }
                }
        }
        

        //Abfahrtstabelle generieren
        //*********************************************************************
        private void btgenerateabfahrtsort_Click(object sender, EventArgs e)
        {
            //Fehlermeldung bei leeren Feldern
            if (tbAbfahrtsort.Text == "")
            {
                MessageBox.Show("Bitte alle Felder Füllen", "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Staionboard von SwissTransport holen
                StationBoardRoot Stationboards = trans.GetStationBoard(tbAbfahrtsort.Text, trans.GetStations(tbAbfahrtsort.Text).StationList[0].Id);

                //Abfüllen der ListView
                LVResult.Items.Clear();
                foreach (StationBoard board in Stationboards.Entries)
                {
                    ListViewItem newBoard = new ListViewItem();
                    newBoard.Text = trans.GetStations(tbAbfahrtsort.Text).StationList.First().Name;
                    newBoard.SubItems.Add(board.To);
                    newBoard.SubItems.Add(board.Stop.Departure.ToShortTimeString());

                    LVResult.Items.Add(newBoard);
                }
            }
        }

        //Setzen der aktuellen Zeit beim Laden des Programmes
        //*********************************************************************
        private void FRMTransportSwiss_Load(object sender, EventArgs e)
        {
            DTPZeitVonNach.Text = DateTime.Now.ToString("HH:mm");
            DTPDatumVonNach.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        //Öffnen der Karte für alle Karten-Buttons
        //*********************************************************************
        private void btKarte_Click(object sender, EventArgs e)
        {
            bool ausgefullt = true;
            string station = null;

            Button sends_event = (Button)sender;

            //Aslesen des Buttons der geklickt wurde 
            if (sends_event.Name == btKarteVon.Name)
            {
                if (tbVon.Text != "")
                {
                    station = this.tbVon.Text;
                }
                else
                {
                    ausgefullt = false;
                }
            }
            else if (sends_event.Name == btKarteNach.Name)
            {
                if (tbNach.Text != "")
                {
                    station = this.tbNach.Text;
                }
                else
                {
                    ausgefullt = false;
                }
            }
            else if (sends_event.Name == btKarteVonAbfahrt.Name)
            {
                if (tbAbfahrtsort.Text != "")
                {
                    station = this.tbAbfahrtsort.Text;
                }
                else
                {
                    ausgefullt = false;
                } 
            }

            //Setzten der URL und öffenen des Map-Forms
            if (ausgefullt)
            {
                Stations stations = trans.GetStations(station);

                string url_maps = "http://maps.google.com/maps?q=loc:"
                                    + stations.StationList.First().Coordinate.XCoordinate.ToString()
                                    + ","
                                    + stations.StationList.First().Coordinate.YCoordinate.ToString();

                Map googleMaps = new Map();

                googleMaps.WBKarte.Navigate(url_maps);
                googleMaps.Show();
            }
            //Fehlermeldung bei leeren Feldern 
            else
            {
                MessageBox.Show("Bitte geben sie zuerst eine Station an", "Keine Staion", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        } 

        //Mail mit Resultaten senden
        //*********************************************************************
        private void btMailSenden_Click(object sender, EventArgs e)
        {
            //Fehlermeldung bei leeren Feldern
            if (tbVon.Text == "" || tbNach.Text == "")
            {
                MessageBox.Show("Es wurden noch keine Verbindungen zum verschicken gesucht", "Keine Verbindungen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Warnung dass nich alle eMail-Adressen erlaubt sind
                DialogResult result = MessageBox.Show("Das senden von Mails ist nur von Bluemail, Bluewin und Hotmail adressen möglich. Trotzdem weiterfahren?",
                                                      "eMail senden", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    //email-Form öffnen
                    eMailUndPasswort email = new eMailUndPasswort(LVResult);
                    email.Show();
                }
            }
        }

        //Autocomplete der Textboxen
        //*********************************************************************
        private AutoCompleteStringCollection SearchStations(string query)
        {
            //Stationen aus Internet holen und in AutoComplete einfügen
            List<Station> stationen = trans.GetStations(query).StationList;
            AutoCompleteStringCollection autoList = new AutoCompleteStringCollection();
            autoList.AddRange(stationen.Select(y => y.Name).ToArray());
            return autoList;
        }

        private void tbVon_TextChanged_1(object sender, EventArgs e)
        {
            //AutoComplete zu TextBox hinzufügen und füllen 
            if (tbVon.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbVon.Text);
                tbVon.AutoCompleteCustomSource = autocompleteListe;
            }
        }

        private void tbNach_TextChanged(object sender, EventArgs e)
        {
            //AutoComplete zu TextBox hinzufügen und füllen
            if (tbNach.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbNach.Text);
                tbNach.AutoCompleteCustomSource = autocompleteListe;
            }
        }

        private void tbAbfahrtsort_TextChanged(object sender, EventArgs e)
        {
            //AutoComplete zu TextBox hinzufügen und füllen
            if (tbAbfahrtsort.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbAbfahrtsort.Text);
                tbAbfahrtsort.AutoCompleteCustomSource = autocompleteListe;
            }
        }

    }
}