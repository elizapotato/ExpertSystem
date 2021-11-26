using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLab
{
	public partial class MainForm : Form
	{
		Offer offer = new Offer();
		public MainForm()
		{
			InitializeComponent();
			this.FormClosing += MainForm_FormClosing;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			FindOfficeForm findForm = new FindOfficeForm();
			findForm.Show();
			this.Hide();
		}

		/*rivate Offer DeserializeJsonObject(string path)
		{
			string jsonString = File.ReadAllText(path);
			Offer obj = File.Exists(path) ? JsonSerializer.Deserialize<Offer>(jsonString) : new Offer();
			return obj;
		}*/

		private void HouseButton_Click(object sender, EventArgs e)
		{
			FindHouseForm findHouseForm = new FindHouseForm();
			findHouseForm.Show();
			this.Hide();
		}

		private void ApartmentButton_Click(object sender, EventArgs e)
		{
			FindApartmentForm findApartmentForm = new FindApartmentForm();
			findApartmentForm.Show();
			this.Hide();
		}

		private void SteadButton_Click(object sender, EventArgs e)
		{
			FindSteadForm findSteadForm = new FindSteadForm();
			findSteadForm.Show();
			this.Hide();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			string path = Directory.GetCurrentDirectory() + @"\JsonOffersList.json";
			string jsonString = File.ReadAllText(path);
			label1.Text = jsonString;
			Offer OffersList ;
			OffersList = JsonSerializer.Deserialize<Offer>(jsonString);
			label1.Text = OffersList.name;
		}
	}

}
