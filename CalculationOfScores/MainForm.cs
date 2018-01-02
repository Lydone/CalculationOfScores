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
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void analysisChooseButton_Click(object sender, EventArgs e) {
			Enabled = false;
			AnalysisForm af = new AnalysisForm();
			af.Show();
		}

		private void algebraChooseButton_Click(object sender, EventArgs e) {
			Enabled = false;
			AlgebraForm af = new AlgebraForm();
			af.Show();
		}

		private void historyChooseButton_Click(object sender, EventArgs e) {

		}

		private void programmingChooseButton_Click(object sender, EventArgs e) {
			Enabled = false;
			ProgrammingForm pf = new ProgrammingForm();
			pf.Show();
		}

		private void discreteChooseButton_Click(object sender, EventArgs e) {
			DiscreteForm df = new DiscreteForm();
			df.Show();
		}

		private void englishChooseButton_Click(object sender, EventArgs e) {
			EnglishForm ef = new EnglishForm();
			ef.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutForm af = new AboutForm();
			Enabled = false;
			af.Show();
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
			AboutForm af = new AboutForm();
			Enabled = false;
			af.Show();
		}
	}
}
