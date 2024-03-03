using AirTicketBookingSystem.BLL;
using AirTicketBookingSystem.DAL;
using AirTicketBookingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketBookingSystem.GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AirTicketEntities dbContext = new AirTicketEntities();
            IFlightRepository flightRepository = new FlightRepository(dbContext);
            FlightManager flightManager = new FlightManager(flightRepository);
            Application.Run(new MainForm(flightManager));
        }
    }
}
