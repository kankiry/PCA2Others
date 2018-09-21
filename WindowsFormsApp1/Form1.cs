using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSetKintone._顧客管理_営業支援パック_' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.顧客管理_営業支援パック_TableAdapter.Fill(this.dataSetKintone._顧客管理_営業支援パック_);
            // TODO: このコード行はデータを 'dataSetSalesforce.Account' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.accountTableAdapter.Fill(this.dataSetSalesforce.Account);
            // TODO: このコード行はデータを 'dataSetPCASales.MasterTms' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.masterTmsTableAdapter.Fill(this.dataSetPCASales.MasterTms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (tabControl2.SelectedTab.Text == "Salesforce")
            {
                PCAtoSalesforce();
            }
            else
            {
                PCAtoKintone();
            }

            button1.Enabled = true;

        }

        private void PCAtoSalesforce()
        {
            dataGridView1.Rows.Cast<DataGridViewRow>()
                 .Where(o => o.Selected)
                 .Select((o, i) => new { Row = (DataSetPCASales.MasterTmsRow)((DataRowView)o.DataBoundItem).Row, Index = i })
                 .ToList()
                 .ForEach(selected =>
                 {
                     var name = selected.Row.TokuisakiMei1 + (selected.Row.IsTokuisakiMei2Null() ? "" : selected.Row.TokuisakiMei2);
                     var row = dataSetSalesforce.Account.Rows.Cast<DataSetSalesforce.AccountRow>()
                     .Where(o => o.Name == name)
                     .FirstOrDefault();

                     if (row is null)
                     {
                         row = dataSetSalesforce.Account.NewAccountRow();
                         //row.Id = "";
                         row.Id = selected.Index.ToString();
                     }

                     row.Name = name;
                     row.BillingPostalCode = selected.Row.IsYubinBangoNull() ? "" : selected.Row.YubinBango;
                     row.BillingStreet = (selected.Row.IsJyusyo1Null() ? "" : selected.Row.Jyusyo1) + (selected.Row.IsJyusyo2Null() ? "" : selected.Row.Jyusyo2);
                     row.Phone = selected.Row.IsAitesakiTelNoNull() ? "" : selected.Row.AitesakiTelNo;
                     row.Fax = selected.Row.IsAitesakiFaxNoNull() ? "" : selected.Row.AitesakiFaxNo;

                     if (row.Id == selected.Index.ToString())
                     {
                         dataSetSalesforce.Account.AddAccountRow(row);
                     }

                     accountTableAdapter.Update(dataSetSalesforce);
                 });

            accountTableAdapter.Fill(dataSetSalesforce.Account);
        }

        private void PCAtoKintone()
        {
            dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(o => o.Selected)
                .Select((o, i) => new { Row = (DataSetPCASales.MasterTmsRow)((DataRowView)o.DataBoundItem).Row, Index = i })
                .ToList()
                .ForEach(selected =>
                {
                    var name = selected.Row.TokuisakiMei1 + (selected.Row.IsTokuisakiMei2Null() ? "" : selected.Row.TokuisakiMei2);
                    var row = dataSetKintone._顧客管理_営業支援パック_.Rows.Cast<DataSetKintone._顧客管理_営業支援パック_Row>()
                    .Where(o => o.顧客名 == name)
                    .FirstOrDefault();

                    if (row is null)
                    {
                        row = dataSetKintone._顧客管理_営業支援パック_.New_顧客管理_営業支援パック_Row();
                        row.RecordId = selected.Index
                        + (dataSetKintone._顧客管理_営業支援パック_.Rows.Cast<DataSetKintone._顧客管理_営業支援パック_Row>().Max(o => (int?)o.RecordId) ?? 0)
                        + 1;
                        row.Revision = 0;
                    }

                    row.顧客名 = name;
                    row.郵便番号 = selected.Row.IsYubinBangoNull() ? "" : selected.Row.YubinBango;
                    row.住所 = (selected.Row.IsJyusyo1Null() ? "" : selected.Row.Jyusyo1) + (selected.Row.IsJyusyo2Null() ? "" : selected.Row.Jyusyo2);
                    row.TEL = selected.Row.IsAitesakiTelNoNull() ? "" : selected.Row.AitesakiTelNo;
                    row.FAX = selected.Row.IsAitesakiFaxNoNull() ? "" : selected.Row.AitesakiFaxNo;

                    if (row.Revision == 0)
                    {
                        dataSetKintone._顧客管理_営業支援パック_.Rows.Add(row);
                    }

                    顧客管理_営業支援パック_TableAdapter.Update(dataSetKintone);
                });

            顧客管理_営業支援パック_TableAdapter.Fill(dataSetKintone._顧客管理_営業支援パック_);
        }
    }
}
