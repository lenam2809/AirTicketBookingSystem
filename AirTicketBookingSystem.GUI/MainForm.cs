using AirTicketBookingSystem.BLL;
using AirTicketBookingSystem.DAL;
using AirTicketBookingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketBookingSystem.GUI
{
    public partial class MainForm : Form
    {
        private readonly FlightManager _flightManager;

        public MainForm(FlightManager flightManager)
        {
            InitializeComponent();
            _flightManager = flightManager;
        }

        private void SeachBtn_Click(object sender, EventArgs e)
        {
            var flights = _flightManager.GetAllFlights();
            foreach (var item in flights)
            {
                dataGridView1.Rows.Add(item.From, item.To, item.Date);
            }
        }
    }
}
