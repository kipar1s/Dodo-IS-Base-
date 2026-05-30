namespace dodoisbase
{
    partial class CurierList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurierList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Create = new System.Windows.Forms.ToolStripButton();
            this.tsb_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_Delite = new System.Windows.Forms.ToolStripButton();
            this.dodoDS = new dodoisbase.dodoDS();
            this.dodoDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курьерTableAdapter = new dodoisbase.dodoDSTableAdapters.КурьерTableAdapter();
            this.curierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерВУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.машинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермашиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКурьераDataGridViewTextBoxColumn,
            this.ID_Сотрудника,
            this.номерВУDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.машинаDataGridViewTextBoxColumn,
            this.номермашиныDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.curierBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 311);
            this.dataGridView1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Create,
            this.tsb_Edit,
            this.tsb_Delite});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Create
            // 
            this.tsb_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Create.Name = "tsb_Create";
            this.tsb_Create.Size = new System.Drawing.Size(68, 24);
            this.tsb_Create.Text = "Создать";
            this.tsb_Create.Click += new System.EventHandler(this.tsb_Create_Click);
            // 
            // tsb_Edit
            // 
            this.tsb_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Edit.Image")));
            this.tsb_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Edit.Name = "tsb_Edit";
            this.tsb_Edit.Size = new System.Drawing.Size(82, 24);
            this.tsb_Edit.Text = "Изменить";
            this.tsb_Edit.Click += new System.EventHandler(this.tsb_Edit_Click);
            // 
            // tsb_Delite
            // 
            this.tsb_Delite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Delite.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Delite.Image")));
            this.tsb_Delite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Delite.Name = "tsb_Delite";
            this.tsb_Delite.Size = new System.Drawing.Size(69, 24);
            this.tsb_Delite.Text = "Удалить";
            this.tsb_Delite.Click += new System.EventHandler(this.tsb_Delite_Click);
            // 
            // dodoDS
            // 
            this.dodoDS.DataSetName = "dodoDS";
            this.dodoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodoDSBindingSource
            // 
            this.dodoDSBindingSource.DataSource = this.dodoDS;
            this.dodoDSBindingSource.Position = 0;
            // 
            // курьерTableAdapter
            // 
            this.курьерTableAdapter.ClearBeforeFill = true;
            // 
            // curierBindingSource
            // 
            this.curierBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Curier);
            // 
            // iDКурьераDataGridViewTextBoxColumn
            // 
            this.iDКурьераDataGridViewTextBoxColumn.DataPropertyName = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.HeaderText = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКурьераDataGridViewTextBoxColumn.Name = "iDКурьераDataGridViewTextBoxColumn";
            this.iDКурьераDataGridViewTextBoxColumn.Width = 125;
            // 
            // ID_Сотрудника
            // 
            this.ID_Сотрудника.DataPropertyName = "ID_Сотрудника";
            this.ID_Сотрудника.HeaderText = "ID_Сотрудника";
            this.ID_Сотрудника.MinimumWidth = 6;
            this.ID_Сотрудника.Name = "ID_Сотрудника";
            this.ID_Сотрудника.ReadOnly = true;
            this.ID_Сотрудника.Width = 125;
            // 
            // номерВУDataGridViewTextBoxColumn
            // 
            this.номерВУDataGridViewTextBoxColumn.DataPropertyName = "Номер_ВУ";
            this.номерВУDataGridViewTextBoxColumn.HeaderText = "Номер_ВУ";
            this.номерВУDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерВУDataGridViewTextBoxColumn.Name = "номерВУDataGridViewTextBoxColumn";
            this.номерВУDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // машинаDataGridViewTextBoxColumn
            // 
            this.машинаDataGridViewTextBoxColumn.DataPropertyName = "Машина";
            this.машинаDataGridViewTextBoxColumn.HeaderText = "Машина";
            this.машинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.машинаDataGridViewTextBoxColumn.Name = "машинаDataGridViewTextBoxColumn";
            this.машинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номермашиныDataGridViewTextBoxColumn
            // 
            this.номермашиныDataGridViewTextBoxColumn.DataPropertyName = "Номер_машины";
            this.номермашиныDataGridViewTextBoxColumn.HeaderText = "Номер_машины";
            this.номермашиныDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номермашиныDataGridViewTextBoxColumn.Name = "номермашиныDataGridViewTextBoxColumn";
            this.номермашиныDataGridViewTextBoxColumn.Width = 125;
            // 
            // CurierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CurierList";
            this.Text = "Список курьеров";
            this.Load += new System.EventHandler(this.CurierList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Create;
        private System.Windows.Forms.ToolStripButton tsb_Edit;
        private System.Windows.Forms.ToolStripButton tsb_Delite;
        private dodoDS dodoDS;
        private System.Windows.Forms.BindingSource dodoDSBindingSource;
        private System.Windows.Forms.BindingSource curierBindingSource;
        private dodoDSTableAdapters.КурьерTableAdapter курьерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn машинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермашиныDataGridViewTextBoxColumn;
    }
}