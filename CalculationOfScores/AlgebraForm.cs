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
	public partial class AlgebraForm : Form {
		public AlgebraForm() {
			InitializeComponent();
		}

		private void algebraCalculate_Click(object sender, EventArgs e) {
			double cw = 0, coll = 0, sem = 0, hw = 0, exam = 0;
			bool flag = true;
			try {
				flag = true;
				cw = double.Parse(cwTextBox.Text);
				coll = double.Parse(collTextBox.Text);
				sem = double.Parse(semTextBox.Text);
				hw = double.Parse(hwTextBox.Text);
				exam = double.Parse(examTextBox.Text);
				if (cw < 0 || cw > 10 || coll < 0 || coll > 10 || sem < 0 || sem > 10 || hw < 0 || hw > 10 || exam < 0 || exam > 10)
					throw new Exception();
			} catch {
				flag = false;
				MessageBox.Show("Некорректный ввод оценок", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (flag) {
				double[] marks = Formulas.CalculateAlgebra(cw, coll, sem, hw, exam);
				algebraScoreLabel1.Text = $"Ваша накопленная оценка: {marks[0]:f3}";
				algebraScoreLabel2.Text = $"Накопленная с учетом округления: {marks[1]}";
				algebraScoreLabel3.Text = $"Ваша итоговая оценка: {marks[2]}";
			}
		}

		private void AlgebraForm_FormClosed(object sender, FormClosedEventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Close();
		}
	}
}
