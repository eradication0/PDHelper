using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
					throw new ArgumentException("Name must not exceed 16 characters.");
				}
				else if (value.Length == 0)
				{
					throw new ArgumentException("Name must not be empty.");
				}

				var regex = new Regex(@"[\\\/\:\*\?\""\<\>\|]");
				if (regex.IsMatch(name))
				{
					throw new ArgumentException(@"Name contains banned characters (\ / : * ? \ < > |).");
				}

				name = value;
			}
		}

		public List<PDCard.School> Schools
		{
			get
			{
				// Add schools
				List<PDCard.School> schools = new List<PDCard.School>();
				foreach (PDCard card in cards)
				{
					PDCard.School school = (PDCard.School)card.SchoolToInt();
					if (!schools.Contains(school) && school != PDCard.School.Aura)
					{
						schools.Add(school);
					}
				}

				// Sort
				schools.Sort();
				return schools;
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

		public static PDArsenal LoadFromFile(string name, string path)
		{
			string file = File.ReadAllText(path);
			string[] deckStrings = file.Split(',');
			string loadSchoolAmount = deckStrings[30].Remove(deckStrings[30].Length - 3);
			if (loadSchoolAmount == "01" || loadSchoolAmount == "02" || loadSchoolAmount == "03")
			{
				PDCard[] cards = new PDCard[30];
				for (int i = 0; i < 30; i++)
				{
					cards[i] = PDCard.cardDef[deckStrings[i]];

					/*
					if (!PDCard.cardDef.ContainsKey(deckStrings[i]))
					{
						throw new FileFormatException(
							"A Skill from your loaded arsenal does not exist in the game and could not be loaded. " +
							"The arsenal has been tampered with or was corrupted. Please try loading another arsenal.");
					}
					else
					{
						//loadedDeck[i] = deckStrings[i];
						//deckListBox.Items.Add(PDCard.cardDef[deckStrings[i]].NAME);
					}*/
				}

				return new PDArsenal(name, cards);
			}
			else
			{
				throw new FileFormatException("The loaded Arsenal loaded is not set to 1, 2 or 3 Schools.");
			}
		}
	}
}
