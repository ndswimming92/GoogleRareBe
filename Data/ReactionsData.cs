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
				image_Url = "https://ih1.redbubble.net/image.5328806804.9180/raf,360x360,075,t,fafafa:ca443f4786.jpg"
            },
			new Reaction
			{
				Id = 2,
				label = "label2",
				image_Url = "https://thumbs.dreamstime.com/b/yellow-emoji-icon-crying-emoji-sad-face-emoticon-chat-comment-reaction-emotes-social-media-concept-emotion-vector-eps-212589528.jpg"
            },
			new Reaction
			{
				Id = 3,
				label = "label3",
				image_Url = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fi%2Fgreeting-card%2Fangry-react-emoji-by-LORRAUN%2F39738117.5MT14&psig=AOvVaw1pJxNNCgUdaRQ_H1PaAKEK&ust=1710690790233000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMCS64OS-YQDFQAAAAAdAAAAABAD"
            }
		};
	}
}

