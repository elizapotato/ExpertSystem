﻿using System;
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
	public partial class FindApartmentForm : Form
	{
		public Apartment modelOfClientApartment = new Apartment(); // Создаём модель квартиры клиента
		public FindApartmentForm()
		{// Инициализируем 
			InitializeComponent();
			modelOfClientApartment.GeneralCharacteristics = new RealEstate(); // Общие характеристики
			this.FormClosing += FindApartmentForm_FormClosing;

			modelOfClientApartment.GeneralCharacteristics.Price = 100000000; //Цена
			modelOfClientApartment.GeneralCharacteristics.Square = 10000; //Площадь
			modelOfClientApartment.GeneralCharacteristics.Location = "В городе"; //Расположение
			modelOfClientApartment.CountOfRooms = 10; //Количество комнат
			modelOfClientApartment.Elevator = "Нет"; // Наличие лифта
			modelOfClientApartment.Floor = 2; // Этаж
			modelOfClientApartment.Infrastructure = "Не имеет значения"; //Инфраструктура
			modelOfClientApartment.MaxFloor = 100; // Максимальный этаж 
			modelOfClientApartment.NewOrOld = "Вторичка"; 
			modelOfClientApartment.Parking = "Нет"; //Парковка
			modelOfClientApartment.TransportAccessibility = "Не имеет значения"; //Транспортная доступность
			modelOfClientApartment.TypeOfBuilding = "Кирпичный"; //Тип постройки дома
			modelOfClientApartment.View = "Нет"; // Красивый вид
			modelOfClientApartment.Years = 100; //Возраст здания
		}

		private void FindApartmentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем цену
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientApartment.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 2000000")
			{
				modelOfClientApartment.GeneralCharacteristics.Price = 2000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "2000000 - 3000000")
			{
				modelOfClientApartment.GeneralCharacteristics.Price = 3000000;
			}
			else
			{
				modelOfClientApartment.GeneralCharacteristics.Price = 300000000;
			}
		}

		private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем расположение
		{
			if (PositionComboBox.SelectedItem.ToString() == "В городе")
			{
				modelOfClientApartment.GeneralCharacteristics.Location = "В городе";
			}
			else
			{
				modelOfClientApartment.GeneralCharacteristics.Location = "За городом";
			}
		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем площадь
		{
			if (SquareComboBox.SelectedItem.ToString() == "< 50")
			{
				modelOfClientApartment.GeneralCharacteristics.Square = 0;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "50 - 100")
			{
				modelOfClientApartment.GeneralCharacteristics.Square = 50;
			}
			else
			{
				modelOfClientApartment.GeneralCharacteristics.Square = 100;
			}
		}

		private void InfastuctureComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем инфраструктуру
		{
			if (InfastuctureComboBox.SelectedItem.ToString() == "Развитая")
			{
				modelOfClientApartment.Infrastructure = "Развитая";
			}
			else
			{
				modelOfClientApartment.Infrastructure = "Не имеет значения";
			}
		}

		private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем возраст здания
		{
			if (YearsComboBox.SelectedItem.ToString() == "меньше 10 лет")
			{
				modelOfClientApartment.Years = 10;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "10-15 лет")
			{
				modelOfClientApartment.Years = 15;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "15-30 лет")
			{
				modelOfClientApartment.Years = 30;
			}
			else
			{
				modelOfClientApartment.Years = 100;
			}
		}

		private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем этаж
		{
			if (FloorComboBox.SelectedItem.ToString() == "Первый этаж")
			{
				modelOfClientApartment.Floor = 1;
			}
			else if (FloorComboBox.SelectedItem.ToString() == "От второго до предпоследнего")
			{
				modelOfClientApartment.Floor = 2;
			}
			else
			{
				modelOfClientApartment.Floor = 3;
			}
		}

		private void CountOfRoomsComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем количество комнат
		{
			if (CountOfRoomsComboBox.SelectedItem.ToString() == "1")
			{
				modelOfClientApartment.CountOfRooms = 1;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "2")
			{
				modelOfClientApartment.CountOfRooms = 2;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "3")
			{
				modelOfClientApartment.CountOfRooms = 3;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "4")
			{
				modelOfClientApartment.CountOfRooms = 4;
			}
			else
			{
				modelOfClientApartment.CountOfRooms = 5;
			}
		}

		private void MaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e) //Устанавливаем тип постройки дома
		{
			if (MaterialsComboBox.SelectedItem.ToString() == "Панельный")
			{
				modelOfClientApartment.TypeOfBuilding = "Панельный";
			}
			else if (MaterialsComboBox.SelectedItem.ToString() == "Кирпичный")
			{
				modelOfClientApartment.TypeOfBuilding = "Кирпичный";
			}
			else if (MaterialsComboBox.SelectedItem.ToString() == "Деревянный")
			{
				modelOfClientApartment.TypeOfBuilding = "Деревянный";
			}
			else
			{
				modelOfClientApartment.TypeOfBuilding = "Монолитный";
			}
		}


		private void ParkingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ParkingCheckBox.Checked)
			{
				modelOfClientApartment.Parking = "Есть";
			}
			else
			{
				modelOfClientApartment.Parking = "Нет";
			}
		}

		private void TransportСheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (TransportСheckBox.Checked)
			{
				modelOfClientApartment.TransportAccessibility = "Развитая";
			}
			else
			{
				modelOfClientApartment.TransportAccessibility = "Не имеет значения";
			}
		}

		

		private void ViewCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ViewCheckBox.Checked)
			{
				modelOfClientApartment.View = "Есть";
			}
			else
			{
				modelOfClientApartment.View = "Нет";
			}
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientApartment);
			resultForm.Show();
		}

		private void NewOrOldcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (NewOrOldcheckBox.Checked)
			{
				modelOfClientApartment.NewOrOld = "Новостройка";
			}
			else
			{
				modelOfClientApartment.NewOrOld = "Вторичка";
			}
		}

		private void GoBackButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();

		}

		private void Elevator_CheckedChanged(object sender, EventArgs e)
		{
			if (Elevator.Checked)
			{
				modelOfClientApartment.Elevator = "Есть";
			}
			else
			{
				modelOfClientApartment.Elevator = "Нет";
			}
		}
	}
}
