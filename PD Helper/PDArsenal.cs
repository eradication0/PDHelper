using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_Helper
{
	internal class PDArsenal
	{
		PDCard[] cards = new PDCard[30];
		public PDCard[] Cards
		{ 
			get => cards;
			set 
			{
				if (value.Length != 30)
				{
					throw new ArgumentException("Arsenal needs exactly 30 cards");
				}

				cards = value;
			}
		}
		
		string name;
		public string Name 
		{ 
			get => name;
			set
			{
				if (value.Length > 16)
				{
					throw new ArgumentException("Name must not exceed 16 characters");
				}
				else if (value.Length == 0)
				{
					throw new ArgumentException("Name must not be empty");
				}

				name = value;
			}
		}

		public PDArsenal(string name, PDCard[] cards)
		{
			Cards = cards;
			Name = name;
		}

		public PDArsenal(string name, List<PDCard> cards = null)
		{
			if (cards == null)
			{
				cards = new List<PDCard>();
			}
			
			if (cards.Count > 30)
			{
				throw new ArgumentException("Arsenal needs no more than 30 cards");
			}

			for (int i = 0; i < 30; i++)
			{
				if (i < cards.Count)
				{
					this.cards[i] = cards.ElementAt(i);
				}
				else
				{
					this.cards[i] = PDCard.cardDef["FF FF"]; // Aura
				}
			}

			Name = name;
		}

		
	}
}
