namespace CalculationOfScores {
	partial class MainForm {
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
			this.components = new System.ComponentModel.Container();
			this.algebraChooseButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.englishChooseButton = new System.Windows.Forms.Button();
			this.discreteChooseButton = new System.Windows.Forms.Button();
			this.historyChooseButton = new System.Windows.Forms.Button();
			this.analysisChooseButton = new System.Windows.Forms.Button();
			this.programmingChooseButton = new System.Windows.Forms.Button();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// algebraChooseButton
			// 
			this.algebraChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.algebraChooseButton.Location = new System.Drawing.Point(115, 156);
			this.algebraChooseButton.Name = "algebraChooseButton";
			this.algebraChooseButton.Size = new System.Drawing.Size(254, 49);
			this.algebraChooseButton.TabIndex = 1;
			this.algebraChooseButton.Text = "Алгебра";
			this.algebraChooseButton.UseVisualStyleBackColor = true;
			this.algebraChooseButton.Click += new System.EventHandler(this.algebraChooseButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "Exit";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(84, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Выберите учебный курс";
			// 
			// englishChooseButton
			// 
			this.englishChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.englishChooseButton.Location = new System.Drawing.Point(115, 376);
			this.englishChooseButton.Name = "englishChooseButton";
			this.englishChooseButton.Size = new System.Drawing.Size(254, 49);
			this.englishChooseButton.TabIndex = 5;
			this.englishChooseButton.Text = "Английский язык";
			this.englishChooseButton.UseVisualStyleBackColor = true;
			this.englishChooseButton.Click += new System.EventHandler(this.englishChooseButton_Click);
			// 
			// discreteChooseButton
			// 
			this.discreteChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.discreteChooseButton.Location = new System.Drawing.Point(115, 321);
			this.discreteChooseButton.Name = "discreteChooseButton";
			this.discreteChooseButton.Size = new System.Drawing.Size(254, 49);
			this.discreteChooseButton.TabIndex = 4;
			this.discreteChooseButton.Text = "Дискретная математика";
			this.discreteChooseButton.UseVisualStyleBackColor = true;
			this.discreteChooseButton.Click += new System.EventHandler(this.discreteChooseButton_Click);
			// 
			// historyChooseButton
			// 
			this.historyChooseButton.Enabled = false;
			this.historyChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.historyChooseButton.Location = new System.Drawing.Point(115, 211);
			this.historyChooseButton.Name = "historyChooseButton";
			this.historyChooseButton.Size = new System.Drawing.Size(254, 49);
			this.historyChooseButton.TabIndex = 2;
			this.historyChooseButton.Text = "История";
			this.toolTip1.SetToolTip(this.historyChooseButton, "ПУД не найден");
			this.historyChooseButton.UseVisualStyleBackColor = true;
			this.historyChooseButton.Click += new System.EventHandler(this.historyChooseButton_Click);
			// 
			// analysisChooseButton
			// 
			this.analysisChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.analysisChooseButton.Location = new System.Drawing.Point(115, 101);
			this.analysisChooseButton.Name = "analysisChooseButton";
			this.analysisChooseButton.Size = new System.Drawing.Size(254, 49);
			this.analysisChooseButton.TabIndex = 0;
			this.analysisChooseButton.Text = "Математический анализ";
			this.analysisChooseButton.UseVisualStyleBackColor = true;
			this.analysisChooseButton.Click += new System.EventHandler(this.analysisChooseButton_Click);
			// 
			// programmingChooseButton
			// 
			this.programmingChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.programmingChooseButton.Location = new System.Drawing.Point(115, 266);
			this.programmingChooseButton.Name = "programmingChooseButton";
			this.programmingChooseButton.Size = new System.Drawing.Size(254, 49);
			this.programmingChooseButton.TabIndex = 3;
			this.programmingChooseButton.Text = "Программирование";
			this.programmingChooseButton.UseVisualStyleBackColor = true;
			this.programmingChooseButton.Click += new System.EventHandler(this.programmingChooseButton_Click);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.programmingChooseButton);
			this.Controls.Add(this.analysisChooseButton);
			this.Controls.Add(this.historyChooseButton);
			this.Controls.Add(this.discreteChooseButton);
			this.Controls.Add(this.englishChooseButton);
			this.Controls.Add(this.algebraChooseButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.Text = "Выбор оценки";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button algebraChooseButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button englishChooseButton;
		private System.Windows.Forms.Button discreteChooseButton;
		private System.Windows.Forms.Button historyChooseButton;
		private System.Windows.Forms.Button analysisChooseButton;
		private System.Windows.Forms.Button programmingChooseButton;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

