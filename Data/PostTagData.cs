using System;
using GoogleRareBe.Models;

namespace GoogleRareBe.Data
{
	public class PostTagData
	{
		public static List<PostTag> PostTags = new List<PostTag>
		{
			new PostTag
			{
				Id = 1,
				PostId = 1,
				TagId = 1
			},

			new PostTag
			{
				Id = 2,
				PostId = 2,
				TagId = 2
			},
		};
	}
}

