using System;
using System.Collections.Generic;
namespace Cartoons.BL
{
	public class CartoonModel
	{

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		private string _image;

		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

		private string _studio;

		public string Studio
		{
			get { return _studio; }
			set { _studio = value; }
		}

		private List<CartoonModel> _cartoonList = new List<CartoonModel>();

		public List<CartoonModel> CartoonList
		{
			get { return _cartoonList; }
			set { _cartoonList = value; }
		}

		private List<CartoonModel> _templist = new List<CartoonModel>();

		public List<CartoonModel> Templist
		{
			get { return _templist; }
			set { _templist = value; }
		}

		private DateTime _dateCreation;

		public DateTime DateCreation
		{
			get { return _dateCreation; }
			set { _dateCreation = value; }
		}

		public CartoonModel(string name, string image, DateTime dateCreation, string studio)
		{
			Name = name;
			Image = image;
			DateCreation = dateCreation;
			Studio = studio;
		}

		public CartoonModel(string image, string name)
		{
			Image = image;
			Name = name;
		}

		private string _Warning;

		public string Warning
		{
			get { return _Warning; }
			set { _Warning = value; }
		}

		public CartoonModel()
		{

		}

		public void SetCartoons()
		{
			CartoonList.Add(new CartoonModel("mickey mouse","Images/cat-mickey-mouse.jpg", new DateTime(2000, 10, 15), "Walt Disney"));
			CartoonList.Add(new CartoonModel("Arnold", "Images/Arnold.jpg", new DateTime(1980, 03, 31), "nickelodeon"));
			CartoonList.Add(new CartoonModel("Buzz Lightyear", "Images/Buzz lightyear.jpg", new DateTime(2000, 10, 15), "Walt Disney"));
		}

		public void CartoonsInListbox(string selectedStudio)
		{
			Templist.Clear();
			foreach (CartoonModel cartoon in CartoonList)
			{
				if ($"System.Windows.Controls.ComboBoxItem: {cartoon.Studio}" == selectedStudio)
				{
					Templist.Add(new CartoonModel (cartoon.Image, cartoon.Name));
				}
				else if(cartoon.Studio == selectedStudio)
				{
					Templist.Add(new CartoonModel(cartoon.Image, cartoon.Name));
				}

			}
		}

		public void CartoonsToevoegen(string name, string image, DateTime creatieDatum, string studio)
		{
			if (name != "" || image != "" || creatieDatum > DateTime.Now)
			{
				Warning = "";
				CartoonList.Add(new CartoonModel(name, image, creatieDatum, studio));
			}

			else
			{
				Warning = "U heeft iets niet goed ingevuld";
			}
		}

		public void CartoonAanpassen(string originalName, string newNaam, DateTime newDate, string newImage, string NewStudio)
		{
			foreach (CartoonModel cartoon in CartoonList)
			{
				if (originalName == cartoon.Name)
				{
					cartoon.Name = newNaam;
					cartoon.Image = newImage;
					cartoon.DateCreation = newDate;
					cartoon.Studio = NewStudio;
				}
			}
		}

		public void CartoonGegevensInvoegen(string originalName)
		{
			foreach (CartoonModel cartoon in CartoonList)
				if (originalName == cartoon.Name)
				{
					Name = cartoon.Name;
					Image = cartoon.Image;
					DateCreation = cartoon.DateCreation;
					Studio = cartoon.Studio;
				}
		}


	}
}

