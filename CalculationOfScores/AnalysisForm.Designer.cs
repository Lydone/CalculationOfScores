namespace CalculationOfScores {
	partial class AnalysisForm {
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
			this.cwTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.semTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.examTextBox = new System.Windows.Forms.TextBox();
			this.analysisCalculate = new System.Windows.Forms.Button();
			this.analysisScoreLabel1 = new System.Windows.Forms.Label();
			this.analysisScoreLabel2 = new System.Windows.Forms.Label();
			this.analysisScoreLabel3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cwTextBox
			// 
			this.cwTextBox.Location = new System.Drawing.Point(382, 98);
			this.cwTextBox.Name = "cwTextBox";
			this.cwTextBox.Size = new System.Drawing.Size(45, 20);
			this.cwTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Введите оценку за контрольную работу";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(439, 24);
			this.menuStrip1.TabIndex = 2;
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
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(58, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(322, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Математический анализ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(314, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Введите оценку за работу на семинарах";
			// 
			// semTextBox
			// 
			this.semTextBox.Location = new System.Drawing.Point(382, 124);
			this.semTextBox.Name = "semTextBox";
			this.semTextBox.Size = new System.Drawing.Size(45, 20);
			this.semTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(219, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Введите оценку за экзамен";
			// 
			// examTextBox
			// 
			this.examTextBox.Location = new System.Drawing.Point(382, 150);
			this.examTextBox.Name = "examTextBox";
			this.examTextBox.Size = new System.Drawing.Size(45, 20);
			this.examTextBox.TabIndex = 6;
			// 
			// analysisCalculate
			// 
			this.analysisCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.analysisCalculate.Location = new System.Drawing.Point(92, 186);
			this.analysisCalculate.Name = "analysisCalculate";
			this.analysisCalculate.Size = new System.Drawing.Size(254, 49);
			this.analysisCalculate.TabIndex = 8;
			this.analysisCalculate.Text = "Рассчитать оценку";
			this.analysisCalculate.UseVisualStyleBackColor = true;
			this.analysisCalculate.Click += new System.EventHandler(this.analysisCalculate_Click);
			// 
			// analysisScoreLabel1
			// 
			this.analysisScoreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.analysisScoreLabel1.Location = new System.Drawing.Point(74, 252);
			this.analysisScoreLabel1.Name = "analysisScoreLabel1";
			this.analysisScoreLabel1.Size = new System.Drawing.Size(290, 20);
			this.analysisScoreLabel1.TabIndex = 9;
			this.analysisScoreLabel1.Text = "Нажмите кнопку для расчета оценки";
			// 
			// analysisScoreLabel2
			// 
			this.analysisScoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.analysisScoreLabel2.Location = new System.Drawing.Point(74, 283);
			this.analysisScoreLabel2.Name = "analysisScoreLabel2";
			this.analysisScoreLabel2.Size = new System.Drawing.Size(290, 20);
			this.analysisScoreLabel2.TabIndex = 10;
			// 
			// analysisScoreLabel3
			// 
			this.analysisScoreLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.analysisScoreLabel3.Location = new System.Drawing.Point(74, 312);
			this.analysisScoreLabel3.Name = "analysisScoreLabel3";
			this.analysisScoreLabel3.Size = new System.Drawing.Size(290, 20);
			this.analysisScoreLabel3.TabIndex = 11;
			// 
			// AnalysisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 369);
			this.Controls.Add(this.analysisScoreLabel3);
			this.Controls.Add(this.analysisScoreLabel2);
			this.Controls.Add(this.analysisScoreLabel1);
			this.Controls.Add(this.analysisCalculate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.examTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.semTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cwTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "AnalysisForm";
			this.Text = "Математический анализ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalysisForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cwTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox semTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox examTextBox;
		private System.Windows.Forms.Button analysisCalculate;
		private System.Windows.Forms.Label analysisScoreLabel1;
		private System.Windows.Forms.Label analysisScoreLabel2;
		private System.Windows.Forms.Label analysisScoreLabel3;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}