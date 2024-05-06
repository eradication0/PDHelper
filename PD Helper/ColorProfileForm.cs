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
using System.Diagnostics;

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

			// Add each color profile file to the list
			savedColorProfileListBox.Items.Clear();
			DirectoryInfo directory = new DirectoryInfo(@"Color_Profiles\");

			FileInfo[] Files = directory.GetFiles("*.json"); // Getting JSON files
			string str = "";

			foreach (FileInfo file in Files)
			{
				// Get Profile name
				string currentProfile = file.Name;
				currentProfile = currentProfile.Remove(currentProfile.Length - 5);

				// If the name is "CURRENT", skip it.
				if (currentProfile == "CURRENT") continue;

				// Add to list
				savedColorProfileListBox.Items.Add(currentProfile);
			}
			colorProfileListBox.Text = "Color Profile List (" + savedColorProfileListBox.Items.Count + ")";
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

		private string getJSONFromColors()
		{
			// Create a TypeColors for each type
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
			return JsonConvert.SerializeObject(typeColors, Formatting.Indented);
		}

		private void btnSaveToPDH_Click(object sender, EventArgs e)
		{
			// Get the profile name
			string profile = colorProfileNameBox.Text;
			
			// Double check we are not rewriting the DEFAULT or CURRENT profiles
			if (profile == "DEFAULT" || profile == "CURRENT" || profile == "" || profile == null)
			{
				// TODO: Throw popup warning against the name
				return;
			}

			// Write the JSON
			string path = @"Color_Profiles\" + profile + ".json";
			string json = getJSONFromColors();
			File.WriteAllText(path, json);

			// Add each color profile file to the list
			savedColorProfileListBox.Items.Clear();
			DirectoryInfo directory = new DirectoryInfo(@"Color_Profiles\");

			FileInfo[] Files = directory.GetFiles("*.json"); // Getting JSON files
			string str = "";

			foreach (FileInfo file in Files)
			{
				// Get Profile name
				string currentProfile = file.Name;
				currentProfile = currentProfile.Remove(currentProfile.Length - 5);

				// If the name is "CURRENT", skip it.
				if (currentProfile == "CURRENT") continue;

				// Add to list
				savedColorProfileListBox.Items.Add(currentProfile);
			}
			colorProfileListBox.Text = "Color Profile List (" + savedColorProfileListBox.Items.Count + ")";
		}

		private void loadColorProfileButton_Click(object sender, EventArgs e)
		{
			if (savedColorProfileListBox.SelectedIndex != -1)
			{
				// Get the profile name
				string profile = savedColorProfileListBox.SelectedItem.ToString();

				// Set button colors
				attackLightColorButton.BackColor = getColor("Attack", true, profile);
				attackDarkColorButton.BackColor = getColor("Attack", false, profile);
				defenseLightColorButton.BackColor = getColor("Defense", true, profile);
				defenseDarkColorButton.BackColor = getColor("Defense", false, profile);
				eraseLightColorButton.BackColor = getColor("Erase", true, profile);
				eraseDarkColorButton.BackColor = getColor("Erase", false, profile);
				environmentalLightColorButton.BackColor = getColor("Environment", true, profile);
				environmentalDarkColorButton.BackColor = getColor("Environment", false, profile);
				statusLightColorButton.BackColor = getColor("Status", true, profile);
				statusDarkColorButton.BackColor = getColor("Status", false, profile);
				specialLightColorButton.BackColor = getColor("Special", true, profile);
				specialDarkColorButton.BackColor = getColor("Special", false, profile);
				auraLightColorButton.BackColor = getColor("Aura", true, profile);
				auraDarkColorButton.BackColor = getColor("Aura", false, profile);
			}
		}

		private void refreshColorProfileButton_Click(object sender, EventArgs e)
		{
			//add each color profile file to the list
			savedColorProfileListBox.Items.Clear();
			DirectoryInfo directory = new DirectoryInfo(@"Color_Profiles\");

			FileInfo[] Files = directory.GetFiles("*.json"); // Getting JSON files
			string str = "";

			foreach (FileInfo file in Files)
			{
				// Get Profile name
				string currentProfile = file.Name;
				currentProfile = currentProfile.Remove(currentProfile.Length - 5);

				// If the name is "CURRENT", skip it.
				if (currentProfile == "CURRENT") continue;
				
				// Add to list
				savedColorProfileListBox.Items.Add(currentProfile);
			}
			colorProfileListBox.Text = "Color Profile List (" + savedColorProfileListBox.Items.Count + ")";
		}

		private void openColorProfileFolderButton_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", @"Color_Profiles\");
		}

		private void deleteColorProfileButton_Click(object sender, EventArgs e)
		{
			// Get the profile name to delete
			string profile = savedColorProfileListBox.SelectedItem.ToString();
			if (profile == "DEFAULT")
			{
				// TODO: Tell the user they cannot delete the default color profile.
				return;
			}
			
			DialogResult dr = MessageBox.Show("Are you sure you want to delete color profile: " + profile + "?", "Color Profile Deletion Check", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				string path = @"Color_Profiles\" + profile + ".json";
				File.Delete(path);
				savedColorProfileListBox.Items.Remove(savedColorProfileListBox.SelectedItem);
			}
		}

		private void useColorProfileButton_Click(object sender, EventArgs e)
		{
			// Write the JSON
			string path = @"Color_Profiles\CURRENT.json";
			string json = getJSONFromColors();
			File.WriteAllText(path, json);

			// Close the form
			Close();
		}
	}
}
