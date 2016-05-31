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

        Transport trans = new Transport();

        private void btSuchen_Click(object sender, EventArgs e)
        {
            if (tbVon.Text == "" || tbNach.Text == "")
            {
                MessageBox.Show("Bitte alle Felder Füllen", "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LVResult.Items.Clear();
                DateTime Zeitpunkt = Convert.ToDateTime(DTPDatumVonNach.Text).Date;
                Zeitpunkt += Convert.ToDateTime(DTPZeitVonNach.Text).TimeOfDay;
                Connections connections = trans.GetConnectionsByTime(tbVon.Text, tbNach.Text, Zeitpunkt);

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

        private AutoCompleteStringCollection SearchStations(string query)
        {
            List<Station> stationen = trans.GetStations(query).StationList;
            AutoCompleteStringCollection autoList = new AutoCompleteStringCollection();
            autoList.AddRange(stationen.Select(y => y.Name).ToArray());
            return autoList;
        }


        private void btgenerateabfahrtsort_Click(object sender, EventArgs e)
        {
            if (tbAbfahrtsort.Text == "")
            {
                MessageBox.Show("Bitte alle Felder Füllen", "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StationBoardRoot Stationboards = trans.GetStationBoard(tbAbfahrtsort.Text, trans.GetStations(tbAbfahrtsort.Text).StationList[0].Id);

                LVResult.Items.Clear();
                foreach (StationBoard board in Stationboards.Entries)
                {
                    ListViewItem newBoard = new ListViewItem();
                    newBoard.Text = tbAbfahrtsort.Text;
                    newBoard.SubItems.Add(board.To);
                    newBoard.SubItems.Add(board.Stop.Departure.ToShortTimeString());

                    LVResult.Items.Add(newBoard);
                }
            }
        }

        private void FRMTransportSwiss_Load(object sender, EventArgs e)
        {
            DTPZeitVonNach.Text = DateTime.Now.ToString("HH:mm");
            DTPDatumVonNach.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btKarte_Click(object sender, EventArgs e)
        {
            string station = null;

            Button sends_event = (Button)sender;

            if (sends_event.Name == btKarteVon.Name)
            {
                station = this.tbVon.Text;
            }
            else if (sends_event.Name == btKarteNach.Name)
            {
                station = this.tbNach.Text;
            }
            else if (sends_event.Name == btKarteVonAbfahrt.Name)
            {
                station = this.tbAbfahrtsort.Text;
            }

            Stations stations = trans.GetStations(station);

            string url_maps = "http://maps.google.com/maps?q=loc:" 
                                + stations.StationList.First().Coordinate.XCoordinate.ToString() 
                                + "," 
                                + stations.StationList.First().Coordinate.YCoordinate.ToString();

            Map googleMaps = new Map();

            googleMaps.WBKarte.Navigate(url_maps);
            googleMaps.Show();

        } 

        private void btMailSenden_Click(object sender, EventArgs e)
        {
            if (tbVon.Text == "" || tbNach.Text == "")
            {
                MessageBox.Show("Es wurden noch keine Verbindungen zum verschicken gesucht", "Keine Verbindungen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eMailUndPasswort email = new eMailUndPasswort(LVResult);
                email.Show();
            }
        }

        private void tbVon_TextChanged_1(object sender, EventArgs e)
        {
            if (tbVon.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbVon.Text);
                tbVon.AutoCompleteCustomSource = autocompleteListe;
            }
        }

        private void tbNach_TextChanged(object sender, EventArgs e)
        {
            if (tbNach.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbNach.Text);
                tbNach.AutoCompleteCustomSource = autocompleteListe;
            }
        }

        private void tbAbfahrtsort_TextChanged(object sender, EventArgs e)
        {
            if (tbAbfahrtsort.Text.Length > 1)
            {
                AutoCompleteStringCollection autocompleteListe = SearchStations(tbAbfahrtsort.Text);
                tbAbfahrtsort.AutoCompleteCustomSource = autocompleteListe;
            }
        }

    }
}