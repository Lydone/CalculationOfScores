using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationOfScores {
	public partial class EnglishForm : Form {
		public EnglishForm() {
			InitializeComponent();
		}

		private void englishCalculate_Click(object sender, EventArgs e) {
			double acc = 0, exam = 0;
			bool flag = true;
			try {
				flag = true;
				acc = double.Parse(accumulatedTextBox.Text);
				exam = double.Parse(examTextBox.Text);
				if (acc < 0 || acc > 10 || exam < 0 || exam > 10)
					throw new Exception();
			} catch {
				flag = false;
				MessageBox.Show("Некорректный ввод оценок", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (flag) {
				englishScoreLabel.Text = $"Итоговая оценка: {Formulas.CalculateEnglish(acc, exam)}";
			}
		}

		private void EnglishForm_FormClosed(object sender, FormClosedEventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Close();
		}
	}
}
