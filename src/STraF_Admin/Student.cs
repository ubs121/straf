using System;

namespace STraF {
	/// <summary>
	/// Summary description for Student.
	/// </summary>
	public class Student {
		public enum Degree {BACHELOR=1, MASTER, ASPIRANT, DOCTOR};
		public static string[] descDegree = new string[] {"бакалавр", "магистрант", "аспирант", "докторант"};
		public enum PType {LOAN=1, HELP, THIRD, TAX, HERDER, POOR, PRIZE, FOREIGN};
		public static string[] types = new string[]{"Loan", "Help", "Third", "Tax", "Herder", "Poor", "Prize", "Foreign", "Tax_UB"};
		public static string[] types_mn = new string[]{"Зээл", "Буцалтгvй", "Гуравдагч", "ТАХ", "Малчны", "Ядуу", "Шагнал", "Гадаад", "ТАХ Улаанбаатар"};
		public enum State {NEW=1, AVL, ABSENT, CANCELLED, GRAD}; 
	}
}

