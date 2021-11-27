using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLab
{
	public partial class FindOfficeForm : Form
	{
		public Office modelOfClientOffice = new Office(); //Создаём модель коммерческой недвижимости клиента
		public FindOfficeForm()
		{// Инициализируем
			InitializeComponent();
			modelOfClientOffice.GeneralCharacteristics = new RealEstate();  //Общие параметры
			this.FormClosing += FindOfficeForm_FormClosing;
			modelOfClientOffice.CountOfRooms = 1; //Количество помещений
			
			modelOfClientOffice.Floor = 1; //Этаж
			modelOfClientOffice.Parking = "Нет"; //Стоянка
			modelOfClientOffice.Specifications = "Не имеет значения"; //Инфраструктура
			modelOfClientOffice.Years = 100; //Возраст здания
			modelOfClientOffice.GeneralCharacteristics.Price = 100000000; // Цена
			modelOfClientOffice.GeneralCharacteristics.Square = 100000; //Площадь
		}

		private void FindOfficeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void FindForm_Load(object sender, EventArgs e)
		{

		}

		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем цену
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 3000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 3000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "3000000 - 6000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 6000000;
			}
			else
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 1000000000;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void GoBackButton_Click(object sender, EventArgs e)
		{

		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем площадь
		{
			if (SquareComboBox.SelectedItem.ToString() == "< 50")
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 0;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "50 - 200")
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 50;
			}
			else 
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 200;
			}
		}

		private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем возраст здания
		{
			if (YearsComboBox.SelectedItem.ToString() == "меньше 10 лет")
			{
				modelOfClientOffice.Years = 10;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "10-15 лет")
			{
				modelOfClientOffice.Years = 15;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "15-30 лет")
			{
				modelOfClientOffice.Years = 30;
			}
			else
			{
				modelOfClientOffice.Years = 31;
			}
		}

		private void InfastuctureComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем инфраструктуру
		{
			if (InfastuctureComboBox.SelectedItem.ToString() == "Развитая")
			{
				modelOfClientOffice.Specifications = "Развитая";
			}
			else
			{
				modelOfClientOffice.Specifications = "Не имеет значения";
			}
		}

		


		private void CountOfRoomsComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем количество помещений
		{
			if (CountOfRoomsComboBox.SelectedItem.ToString() == "1 - 2")
			{
				modelOfClientOffice.CountOfRooms = 1;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "2 - 5")
			{
				modelOfClientOffice.CountOfRooms = 2;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "5 - 10")
			{
				modelOfClientOffice.CountOfRooms = 5;
			}
			else
			{
				modelOfClientOffice.CountOfRooms = 10;
			}
		}

		private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем этаж
		{
			if (FloorComboBox.SelectedItem.ToString() == "1")
			{
				modelOfClientOffice.Floor = 1;
			}
			else
			{
				modelOfClientOffice.Floor = 2;
			}

		}

		private void ParkingCheckBox_CheckedChanged(object sender, EventArgs e) //Устанавливаем парковку
		{
			if (ParkingCheckBox.Checked)
			{
				modelOfClientOffice.Parking = "Есть";
			}
			else
			{
				modelOfClientOffice.Parking = "Нет";
			}
		}


		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientOffice);
			resultForm.Show();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем общие параметры
		{
			modelOfClientOffice.GeneralCharacteristics.Location = comboBox1.SelectedItem.ToString();
	    }

		private void PriceComboBox_SelectedIndexChanged_1(object sender, EventArgs e) //Устанавливаем цены
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 3000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 3000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "3000000 - 6000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 6000000;
			}
			else
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 100000000;
			}
		}

		private void GoBackButton_Click_1(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}
		private void formClosing()
		{
			Application.Exit();
		}
	}
}
