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
    public partial class AdminDataForm : Form
    {
        public AdminDataForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = SharedData.data;
            UpdateLabels();
        }

        private void btnGData_Click(object sender, EventArgs e)
        {
            panelImp.Visible = false;
            panelData.Visible = true;
            panelAvailableRooms.Visible = false;
        }

        private void btnAvRoom_Click(object sender, EventArgs e)
        {
            panelImp.Visible = false;
            panelData.Visible = false;
            panelAvailableRooms.Visible = true;
        }

        public void UpdateLabels()
        {
            lblAvDK.Text = Rooms.DeluxeKingRoom.ToString();
            lblAvDT.Text = Rooms.DeluxeTwinRoom.ToString();
            lblAvGDK.Text = Rooms.GrandDeluxeKingRoom.ToString();
            lblAvGDD.Text = Rooms.GrandDeluxeTwinRoom.ToString();
            lblAvPSK.Text = Rooms.PremiumSuiteKingRoom.ToString();
            lblAvPSD.Text = Rooms.PremiumSuiteDoubleRoom.ToString();
            lblAvESK.Text = Rooms.ExecutiveSuiteKingRoom.ToString();
            lblAvESD.Text = Rooms.ExecutiveSuiteDoubleRoom.ToString();
            lblAvPS.Text = Rooms.PresidentialSuiteRoom.ToString();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Remove this row ?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows.RemoveAt(r);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
