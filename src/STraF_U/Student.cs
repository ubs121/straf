using System;

namespace STraF_U {
	/// <summary>
	/// Summary description for Student.
	/// </summary>
	public class Student {
		public enum Degree {DIPLOMA = 1, BACHELOR = 2, MASTER = 3, ASPIRANT = 4, DOCTOR = 5};
		public enum PType {LOAN = 1, ADVANCE=2, HERDER=3, POOR=4, THIRD=5, TAX=6};
		public enum State {NEW = 1, AVL = 2, ABSENT = 4, CANCELLED = 8, GRAD = 16}; 
		public static int[] States = new int[] {(int)State.NEW, (int)State.AVL, (int)State.ABSENT, (int)State.CANCELLED, (int)State.GRAD};

		public static bool CheckState(int newState, int oldState) {
			bool b = false;
			switch (newState) {
				case (int)State.ABSENT: 
					if (oldState == (int)State.AVL)
						b = true; 
					break;
			
				case (int)State.AVL: 
					if (oldState == (int)State.ABSENT || oldState == (int)State.NEW)
						b = true; 
					break;
			
				case (int)State.GRAD: 
					if (oldState == (int)State.AVL)
						b = true;
					break;
			
				case (int)State.CANCELLED: 
					if (oldState == (int)State.AVL || oldState == (int)State.GRAD)
						b = true;
					break;
			}
		
			return b;
		}
	}
}

