using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using YaduVilasHM.DataService;
using YaduVilasHM.Models;

namespace YaduVilasHM
{
    public partial class Form1 : Form
    {
        Booking CurrentBooking = new Booking();
        List<Room> rooms = new List<Room>();
        Booking ConfirmedBooking = new Booking();
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            panel3.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            List<string> lstInput = new List<string> { txtUsername.Text,txtPassword.Text};
            if(Helper.ValidateTextFields(lstInput))
            {
                LogInService _service = new LogInService();
                var user = await _service.GetUserLoggedIn(txtUsername.Text, txtPassword.Text);
                if (user != null)
                    MessageBox.Show("Logged in.");
                else
                {
                    txtPassword.Text = "";
                    lblError.Text = "Invalid Username or Password";
                    panel3.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Username and password are required";
                panel3.Visible = true;
            }
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab == MainTab.TabPages["tabBookings"])
                InitializeBookingTab(sender, e);
        }
        private void InitializeBookingTab(object sender, EventArgs e)
        {
            fromDatePicker.MinDate = DateTime.Now.AddDays(-1);
            toDatePicker.MinDate = DateTime.Now;
            pnlSelectRoom.Visible = false;
            ComboBoxDeluxe.DataSource = new List<string>();
            comboBoxExecutive.DataSource = new List<string>();
            comboBoxSuit.DataSource = new List<string>();
            radDeluxe.Checked = false;
            radExecutive.Checked = false;
            radSuit.Checked = false;
            errPannel.Visible = false;
            btnConfirmBooking.Visible = false;
            txtGuestName.Text = "";
            txtNationalIdNumber.Text = "";
            txtNationalIdType.Text = "";
            lblTotalDays.Visible = false;
            lblTotalDays.Text = "";
        }

        private async void btnCheckAvailableRoom_Click(object sender, EventArgs e)
        {
            lblTotalDays.Text = "";
            lblTotalDays.Visible = false;
            btnConfirmBooking.Visible = false;
            pnlSelectRoom.Visible = false;
            ComboBoxDeluxe.DataSource = new List<string>();
            comboBoxExecutive.DataSource = new List<string>();
            comboBoxSuit.DataSource = new List<string>(); 
            radDeluxe.Checked = false;
            radExecutive.Checked = false;
            radSuit.Checked = false;
            errPannel.Visible = false;
            if (Helper.ValidateDateRange(Convert.ToDateTime(fromDatePicker.Value), Convert.ToDateTime(toDatePicker.Value),txtGuestName.Text))
            {
                
                CurrentBooking.BookingPerson = txtGuestName.Text;
                CurrentBooking.BookingDate = DateTime.Now;
                CurrentBooking.FromDate = Convert.ToDateTime(fromDatePicker.Value);
                CurrentBooking.ToDate = Convert.ToDateTime(toDatePicker.Value);
                CurrentBooking.NationalIdType = txtNationalIdType.Text;
                CurrentBooking.NationalIdNumber = txtNationalIdNumber.Text;
                lblTotalDays.Text = $"Total Days: {CurrentBooking.ToDate.Subtract(CurrentBooking.FromDate).Days}";
                lblTotalDays.Visible = true;
                BookingService _bookingService = new BookingService();
                var bookings = await _bookingService.GetAllBookings(Convert.ToDateTime(fromDatePicker.Value), Convert.ToDateTime(toDatePicker.Value));
                rooms = BookingService.rooms;
                List<Room> availableRooms = Booking.GetAvailableRooms(rooms, bookings);
                if(availableRooms.Count>0)
                {
                    List<string> DeluxeRooms = new List<string>();
                    List<string> ExecutiveRooms = new List<string>();
                    List<string> SuitRooms = new List<string>();
                    foreach (var room in availableRooms)
                    {
                        if (room.RoomType == "Deluxe")
                            DeluxeRooms.Add(room.RoomName);
                        else if (room.RoomType == "Executive")
                            ExecutiveRooms.Add(room.RoomName);
                        else
                            SuitRooms.Add(room.RoomName);
                    }
                    ComboBoxDeluxe.DataSource = DeluxeRooms;
                    comboBoxExecutive.DataSource = ExecutiveRooms;
                    comboBoxSuit.DataSource = SuitRooms;
                    SetRadioButtonAndCombobox(DeluxeRooms, ExecutiveRooms, SuitRooms);
                    pnlSelectRoom.Visible = true;
                    btnConfirmBooking.Visible = true;
                }
                else
                {
                    pnlSelectRoom.Visible = false;
                    errLblBooking.Text = "No Rooms available for the specified period.";
                    errPannel.Visible = true;
                }
            }
            else
            {
                errLblBooking.Text = "Name is required, To Date must be greater than from date.";
                errPannel.Visible = true;
            }
        }

        private async void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (Helper.ValidateDateRange(Convert.ToDateTime(fromDatePicker.Value), Convert.ToDateTime(toDatePicker.Value), txtGuestName.Text)
                &&(radSuit.Checked||radExecutive.Checked||radDeluxe.Checked))
            {
                string roomName = "";
                if (radDeluxe.Checked)
                    roomName = ComboBoxDeluxe.Text;
                if (radExecutive.Checked)
                    roomName = comboBoxExecutive.Text;
                if (radSuit.Checked)
                    roomName = comboBoxSuit.Text;
                CurrentBooking.RoomId = rooms.Where(x => x.RoomName == roomName).Select(x => x.RoomId).FirstOrDefault();
                try
                {
                    BookingService _bookingService = new BookingService();
                    ConfirmedBooking = await _bookingService.BookingInsert(CurrentBooking);
                    if(ConfirmedBooking == null || ConfirmedBooking.BookingId ==0)
                    {
                        MessageBox.Show("An Error Occured while booking.");
                    }
                    else
                    {
                        MessageBox.Show($"Congratulations your booking has been confirmed and your booking number is {ConfirmedBooking.BookingId}");
                        InitializeBookingTab(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured {ex.Message}");
                }
            }
            else
            {
                errLblBooking.Text = "Name is required, To Date must be greater than from date, Please select a Room type.";
                errPannel.Visible = true;
            }
        }
        private void SetRadioButtonAndCombobox(List<string> DeluxeRooms, List<string> ExecutiveRooms, List<string> SuitRooms)
        {
            if (DeluxeRooms.Count == 0)
            {
                radDeluxe.Visible = false;
                ComboBoxDeluxe.Visible = false;
            }
            else
            {
                radDeluxe.Visible = true;
                ComboBoxDeluxe.Visible = true;
            }
            if (SuitRooms.Count == 0)
            {
                radSuit.Visible = false;
                comboBoxSuit.Visible = false;
            }
            else
            {
                radSuit.Visible = true;
                comboBoxSuit.Visible = true;
            }
            if (ExecutiveRooms.Count == 0)
            {
                radExecutive.Visible = false;
                comboBoxExecutive.Visible = false;
            }
            else
            {
                radExecutive.Visible = true;
                comboBoxExecutive.Visible = true;
            }
        }
    }
}
