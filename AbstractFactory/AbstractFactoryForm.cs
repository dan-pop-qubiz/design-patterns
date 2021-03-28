using DesignPatterns.AbstractFactory.Vehicles;
using System;
using System.Windows.Forms;

namespace DesignPatterns.AbstractFactory
{
    public partial class AbstractFactoryForm : Form
    {
        VehicleFilter filter;

        public AbstractFactoryForm()
        {
            filter = new VehicleFilter
            {
                HasCargo = false,
                HasEngine = true,
                NumberOfPassengers = 5,
                NumberOfWheels = 4
            };

            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (hasCargoYes.Checked)
            {
                filter.HasCargo = true;
            }
            if (hasCargoNo.Checked)
            {
                filter.HasCargo = false;
            }

            if (hasEngineYes.Checked)
            {
                filter.HasEngine = true;
            }
            if (hasEngineNo.Checked)
            {
                filter.HasEngine = false;
            }

            filter.NumberOfPassengers = int.Parse(numberOfPassengers.Text);
            filter.NumberOfWheels = int.Parse(numberOfWheels.Text);

            AbstractVehicleFactory factory = new VehicleFactory(filter);
            IVehicle vehicle = factory.Create();

            MessageBox.Show("We created a " + vehicle.Name);
        }
    }
}