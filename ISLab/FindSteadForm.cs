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
	public partial class FindSteadForm : Form
	{
		public Stead modelOfClientSted = new Stead(); // создаём модель земельного участка
		public FindSteadForm()
		{// Инициализируем 
			InitializeComponent();
			modelOfClientSted.GeneralCharacteristics = new RealEstate(); // Общие характеристики
			this.FormClosing += FindSteadForm_FormClosing;

			modelOfClientSted.GeneralCharacteristics.Price = 100000000; //цена
			modelOfClientSted.GeneralCharacteristics.Square = 1000000; //площадь
			modelOfClientSted.GeneralCharacteristics.Location = "В области"; //расположение
			modelOfClientSted.TypeOfSoil = "Дерново-подзолистая"; //тип почвы
			modelOfClientSted.Ecology = "Нет"; //экология
			modelOfClientSted.TransportAccessibility = "Не имеет значения"; //транспортная доступность
		}

		private void FindSteadForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientSted);
			resultForm.Show();
		}
		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e) //устанавливаем цену
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientSted.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 2000000")
			{
				modelOfClientSted.GeneralCharacteristics.Price = 2000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "2000000 - 3000000")
			{
				modelOfClientSted.GeneralCharacteristics.Price = 3000000;
			}
			else
			{
				modelOfClientSted.GeneralCharacteristics.Price = 300000000;
			}

		}

		private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e) //устанавливаем расположение
		{
			modelOfClientSted.GeneralCharacteristics.Location = PositionComboBox.SelectedItem.ToString();
		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e) //устанавливаем площадь
		{
			if (SquareComboBox.SelectedItem.ToString() == "< 1 га")
			{
				modelOfClientSted.GeneralCharacteristics.Square = 0;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "1 -5 га")
			{
				modelOfClientSted.GeneralCharacteristics.Square = 1;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "5 - 10 га")
			{
				modelOfClientSted.GeneralCharacteristics.Square = 5;
			}
			else
			{
				modelOfClientSted.GeneralCharacteristics.Square = 10;
			}
		}


		private void FindSteadForm_Load(object sender, EventArgs e)
		{

		}

		
		
		

		private void TransportCheckBox_CheckedChanged(object sender, EventArgs e) //устанавливаем транспортную доступность
		{
			if (TransportCheckBox.Checked)
			{
				modelOfClientSted.TransportAccessibility = "Развитая";
			}
			else
			{
				modelOfClientSted.TransportAccessibility = "Не имеет значения";
			}
		}

		private void EcologyCheckBox_CheckedChanged(object sender, EventArgs e) //устанавливаем экологию
		{
			if (EcologyCheckBox.Checked)
			{
				modelOfClientSted.Ecology = "Есть";
			}
			else
			{

				modelOfClientSted.Ecology = "Нет";
			}
		}

		

		private void GoBackButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}

		private void TypeOfSoilComboBox_SelectedIndexChanged(object sender, EventArgs e) //устанавлиаем тип почвы
		{
			if (TypeOfSoilComboBox.SelectedItem.ToString() == "Дерново-подзолистая")
			{
				modelOfClientSted.TypeOfSoil = "Дерново-подзолистая";
			}
			else if (TypeOfSoilComboBox.SelectedItem.ToString() == "Серая лесная")
			{
				modelOfClientSted.TypeOfSoil = "Серая лесная";
			}
			else
			{
				modelOfClientSted.TypeOfSoil = "Торфяно-болотная";
			}
		}
	}
}
