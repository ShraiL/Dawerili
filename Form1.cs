using LashaMurgvaLominadzeShraieri.Quiz3.Models;
using LashaMurgvaLominadzeShraieri.Quiz3.Services;
using System.ComponentModel;
using System.Windows.Forms;

namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    public partial class Form1 : Form
    {
        private readonly CarService _carService;
        private readonly BindingList<Car> _bindingList;
        private int _currentEditIndex = -1;

        public Form1()
        {
            InitializeComponent();
            _carService = new CarService();
            _bindingList = new BindingList<Car>();
            listBox.DataSource = _bindingList;
            listBox.DisplayMember = "ToString"; 
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CarDialog dialog = new CarDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(
                    dialog.Model,
                    dialog.Weight,
                    dialog.Speed
                );

                _carService.AddCar(car);
                Sync(); 
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                var selectedCar = _carService.GetCars().ToList()[index];
                CarDialog dialog = new CarDialog(selectedCar);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedCar.Model = dialog.Model;
                    selectedCar.Weight = dialog.Weight;
                    selectedCar.Speed = dialog.Speed;

                    _carService.UpdateCar(index, selectedCar);
                    Sync(); 
                }
            }
        }

        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                _carService.DeleteCar(index);
                Sync(); 
            }
        }

        
        private void Sync()
        {
            _bindingList.Clear(); 
            var cars = _carService.GetCars();
            foreach (var car in cars)
            {
                _bindingList.Add(car); 
            }
        }
    }
}
