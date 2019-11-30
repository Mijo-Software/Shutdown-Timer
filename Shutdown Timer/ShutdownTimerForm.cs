using System;
using System.Windows.Forms;

namespace ShutdownTimer
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	public partial class ShutdownTimerForm : Form
	{
		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public ShutdownTimerForm()
		{
			InitializeComponent();
			ClearStatusbar_Leave(sender: null, e: null);
		}

		private void ShutdownTimerForm_Load(object sender, EventArgs e)
		{
			buttonStopTimer.Enabled = false;
			numericUpDownMinutes.Value = 30;
			comboBoxAction.SelectedIndex = 0;
		}

		private void ButtonStartTimer_Click(object sender, EventArgs e)
		{
			buttonStartTimer.Enabled = false;
			buttonStopTimer.Enabled = true;
			progressBarAction.Minimum = 0;
			progressBarAction.Maximum = (int)numericUpDownMinutes.Value;
			timer.Enabled = true;

			//System.Diagnostics.Process.Start("shutdown", "-h");
		}

		private void ButtonStopTimer_Click(object sender, EventArgs e)
		{
			buttonStartTimer.Enabled = true;
			buttonStopTimer.Enabled = false;
			timer.Enabled = false;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			//progressBarAction.Value = minutes;
		}

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => SetStatusbarText(text: ((Control)sender).AccessibleDescription);

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: "");
	}
}
