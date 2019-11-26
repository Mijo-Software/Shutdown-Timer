using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shutdown_Timer
{
  public partial class ShutdownTimerForm : Form
  {
    public ShutdownTimerForm()
    {
      InitializeComponent();
    }

    private void ShutdownTimerForm_Load(object sender, EventArgs e)
    {
      buttonStopTimer.Enabled = false;
      numericUpDownMinutes.Value = 30;
      comboBoxAction.SelectedIndex = 0;
    }

    private void buttonStartTimer_Click(object sender, EventArgs e)
    {
      buttonStartTimer.Enabled = false;
      buttonStopTimer.Enabled = true;
      progressBarAction.Minimum = 0;
      progressBarAction.Maximum = (int)numericUpDownMinutes.Value;
      timer.Enabled = true;

      System.Diagnostics.Process.Start("shutdown", "-h");
      buttonStartTimer.Enabled = true;
      buttonStopTimer.Enabled = false;
      timer.Enabled = false;
    }

    private void buttonStopTimer_Click(object sender, EventArgs e)
    {
      buttonStartTimer.Enabled = true;
      buttonStopTimer.Enabled = false;
      timer.Enabled = false;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      //progressBarAction.Value = minutes;
    }

  }
}
