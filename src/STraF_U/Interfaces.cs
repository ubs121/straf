using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF_U {
	public interface IStrafChild {
		int Find(object search, bool regular, bool back);
		int Replace(object search, object replace, bool regular, bool back);
		ReportDocument GetDocument();
	}
	public interface IStudentChild : IStrafChild {
		void ChangeProf(string prof);
	}
}