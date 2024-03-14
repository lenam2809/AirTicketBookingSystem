using AirTicketBookingSystem.BLL;
using AirTicketBookingSystem.BLL.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirTicketBookingSystem.GUI
{
    public partial class MainForm : Form
    {
        private UserService userService;
        private BookingService bookingService;
        private int selectFrom;
        private int selectTo;
        private int selectCabinType;
        public MainForm()
        {
            InitializeComponent();
            userService = new UserService();
            bookingService = new BookingService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbFrom.DataSource = bookingService.GetAllAirports();
            cbFrom.DisplayMember = "IATACode";
            cbFrom.ValueMember = "ID";

            cbTo.DataSource = bookingService.GetAllAirports();
            cbTo.DisplayMember = "IATACode";
            cbTo.ValueMember = "ID";


            cbCabinType.DataSource = bookingService.GetAllCabinTypes();
            cbCabinType.DisplayMember = "Name";
            cbCabinType.ValueMember = "ID";

            rdbOneWay.Checked = true;

            LoadData();
        }

        private void LoadData()
        {
            int selectFrom = int.Parse(cbFrom.SelectedValue.ToString());
            var selectTo = int.Parse(cbTo.SelectedValue.ToString());
            var selectCabinType = int.Parse(cbCabinType.SelectedValue.ToString());

            dgvOutboundFlight.DataSource = bookingService.GetFlightOutbounds(selectFrom, selectTo, selectCabinType, dtpOutbound.Value.Date);
            dgvReturnFilght.DataSource = bookingService.GetFlightReturns(selectFrom, selectTo, selectCabinType, dtpOutbound.Value.Date, dtpReturn.Value.Date);
        }

        private void SeachBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BookFlightBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbOneWay.Checked)
            {
                lblReturnDetail.Hide();
                dgvReturnFilght.Hide();
                checkboxReturnThreeDay.Hide();
                lblReturn.Hide();
                dtpReturn.Hide();
            }
            else
            {
                lblReturnDetail.Show();
                dgvReturnFilght.Show();
                checkboxReturnThreeDay.Show();
                lblReturn.Show();
                dtpReturn.Show();
            }
        }

        //private void CheckPassengersNumber()
        //{
        //    if (checkIdOutbound == true)
        //    {
        //        if (cbb_cabin.Text == "Economy")
        //        {
        //            if (numberPassengers < (numberEconomyOutboundDefault - numberEconomyOutbound))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers Economy is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //        else if (cbb_cabin.Text == "Business")
        //        {
        //            if (numberPassengers < (numberBusinessOutboundDefault - numberBusinessOutbound))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers Business is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //        else if (cbb_cabin.Text == "First Class")
        //        {
        //            if (numberPassengers < (numberTotalOutboundDefault - numberEconomyOutboundDefault - numberBusinessOutboundDefault) - (numberTotalOutbound - numberEconomyOutbound - numberBusinessOutbound))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers First Class is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (cbb_cabin.Text == "Economy")
        //        {
        //            if (numberPassengers < (numberEconomyReturnDefault - numberEconomyReturn))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers Economy is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //        else if (cbb_cabin.Text == "Business")
        //        {
        //            if (numberPassengers < (numberBusinessReturnDefault - numberBusinessReturn))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers Business is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //        else if (cbb_cabin.Text == "First Class")
        //        {
        //            if (numberPassengers < (numberTotalReturnDefault - numberEconomyReturnDefault - numberBusinessReturnDefault) - (numberTotalReturn - numberEconomyReturn - numberBusinessReturn))
        //            {
        //                checkPassengers = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("The number of passengers First Class is full!");
        //                checkPassengers = false;
        //            }
        //        }
        //    }
        //}



        private void DgvOutboundFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvOutboundFlight.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng đã chọn
                string id = selectedRow.Cells["IDOutbound"].Value.ToString();
                string from = selectedRow.Cells["FromOutbound"].Value.ToString();
                string to = selectedRow.Cells["ToOutbound"].Value.ToString();
                string message = $"Bạn có chắc chắn muốn chọn chuyến bay có mã {id} từ {from} đến {to} không?";
                DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("no");
                }
            }
        }

        private void DgvReturnFilght_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvReturnFilght.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng đã chọn
                string id = selectedRow.Cells["IDReturn"].Value.ToString();
                string from = selectedRow.Cells["FromReturn"].Value.ToString();
                string to = selectedRow.Cells["ToReturn"].Value.ToString();
                string message = $"Bạn có chắc chắn muốn chọn chuyến bay có mã {id} từ {from} đến {to} không?";
                DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("no");
                }
            }
        }

        private void CheckboxOutboundThreeDay_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxOutboundThreeDay.Checked)
            {
                dgvOutboundFlight.DataSource = bookingService.GetFlightOutbounds(selectFrom, selectTo, selectCabinType, dtpOutbound.Value.Date);
            }
        }

        private void TxtPassenger_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtPassenger.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for TextBox2.");
                e.Cancel = true;
            }
        }
    }
}
