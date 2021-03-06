﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace STraF_U {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DatasetSummary : DataSet {
        
        private summaryDataTable tablesummary;
        
        public DatasetSummary() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DatasetSummary(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["summary"] != null)) {
                    this.Tables.Add(new summaryDataTable(ds.Tables["summary"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public summaryDataTable summary {
            get {
                return this.tablesummary;
            }
        }
        
        public override DataSet Clone() {
            DatasetSummary cln = ((DatasetSummary)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["summary"] != null)) {
                this.Tables.Add(new summaryDataTable(ds.Tables["summary"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tablesummary = ((summaryDataTable)(this.Tables["summary"]));
            if ((this.tablesummary != null)) {
                this.tablesummary.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DatasetSummary";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DatasetSummary.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesummary = new summaryDataTable();
            this.Tables.Add(this.tablesummary);
        }
        
        private bool ShouldSerializesummary() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void summaryRowChangeEventHandler(object sender, summaryRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class summaryDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnshortname;
            
            private DataColumn columndegree;
            
            private DataColumn columnLoan;
            
            private DataColumn columnLoanTuition;
            
            private DataColumn columnAdvance;
            
            private DataColumn columnAdvanceTuition;
            
            private DataColumn columnHerder;
            
            private DataColumn columnHerderTuition;
            
            private DataColumn columnPoor;
            
            private DataColumn columnPoorTuition;
            
            private DataColumn columnThird;
            
            private DataColumn columnThirdTuition;
            
            private DataColumn columnTax;
            
            private DataColumn columnTaxTuition;
            
            internal summaryDataTable() : 
                    base("summary") {
                this.InitClass();
            }
            
            internal summaryDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn shortnameColumn {
                get {
                    return this.columnshortname;
                }
            }
            
            internal DataColumn degreeColumn {
                get {
                    return this.columndegree;
                }
            }
            
            internal DataColumn LoanColumn {
                get {
                    return this.columnLoan;
                }
            }
            
            internal DataColumn LoanTuitionColumn {
                get {
                    return this.columnLoanTuition;
                }
            }
            
            internal DataColumn AdvanceColumn {
                get {
                    return this.columnAdvance;
                }
            }
            
            internal DataColumn AdvanceTuitionColumn {
                get {
                    return this.columnAdvanceTuition;
                }
            }
            
            internal DataColumn HerderColumn {
                get {
                    return this.columnHerder;
                }
            }
            
            internal DataColumn HerderTuitionColumn {
                get {
                    return this.columnHerderTuition;
                }
            }
            
            internal DataColumn PoorColumn {
                get {
                    return this.columnPoor;
                }
            }
            
            internal DataColumn PoorTuitionColumn {
                get {
                    return this.columnPoorTuition;
                }
            }
            
            internal DataColumn ThirdColumn {
                get {
                    return this.columnThird;
                }
            }
            
            internal DataColumn ThirdTuitionColumn {
                get {
                    return this.columnThirdTuition;
                }
            }
            
            internal DataColumn TaxColumn {
                get {
                    return this.columnTax;
                }
            }
            
            internal DataColumn TaxTuitionColumn {
                get {
                    return this.columnTaxTuition;
                }
            }
            
            public summaryRow this[int index] {
                get {
                    return ((summaryRow)(this.Rows[index]));
                }
            }
            
            public event summaryRowChangeEventHandler summaryRowChanged;
            
            public event summaryRowChangeEventHandler summaryRowChanging;
            
            public event summaryRowChangeEventHandler summaryRowDeleted;
            
            public event summaryRowChangeEventHandler summaryRowDeleting;
            
            public void AddsummaryRow(summaryRow row) {
                this.Rows.Add(row);
            }
            
            public summaryRow AddsummaryRow(string shortname, string degree, int Loan, System.Double LoanTuition, int Advance, System.Double AdvanceTuition, int Herder, System.Double HerderTuition, int Poor, System.Double PoorTuition, int Third, System.Double ThirdTuition, int Tax, System.Double TaxTuition) {
                summaryRow rowsummaryRow = ((summaryRow)(this.NewRow()));
                rowsummaryRow.ItemArray = new object[] {
                        shortname,
                        degree,
                        Loan,
                        LoanTuition,
                        Advance,
                        AdvanceTuition,
                        Herder,
                        HerderTuition,
                        Poor,
                        PoorTuition,
                        Third,
                        ThirdTuition,
                        Tax,
                        TaxTuition};
                this.Rows.Add(rowsummaryRow);
                return rowsummaryRow;
            }
            
            public summaryRow FindByshortname(string shortname) {
                return ((summaryRow)(this.Rows.Find(new object[] {
                            shortname})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                summaryDataTable cln = ((summaryDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new summaryDataTable();
            }
            
            internal void InitVars() {
                this.columnshortname = this.Columns["shortname"];
                this.columndegree = this.Columns["degree"];
                this.columnLoan = this.Columns["Loan"];
                this.columnLoanTuition = this.Columns["LoanTuition"];
                this.columnAdvance = this.Columns["Advance"];
                this.columnAdvanceTuition = this.Columns["AdvanceTuition"];
                this.columnHerder = this.Columns["Herder"];
                this.columnHerderTuition = this.Columns["HerderTuition"];
                this.columnPoor = this.Columns["Poor"];
                this.columnPoorTuition = this.Columns["PoorTuition"];
                this.columnThird = this.Columns["Third"];
                this.columnThirdTuition = this.Columns["ThirdTuition"];
                this.columnTax = this.Columns["Tax"];
                this.columnTaxTuition = this.Columns["TaxTuition"];
            }
            
            private void InitClass() {
                this.columnshortname = new DataColumn("shortname", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnshortname);
                this.columndegree = new DataColumn("degree", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columndegree);
                this.columnLoan = new DataColumn("Loan", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLoan);
                this.columnLoanTuition = new DataColumn("LoanTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLoanTuition);
                this.columnAdvance = new DataColumn("Advance", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAdvance);
                this.columnAdvanceTuition = new DataColumn("AdvanceTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAdvanceTuition);
                this.columnHerder = new DataColumn("Herder", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHerder);
                this.columnHerderTuition = new DataColumn("HerderTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHerderTuition);
                this.columnPoor = new DataColumn("Poor", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPoor);
                this.columnPoorTuition = new DataColumn("PoorTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPoorTuition);
                this.columnThird = new DataColumn("Third", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnThird);
                this.columnThirdTuition = new DataColumn("ThirdTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnThirdTuition);
                this.columnTax = new DataColumn("Tax", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTax);
                this.columnTaxTuition = new DataColumn("TaxTuition", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTaxTuition);
                this.Constraints.Add(new UniqueConstraint("DatasetSummaryKey1", new DataColumn[] {
                                this.columnshortname}, true));
                this.columnshortname.AllowDBNull = false;
                this.columnshortname.Unique = true;
                this.columnLoan.ReadOnly = true;
                this.columnLoanTuition.ReadOnly = true;
                this.columnLoanTuition.DefaultValue = 0;
                this.columnAdvance.ReadOnly = true;
                this.columnAdvanceTuition.ReadOnly = true;
                this.columnAdvanceTuition.DefaultValue = 0;
                this.columnHerder.ReadOnly = true;
                this.columnHerderTuition.ReadOnly = true;
                this.columnHerderTuition.DefaultValue = 0;
                this.columnPoor.ReadOnly = true;
                this.columnPoorTuition.ReadOnly = true;
                this.columnPoorTuition.DefaultValue = 0;
                this.columnThird.ReadOnly = true;
                this.columnThirdTuition.ReadOnly = true;
                this.columnThirdTuition.DefaultValue = 0;
                this.columnTax.ReadOnly = true;
                this.columnTaxTuition.ReadOnly = true;
                this.columnTaxTuition.DefaultValue = 0;
            }
            
            public summaryRow NewsummaryRow() {
                return ((summaryRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new summaryRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(summaryRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.summaryRowChanged != null)) {
                    this.summaryRowChanged(this, new summaryRowChangeEvent(((summaryRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.summaryRowChanging != null)) {
                    this.summaryRowChanging(this, new summaryRowChangeEvent(((summaryRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.summaryRowDeleted != null)) {
                    this.summaryRowDeleted(this, new summaryRowChangeEvent(((summaryRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.summaryRowDeleting != null)) {
                    this.summaryRowDeleting(this, new summaryRowChangeEvent(((summaryRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovesummaryRow(summaryRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class summaryRow : DataRow {
            
            private summaryDataTable tablesummary;
            
            internal summaryRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesummary = ((summaryDataTable)(this.Table));
            }
            
            public string shortname {
                get {
                    return ((string)(this[this.tablesummary.shortnameColumn]));
                }
                set {
                    this[this.tablesummary.shortnameColumn] = value;
                }
            }
            
            public string degree {
                get {
                    try {
                        return ((string)(this[this.tablesummary.degreeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.degreeColumn] = value;
                }
            }
            
            public int Loan {
                get {
                    try {
                        return ((int)(this[this.tablesummary.LoanColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.LoanColumn] = value;
                }
            }
            
            public System.Double LoanTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.LoanTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.LoanTuitionColumn] = value;
                }
            }
            
            public int Advance {
                get {
                    try {
                        return ((int)(this[this.tablesummary.AdvanceColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.AdvanceColumn] = value;
                }
            }
            
            public System.Double AdvanceTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.AdvanceTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.AdvanceTuitionColumn] = value;
                }
            }
            
            public int Herder {
                get {
                    try {
                        return ((int)(this[this.tablesummary.HerderColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.HerderColumn] = value;
                }
            }
            
            public System.Double HerderTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.HerderTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.HerderTuitionColumn] = value;
                }
            }
            
            public int Poor {
                get {
                    try {
                        return ((int)(this[this.tablesummary.PoorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.PoorColumn] = value;
                }
            }
            
            public System.Double PoorTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.PoorTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.PoorTuitionColumn] = value;
                }
            }
            
            public int Third {
                get {
                    try {
                        return ((int)(this[this.tablesummary.ThirdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.ThirdColumn] = value;
                }
            }
            
            public System.Double ThirdTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.ThirdTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.ThirdTuitionColumn] = value;
                }
            }
            
            public int Tax {
                get {
                    try {
                        return ((int)(this[this.tablesummary.TaxColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.TaxColumn] = value;
                }
            }
            
            public System.Double TaxTuition {
                get {
                    try {
                        return ((System.Double)(this[this.tablesummary.TaxTuitionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesummary.TaxTuitionColumn] = value;
                }
            }
            
            public bool IsdegreeNull() {
                return this.IsNull(this.tablesummary.degreeColumn);
            }
            
            public void SetdegreeNull() {
                this[this.tablesummary.degreeColumn] = System.Convert.DBNull;
            }
            
            public bool IsLoanNull() {
                return this.IsNull(this.tablesummary.LoanColumn);
            }
            
            public void SetLoanNull() {
                this[this.tablesummary.LoanColumn] = System.Convert.DBNull;
            }
            
            public bool IsLoanTuitionNull() {
                return this.IsNull(this.tablesummary.LoanTuitionColumn);
            }
            
            public void SetLoanTuitionNull() {
                this[this.tablesummary.LoanTuitionColumn] = System.Convert.DBNull;
            }
            
            public bool IsAdvanceNull() {
                return this.IsNull(this.tablesummary.AdvanceColumn);
            }
            
            public void SetAdvanceNull() {
                this[this.tablesummary.AdvanceColumn] = System.Convert.DBNull;
            }
            
            public bool IsAdvanceTuitionNull() {
                return this.IsNull(this.tablesummary.AdvanceTuitionColumn);
            }
            
            public void SetAdvanceTuitionNull() {
                this[this.tablesummary.AdvanceTuitionColumn] = System.Convert.DBNull;
            }
            
            public bool IsHerderNull() {
                return this.IsNull(this.tablesummary.HerderColumn);
            }
            
            public void SetHerderNull() {
                this[this.tablesummary.HerderColumn] = System.Convert.DBNull;
            }
            
            public bool IsHerderTuitionNull() {
                return this.IsNull(this.tablesummary.HerderTuitionColumn);
            }
            
            public void SetHerderTuitionNull() {
                this[this.tablesummary.HerderTuitionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPoorNull() {
                return this.IsNull(this.tablesummary.PoorColumn);
            }
            
            public void SetPoorNull() {
                this[this.tablesummary.PoorColumn] = System.Convert.DBNull;
            }
            
            public bool IsPoorTuitionNull() {
                return this.IsNull(this.tablesummary.PoorTuitionColumn);
            }
            
            public void SetPoorTuitionNull() {
                this[this.tablesummary.PoorTuitionColumn] = System.Convert.DBNull;
            }
            
            public bool IsThirdNull() {
                return this.IsNull(this.tablesummary.ThirdColumn);
            }
            
            public void SetThirdNull() {
                this[this.tablesummary.ThirdColumn] = System.Convert.DBNull;
            }
            
            public bool IsThirdTuitionNull() {
                return this.IsNull(this.tablesummary.ThirdTuitionColumn);
            }
            
            public void SetThirdTuitionNull() {
                this[this.tablesummary.ThirdTuitionColumn] = System.Convert.DBNull;
            }
            
            public bool IsTaxNull() {
                return this.IsNull(this.tablesummary.TaxColumn);
            }
            
            public void SetTaxNull() {
                this[this.tablesummary.TaxColumn] = System.Convert.DBNull;
            }
            
            public bool IsTaxTuitionNull() {
                return this.IsNull(this.tablesummary.TaxTuitionColumn);
            }
            
            public void SetTaxTuitionNull() {
                this[this.tablesummary.TaxTuitionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class summaryRowChangeEvent : EventArgs {
            
            private summaryRow eventRow;
            
            private DataRowAction eventAction;
            
            public summaryRowChangeEvent(summaryRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public summaryRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
