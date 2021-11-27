using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISLab
{
	[System.Serializable] 
	public class Offer // Класс предложений
	{
		public List<Office> officeList { get; set; } //объявляем список коммерческих недвижимостей из базы
		public List<House> houseList { get; set; } // объявляем список домов из базы
		public List<Apartment> apartmentList { get; set; } // объявляем список домов из базы
		public List<Stead> steadList { get; set; } // объявляем список земельных участков из базы
		public string name { get; set; }
	}

	[System.Serializable]
	public class Stead //описание земельных участков
	{
		public RealEstate GeneralCharacteristics { get; set; } // Общие параметры
		public string Ecology { get; set; } // Экологическая чистота
		public string TransportAccessibility { get; set; } // Транспортная доступность
		public string TypeOfSoil { get; set; } // Тип почвы
	}

	[System.Serializable]
	public class Apartment //описание квартир
	{
		public RealEstate GeneralCharacteristics { get; set; } //Общие параметры
		public string Infrastructure { get; set; } //Инфраструктура
		public int Floor { get; set; } //Этаж
		public int MaxFloor { get; set; } // Максимальный этаж
		public string TransportAccessibility { get; set; } //Транспортная доступность
		public int CountOfRooms { get; set; } //Количество комнат
		public int Years { get; set; } //Возраст
		public string TypeOfBuilding { get; set; } //Тип постройки дома
		public string NewOrOld { get; set; } // Вторичка или новостройка 
		public string Parking { get; set; } //Парковка
		public string Elevator { get; set; } //Наличие лифта
		public string View { get; set; } //Красивый вид
	}

	[System.Serializable]
	public class Office // описание коммерческой недвижимости
	{
		public RealEstate GeneralCharacteristics { get; set; } //общие параметры
		public string Specifications { get; set; } //Инфраструктура
		public string Parking { get; set; } //Парковка
		public int Years { get; set; } //Возраст здания
		public int Floor { get; set; } //Этаж
		
		public int CountOfRooms { get; set; } //Количество помещений
	}
	[System.Serializable]
	public class House //описание дома
	{
		public RealEstate GeneralCharacteristics { get; set; } //Общие характеристики
		public int Floors { get; set; } //Количество этажей
		public string TransportAccessibility { get; set; } //Транспортная доступность
		public string TypeOfHouse { get; set; } //Тип дома
		public string Comunication { get; set; } //Коммуникация
		
		
	}

	[System.Serializable]
	public class RealEstate //описание общих параметров для всех видов недвижимостей
	{
		
		public int Price { get; set; } //цена
		public string Adress { get; set; }  //адрес
		public string Location { get; set; } //расположение
		public int Square { get; set; } //площадь
	}
	



}
