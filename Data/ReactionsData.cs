using GoogleRareBe.Models;
using System;
namespace GoogleRareBe.Data
{
	public class ReactionsData
	{
		public static List<Reaction> Reactions = new List<Reaction> 
		{
			new Reaction
			{
				Id = 1,
				label = "label1",
				image_Url = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_square.jpg"
            },
			new Reaction
			{
				Id = 2,
				label = "label2",
				image_Url = "https://cdn.theatlantic.com/thumbor/tO5tLGl38cH3MjWz3PypY1dPHX4=/0x62:2000x1187/960x540/media/img/mt/2018/03/AP_325360162607/original.jpg"
            },
			new Reaction
			{
				Id = 3,
				label = "label3",
				image_Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaTytvoycBuzLUAJ9IfWi9sWZ9XJBpZdQFSw&usqp=CAU"
            }
		};
	}
}

