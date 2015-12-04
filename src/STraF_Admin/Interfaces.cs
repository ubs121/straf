using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF {
	public interface IStrafChild {
		void Find(object search, bool regular, bool back);
		void Replace(object search, object replace, bool regular, bool back);
		//void ReplaceAll(object search, object replace, bool regular);
		ReportDocument GetReportDocument();
	}
	public interface IStudentChild : IStrafChild {
		void ChangeSchool(int school_id);
		void ChangeRegion(int region_id);
		void ChangeOrg(int org_id);
	}
}