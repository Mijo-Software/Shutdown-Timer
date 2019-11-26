namespace Shutdown_Timer
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
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
      this.SuspendLayout();
      // 
      // labelActionTimer
      // 
      this.labelActionTimer.AutoSize = true;
      this.labelActionTimer.Location = new System.Drawing.Point(12, 35);
      this.labelActionTimer.Name = "labelActionTimer";
      this.labelActionTimer.Size = new System.Drawing.Size(64, 13);
      this.labelActionTimer.TabIndex = 0;
      this.labelActionTimer.Text = "Aktion nach";
      // 
      // numericUpDownMinutes
      // 
      this.numericUpDownMinutes.Location = new System.Drawing.Point(82, 33);
      this.numericUpDownMinutes.Name = "numericUpDownMinutes";
      this.numericUpDownMinutes.Size = new System.Drawing.Size(47, 20);
      this.numericUpDownMinutes.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(135, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Minuten ausführen";
      // 
      // labelAction
      // 
      this.labelAction.AutoSize = true;
      this.labelAction.Location = new System.Drawing.Point(12, 9);
      this.labelAction.Name = "labelAction";
      this.labelAction.Size = new System.Drawing.Size(40, 13);
      this.labelAction.TabIndex = 3;
      this.labelAction.Text = "Aktion:";
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
      this.comboBoxAction.TabIndex = 4;
      // 
      // buttonStartTimer
      // 
      this.buttonStartTimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartTimer.Image")));
      this.buttonStartTimer.Location = new System.Drawing.Point(15, 59);
      this.buttonStartTimer.Name = "buttonStartTimer";
      this.buttonStartTimer.Size = new System.Drawing.Size(98, 23);
      this.buttonStartTimer.TabIndex = 5;
      this.buttonStartTimer.Text = "Timer starten";
      this.buttonStartTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonStartTimer.UseVisualStyleBackColor = true;
      this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
      // 
      // buttonStopTimer
      // 
      this.buttonStopTimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonStopTimer.Image")));
      this.buttonStopTimer.Location = new System.Drawing.Point(130, 59);
      this.buttonStopTimer.Name = "buttonStopTimer";
      this.buttonStopTimer.Size = new System.Drawing.Size(100, 23);
      this.buttonStopTimer.TabIndex = 6;
      this.buttonStopTimer.Text = "Timer stoppen";
      this.buttonStopTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonStopTimer.UseVisualStyleBackColor = true;
      this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
      // 
      // progressBarAction
      // 
      this.progressBarAction.Location = new System.Drawing.Point(15, 88);
      this.progressBarAction.Name = "progressBarAction";
      this.progressBarAction.Size = new System.Drawing.Size(215, 16);
      this.progressBarAction.TabIndex = 8;
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // ShutdownTimerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(246, 117);
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
  }
}

