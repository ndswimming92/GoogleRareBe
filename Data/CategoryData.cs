using System;
using GoogleRareBe.Models;
namespace GoogleRareBe.Data
{
	public class CategoryData
	{
		public static List<Category> Categories = new List<Category>
		{
			new Category {Id = 1, Label = "Sports" },
            new Category {Id = 2, Label = "Food" },
			new Category {Id = 3, Label = "Travel" },
			new Category {Id = 4, Label = "Animals" },
			new Category {Id = 5, Label = "News" }
        };
	}
}

