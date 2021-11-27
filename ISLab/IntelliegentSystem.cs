using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISLab
{
	public static class IntelliegentSystem
	{
		public static List<Office> FindOffice(Office clientOffice, List<Office> offices) //метод для поиска подходящей коммерческой недвижимости
		{
			List<Office> result = new List<Office>(); //создаём результирующий список
			foreach(var variant in offices) //для каждой коммерческой недвижимости в базе
			{
				if(CheckGeneralCharacteristics(clientOffice.GeneralCharacteristics, variant.GeneralCharacteristics) //сравнение параметров
					&& CheckOfficeCharacteristics(clientOffice, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<House> FindHouse(House clientHouse, List<House> houses) //метод для поиска подходящего дома
		{
			List<House> result = new List<House>(); //создаём результирующий список
			foreach (var variant in houses)
			{
				if(CheckGeneralCharacteristics(clientHouse.GeneralCharacteristics, variant.GeneralCharacteristics) && //сравнение параметров
					CheckHouseCharacteristics(clientHouse, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<Apartment> FindApartment(Apartment clientApartment, List<Apartment> apartments) //метод для поиска подходящей квартиры
		{
			List<Apartment> result = new List<Apartment>(); //создаём результирующий список
			foreach (var variant in apartments)
			{
				if (CheckGeneralCharacteristics(clientApartment.GeneralCharacteristics, variant.GeneralCharacteristics) && //сравнение параметров
					CheckApartmentCharacteristics(clientApartment, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<Stead> FindStead(Stead clientStead, List<Stead> steads) //метод для поиска подходящего земельного участка
		{
			List<Stead> result = new List<Stead>(); //создаём результирующий список
	        //сравнение параметров
			foreach (var variant in steads)
			{
				if(CheckGeneralCharacteristics(clientStead.GeneralCharacteristics, variant.GeneralCharacteristics) && CheckSteadCharacteristics(clientStead, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		private static bool CheckGeneralCharacteristics (RealEstate clientModel, RealEstate listModel) //сравнение общих параметров
		{
			if(clientModel.Location == listModel.Location) //сравнение расположений
			{
				if(clientModel.Price >= listModel.Price && clientModel.Square <= listModel.Square) //сравнение цен и площадей
				{
					return true;
				}
			}
			return false;
		}
		private static bool CheckOfficeCharacteristics (Office clientModel, Office listModel) //сравнений характеристик офисов
		{
			if (clientModel.CountOfRooms <= listModel.CountOfRooms &&  clientModel.Parking == listModel.Parking && clientModel.Specifications == listModel.Specifications)
			{
				if(clientModel.Floor == 1 && clientModel.Floor == listModel.Floor && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
				if (clientModel.Floor == 2 && listModel.Floor >= 2 && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
				if (clientModel.Floor == 3 && listModel.Floor >=3 && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
			}
			return false;
		}
		private static bool CheckOfficeRooms(Office clientModel, Office listModel) //сравнение количества помещений
		{
			if (clientModel.CountOfRooms <= listModel.CountOfRooms)
			{
				return true;
			}
			else return false;
		}

		private static bool CheckHouseCharacteristics(House clientModel, House listModel) // сравнение характеристик домов
		{
			if (clientModel.TransportAccessibility == listModel.TransportAccessibility //транспортная доступность
			
				&& clientModel.Comunication == listModel.Comunication //коммуникция
				&& clientModel.TypeOfHouse == listModel.TypeOfHouse && //тип постройи дома
				(clientModel.Floors == listModel.Floors || clientModel.Floors == 4 && listModel.Floors >= 4)) //этажи
			{
				return true;
			}
			return false;
		}
		private static bool CheckApartmentCharacteristics(Apartment clientModel, Apartment listModel) //сравнение характеристик квартир
		{
			if (clientModel.TransportAccessibility == listModel.TransportAccessibility //транспортная доступность
				&& 
				clientModel.Infrastructure == listModel.Infrastructure //инфраструктура
				&& clientModel.TypeOfBuilding == listModel.TypeOfBuilding && //тип постройки
				clientModel.Elevator == listModel.Elevator && //наличие лифта
				clientModel.Parking == listModel.Parking && //парковка
				clientModel.View == listModel.View && //красивый вид
				clientModel.Years >= listModel.Years && //возраст здания
				clientModel.NewOrOld == listModel.NewOrOld && // вторичка или новостройка
				//Этажи
				(clientModel.Floor == listModel.Floor || (clientModel.Floor == 2 && (listModel.Floor>=2 && listModel.Floor<listModel.MaxFloor)) ||(clientModel.Floor == 3 && listModel.Floor == listModel.MaxFloor)))
			{
				return true;
			}
			return false;
		}
		private static bool CheckSteadCharacteristics(Stead clientModel, Stead listModel) //сравнение характеристик земельных участков
		{
			if (clientModel.TransportAccessibility == listModel.TransportAccessibility //транспортная доступность
				&& clientModel.Ecology == listModel.Ecology && //экология
				clientModel.TypeOfSoil==listModel.TypeOfSoil) //тип почвы
			{
				return true;
			}
			return false;
		}
		

	}

}
