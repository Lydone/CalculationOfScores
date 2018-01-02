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
	public partial class DiscreteForm : Form {
		public DiscreteForm() {
			InitializeComponent();
		}

		private void discreteCalculate_Click(object sender, EventArgs e) {
			double hw3 = 0, cw3 = 0, hw4 = 0, cw4 = 0, test = 0;
			bool flag = true;
			try {
				flag = true;
				hw3 = double.Parse(hw3TextBox.Text);
				cw3 = double.Parse(cw3TextBox.Text);
				hw4 = double.Parse(hw4TextBox.Text);
				cw4 = double.Parse(cw4TextBox.Text);
				test = double.Parse(testTextBox.Text);
				if (hw3 < 0 || hw3 > 10 || hw4 < 0 || hw4 > 10 || cw3 < 0 || cw3 > 10 || cw4 < 0 || cw4 > 10)
					throw new Exception();
			} catch {
				flag = false;
				MessageBox.Show("Некорректный ввод оценок", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (flag) {
				double[] marks = Formulas.CalculateDiscrete(hw3, hw4, cw3, cw4, test);
				discreteScoreLabel1.Text = $"Оценка за 3 модуль: {marks[0]}";
				discreteScoreLabel2.Text = $"Оценка за 4 модуль: {marks[1]}";
				discreteScoreLabel3.Text = $"Оценка без учета теста: {marks[2]}";
				discreteScoreLabel4.Text = $"Итоговая оценка: {marks[3]}";
			}
		}

		private void DiscreteForm_FormClosed(object sender, FormClosedEventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Close();
		}
	}
}
