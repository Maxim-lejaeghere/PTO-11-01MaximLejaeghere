using System;
using System.Collections.Generic;
using System.Text;

namespace Cartoons.BL
{
    public class StudioModel : CartoonModel
    {
		CartoonModel NewCartoon = new CartoonModel();

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

		public StudioModel(string studio)
		{

		}

		public StudioModel()
		{

		}

		public override void GetStudio()
		{

		}

		public override void SetStudio()
		{

		}
		
		public override void GetCartoons()
		{

		}

		public void SetCartoons()
		{
			CartoonList.Add(new CartoonModel("mickey mouse", "Images/cat-mickey-mouse.jpg", new DateTime(2000, 10, 15), new StudioModel("Walt Disney")));
			CartoonList.Add(new CartoonModel("Arnold", "Images/Arnold.jpg", new DateTime(1980, 03, 31), new StudioModel("Nickelodeon")));
			CartoonList.Add(new CartoonModel("Buzz Lightyear", "Images/cat-mickey-mouse.jpg", new DateTime(2000, 10, 15), new StudioModel("Pixar")));
		}
	}
}
