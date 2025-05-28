using LashaMurgvaLominadzeShraieri.Quiz3.Models;

namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    public partial class CarDialog : Form
    {
        public string Model { get; private set; }
        public double Weight { get; private set; }
        public double Speed { get; private set; }

        public CarDialog()
        {
            InitializeComponent();
        }

        public CarDialog(Car car) : this()
        {
            ModelTextBox.Text = car.Model;
            WeightTextBox.Text = car.Weight.ToString();
            SpeedTextBox.Text = car.Speed.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Model = ModelTextBox.Text;

            if (!double.TryParse(WeightTextBox.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(SpeedTextBox.Text, out double speed))
            {
                MessageBox.Show("Please enter a valid speed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Weight = weight;
            Speed = speed;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
