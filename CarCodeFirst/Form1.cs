using CarCodeFirst.Source;
using CarCodeFirst.Models;
using System.Linq;
using System.Data;

namespace CarCodeFirst
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            carGrid.DataSource = crud.GetCars();
            //carGrid.Columns[5].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVIN.Text) && !string.IsNullOrEmpty(txtMake.Text)
                && !string.IsNullOrEmpty(txtModel.Text))
            {
                Car car = new Car();
                car.VIN = int.Parse(txtVIN.Text);
                car.Make = txtMake.Text;
                car.Model = txtModel.Text;
                car.Price = double.Parse(txtPrice.Text);
                car.Year = int.Parse(txtYear.Text);

                crud.AddRecord(car);
                MessageBox.Show($"{car.VIN} {car.Make} {car.Model} added!");
            }

            btnSubmit.Enabled = false;
            carGrid.DataSource = crud.GetCars();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtVIN.Text = (crud.GetUnusedId()).ToString();
            txtVIN.ReadOnly = true;
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtYear.Clear();

            btnSubmit.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVIN.Text) && !string.IsNullOrEmpty(txtMake.Text)
                && !string.IsNullOrEmpty(txtModel.Text))
            {
                Car car = new Car();
                car.VIN = int.Parse(txtVIN.Text);
                car.Make = txtMake.Text;
                car.Model = txtModel.Text;
                car.Price = double.Parse(txtPrice.Text);
                car.Year = int.Parse(txtYear.Text);

                crud.UpdateRecord(car.VIN, car);
                MessageBox.Show($"{car.VIN} {car.Make} {car.Model} updated!");
                btnUpdate.Enabled = false;
                btnAddNew.Enabled = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = carGrid.SelectedRows[0].Cells["VIN"].Value;
            if (vin is not null)
            {
                var car = crud.GetCar((int)vin);
                if (car is Car)
                {
                    txtVIN.Text = car.VIN.ToString();
                    txtMake.Text = car.Make;
                    txtModel.Text = car.Model;
                    txtPrice.Text = car.Price.ToString();
                    txtYear.Text = car.Year.ToString();
                    btnAddNew.Enabled = false;
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carGrid.DataSource = crud.GetCars();
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddNew.Enabled = true;

            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtYear.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = carGrid.CurrentRow.Cells[0].Value;
            crud.DeleteRecord((int)id);
            MessageBox.Show("Record deleted!");
            carGrid.DataSource = crud.GetCars();
        }
    }
}
