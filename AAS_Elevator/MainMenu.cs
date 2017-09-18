using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAS_Elevator.Bookkeeping;
using AAS_Elevator.Granary;
using AAS_Elevator.Laboratory;
using AAS_Elevator.WeighingStation;

namespace AAS_Elevator
{
    public partial class MainMenu : Form
    {
        public MainMenu(string category)
        {
            InitializeComponent();
            switch (category)
            {
                case "admin": break;
                case "bookkeeper":
                    buttonLaboratory.Enabled = false;
                    buttonGranary.Enabled = false;
                    break;
                case "assistant":
                    buttonBookkeeping.Enabled = false;
                    buttonGranary.Enabled = false;
                    buttonWeighing_station.Enabled = false;
                    break;
                case "headOfWareh":
                    buttonBookkeeping.Enabled = false;
                    buttonWeighing_station.Enabled = false;
                    buttonLaboratory.Enabled = false;
                    break;
            }
        }

        public static void HideAndShowForm(Form outForm, Form inForm)
        {
            outForm.Hide();
            inForm.ShowDialog();
            outForm.Show();
        }
        private void buttonBookkeeping_Click(object sender, EventArgs e)
        {
            HideAndShowForm(this, new BookkeepingForm());
        }

        private void buttonLaboratory_Click(object sender, EventArgs e)
        {
            HideAndShowForm(this, new LaboratoryForm());
        }

        private void buttonWeighing_station_Click(object sender, EventArgs e)
        {
            HideAndShowForm(this, new WeighingStationForm());
        }

        private void buttonGranary_Click(object sender, EventArgs e)
        {
            HideAndShowForm(this, new GranaryForm());
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HideAndShowForm(this, new HelpForm());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
