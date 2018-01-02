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
	public partial class ProgrammingForm : Form {
		public ProgrammingForm() {
			InitializeComponent();
		}

		private void programmingCalculate_Click(object sender, EventArgs e) {
			double[] iw3 = new double[0], iw4 = new double[0];
			double cw3 = 0, cw4 = 0, hw = 0, exam = 0, test = 0;
			bool flag = true;
			try {
				flag = true;
				string[] iw3s = iw3TextBox.Text.Split(' ');
				string[] iw4s = iw4TextBox.Text.Split(' ');
				iw3 = new double[iw3s.Length];
				for (int i = 0; i < iw3.Length; i++) {
					iw3[i] = double.Parse(iw3s[i]);
				}
				iw4 = new double[iw4s.Length];
				for (int i = 0; i < iw4.Length; i++) {
					iw4[i] = double.Parse(iw4s[i]);
				}
				cw3 = double.Parse(cw3TextBox.Text);
				cw4 = double.Parse(cw4TextBox.Text);
				hw = double.Parse(hwTextBox.Text);
				exam = double.Parse(examTextBox.Text);
				test = double.Parse(testTextBox.Text);
				foreach (var item in iw3) {
					if (item < 0 || item > 10)
						throw new Exception();
				}
				foreach (var item in iw4) {
					if (item < 0 || item > 10)
						throw new Exception();
				}
				if (cw3 < 0 || cw3 > 10 || cw4 < 0 || cw4 > 10 || hw < 0 || hw > 10 || exam < 0 || exam > 10 || test < 0 || test > 10)
					throw new Exception();
			} catch {
				flag = false;
				MessageBox.Show("Некорректный ввод оценок", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (flag) {
				double[] marks = Formulas.CalculateProgramming(iw3, cw3, iw4, cw4, hw, exam, test);
				programmingScoreLabel1.Text = $"Средняя оценка за ср 3 модуля: {marks[0]}";
				programmingScoreLabel2.Text = $"Накопленная оценка за 3 модуль: {marks[1]}";
				programmingScoreLabel3.Text = $"Средняя оценка за ср 4 модуля: {marks[2]}";
				programmingScoreLabel4.Text = $"Накопленная оценка за 4 модуль: {marks[3]}";
				programmingScoreLabel5.Text = $"Итоговая оценка: {marks[4]}";
			}

		}

		private void ProgrammingForm_FormClosed(object sender, FormClosedEventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			MainForm mf = (MainForm) Application.OpenForms[0];
			mf.Close();
		}
	}
}
