namespace WindowsFormsApp2
{
    using System;
    using System.Windows.Forms;
    using Database;

    public partial class Form1 : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public Form1()
        {
            InitializeComponent();

            dataAccess.CreateCarTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmCar = new frmCar();
            frmCar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetOverallMinMaxPriceForRepair();
        }
    }
}