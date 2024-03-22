namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Database;
    using Entities;
    using FontAwesome.Sharp;

    public partial class frmCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmCar()
        {
            InitializeComponent();
            CenterToScreen();


            //Panel
            leftBorderBtn = new Panel();    
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // *** PANEL BUTTONS *** //
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(49, 54, 63);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(118, 171, 174);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 40, 49);
                currentBtn.ForeColor = Color.FromArgb(238, 238, 238);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(238, 238, 238);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        // Add a car
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (txtLicensePlate.Text == "" || txtModel.Text == "" ||
        //        txtMake.Text == "" ||
        //        txtColor.Text == "" ||
        //        txtYear.Text == "" ||
        //        txtSeats.Text == "" ||
        //        txtPriceForRepairing.Text == "")
        //    {
        //        MessageBox.Show("Please fill all the fields to create a car.");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Car newCar = new Car
        //            {
        //                LicensePlate = txtLicensePlate.Text,
        //                Model = txtModel.Text,
        //                Make = txtMake.Text,
        //                Color = txtColor.Text,
        //                Year = Convert.ToInt32(txtYear.Text),
        //                Seats = Convert.ToInt32(txtSeats.Text),
        //                PriceForRepairing = Convert.ToDouble(txtPriceForRepairing.Text)
        //            };

        //            dataAccess.CreateCar(newCar);
        //            DisplayAllCars();
        //        }
        //        catch (Exception exc)
        //        {
        //            MessageBox.Show(exc.Message);
        //        }
        //    }
        //}

        // Update a car
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        try
        //        {
        //            int carId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

        //            Car carToUpdate = dataAccess.GetAllCars().First(x => x.Id == carId);

        //            if (txtLicensePlate.Text.Length != 0)
        //            {
        //                carToUpdate.LicensePlate = txtLicensePlate.Text;
        //            }

        //            if (txtModel.Text.Length != 0)
        //            {
        //                carToUpdate.Model = txtModel.Text;
        //            }

        //            if (txtMake.Text.Length != 0)
        //            {
        //                carToUpdate.Make = txtMake.Text;
        //            }

        //            if (txtColor.Text.Length != 0)
        //            {
        //                carToUpdate.Color = txtColor.Text;
        //            }

        //            if (txtYear.Text.Length != 0)
        //            {
        //                carToUpdate.Year = Convert.ToInt32(txtYear.Text);
        //            }

        //            if (txtSeats.Text.Length != 0)
        //            {
        //                carToUpdate.Seats = Convert.ToInt32(txtSeats.Text);
        //            }

        //            if (txtPriceForRepairing.Text.Length != 0)
        //            {
        //                carToUpdate.PriceForRepairing = Convert.ToDouble(txtPriceForRepairing.Text);
        //            }

        //            dataAccess.UpdateCar(carToUpdate);
        //            DisplayAllCars();
        //        }
        //        catch (Exception exc)
        //        {
        //            MessageBox.Show(exc.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a car to update.");
        //    }
        //}

        // Delete a car
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            int carIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

        //            dataAccess.DeleteCar(carIdToDelete);

        //            DisplayAllCars();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a car to delete.");
        //    }
        //}

        // Display all cars
        //private void DisplayAllCars()
        //{
        //    List<Car> allCars = dataAccess.GetAllCars();
        //    dataGridView1.DataSource = allCars;
        //}

        // Empty all fields
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    txtLicensePlate.Text = "";
        //    txtModel.Text = "";
        //    txtMake.Text = "";
        //    txtColor.Text = "";
        //    txtYear.Text = "";
        //    txtSeats.Text = "";
        //    txtPriceForRepairing.Text = "";
        //}

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string licensePlate = txtLicensePlate.Text.Trim();
        //        string model = txtModel.Text.Trim();
        //        string make = txtMake.Text.Trim();
        //        string color = txtColor.Text.Trim();
        //        string year = txtYear.Text.Trim();
        //        string seats = txtSeats.Text.Trim();
        //        string priceForRepairing = txtPriceForRepairing.Text.Trim();

        //        List<Car> filteredCars =
        //            dataAccess.GetFilteredCars(licensePlate, model, make, color, year, seats, priceForRepairing);
        //        dataGridView1.DataSource = filteredCars;
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //}

        //private void btnPopulateCars_Click(object sender, EventArgs e)
        //{
        //    // Populate with 30 example cars

        //    Random rnd = new Random();
        //    string[] randomMakes =
        //        { "Toyota", "Ford", "VW", "Honda", "Nissan", "Mercedes-Benz", "BMW", "Audi", "Porsche", "Mazda" };
        //    string[] randomModels =
        //    {
        //        "M5", "Focus", "Civic", "A3", "Corolla", "Accord", "Golf", "Passat", "E90", "Auris", "Panamera", "F10"
        //    };
        //    string[] randomColors = { "Red", "Blue", "White", "Black", "Silver", "Gray" };

        //    for (int i = 0; i < 30; i++)
        //    {
        //        Car randomCar = new Car
        //        {
        //            LicensePlate = "RA " + rnd.Next(1000, 9999) + " ND",
        //            Model = randomModels[rnd.Next(randomModels.Length)],
        //            Make = randomMakes[rnd.Next(randomMakes.Length)],
        //            Color = randomColors[rnd.Next(randomColors.Length)],
        //            Year = rnd.Next(1996, 2024),
        //            Seats = rnd.Next(2, 8),
        //            PriceForRepairing = rnd.Next(100, 20000)
        //        };
        //        dataAccess.CreateCar(randomCar);
        //    }


        //    MessageBox.Show("30 example cars populated successfully!");
        //    DisplayAllCars();
        //}

        //private void btnDeleteAllCars_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Are you sure you want to delete all cars?", "Confirm",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        dataAccess.DeleteAllCars();
        //        DisplayAllCars();
        //    }
        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(118, 171, 174);
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(118, 171, 174));
            OpenChildForm(new FormDashboard());
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(118, 171, 174));
            OpenChildForm(new FormAddCar());
        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(118, 171, 174));
            OpenChildForm(new FormDeleteCar());
        }

        private void btnMenuUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(118, 171, 174));
            OpenChildForm(new FormUpdateCar());
        }

        private void btnMenuSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(118, 171, 174));
            OpenChildForm(new FormSearchCar());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}