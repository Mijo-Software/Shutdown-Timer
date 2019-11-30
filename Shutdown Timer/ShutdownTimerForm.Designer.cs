namespace ShutdownTimer
{
  partial class ShutdownTimerForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTimerForm));
			this.labelActionTimer = new System.Windows.Forms.Label();
			this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAction = new System.Windows.Forms.Label();
			this.comboBoxAction = new System.Windows.Forms.ComboBox();
			this.buttonStartTimer = new System.Windows.Forms.Button();
			this.buttonStopTimer = new System.Windows.Forms.Button();
			this.progressBarAction = new System.Windows.Forms.ProgressBar();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxRecording = new System.Windows.Forms.CheckBox();
			this.checkBoxNoTimelimitWarning = new System.Windows.Forms.CheckBox();
			this.labelProgress = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelActionTimer
			// 
			this.labelActionTimer.AutoSize = true;
			this.labelActionTimer.Location = new System.Drawing.Point(12, 35);
			this.labelActionTimer.Name = "labelActionTimer";
			this.labelActionTimer.Size = new System.Drawing.Size(64, 13);
			this.labelActionTimer.TabIndex = 2;
			this.labelActionTimer.Text = "Aktion nach";
			this.labelActionTimer.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelActionTimer.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelActionTimer.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelActionTimer.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownMinutes
			// 
			this.numericUpDownMinutes.Location = new System.Drawing.Point(82, 33);
			this.numericUpDownMinutes.Name = "numericUpDownMinutes";
			this.numericUpDownMinutes.Size = new System.Drawing.Size(47, 20);
			this.numericUpDownMinutes.TabIndex = 3;
			this.numericUpDownMinutes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownMinutes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Minuten ausführen";
			this.label2.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.label2.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.label2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.label2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAction
			// 
			this.labelAction.AutoSize = true;
			this.labelAction.Location = new System.Drawing.Point(12, 9);
			this.labelAction.Name = "labelAction";
			this.labelAction.Size = new System.Drawing.Size(40, 13);
			this.labelAction.TabIndex = 0;
			this.labelAction.Text = "Aktion:";
			this.labelAction.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAction.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAction.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAction.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// comboBoxAction
			// 
			this.comboBoxAction.FormattingEnabled = true;
			this.comboBoxAction.Items.AddRange(new object[] {
            "Herunterfahren",
            "Neustarten",
            "Ruhezustand",
            "Benutzer abmelden"});
			this.comboBoxAction.Location = new System.Drawing.Point(58, 6);
			this.comboBoxAction.Name = "comboBoxAction";
			this.comboBoxAction.Size = new System.Drawing.Size(172, 21);
			this.comboBoxAction.TabIndex = 1;
			this.comboBoxAction.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.comboBoxAction.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.comboBoxAction.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.comboBoxAction.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonStartTimer
			// 
			this.buttonStartTimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartTimer.Image")));
			this.buttonStartTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStartTimer.Location = new System.Drawing.Point(15, 105);
			this.buttonStartTimer.Name = "buttonStartTimer";
			this.buttonStartTimer.Size = new System.Drawing.Size(98, 23);
			this.buttonStartTimer.TabIndex = 7;
			this.buttonStartTimer.Text = "Timer starten";
			this.buttonStartTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStartTimer.UseVisualStyleBackColor = true;
			this.buttonStartTimer.Click += new System.EventHandler(this.ButtonStartTimer_Click);
			this.buttonStartTimer.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStartTimer.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonStopTimer
			// 
			this.buttonStopTimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonStopTimer.Image")));
			this.buttonStopTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStopTimer.Location = new System.Drawing.Point(130, 105);
			this.buttonStopTimer.Name = "buttonStopTimer";
			this.buttonStopTimer.Size = new System.Drawing.Size(100, 23);
			this.buttonStopTimer.TabIndex = 8;
			this.buttonStopTimer.Text = "Timer stoppen";
			this.buttonStopTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStopTimer.UseVisualStyleBackColor = true;
			this.buttonStopTimer.Click += new System.EventHandler(this.ButtonStopTimer_Click);
			this.buttonStopTimer.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStopTimer.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBarAction
			// 
			this.progressBarAction.Location = new System.Drawing.Point(77, 134);
			this.progressBarAction.Name = "progressBarAction";
			this.progressBarAction.Size = new System.Drawing.Size(153, 16);
			this.progressBarAction.TabIndex = 10;
			this.progressBarAction.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBarAction.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// checkBoxRecording
			// 
			this.checkBoxRecording.AutoSize = true;
			this.checkBoxRecording.Location = new System.Drawing.Point(15, 59);
			this.checkBoxRecording.Name = "checkBoxRecording";
			this.checkBoxRecording.Size = new System.Drawing.Size(98, 17);
			this.checkBoxRecording.TabIndex = 5;
			this.checkBoxRecording.Text = "Dokumentieren";
			this.checkBoxRecording.UseVisualStyleBackColor = true;
			this.checkBoxRecording.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkBoxRecording.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkBoxRecording.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkBoxRecording.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// checkBoxNoTimelimitWarning
			// 
			this.checkBoxNoTimelimitWarning.AutoSize = true;
			this.checkBoxNoTimelimitWarning.Location = new System.Drawing.Point(15, 82);
			this.checkBoxNoTimelimitWarning.Name = "checkBoxNoTimelimitWarning";
			this.checkBoxNoTimelimitWarning.Size = new System.Drawing.Size(131, 17);
			this.checkBoxNoTimelimitWarning.TabIndex = 6;
			this.checkBoxNoTimelimitWarning.Text = "Ohne Zeitlimitwarnung";
			this.checkBoxNoTimelimitWarning.UseVisualStyleBackColor = true;
			this.checkBoxNoTimelimitWarning.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkBoxNoTimelimitWarning.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkBoxNoTimelimitWarning.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkBoxNoTimelimitWarning.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelProgress
			// 
			this.labelProgress.AutoSize = true;
			this.labelProgress.Location = new System.Drawing.Point(15, 135);
			this.labelProgress.Name = "labelProgress";
			this.labelProgress.Size = new System.Drawing.Size(56, 13);
			this.labelProgress.TabIndex = 9;
			this.labelProgress.Text = "Fortschritt:";
			this.labelProgress.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgress.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelProgress.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgress.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 157);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(246, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 11;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(92, 17);
			this.labelInformation.Text = "information text";
			// 
			// ShutdownTimerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 179);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.labelProgress);
			this.Controls.Add(this.checkBoxNoTimelimitWarning);
			this.Controls.Add(this.checkBoxRecording);
			this.Controls.Add(this.progressBarAction);
			this.Controls.Add(this.buttonStopTimer);
			this.Controls.Add(this.buttonStartTimer);
			this.Controls.Add(this.comboBoxAction);
			this.Controls.Add(this.labelAction);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownMinutes);
			this.Controls.Add(this.labelActionTimer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ShutdownTimerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shutdown Timer";
			this.Load += new System.EventHandler(this.ShutdownTimerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelActionTimer;
    private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelAction;
    private System.Windows.Forms.ComboBox comboBoxAction;
    private System.Windows.Forms.Button buttonStartTimer;
    private System.Windows.Forms.Button buttonStopTimer;
    private System.Windows.Forms.ProgressBar progressBarAction;
    private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxRecording;
		private System.Windows.Forms.CheckBox checkBoxNoTimelimitWarning;
		private System.Windows.Forms.Label labelProgress;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}

