using System;
using GoogleRareBe.Models;

namespace GoogleRareBe.Data
{
	public class RareUsersData
	{
		public static List<User> Users = new List<User>
		{
			new User {Id = 1, FirstName = "John", LastName = "Doe", Bio = "A Mystery Man", PublicImageUrl ="https://images.saymedia-content.com/.image/t_share/MTgyODcwNDI1NTAyNDkyMDY3/the-mystery-man.jpg", email = "mman@googlerare.com", CreatedOn = new DateTime(2022, 5, 11), Active = true, IsStaff = true, Uid = "JD1234MM"},
			new User {Id = 2, FirstName = "Jane", LastName = "Doe", Bio = "A Mystery Woman", PublicImageUrl = "https://th.bing.com/th/id/R.e2149e74aa05e6864c45bd9ec1ab773f?rik=fQx6Mc1U%2b6Hl1A&riu=http%3a%2f%2fwww.brookpacelascelles.com%2fproduct-images%2fFullsize%2f9d8ddd3d-3f11-420b-aba6-695eb86f7f9b-1.jpg&ehk=oYOiBFvK5j0fz3qyT1tbBHOvEdDkdEVu4HClA72AO4M%3d&risl=&pid=ImgRaw&r=0", email ="MsJDoe@googlerare.com", CreatedOn = new DateTime(2023,5,16), Active = true, IsStaff = false, Uid ="MJD1234E"},
			new User {Id = 3, FirstName = "Nick", LastName = "Cage", Bio ="Actor and Lover of Elanor", PublicImageUrl = "https://epmgaa.media.clients.ellingtoncms.com/img/photos/2019/04/01/S107298446.JPG", email ="goneis60sec@googlerate.com", CreatedOn = new DateTime(2023,07,11), Active = true, IsStaff = false, Uid = "FGT1967GO"}
		};
	}
}

