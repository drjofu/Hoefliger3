namespace WinFormsQuiz
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.LBLFrage = new System.Windows.Forms.Label();
      this.RBAntwortA = new System.Windows.Forms.RadioButton();
      this.RBAntwortB = new System.Windows.Forms.RadioButton();
      this.RBAntwortC = new System.Windows.Forms.RadioButton();
      this.RBAntwortD = new System.Windows.Forms.RadioButton();
      this.BTNAntworten = new System.Windows.Forms.Button();
      this.BTNAufgeben = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LBLFrage
      // 
      this.LBLFrage.AutoSize = true;
      this.LBLFrage.Location = new System.Drawing.Point(67, 45);
      this.LBLFrage.Name = "LBLFrage";
      this.LBLFrage.Size = new System.Drawing.Size(38, 15);
      this.LBLFrage.TabIndex = 0;
      this.LBLFrage.Text = "label1";
      // 
      // RBAntwortA
      // 
      this.RBAntwortA.AutoSize = true;
      this.RBAntwortA.Location = new System.Drawing.Point(67, 80);
      this.RBAntwortA.Name = "RBAntwortA";
      this.RBAntwortA.Size = new System.Drawing.Size(94, 19);
      this.RBAntwortA.TabIndex = 1;
      this.RBAntwortA.TabStop = true;
      this.RBAntwortA.Text = "radioButton1";
      this.RBAntwortA.UseVisualStyleBackColor = true;
      // 
      // RBAntwortB
      // 
      this.RBAntwortB.AutoSize = true;
      this.RBAntwortB.Location = new System.Drawing.Point(67, 120);
      this.RBAntwortB.Name = "RBAntwortB";
      this.RBAntwortB.Size = new System.Drawing.Size(94, 19);
      this.RBAntwortB.TabIndex = 2;
      this.RBAntwortB.TabStop = true;
      this.RBAntwortB.Text = "radioButton2";
      this.RBAntwortB.UseVisualStyleBackColor = true;
      // 
      // RBAntwortC
      // 
      this.RBAntwortC.AutoSize = true;
      this.RBAntwortC.Location = new System.Drawing.Point(67, 158);
      this.RBAntwortC.Name = "RBAntwortC";
      this.RBAntwortC.Size = new System.Drawing.Size(94, 19);
      this.RBAntwortC.TabIndex = 3;
      this.RBAntwortC.TabStop = true;
      this.RBAntwortC.Text = "radioButton3";
      this.RBAntwortC.UseVisualStyleBackColor = true;
      // 
      // RBAntwortD
      // 
      this.RBAntwortD.AutoSize = true;
      this.RBAntwortD.Location = new System.Drawing.Point(67, 196);
      this.RBAntwortD.Name = "RBAntwortD";
      this.RBAntwortD.Size = new System.Drawing.Size(94, 19);
      this.RBAntwortD.TabIndex = 4;
      this.RBAntwortD.TabStop = true;
      this.RBAntwortD.Text = "radioButton4";
      this.RBAntwortD.UseVisualStyleBackColor = true;
      // 
      // BTNAntworten
      // 
      this.BTNAntworten.Location = new System.Drawing.Point(67, 258);
      this.BTNAntworten.Name = "BTNAntworten";
      this.BTNAntworten.Size = new System.Drawing.Size(75, 23);
      this.BTNAntworten.TabIndex = 5;
      this.BTNAntworten.Text = "Antworten";
      this.BTNAntworten.UseVisualStyleBackColor = true;
      this.BTNAntworten.Click += new System.EventHandler(this.BTNAntworten_Click);
      // 
      // BTNAufgeben
      // 
      this.BTNAufgeben.Location = new System.Drawing.Point(222, 258);
      this.BTNAufgeben.Name = "BTNAufgeben";
      this.BTNAufgeben.Size = new System.Drawing.Size(75, 23);
      this.BTNAufgeben.TabIndex = 6;
      this.BTNAufgeben.Text = "Aufgeben";
      this.BTNAufgeben.UseVisualStyleBackColor = true;
      this.BTNAufgeben.Click += new System.EventHandler(this.BTNAufgeben_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BTNAufgeben);
      this.Controls.Add(this.BTNAntworten);
      this.Controls.Add(this.RBAntwortD);
      this.Controls.Add(this.RBAntwortC);
      this.Controls.Add(this.RBAntwortB);
      this.Controls.Add(this.RBAntwortA);
      this.Controls.Add(this.LBLFrage);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label LBLFrage;
    private RadioButton RBAntwortA;
    private RadioButton RBAntwortB;
    private RadioButton RBAntwortC;
    private RadioButton RBAntwortD;
    private Button BTNAntworten;
    private Button BTNAufgeben;
  }
}