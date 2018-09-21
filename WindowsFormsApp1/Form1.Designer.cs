namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tokuisakiCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokuisakiMei1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokuisakiMei2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yubinBangoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jyusyo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jyusyo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitesakiTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitesakiFaxNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterTmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPCASales = new WindowsFormsApp1.DataSetPCASales();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalesforce = new WindowsFormsApp1.DataSetSalesforce();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.郵便番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客管理営業支援パックBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetKintone = new WindowsFormsApp1.DataSetKintone();
            this.button1 = new System.Windows.Forms.Button();
            this.masterTmsTableAdapter = new WindowsFormsApp1.DataSetPCASalesTableAdapters.MasterTmsTableAdapter();
            this.accountTableAdapter = new WindowsFormsApp1.DataSetSalesforceTableAdapters.AccountTableAdapter();
            this.顧客管理_営業支援パック_TableAdapter = new WindowsFormsApp1.DataSetKintoneTableAdapters.顧客管理_営業支援パック_TableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPCASales)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesforce)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客管理営業支援パックBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKintone)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1634, 1049);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 1043);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 1011);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PCASales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tokuisakiCodeDataGridViewTextBoxColumn,
            this.tokuisakiMei1DataGridViewTextBoxColumn,
            this.tokuisakiMei2DataGridViewTextBoxColumn,
            this.yubinBangoDataGridViewTextBoxColumn,
            this.jyusyo1DataGridViewTextBoxColumn,
            this.jyusyo2DataGridViewTextBoxColumn,
            this.aitesakiTelNoDataGridViewTextBoxColumn,
            this.aitesakiFaxNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masterTmsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(715, 1005);
            this.dataGridView1.TabIndex = 0;
            // 
            // tokuisakiCodeDataGridViewTextBoxColumn
            // 
            this.tokuisakiCodeDataGridViewTextBoxColumn.DataPropertyName = "TokuisakiCode";
            this.tokuisakiCodeDataGridViewTextBoxColumn.HeaderText = "TokuisakiCode";
            this.tokuisakiCodeDataGridViewTextBoxColumn.Name = "tokuisakiCodeDataGridViewTextBoxColumn";
            // 
            // tokuisakiMei1DataGridViewTextBoxColumn
            // 
            this.tokuisakiMei1DataGridViewTextBoxColumn.DataPropertyName = "TokuisakiMei1";
            this.tokuisakiMei1DataGridViewTextBoxColumn.HeaderText = "TokuisakiMei1";
            this.tokuisakiMei1DataGridViewTextBoxColumn.Name = "tokuisakiMei1DataGridViewTextBoxColumn";
            // 
            // tokuisakiMei2DataGridViewTextBoxColumn
            // 
            this.tokuisakiMei2DataGridViewTextBoxColumn.DataPropertyName = "TokuisakiMei2";
            this.tokuisakiMei2DataGridViewTextBoxColumn.HeaderText = "TokuisakiMei2";
            this.tokuisakiMei2DataGridViewTextBoxColumn.Name = "tokuisakiMei2DataGridViewTextBoxColumn";
            // 
            // yubinBangoDataGridViewTextBoxColumn
            // 
            this.yubinBangoDataGridViewTextBoxColumn.DataPropertyName = "YubinBango";
            this.yubinBangoDataGridViewTextBoxColumn.HeaderText = "YubinBango";
            this.yubinBangoDataGridViewTextBoxColumn.Name = "yubinBangoDataGridViewTextBoxColumn";
            // 
            // jyusyo1DataGridViewTextBoxColumn
            // 
            this.jyusyo1DataGridViewTextBoxColumn.DataPropertyName = "Jyusyo1";
            this.jyusyo1DataGridViewTextBoxColumn.HeaderText = "Jyusyo1";
            this.jyusyo1DataGridViewTextBoxColumn.Name = "jyusyo1DataGridViewTextBoxColumn";
            // 
            // jyusyo2DataGridViewTextBoxColumn
            // 
            this.jyusyo2DataGridViewTextBoxColumn.DataPropertyName = "Jyusyo2";
            this.jyusyo2DataGridViewTextBoxColumn.HeaderText = "Jyusyo2";
            this.jyusyo2DataGridViewTextBoxColumn.Name = "jyusyo2DataGridViewTextBoxColumn";
            // 
            // aitesakiTelNoDataGridViewTextBoxColumn
            // 
            this.aitesakiTelNoDataGridViewTextBoxColumn.DataPropertyName = "AitesakiTelNo";
            this.aitesakiTelNoDataGridViewTextBoxColumn.HeaderText = "AitesakiTelNo";
            this.aitesakiTelNoDataGridViewTextBoxColumn.Name = "aitesakiTelNoDataGridViewTextBoxColumn";
            // 
            // aitesakiFaxNoDataGridViewTextBoxColumn
            // 
            this.aitesakiFaxNoDataGridViewTextBoxColumn.DataPropertyName = "AitesakiFaxNo";
            this.aitesakiFaxNoDataGridViewTextBoxColumn.HeaderText = "AitesakiFaxNo";
            this.aitesakiFaxNoDataGridViewTextBoxColumn.Name = "aitesakiFaxNoDataGridViewTextBoxColumn";
            // 
            // masterTmsBindingSource
            // 
            this.masterTmsBindingSource.DataMember = "MasterTms";
            this.masterTmsBindingSource.DataSource = this.dataSetPCASales;
            // 
            // dataSetPCASales
            // 
            this.dataSetPCASales.DataSetName = "DataSetPCASales";
            this.dataSetPCASales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(901, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(730, 1043);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(722, 1011);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Salesforce";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.billingStreetDataGridViewTextBoxColumn,
            this.billingPostalCodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.accountBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(716, 1005);
            this.dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // billingStreetDataGridViewTextBoxColumn
            // 
            this.billingStreetDataGridViewTextBoxColumn.DataPropertyName = "BillingStreet";
            this.billingStreetDataGridViewTextBoxColumn.HeaderText = "BillingStreet";
            this.billingStreetDataGridViewTextBoxColumn.Name = "billingStreetDataGridViewTextBoxColumn";
            // 
            // billingPostalCodeDataGridViewTextBoxColumn
            // 
            this.billingPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "BillingPostalCode";
            this.billingPostalCodeDataGridViewTextBoxColumn.HeaderText = "BillingPostalCode";
            this.billingPostalCodeDataGridViewTextBoxColumn.Name = "billingPostalCodeDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.dataSetSalesforce;
            // 
            // dataSetSalesforce
            // 
            this.dataSetSalesforce.DataSetName = "DataSetSalesforce";
            this.dataSetSalesforce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(722, 1011);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "kintone";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.郵便番号DataGridViewTextBoxColumn,
            this.顧客名DataGridViewTextBoxColumn,
            this.住所DataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.顧客管理営業支援パックBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(716, 1005);
            this.dataGridView2.TabIndex = 0;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Revision";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            // 
            // 郵便番号DataGridViewTextBoxColumn
            // 
            this.郵便番号DataGridViewTextBoxColumn.DataPropertyName = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.HeaderText = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.Name = "郵便番号DataGridViewTextBoxColumn";
            // 
            // 顧客名DataGridViewTextBoxColumn
            // 
            this.顧客名DataGridViewTextBoxColumn.DataPropertyName = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.HeaderText = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.Name = "顧客名DataGridViewTextBoxColumn";
            // 
            // 住所DataGridViewTextBoxColumn
            // 
            this.住所DataGridViewTextBoxColumn.DataPropertyName = "住所";
            this.住所DataGridViewTextBoxColumn.HeaderText = "住所";
            this.住所DataGridViewTextBoxColumn.Name = "住所DataGridViewTextBoxColumn";
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            // 
            // fAXDataGridViewTextBoxColumn1
            // 
            this.fAXDataGridViewTextBoxColumn1.DataPropertyName = "FAX";
            this.fAXDataGridViewTextBoxColumn1.HeaderText = "FAX";
            this.fAXDataGridViewTextBoxColumn1.Name = "fAXDataGridViewTextBoxColumn1";
            // 
            // 顧客管理営業支援パックBindingSource
            // 
            this.顧客管理営業支援パックBindingSource.DataMember = "顧客管理（営業支援パック）";
            this.顧客管理営業支援パックBindingSource.DataSource = this.dataSetKintone;
            // 
            // dataSetKintone
            // 
            this.dataSetKintone.DataSetName = "DataSetKintone";
            this.dataSetKintone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(779, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterTmsTableAdapter
            // 
            this.masterTmsTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // 顧客管理_営業支援パック_TableAdapter
            // 
            this.顧客管理_営業支援パック_TableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 1049);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPCASales)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesforce)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客管理営業支援パックBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKintone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetPCASales dataSetPCASales;
        private System.Windows.Forms.BindingSource masterTmsBindingSource;
        private DataSetPCASalesTableAdapters.MasterTmsTableAdapter masterTmsTableAdapter;
        private DataSetSalesforce dataSetSalesforce;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DataSetSalesforceTableAdapters.AccountTableAdapter accountTableAdapter;
        private DataSetKintone dataSetKintone;
        private System.Windows.Forms.BindingSource 顧客管理営業支援パックBindingSource;
        private DataSetKintoneTableAdapters.顧客管理_営業支援パック_TableAdapter 顧客管理_営業支援パック_TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokuisakiCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokuisakiMei1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokuisakiMei2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yubinBangoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jyusyo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jyusyo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitesakiTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitesakiFaxNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

