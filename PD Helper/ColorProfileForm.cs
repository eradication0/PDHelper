using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_Helper
{
	public partial class ColorProfileForm : Form
	{
		public ColorProfileForm()
		{
			InitializeComponent();
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
	}
}
