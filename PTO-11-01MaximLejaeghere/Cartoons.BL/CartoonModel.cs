using System;
using System.Collections.Generic;

namespace Cartoons.BL
{
    public class CartoonModel
    {
		StudioModel Studio = new StudioModel();

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


		private DateTime _dateCreation;

		public DateTime DateCreation
		{
			get { return _dateCreation; }
			set { _dateCreation = value; }
		}

		public CartoonModel(string name, string image, DateTime dateCreation, StudioModel studio)
		{
			Name = name;
			Image = image;
			DateCreation = dateCreation;
			Studio = studio;
		}
		

		public CartoonModel()
		{

		}

		public void GetName()
		{

		}

		public void GetDateOfCreation()
		{

		}

		public void GetImage()
		{

		}

		public virtual void GetStudio()
		{

		}

		public void SetName()
		{

		}

		public void SetDateOfCreation()
		{

		}

		public void SetImage()
		{

		}

		public virtual void SetStudio()
		{

		}

		public void AddCartoon()
		{

		}

		public virtual void GetCartoons()
		{
			
		}
	}
}
