using System;
using GoogleRareBe.DTO;

namespace GoogleRareBe.Data
{
	public class PostTagData
	{
		public static List<PostTagsDTO> PostTags = new List<PostTagsDTO>
		{
			new PostTagsDTO
			{
				PostId = 1,
				TagId = 1
			},

			new PostTagsDTO
			{
				PostId = 2,
				TagId = 2
			},
		};
	}
}

