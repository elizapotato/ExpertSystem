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
		public Stead modelOfClientSted = new Stead();
		public FindSteadForm()
		{
			InitializeComponent();
			modelOfClientSted.GeneralCharacteristics = new RealEstate();
			this.FormClosing += FindSteadForm_FormClosing;

			modelOfClientSted.GeneralCharacteristics.Price = 100000000;
			modelOfClientSted.GeneralCharacteristics.Square = 1000000;
			modelOfClientSted.GeneralCharacteristics.Location = "В области";
			modelOfClientSted.AdjacentTerritory = 5;
			modelOfClientSted.Ecology = "Средняя";
			modelOfClientSted.TransportAccessibility = "Неразвитая";
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
		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

		private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			modelOfClientSted.GeneralCharacteristics.Location = PositionComboBox.SelectedItem.ToString();
		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

		/*
		private void NearTerritoryCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (NearTerritoryCheckBox.Checked)
			{
				modelOfClientSted.AdjacentTerritory = "Есть";
			}
			else
			{
				modelOfClientSted.AdjacentTerritory = "Нет";
			}
		}
		*/

		private void TransportCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (TransportCheckBox.Checked)
			{
				modelOfClientSted.TransportAccessibility = "Развитая";
			}
			else
			{
				modelOfClientSted.TransportAccessibility = "Неразвитая";
			}
		}

		private void EcologyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (EcologyCheckBox.Checked)
			{
				modelOfClientSted.Ecology = "Хорошая";
			}
			else
			{

				modelOfClientSted.Ecology = "Средняя";
			}
		}

		private void NearTeritotyComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NearTeritotyComboBox.SelectedItem.ToString() == "1-2")
			{
				modelOfClientSted.AdjacentTerritory = 2;
			}
			else if (NearTeritotyComboBox.SelectedItem.ToString() == "3-5")
			{
				modelOfClientSted.AdjacentTerritory = 5;
			}
			else
			{
				modelOfClientSted.AdjacentTerritory = 1000;
			}
		}

		private void GoBackButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}
	}
}
