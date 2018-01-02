namespace CalculationOfScores {
	partial class EnglishForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.englishScoreLabel = new System.Windows.Forms.Label();
			this.englishCalculate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.examTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.accumulatedTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// englishScoreLabel
			// 
			this.englishScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.englishScoreLabel.Location = new System.Drawing.Point(42, 235);
			this.englishScoreLabel.Name = "englishScoreLabel";
			this.englishScoreLabel.Size = new System.Drawing.Size(290, 20);
			this.englishScoreLabel.TabIndex = 19;
			this.englishScoreLabel.Text = "Нажмите кнопку для расчета оценки";
			this.englishScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// englishCalculate
			// 
			this.englishCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.englishCalculate.Location = new System.Drawing.Point(60, 168);
			this.englishCalculate.Name = "englishCalculate";
			this.englishCalculate.Size = new System.Drawing.Size(254, 49);
			this.englishCalculate.TabIndex = 18;
			this.englishCalculate.Text = "Рассчитать оценку";
			this.englishCalculate.UseVisualStyleBackColor = true;
			this.englishCalculate.Click += new System.EventHandler(this.englishCalculate_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(219, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Введите оценку за экзамен";
			// 
			// examTextBox
			// 
			this.examTextBox.Location = new System.Drawing.Point(318, 125);
			this.examTextBox.Name = "examTextBox";
			this.examTextBox.Size = new System.Drawing.Size(45, 20);
			this.examTextBox.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(73, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 31);
			this.label2.TabIndex = 13;
			this.label2.Text = "Английский язык";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Введите накопленную оценку";
			// 
			// accumulatedTextBox
			// 
			this.accumulatedTextBox.Location = new System.Drawing.Point(318, 99);
			this.accumulatedTextBox.Name = "accumulatedTextBox";
			this.accumulatedTextBox.Size = new System.Drawing.Size(45, 20);
			this.accumulatedTextBox.TabIndex = 10;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(375, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// EnglishForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 280);
			this.Controls.Add(this.englishScoreLabel);
			this.Controls.Add(this.englishCalculate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.examTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.accumulatedTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "EnglishForm";
			this.Text = "Английский язык";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnglishForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label englishScoreLabel;
		private System.Windows.Forms.Button englishCalculate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox examTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox accumulatedTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}