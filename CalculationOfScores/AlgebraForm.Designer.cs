namespace CalculationOfScores {
	partial class AlgebraForm {
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
			this.algebraCalculate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.semTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.collTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cwTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label5 = new System.Windows.Forms.Label();
			this.hwTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.examTextBox = new System.Windows.Forms.TextBox();
			this.algebraScoreLabel3 = new System.Windows.Forms.Label();
			this.algebraScoreLabel2 = new System.Windows.Forms.Label();
			this.algebraScoreLabel1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// algebraCalculate
			// 
			this.algebraCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.algebraCalculate.Location = new System.Drawing.Point(91, 242);
			this.algebraCalculate.Name = "algebraCalculate";
			this.algebraCalculate.Size = new System.Drawing.Size(254, 49);
			this.algebraCalculate.TabIndex = 5;
			this.algebraCalculate.Text = "Рассчитать оценку";
			this.algebraCalculate.UseVisualStyleBackColor = true;
			this.algebraCalculate.Click += new System.EventHandler(this.algebraCalculate_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(314, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Введите оценку за работу на семинарах";
			// 
			// semTextBox
			// 
			this.semTextBox.Location = new System.Drawing.Point(382, 148);
			this.semTextBox.Name = "semTextBox";
			this.semTextBox.Size = new System.Drawing.Size(45, 20);
			this.semTextBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Введите оценку за коллоквиум";
			// 
			// collTextBox
			// 
			this.collTextBox.Location = new System.Drawing.Point(382, 122);
			this.collTextBox.Name = "collTextBox";
			this.collTextBox.Size = new System.Drawing.Size(45, 20);
			this.collTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(160, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 31);
			this.label2.TabIndex = 13;
			this.label2.Text = "Алгебра";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Введите оценку за контрольную работу";
			// 
			// cwTextBox
			// 
			this.cwTextBox.Location = new System.Drawing.Point(382, 96);
			this.cwTextBox.Name = "cwTextBox";
			this.cwTextBox.Size = new System.Drawing.Size(45, 20);
			this.cwTextBox.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(439, 24);
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
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Введите оценку за домашнее задание";
			// 
			// hwTextBox
			// 
			this.hwTextBox.Location = new System.Drawing.Point(382, 174);
			this.hwTextBox.Name = "hwTextBox";
			this.hwTextBox.Size = new System.Drawing.Size(45, 20);
			this.hwTextBox.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(219, 20);
			this.label6.TabIndex = 23;
			this.label6.Text = "Введите оценку за экзамен";
			// 
			// examTextBox
			// 
			this.examTextBox.Location = new System.Drawing.Point(382, 200);
			this.examTextBox.Name = "examTextBox";
			this.examTextBox.Size = new System.Drawing.Size(45, 20);
			this.examTextBox.TabIndex = 4;
			// 
			// algebraScoreLabel3
			// 
			this.algebraScoreLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.algebraScoreLabel3.Location = new System.Drawing.Point(73, 371);
			this.algebraScoreLabel3.Name = "algebraScoreLabel3";
			this.algebraScoreLabel3.Size = new System.Drawing.Size(290, 20);
			this.algebraScoreLabel3.TabIndex = 26;
			// 
			// algebraScoreLabel2
			// 
			this.algebraScoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.algebraScoreLabel2.Location = new System.Drawing.Point(73, 342);
			this.algebraScoreLabel2.Name = "algebraScoreLabel2";
			this.algebraScoreLabel2.Size = new System.Drawing.Size(290, 20);
			this.algebraScoreLabel2.TabIndex = 25;
			// 
			// algebraScoreLabel1
			// 
			this.algebraScoreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.algebraScoreLabel1.Location = new System.Drawing.Point(73, 311);
			this.algebraScoreLabel1.Name = "algebraScoreLabel1";
			this.algebraScoreLabel1.Size = new System.Drawing.Size(290, 20);
			this.algebraScoreLabel1.TabIndex = 24;
			this.algebraScoreLabel1.Text = "Нажмите кнопку для расчета оценки";
			// 
			// AlgebraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 412);
			this.Controls.Add(this.algebraScoreLabel3);
			this.Controls.Add(this.algebraScoreLabel2);
			this.Controls.Add(this.algebraScoreLabel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.examTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.hwTextBox);
			this.Controls.Add(this.algebraCalculate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.semTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.collTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cwTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AlgebraForm";
			this.Text = "Алгебра";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlgebraForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button algebraCalculate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox semTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox collTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox cwTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox hwTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox examTextBox;
		private System.Windows.Forms.Label algebraScoreLabel3;
		private System.Windows.Forms.Label algebraScoreLabel2;
		private System.Windows.Forms.Label algebraScoreLabel1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}