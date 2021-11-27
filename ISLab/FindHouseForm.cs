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
	public partial class FindHouseForm : Form
	{
		public House modelOfClientHouse = new House(); //созздаём модель дома клиента
		public FindHouseForm()
		{// инициализируем параметры
			InitializeComponent();
			modelOfClientHouse.GeneralCharacteristics = new RealEstate();  //общие параметры
			this.FormClosing += FindHouseForm_FormClosing; 
			modelOfClientHouse.GeneralCharacteristics.Price = 1000000000; //цена
			modelOfClientHouse.GeneralCharacteristics.Square = 1000000; // площадь
			modelOfClientHouse.Comunication = "Нет"; //коммуникация
			modelOfClientHouse.Floors = 1; //этаж
			modelOfClientHouse.TransportAccessibility = "Не имеет значения"; //транспортная доступность
			modelOfClientHouse.TypeOfHouse = "Бревенчатый"; //тип дома
			modelOfClientHouse.GeneralCharacteristics.Location = "За городом"; //расположение

		}

		private void FindHouseForm_FormClosing(object sender, FormClosingEventArgs e) //закрытие формы
		{
			Application.Exit();
		}

		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e) //устанавливаем цены
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 3000000")
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 3000000;
			}
			else if (PriceComboBox.SelectedItem.ToString().Equals("3000000 - 6000000"))
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 6000000;
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 1000000000;
			}
		}

		private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e) // указание места положения 
		{
			if (PositionComboBox.SelectedItem.ToString() == "В городе")
			{
				modelOfClientHouse.GeneralCharacteristics.Location = "В городе";
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Location = "За городом";
			}
		}

		private void TransportComboBox_SelectedIndexChanged(object sender, EventArgs e) //указание транспортной доступности
		{
			if (TransportComboBox.SelectedItem.ToString() == "Развитая")
			{
				modelOfClientHouse.TransportAccessibility = "Развитая";
			}
			else
			{
				modelOfClientHouse.TransportAccessibility = "Не имеет значения";
			}
		}

		private void TypeOfHouseComboBox_SelectedIndexChanged(object sender, EventArgs e) //тип постройки дома
		{
			if (TypeOfHouseComboBox.SelectedItem.ToString() == "Деревянный")
			{
				modelOfClientHouse.TypeOfHouse = "Деревянный";
			}else if (TypeOfHouseComboBox.SelectedItem.ToString() == "Кирпичный")
			{
				modelOfClientHouse.TypeOfHouse = "Кирпичный";
			}
			else
			{
				modelOfClientHouse.TypeOfHouse = "Бревенчатый";
			}
		}

		private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e) //площадь
		{
			if (SizeComboBox.SelectedItem.ToString() == "< 80")
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 0;
			}
			else if (SizeComboBox.SelectedItem.ToString() == "80 - 150")
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 80;
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 150;
			}
		}

		private void CountOfFloorsComboBox_SelectedIndexChanged(object sender, EventArgs e) //количество этажей
		{
			if (CountOfFloorsComboBox.SelectedItem.ToString() == "1")
			{
				modelOfClientHouse.Floors = 1;
			}
			else if (CountOfFloorsComboBox.SelectedItem.ToString() == "2")
			{
				modelOfClientHouse.Floors = 2;
			}
			else if (CountOfFloorsComboBox.SelectedItem.ToString() == "3")
			{
				modelOfClientHouse.Floors = 3;
			}
			else
			{
				modelOfClientHouse.Floors = 4;
			}
		}


		private void ComunicationCheckBox_CheckedChanged(object sender, EventArgs e) //Коммуникация
		{
			if (ComunicationCheckBox.Checked)
			{
				modelOfClientHouse.Comunication = "Есть";
			}
			else
			{
				modelOfClientHouse.Comunication = "Нет";
			}
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientHouse);
			resultForm.Show();
			
		}

		private void GoBackButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}
	}
}
