using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Dashboard : Form
    {
        
        bool isFormOpen = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            foreach (Form openform in Application.OpenForms)
            {
                if (openform.Name == "GuestForm") // Replace with the actual form name
                {
                    isFormOpen = true;
                    openform.BringToFront();
                    openform.Activate();
                    break;
                }
            }

            if (!isFormOpen)
            {
                GuestForm guestForm = new GuestForm();
                guestForm.Show();
            }
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
