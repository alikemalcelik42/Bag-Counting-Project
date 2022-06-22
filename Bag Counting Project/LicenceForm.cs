using System.Data;
using System.Net.NetworkInformation;

namespace Bag_Counting_Project
{
    public partial class LicenceForm : Form
    {
        public LicenceForm()
        {
            InitializeComponent();
            idValueLbl.Text = (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
        }

        private void saveKeyBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText("key.txt", keyTxt.Text);
        }
    }
}
