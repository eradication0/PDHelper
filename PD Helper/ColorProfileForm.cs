using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PD_Helper
{
	public partial class ColorProfileForm : Form
	{
		public class TypeColors
		{
			// JSON Properties
            [JsonProperty("Light")]
            public string Light { get; set; }
            [JsonProperty("Dark")]
            public string Dark { get; set; }

			public TypeColors()
			{
				// Empty
			}

			public TypeColors(string light, string dark)
			{
				Light = light;
				Dark = dark;
			}

			public TypeColors(Color light, Color dark)
			{
				Light = colorToHex(light);
				Dark = colorToHex(dark);
			}

			public static Color hexToColor(string hex)
			{
				hex = hex.Replace("#", string.Empty);
				byte r = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
				byte g = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
				byte b = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
				return Color.FromArgb(r, g, b);
			}

			public static string colorToHex(Color color) => string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);

			public Color getLightColor() => hexToColor(Light);
			public Color getDarkColor() => hexToColor(Dark);
		}
		
		public ColorProfileForm()
		{
			InitializeComponent();

			// Set button colors
			attackLightColorButton.BackColor = getColor("Attack", true);
			attackDarkColorButton.BackColor = getColor("Attack", false);
			defenseLightColorButton.BackColor = getColor("Defense", true);
			defenseDarkColorButton.BackColor = getColor("Defense", false);
			eraseLightColorButton.BackColor = getColor("Erase", true);
			eraseDarkColorButton.BackColor = getColor("Erase", false);
			environmentalLightColorButton.BackColor = getColor("Environment", true);
			environmentalDarkColorButton.BackColor = getColor("Environment", false);
			statusLightColorButton.BackColor = getColor("Status", true);
			statusDarkColorButton.BackColor = getColor("Status", false);
			specialLightColorButton.BackColor = getColor("Special", true);
			specialDarkColorButton.BackColor = getColor("Special", false);
			auraLightColorButton.BackColor = getColor("Aura", true);
			auraDarkColorButton.BackColor = getColor("Aura", false);
		}

		public static Color getColor(string type, bool isLight) => getColor(type, isLight, "CURRENT");

		public static Color getColor(string type, bool isLight, string profile)
		{
			// Get the path of the profile
			string path = @"Color_Profiles\" + profile + ".json";

			// Load the JSON file
			string fileText = File.ReadAllText(path);
			Dictionary<string, TypeColors> colorProfile = JsonConvert.DeserializeObject<Dictionary<string, TypeColors>>(fileText);

			// Return color
			if (isLight) return colorProfile[type].getLightColor();
			else return colorProfile[type].getDarkColor();
		}

		private void colorButtonClick(object sender, EventArgs e)
		{
			// Get the button we clicked on
			Button button = (Button)sender;

			// Open color dialog
			ColorDialog colorDialog = new ColorDialog();

			// Set the color
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				button.BackColor = colorDialog.Color;
			}
		}

		private void btnSaveToPDH_Click(object sender, EventArgs e)
		{
			// Get the profile name
			string profile = colorProfileNameBox.Text;
			
			// Double check we are not rewriting the DEFAULT or CURRENT profiles
			if (profile == "DEFAULT" || profile == "CURRENT")
			{
				// TODO: Throw popup warning against the name
				return;
			}

			// Create a TypeColors for each type
			//TypeColors[] typeColors = new TypeColors[7];
			Dictionary<string, TypeColors> typeColors = new Dictionary<string, TypeColors>();
			typeColors["Attack"] = new TypeColors(
				attackLightColorButton.BackColor,
				attackDarkColorButton.BackColor
				);
			typeColors["Defense"] = new TypeColors(
				defenseLightColorButton.BackColor,
				defenseDarkColorButton.BackColor
				);
			typeColors["Erase"] = new TypeColors(
				eraseLightColorButton.BackColor,
				eraseDarkColorButton.BackColor
				);
			typeColors["Environment"] = new TypeColors(
				environmentalLightColorButton.BackColor,
				environmentalDarkColorButton.BackColor
				);
			typeColors["Status"] = new TypeColors(
				statusLightColorButton.BackColor,
				statusDarkColorButton.BackColor
				);
			typeColors["Special"] = new TypeColors(
				specialLightColorButton.BackColor,
				specialDarkColorButton.BackColor
				);
			typeColors["Aura"] = new TypeColors(
				auraLightColorButton.BackColor,
				auraDarkColorButton.BackColor
				);

			// Create JSON string
			string json = JsonConvert.SerializeObject(typeColors, Formatting.Indented);

			// Write the JSON
			string path = @"Color_Profiles\" + profile + ".json";
			System.IO.File.WriteAllText(path, json);
		}
	}
}
