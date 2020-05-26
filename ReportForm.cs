using System.Data;
using KinderGarten.Data;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class ReportForm : MaterialForm
    {
        private readonly string _reportName;
        private readonly object _source;
        private readonly IDataService _service;

        public ReportForm(string reportName, object source, IDataService service)
        {
            _reportName = reportName;
            _source = source;
            _service = service;
            InitializeComponent();
        }

        private async void ReportForm_Load(object sender, System.EventArgs e)
        {
            switch (_reportName)
            {
                case "ScheduleTableReport":
                {

                    (DataTable table, string group, string data) data =
                        ((DataTable table, string group, string data)) _source;

                        DataSet1.ScheduleDataTable dtable = new DataSet1.ScheduleDataTable();
                        foreach (DataRow d in data.table.Rows)
                        {
                            var row = dtable.NewRow();
                            row[0] = d[0];
                            row[1] = d[1];
                            row[2] = d[2];
                            row[3] = d[3];
                            row[4] = d[4];
                            row[5] = d[5];
                            row[6] = d[6];
                            row[7] = d[7];
                            row[8] = d[8];
                            row[9] = d[9];
                            row[10] = d[10];
                            row[11] = d[11];
                            row[12] = d[12];
                            row[13] = d[13];
                            row[14] = d[14];
                            row[15] = d[15];
                            row[16] = d[16];
                            row[17] = d[17];
                            row[18] = d[18];
                            row[19] = d[19];
                            row[20] = d[20];
                            row[21] = d[21];
                            row[22] = d[22];
                            row[23] = d[23];
                            row[24] = d[24];
                            row[25] = d[25];
                            row[26] = d[26];
                            row[27] = d[27];
                            row[28] = d[28];

                            if (d.ItemArray.Length>28)
                                row[28] = d[28];
                            if (d.ItemArray.Length > 29)
                                row[29] = d[29];
                            if (d.ItemArray.Length > 30)
                                row[30] = d[30];
                            if (d.ItemArray.Length > 31)
                                row[31] = d[31];
                            row["Group"] = data.group;
                            row["DateStr"] = data.data;
                            dtable.Rows.Add(row);
                        }

                        this.Text = "Таблица посещений";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DataSet1";

                        reportDataSource1.Value = dtable;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.ScheduleTableReport.rdlc";

                    }
                    break;
                case "ChildReport":
                    {
                        var data = _source as Children[];
                        this.Text = "Список воспитанников";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "ChildsDataSet";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.ChildsReport.rdlc";

                    }
                    break;
                case "ChildrenListReport":
                {
                    var data = _source as Children[];
                    this.Text = "Список воспитанников";
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                        = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource1.Name = "ChildsDataSet";

                    reportDataSource1.Value = data;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.ChildrenListReport.rdlc";

                }
                    break;
                case "VisitFilterReport":
                {
                    var data = _source as Visit[];
                    this.Text = "Список посещений";
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                        = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource1.Name = "DataSet1";

                    reportDataSource1.Value = data;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.VisitFilterReport.rdlc";

                }
                    break;
                case "CountGraphReport":
                    {
                        var data = _source as CountReport[];
                        this.Text = "Количество воспитанников за период";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DataSetEntered";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.CountGraphReport.rdlc";

                    }
                    break;
                case "ReqGraphReport":
                    {
                        var data = _source as CountReport[];
                        this.Text = "Заявки за период";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DataSetEntered";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.ReqGraphReport.rdlc";

                    }
                    break;
                case "EnteredGraphReport":
                    {
                        var data = _source as CountReport[];
                        this.Text = "Поступившие за период";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DataSetEntered";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.EnteredGraphReport.rdlc";

                    }
                    break;
                case "VisitReport":
                    {
                        var data = _source as VisitReport[];
                        this.Text = "Посещения";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "VisitDataSet";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.VisitReport.rdlc";

                    }
                    break;
                case "MenuReport":
                    {
                        var data = _source as MenuReport[];
                        this.Text = "Меню";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "MenuDataSet";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.MenuReport.rdlc";

                    }
                    break;
                case "ScheduleReport":
                    {
                        var data = _source as Schedule[];
                        this.Text = "Расписание";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "ScheduleDataSet";

                        reportDataSource1.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.ScheduleReport.rdlc";

                    }
                    break;
                case "AgreementReport":
                    {
                        var data = _source as Parent[];
                        this.Text = "Договор";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DetailsDataSet";
                        var details = await _service.GetEntitiesAsync<Details>();
                        reportDataSource1.Value = details;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource2.Name = "ParentDataSet";

                        reportDataSource2.Value = data;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.AgreementReport.rdlc";

                    }
                    break;
                case "EnteredReport":
                    {
                        var data = _source as Children;
                        this.Text = "Приказ о зачислении";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DetailsDataSet";
                        var details = await _service.GetEntitiesAsync<Details>();
                        reportDataSource1.Value = details;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource2.Name = "ChildDataSet";

                        reportDataSource2.Value = new[] { data };
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.EnteredReport.rdlc";

                    }
                    break;
                case "TransferReport":
                    {
                        var data = _source as Children;
                        this.Text = "Приказ о переводе";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DetailsDataSet";
                        var details = await _service.GetEntitiesAsync<Details>();
                        reportDataSource1.Value = details;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource2.Name = "ChildDataSet";

                        reportDataSource2.Value = new[] { data };
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.TransferReport.rdlc";

                    }
                    break;
                case "LeaveReport":
                    {
                        var data = _source as Children;
                        this.Text = "Приказ об отчислении";
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource1.Name = "DetailsDataSet";
                        var details = await _service.GetEntitiesAsync<Details>();
                        reportDataSource1.Value = details;
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2
                            = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource2.Name = "ChildDataSet";

                        reportDataSource2.Value = new[] { data };
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "KinderGarten.Views.LeaveReport.rdlc";

                    }
                    break;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
