using GoogleRareBe.Models;
using System;
namespace GoogleRareBe.Data
{
	public class PostsData
	{
		public static List<Post> posts = new List<Post>
		{
			new Post
			{
				Id = 1,
				RareUserId = 1,
				CategoryId = 1,
				Title = "oh wow, what a field goal!",
				PublicationDate = DateTime.Now,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQaqJLGCMY6GnWpqz1a9uh0FO8yuFsJ5XTJg&usqp=CAU",
				Content = "that was amazing! I cant belive he hit that kick.",
				Approved = true
			},
			new Post
			{
				Id = 2,
				RareUserId = 2,
				CategoryId = 2,
				Title = "this food was absolutly amazing!",
				PublicationDate = DateTime.Now,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStxYUb82L3RX5dgbZ_sPnFJGziaA3O3nqMQw&usqp=CAU",
				Content = "I went to a restaurant recently and I got this, it was amazing!",
				Approved = false
			},
			new Post
			{
				Id = 3,
				RareUserId = 3,
				CategoryId = 3,
				Title = "Beautiful mountains",
				PublicationDate = DateTime.Now,
				ImageUrl = "https://uploads.alaska.org/suppliers/activities/K/K2/_690x460_crop_center-center_65_none/full-8431-alaska-rusts-k2-talkeetna.jpg",
				Content = "Went to New Zealand recently, so amazing!",
				Approved = true
			},
			new Post 
			{
				Id = 4,
				RareUserId = 4,
				CategoryId = 4,
                Title = "I got a new Cat!",
                PublicationDate = DateTime.Now,
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nationalgeographic.com%2Fanimals%2Fmammals%2Ffacts%2Fdomestic-cat&psig=AOvVaw1VGG2bBHXaIDXPM2sRgYSO&ust=1710688495265000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCLDFz5aK-YQDFQAAAAAdAAAAABAD",
                Content = "we went down to the shelter and got myself a new cat, welcome Slinky!",
                Approved = true
            },
			new Post
			{
				Id = 5,
				RareUserId = 5,
				CategoryId = 5,
                Title = "Local kids helped at the homeless shelter, neighborhood moral skyrockets!",
                PublicationDate = DateTime.Now,
                ImageUrl = "https://i0.wp.com/bcc-newspack.s3.amazonaws.com/uploads/2021/06/060221-Good-News-Shelter-Rogers-Park-ColinBoyle-5-e1623936580193.jpg?fit=1500%2C998&ssl=1",
                Content = "family comes together to help those in need, what a time for the youth to help out!",
                Approved = true
            }
		};
	}
}

