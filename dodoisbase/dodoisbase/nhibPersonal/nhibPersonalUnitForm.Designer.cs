namespace dodoisbase.nhibPersonal
{
    partial class nhibPersonalUnitForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtСтаж = new System.Windows.Forms.TextBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtФИО = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tipsot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_Сотрудника = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Категория";
            // 
            // txtСтаж
            // 
            this.txtСтаж.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Стаж", true));
            this.txtСтаж.Location = new System.Drawing.Point(128, 130);
            this.txtСтаж.Name = "txtСтаж";
            this.txtСтаж.Size = new System.Drawing.Size(75, 22);
            this.txtСтаж.TabIndex = 35;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Personal);
            // 
            // txtФИО
            // 
            this.txtФИО.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ФИО", true));
            this.txtФИО.Location = new System.Drawing.Point(128, 57);
            this.txtФИО.Name = "txtФИО";
            this.txtФИО.Size = new System.Drawing.Size(390, 22);
            this.txtФИО.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(21, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "Сохранить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Стаж";
            // 
            // tb_tipsot
            // 
            this.tb_tipsot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Тип_сотрудника", true));
            this.tb_tipsot.Location = new System.Drawing.Point(128, 95);
            this.tb_tipsot.Name = "tb_tipsot";
            this.tb_tipsot.Size = new System.Drawing.Size(153, 22);
            this.tb_tipsot.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Тип Сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "ФИО";
            // 
            // txtID_Сотрудника
            // 
            this.txtID_Сотрудника.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ID_Сотрудника", true));
            this.txtID_Сотрудника.Enabled = false;
            this.txtID_Сотрудника.Location = new System.Drawing.Point(128, 19);
            this.txtID_Сотрудника.Name = "txtID_Сотрудника";
            this.txtID_Сотрудника.ReadOnly = true;
            this.txtID_Сотрудника.Size = new System.Drawing.Size(53, 22);
            this.txtID_Сотрудника.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personalBindingSource, "Категория", true));
            this.comboBoxCategory.DataSource = this.personalBindingSource;
            this.comboBoxCategory.DisplayMember = "Категория";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(128, 171);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 37;
            this.comboBoxCategory.ValueMember = "Категория";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_cancel.Location = new System.Drawing.Point(259, 210);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(232, 68);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "Отменить";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // nhibPersonalUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 296);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtСтаж);
            this.Controls.Add(this.txtФИО);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tipsot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_Сотрудника);
            this.Controls.Add(this.label1);
            this.Name = "nhibPersonalUnitForm";
            this.Text = "Форма Сотрудник nhib ";
            this.Load += new System.EventHandler(this.nhibPersonalUnitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtСтаж;
        private System.Windows.Forms.TextBox txtФИО;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tipsot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_Сотрудника;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btn_cancel;
    }
}