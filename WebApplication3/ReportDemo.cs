namespace WebApplication3
{
    using System;
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

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            TryAddOneMoreRow();
            TryAddOneMoreColumn();
        }

        private void TryAddOneMoreRow()
        {
            Telerik.Reporting.TableGroup tableGroup13 = new Telerik.Reporting.TableGroup();
            var txtBox60 = new Telerik.Reporting.TextBox();
            var txtBox62 = new Telerik.Reporting.TextBox();
            var txtBox63 = new Telerik.Reporting.TextBox();

            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5D)));
            this.table1.Body.SetCellContent(5, 0, txtBox60, 1, 2);
            this.table1.Body.SetCellContent(5, 2, txtBox62);
            this.table1.Body.SetCellContent(5, 3, txtBox63);
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] { txtBox60, txtBox62, txtBox63 });

            tableGroup13.Name = "rowgroup_60";
            this.table1.RowGroups[0].ChildGroups.Add(tableGroup13); // Get "detailTableGroup"
            //
            // txtBox60
            // 
            txtBox60.Name = "txtBox60";
            txtBox60.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox60.StyleName = "";
            txtBox60.Value = "6.0";
            //
            // txtBox62
            // 
            txtBox62.Name = "txtBox62";
            txtBox62.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox62.StyleName = "";
            txtBox62.Value = "6.2";
            //
            // txtBox63
            // 
            txtBox63.Name = "txtBox63";
            txtBox63.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox63.StyleName = "";
            txtBox63.Value = "6.3";
        }

        private void TryAddOneMoreColumn()
        {
            Telerik.Reporting.TableGroup colGroup04 = new Telerik.Reporting.TableGroup();

            var txtBox04 = new Telerik.Reporting.TextBox();
            var txtBox14 = new Telerik.Reporting.TextBox();
            var txtBox24 = new Telerik.Reporting.TextBox();
            var txtBox34 = new Telerik.Reporting.TextBox();
            var txtBox44 = new Telerik.Reporting.TextBox();
            var txtBox54 = new Telerik.Reporting.TextBox();
            var txtBox64 = new Telerik.Reporting.TextBox();

            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2D)));

            this.table1.Body.SetCellContent(0, 4, txtBox14);
            this.table1.Body.SetCellContent(1, 4, txtBox24);
            this.table1.Body.SetCellContent(2, 4, txtBox34);
            this.table1.Body.SetCellContent(3, 4, txtBox44);
            this.table1.Body.SetCellContent(4, 4, txtBox54);
            this.table1.Body.SetCellContent(5, 4, txtBox64);
            
            colGroup04.Name = "colgroup_04";
            colGroup04.ReportItem = txtBox04;
            this.table1.ColumnGroups.Add(colGroup04);

            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                txtBox04, txtBox14, txtBox24, txtBox34, txtBox44, txtBox54, txtBox64
            });

            //
            // txtBox04
            // 
            txtBox04.Name = "txtBox04";
            txtBox04.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox04.StyleName = "";
            txtBox04.Value = "0.4";
            //
            // txtBox14
            // 
            txtBox14.Name = "txtBox14";
            txtBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox14.StyleName = "";
            txtBox14.Value = "1.4";
            //
            // txtBox24
            // 
            txtBox24.Name = "txtBox24";
            txtBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox24.StyleName = "";
            txtBox24.Value = "2.4";
            //
            // txtBox34
            // 
            txtBox34.Name = "txtBox34";
            txtBox34.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox34.StyleName = "";
            txtBox34.Value = "3.4";
            //
            // txtBox44
            // 
            txtBox44.Name = "txtBox44";
            txtBox44.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox44.StyleName = "";
            txtBox44.Value = "4.4";
            //
            // txtBox54
            // 
            txtBox54.Name = "txtBox54";
            txtBox54.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox54.StyleName = "";
            txtBox54.Value = "5.4";
            //
            // txtBox64
            // 
            txtBox64.Name = "txtBox64";
            txtBox64.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.98979115486145D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            txtBox64.StyleName = "";
            txtBox64.Value = "6.4";
        }
    }
}