namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ReportDemo.
    /// </summary>
    public partial class ReportDemo : Telerik.Reporting.Report
    {
        public ReportDemo()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            // Uncomment one of the cases to see the result
            //CreateTable2x2Test(); // case 1
            //CreateTable2x2MergeHeaderTest(); // case 2
            //CreateTable2x2MergeBodyCellTest(); // case 3
        }

        /// case 1:
        /// | 0.0 | 0.1 |
        /// -------------
        /// | 1.0 | 1.1 |
        /// 
        private void CreateTable2x2Test()
        {
            var table1 = new Telerik.Reporting.Table();
            var colGroup1 = new Telerik.Reporting.TableGroup();
            var colGroup2 = new Telerik.Reporting.TableGroup();
            var colGroup3 = new Telerik.Reporting.TableGroup();
            var colGroup4 = new Telerik.Reporting.TableGroup();
            var detailGroup = new Telerik.Reporting.TableGroup();
            var rowGroup1 = new Telerik.Reporting.TableGroup();

            var txtBox00 = new Telerik.Reporting.TextBox();
            var txtBox01 = new Telerik.Reporting.TextBox();
            var txtBox10 = new Telerik.Reporting.TextBox();
            var txtBox11 = new Telerik.Reporting.TextBox();

            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            table1});

            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5D)));

            table1.Body.SetCellContent(0, 0, txtBox10);
            table1.Body.SetCellContent(0, 1, txtBox11);

            table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                txtBox00, txtBox01, txtBox10, txtBox11
            });

            colGroup2.Name = "colgroup-02";
            colGroup1.ChildGroups.Add(colGroup2);
            colGroup1.Name = "colgroup-01";
            colGroup1.ReportItem = txtBox00;

            colGroup4.Name = "colgroup-04";
            colGroup3.ChildGroups.Add(colGroup4);
            colGroup3.Name = "colgroup-03";
            colGroup3.ReportItem = txtBox01;

            table1.ColumnGroups.Add(colGroup1);
            table1.ColumnGroups.Add(colGroup3);

            rowGroup1.Name = "rowgroup-01";
            detailGroup.ChildGroups.Add(rowGroup1);
            detailGroup.Groupings.Add(new Telerik.Reporting.Grouping(null));
            detailGroup.Name = "detailgroup";

            table1.RowGroups.Add(detailGroup);

            table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(1.5D));
            table1.Name = "table1";

            //
            // txtBox00
            //
            txtBox00.Name = "txtBox00";
            txtBox00.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox00.StyleName = "";
            txtBox00.Value = "0.0";
            //
            // txtBox01
            //
            txtBox01.Name = "txtBox01";
            txtBox01.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox01.StyleName = "";
            txtBox01.Value = "0.1";
            //
            // txtBox10
            //
            txtBox10.Name = "txtBox10";
            txtBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox10.StyleName = "";
            txtBox10.Value = "1.0";
            //
            // txtBox11
            //
            txtBox11.Name = "txtBox11";
            txtBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox11.StyleName = "";
            txtBox11.Value = "1.1";
        }

        /// case 2:
        /// | 0.0       |
        /// -------------
        /// | 1.0 | 1.1 |
        /// 
        private void CreateTable2x2MergeHeaderTest()
        {
            var table1 = new Telerik.Reporting.Table();
            var colGroup1 = new Telerik.Reporting.TableGroup();
            var colGroup2 = new Telerik.Reporting.TableGroup();
            var colGroup3 = new Telerik.Reporting.TableGroup();
            var detailGroup = new Telerik.Reporting.TableGroup();
            var rowGroup1 = new Telerik.Reporting.TableGroup();

            var txtBox00 = new Telerik.Reporting.TextBox();
            var txtBox10 = new Telerik.Reporting.TextBox();
            var txtBox11 = new Telerik.Reporting.TextBox();

            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            table1});

            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5D)));

            table1.Body.SetCellContent(0, 0, txtBox10);
            table1.Body.SetCellContent(0, 1, txtBox11);

            table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                txtBox00, txtBox10, txtBox11
            });

            colGroup2.Name = "colgroup-02";
            colGroup3.Name = "colgroup-03";
            colGroup1.ChildGroups.Add(colGroup2);
            colGroup1.ChildGroups.Add(colGroup3);
            colGroup1.Name = "colgroup-01";
            colGroup1.ReportItem = txtBox00;

            table1.ColumnGroups.Add(colGroup1);

            rowGroup1.Name = "rowgroup-01";
            detailGroup.ChildGroups.Add(rowGroup1);
            detailGroup.Groupings.Add(new Telerik.Reporting.Grouping(null));
            detailGroup.Name = "detailgroup";

            table1.RowGroups.Add(detailGroup);

            table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(1.5D));
            table1.Name = "table1";

            //
            // txtBox00
            //
            txtBox00.Name = "txtBox00";
            txtBox00.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox00.StyleName = "";
            txtBox00.Value = "0.0";
            //
            // txtBox10
            //
            txtBox10.Name = "txtBox10";
            txtBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox10.StyleName = "";
            txtBox10.Value = "1.0";
            //
            // txtBox11
            //
            txtBox11.Name = "txtBox11";
            txtBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox11.StyleName = "";
            txtBox11.Value = "1.1";
        }

        /// case 3:
        /// | 0.0 | 0.1 |
        /// -------------
        /// | 1.0       |
        /// 
        private void CreateTable2x2MergeBodyCellTest()
        {
            var table1 = new Telerik.Reporting.Table();
            var colGroup1 = new Telerik.Reporting.TableGroup();
            var colGroup2 = new Telerik.Reporting.TableGroup();
            var colGroup3 = new Telerik.Reporting.TableGroup();
            var colGroup4 = new Telerik.Reporting.TableGroup();
            var detailGroup = new Telerik.Reporting.TableGroup();
            var rowGroup1 = new Telerik.Reporting.TableGroup();

            var txtBox00 = new Telerik.Reporting.TextBox();
            var txtBox01 = new Telerik.Reporting.TextBox();
            var txtBox10 = new Telerik.Reporting.TextBox();

            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            table1});

            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3D)));
            table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5D)));

            table1.Body.SetCellContent(0, 0, txtBox10, 1, 2);

            table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                txtBox00, txtBox01, txtBox10
            });

            colGroup2.Name = "colgroup-02";
            colGroup1.ChildGroups.Add(colGroup2);
            colGroup1.Name = "colgroup-01";
            colGroup1.ReportItem = txtBox00;

            colGroup4.Name = "colgroup-04";
            colGroup3.ChildGroups.Add(colGroup4);
            colGroup3.Name = "colgroup-03";
            colGroup3.ReportItem = txtBox01;

            table1.ColumnGroups.Add(colGroup1);
            table1.ColumnGroups.Add(colGroup3);

            rowGroup1.Name = "rowgroup-01";
            detailGroup.ChildGroups.Add(rowGroup1);
            detailGroup.Groupings.Add(new Telerik.Reporting.Grouping(null));
            detailGroup.Name = "detailgroup";

            table1.RowGroups.Add(detailGroup);

            table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(1.5D));
            table1.Name = "table1";

            //
            // txtBox00
            //
            txtBox00.Name = "txtBox00";
            txtBox00.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox00.StyleName = "";
            txtBox00.Value = "0.0";
            //
            // txtBox01
            //
            txtBox01.Name = "txtBox01";
            txtBox01.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox01.StyleName = "";
            txtBox01.Value = "0.1";
            //
            // txtBox10
            //
            txtBox10.Name = "txtBox10";
            txtBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox10.StyleName = "";
            txtBox10.Value = "1.0";
        }
    }
}