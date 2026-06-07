namespace dodoisbase.nhibPersonal
{
    partial class nhibPersonalListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhibPersonalListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Create = new System.Windows.Forms.ToolStripButton();
            this.tsb_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_Delite = new System.Windows.Forms.ToolStripButton();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип_сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn,
            this.Тип_сотрудника,
            this.Категория});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 419);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Create
            // 
            this.tsb_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Create.Name = "tsb_Create";
            this.tsb_Create.Size = new System.Drawing.Size(68, 28);
            this.tsb_Create.Text = "Создать";
            this.tsb_Create.Click += new System.EventHandler(this.tsb_Create_Click);
            // 
            // tsb_Edit
            // 
            this.tsb_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Edit.Image")));
            this.tsb_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Edit.Name = "tsb_Edit";
            this.tsb_Edit.Size = new System.Drawing.Size(82, 28);
            this.tsb_Edit.Text = "Изменить";
            this.tsb_Edit.Click += new System.EventHandler(this.tsb_Edit_Click);
            // 
            // tsb_Delite
            // 
            this.tsb_Delite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Delite.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Delite.Image")));
            this.tsb_Delite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Delite.Name = "tsb_Delite";
            this.tsb_Delite.Size = new System.Drawing.Size(69, 28);
            this.tsb_Delite.Text = "Удалить";
            this.tsb_Delite.Click += new System.EventHandler(this.tsb_Delite_Click);
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Personal);
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDСотрудникаDataGridViewTextBoxColumn.Width = 125;
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
            // Тип_сотрудника
            // 
            this.Тип_сотрудника.DataPropertyName = "Тип_сотрудника";
            this.Тип_сотрудника.HeaderText = "Тип сотрудника";
            this.Тип_сотрудника.MinimumWidth = 6;
            this.Тип_сотрудника.Name = "Тип_сотрудника";
            this.Тип_сотрудника.Width = 125;
            // 
            // Категория
            // 
            this.Категория.DataPropertyName = "Категория";
            this.Категория.HeaderText = "Категория";
            this.Категория.MinimumWidth = 6;
            this.Категория.Name = "Категория";
            this.Категория.Width = 125;
            // 
            // nhibPersonalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "nhibPersonalListForm";
            this.Text = "Справочник nhib Сотрудник";
            this.Load += new System.EventHandler(this.nhibPersonalListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Create;
        private System.Windows.Forms.ToolStripButton tsb_Edit;
        private System.Windows.Forms.ToolStripButton tsb_Delite;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип_сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
    }
}