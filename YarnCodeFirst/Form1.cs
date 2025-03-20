using YarnCodeFirst.Models;
using YarnCodeFirst.Source;

namespace YarnCodeFirst
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
            yarnGrid.DataSource = crud.GetYarn();
            yarnGrid.Columns[4].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;

            foreach (var d in Enum.GetValues(typeof(Weight)))
            {
                comboWeight.Items.Add(d.GetType());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYarnId.Text) && !string.IsNullOrEmpty(txtYarnName.Text))
            {
                if(comboWeight.SelectedIndex != -1)
                {
                    var newYarn = new Yarn();
                    newYarn.ManufacturerID = int.Parse(txtManufacturerId.Text);
                    if (comboWeight.SelectedItem is not null)
                    {
                        newYarn.weight = (Weight)comboWeight.SelectedItem;
                    }

                    newYarn.YarnId = int.Parse(txtYarnId.Text);
                    crud.AddRecord(newYarn);
                    MessageBox.Show("Record Added");
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtYarnId.Text = (crud.GetMaxId() + 1).ToString();
            txtYarnId.ReadOnly = true;
            txtYarnName.Clear();
            txtManufacturerId.Clear();
            txtManufacturerName.Clear();
            btnSelectUpdate.Enabled = true;
        }
    }
}
