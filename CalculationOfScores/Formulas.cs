using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfScores {
	static class Formulas {

		public static double[] CalculateAnalysis(double cw, double sem, double exam) {
			double[] marks = new double[3]; // 0 - accumulated, 1 - rounded, 2 - final
			marks[0] = Math.Round(cw * 0.7, 4) + Math.Round(sem * 0.3, 4);
			marks[1] = Math.Round(marks[0], MidpointRounding.AwayFromZero);
			marks[2] = Math.Round(Math.Round(marks[1] * 0.3, 4) + Math.Round(exam * 0.7, 4), MidpointRounding.AwayFromZero);
			return marks;
		}

		public static double[] CalculateAlgebra(double cw, double coll, double sem, double hw, double exam) {
			double[] marks = new double[3]; // 0 - accumulated, 1 - rounded, 2 - final
			marks[0] = Math.Round(0.35 * cw, 4) + Math.Round(0.45 * coll, 4) + Math.Round(0.1 * sem, 4) + Math.Round(0.1 * hw, 4);
			marks[1] = Math.Round(marks[0], MidpointRounding.AwayFromZero);
			marks[2] = Math.Round(Math.Round(marks[1] * 0.7, 4) + Math.Round(exam * 0.3, 4), MidpointRounding.AwayFromZero);
			return marks;
		}

		public static double[] CalculateProgramming(double[] iw3, double cw3, double[] iw4, double cw4, double hw, double exam, double test) {
			double[] marks = new double[5]; //0 - iw3 average, 1 - accumulated3, 2 - iw4 average, 3 - accumulated4, 4 - final 
			double cnt = 0;
			foreach (var item in iw3) {
				cnt += item;
			}
			marks[0] = Math.Round(cnt / iw3.Length, 4);
			cnt = 0;
			foreach (var item in iw4) {
				cnt += item;
			}
			marks[2] = Math.Round(cnt / iw4.Length, 4);
			marks[1] = Math.Round(Math.Round(0.2 * marks[0], 4) + Math.Round(0.8 * cw3, 4), MidpointRounding.AwayFromZero);
			marks[3] = Math.Round(Math.Round(0.35 * cw4, 4) + Math.Round(0.35 * hw, 4) + Math.Round(0.3 * marks[2], 4), MidpointRounding.AwayFromZero);
			double acc = Math.Round(Math.Round(marks[3] * 0.8, 4) + Math.Round(marks[1] * 0.2, 4), MidpointRounding.AwayFromZero);
			double finExam = Math.Round(Math.Round(Math.Min(test, exam) * 0.8, 4) + Math.Round(Math.Max(test, exam) * 0.2, 4), MidpointRounding.AwayFromZero);
			marks[4] = Math.Round(Math.Round(acc * 0.2, 4) + Math.Round(finExam * 0.8, 4), MidpointRounding.AwayFromZero);
			return marks;
		}

		public static double[] CalculateDiscrete(double hw3, double hw4, double cw3, double cw4, double test) {
			double[] marks = new double[4]; // 0 - 3 mod merge, 1 - 4 mod merge, 2 - accum, 3 - final
			marks[0] = Math.Round(Math.Round(Math.Max(cw3, hw3) * 0.38, 4) + Math.Round(Math.Min(cw3, hw3) * 0.62, 4), MidpointRounding.AwayFromZero);
			marks[1] = Math.Round(Math.Round(Math.Max(hw4, cw4) * 0.38, 4) + Math.Round(Math.Min(hw4, cw4) * 0.62, 4), MidpointRounding.AwayFromZero);
			marks[2] = Math.Round(Math.Round(Math.Max(marks[0], marks[1]) * 0.38, 4) + Math.Round(Math.Min(marks[0], marks[1]) * 0.62, 4), MidpointRounding.AwayFromZero);
			marks[3] = Math.Round(Math.Round(marks[2] * 0.8, 4) + Math.Round(test * 0.2, 4), MidpointRounding.AwayFromZero);
			return marks;
		}

		public static double CalculateEnglish(double acc, double exam) {
			return Math.Round(Math.Round(acc * 0.6, 4) + Math.Round(exam * 0.4, 4), MidpointRounding.AwayFromZero);
		}
	}
}
