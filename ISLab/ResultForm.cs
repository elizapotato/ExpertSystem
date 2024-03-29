﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace ISLab
{
	public partial class ResultForm : Form
	{
		private Offer offerList; //объект предложений из базы
		private Office clientOffice; //объект коммерческой недвижимости
		private House clientHouse; //объект дома
		private Apartment clientApartment; //объект квартиры
		private Stead clientStead; //объект земельного участка
		private List<Office> officeResult; //список результатов по поиску коммерческой недвижимости
		private List<House> houseResult; //список результатов по поиску домов
		private List<Apartment> apartmentResult; //список результатов по поиску квартир
		private List<Stead> steadResult; //список результатов по поиску земельных участков

		public ResultForm()
		{
			InitializeComponent();
		}
		public ResultForm(Office office)
		{
			clientOffice = office;
			InitializeComponent();
			TakeOffers();
			officeResult = IntelliegentSystem.FindOffice(clientOffice, offerList.officeList);
			if (officeResult.Count > 0)
			{
				foreach(var res in officeResult)
				{
					richTextBox1.Text += res.GeneralCharacteristics.Price.ToString() + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += res.Years + " лет" + "\n";
					richTextBox1.Text += res.CountOfRooms.ToString() + " комнат" + "\n";
					richTextBox1.Text += res.Floor.ToString() + " этаж" + "\n";
					richTextBox1.Text += res.Specifications + " инфраструктура" + "\n";
					richTextBox1.Text += res.Parking + " парковка" + "\n";
					richTextBox1.Text += "...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}
		}
		public ResultForm(House house)
		{
			clientHouse = house;
			InitializeComponent();
			TakeOffers();
			houseResult = IntelliegentSystem.FindHouse(clientHouse, offerList.houseList);
			if (houseResult.Count > 0)
			{
				foreach (var res in houseResult)
				{
					richTextBox1.Text += res.GeneralCharacteristics.Price.ToString() + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += res.Floors + " - количество этажей" + "\n";
					
					richTextBox1.Text += res.Comunication + " комуникации" + "\n";
					richTextBox1.Text += res.TransportAccessibility + " - транспортная доступность" + "\n";
					richTextBox1.Text += res.TypeOfHouse + "\n";
					richTextBox1.Text += "...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}

		}
		public ResultForm(Apartment apartment)
		{
			clientApartment = apartment;
			InitializeComponent();
			TakeOffers();
			apartmentResult = IntelliegentSystem.FindApartment(clientApartment, offerList.apartmentList);
			if (apartmentResult.Count > 0)
			{
				foreach (var res in apartmentResult)
				{
					richTextBox1.Text += res.GeneralCharacteristics.Price.ToString() + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += res.NewOrOld + "\n";
					richTextBox1.Text += res.Floor + " этаж" + "\n";
					richTextBox1.Text += res.MaxFloor + " - всего этажей" + "\n";
					richTextBox1.Text += res.CountOfRooms + " количство комнат" + "\n";
					richTextBox1.Text += res.TransportAccessibility + " транспортная доступность" + "\n";
					richTextBox1.Text += res.TypeOfBuilding + "\n";
					richTextBox1.Text += res.View + " красивый вид" + "\n";
					richTextBox1.Text += res.Parking + " парковка" + "\n";
					richTextBox1.Text += res.Elevator + "Наличие лифта" + "\n";
					richTextBox1.Text += "...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}

		}
		public ResultForm(Stead stead )
		{
			clientStead = stead;
			InitializeComponent();
			TakeOffers();
			steadResult = IntelliegentSystem.FindStead(clientStead, offerList.steadList);
			if (steadResult.Count > 0)
			{
				foreach (var res in steadResult)
				{
					richTextBox1.Text += res.GeneralCharacteristics.Price.ToString() + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += res.GeneralCharacteristics.Square + " га." + "\n";
					richTextBox1.Text += res.TypeOfSoil + " Тип почвы" + "\n";
					richTextBox1.Text += res.Ecology + " экология" + "\n";
					richTextBox1.Text += res.TransportAccessibility + " - транспортная доступность" + "\n";
					richTextBox1.Text += "...\n";

				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}
		}
		private void TakeOffers() // передаём из базы
		{
			string path = Directory.GetCurrentDirectory() + @"\JsonOffersList.json";
			string jsonString = File.ReadAllText(path);
			offerList = JsonSerializer.Deserialize<Offer>(jsonString);
		}
		private void WriteResult()
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
			this.Hide();
		}
	}
}
