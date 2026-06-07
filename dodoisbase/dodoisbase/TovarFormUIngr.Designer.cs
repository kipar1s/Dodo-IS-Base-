namespace dodoisbase.Nhibernate.Maping
{
    partial class TovarFormUIngr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_IDTovar = new System.Windows.Forms.TextBox();
            this.товарTableAdapter = new dodoisbase.dodoDSTableAdapters.ТоварTableAdapter();
            this.ингредиентыTableAdapter = new dodoisbase.dodoDSTableAdapters.ИнгредиентыTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ingrCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tovarbS = new System.Windows.Forms.BindingSource(this.components);
            this.iDИнгредиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценазаедDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокгодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествонаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrbS = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(272, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имеющиеся Ингридиенты ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИнгредиентаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценазаедDataGridViewTextBoxColumn,
            this.срокгодностиDataGridViewTextBoxColumn,
            this.количествонаскладеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ingrbS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "IDТовара";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(423, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(578, 34);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(149, 43);
            this.btn_cancel.TabIndex = 37;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_IDTovar
            // 
            this.tb_IDTovar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbS, "ID_Товара", true));
            this.tb_IDTovar.Location = new System.Drawing.Point(87, 40);
            this.tb_IDTovar.Name = "tb_IDTovar";
            this.tb_IDTovar.ReadOnly = true;
            this.tb_IDTovar.Size = new System.Drawing.Size(57, 22);
            this.tb_IDTovar.TabIndex = 35;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingrCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 323);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // ingrCol
            // 
            this.ingrCol.Text = "Ингридиенты";
            this.ingrCol.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbS, "Название", true));
            this.textBox1.Location = new System.Drawing.Point(236, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Название";
            // 
            // tovarbS
            // 
            this.tovarbS.DataSource = typeof(dodoisbase.Nhibernate.Entites.Tovar);
            // 
            // iDИнгредиентаDataGridViewTextBoxColumn
            // 
            this.iDИнгредиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Ингредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.HeaderText = "ID_Ингредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDИнгредиентаDataGridViewTextBoxColumn.Name = "iDИнгредиентаDataGridViewTextBoxColumn";
            this.iDИнгредиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценазаедDataGridViewTextBoxColumn
            // 
            this.ценазаедDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_ед";
            this.ценазаедDataGridViewTextBoxColumn.HeaderText = "Цена_за_ед";
            this.ценазаедDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценазаедDataGridViewTextBoxColumn.Name = "ценазаедDataGridViewTextBoxColumn";
            this.ценазаедDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокгодностиDataGridViewTextBoxColumn
            // 
            this.срокгодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок_годности";
            this.срокгодностиDataGridViewTextBoxColumn.HeaderText = "Срок_годности";
            this.срокгодностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокгодностиDataGridViewTextBoxColumn.Name = "срокгодностиDataGridViewTextBoxColumn";
            this.срокгодностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествонаскладеDataGridViewTextBoxColumn
            // 
            this.количествонаскладеDataGridViewTextBoxColumn.DataPropertyName = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.HeaderText = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествонаскладеDataGridViewTextBoxColumn.Name = "количествонаскладеDataGridViewTextBoxColumn";
            this.количествонаскладеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingrbS
            // 
            this.ingrbS.DataSource = typeof(dodoisbase.Nhibernate.Entites.Ingr);
            // 
            // TovarFormUIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 428);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_IDTovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TovarFormUIngr";
            this.Text = "Форма Товара из Ингридиентом";
            this.Load += new System.EventHandler(this.TovarFormUIngr_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dodoDSTableAdapters.ТоварTableAdapter товарTableAdapter;
        private dodoDSTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private System.Windows.Forms.BindingSource tovarbS;
        private System.Windows.Forms.BindingSource ingrbS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_IDTovar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИнгредиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценазаедDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокгодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествонаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ingrCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}