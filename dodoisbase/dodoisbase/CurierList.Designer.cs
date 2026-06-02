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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Create = new System.Windows.Forms.ToolStripButton();
            this.tsb_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_Delite = new System.Windows.Forms.ToolStripButton();
            this.dodoDS = new dodoisbase.dodoDS();
            this.dodoDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курьерTableAdapter = new dodoisbase.dodoDSTableAdapters.КурьерTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1268, 27);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.curierBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 311);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Курьера";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Курьера";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // стажDataGridViewTextBoxColumn
            // 
            this.стажDataGridViewTextBoxColumn.DataPropertyName = "Стаж";
            this.стажDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.стажDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стажDataGridViewTextBoxColumn.Name = "стажDataGridViewTextBoxColumn";
            this.стажDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_ВУ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_ВУ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Машина";
            this.dataGridViewTextBoxColumn4.HeaderText = "Машина";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер_машины";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер_машины";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // curierBindingSource
            // 
            this.curierBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Curier);
            // 
            // CurierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CurierList";
            this.Text = "Список курьеров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurierList_FormClosing);
            this.Load += new System.EventHandler(this.CurierList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Create;
        private System.Windows.Forms.ToolStripButton tsb_Edit;
        private System.Windows.Forms.ToolStripButton tsb_Delite;
        private dodoDS dodoDS;
        private System.Windows.Forms.BindingSource dodoDSBindingSource;
        private dodoDSTableAdapters.КурьерTableAdapter курьерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn машинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермашиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource curierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}