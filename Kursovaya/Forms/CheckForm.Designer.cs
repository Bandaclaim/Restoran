namespace Kursovaya.Forms
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBludDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBludDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimObslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogVsegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(76, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 327);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zakazDataGridViewTextBoxColumn,
            this.personalDataGridViewTextBoxColumn,
            this.nameBludDataGridViewTextBoxColumn,
            this.priceBludDataGridViewTextBoxColumn,
            this.stoimObslDataGridViewTextBoxColumn,
            this.stolDataGridViewTextBoxColumn,
            this.itogVsegoDataGridViewTextBoxColumn,
            this.zakazIdDataGridViewTextBoxColumn,
            this.personalIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBindingSource2
            // 
            this.checkBindingSource2.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(99, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Распечать чек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(577, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерии";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(133, 35);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(65, 19);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Итого";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(133, 16);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(122, 19);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Кол-во столов";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 92);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(198, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Стоимость обслуживания";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 73);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(99, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Цены блюд";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(128, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Название блюд";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ФИО персонала";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Номер заказа";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBindingSource1
            // 
            this.checkBindingSource1.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // checkBindingSource
            // 
            this.checkBindingSource.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(442, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(442, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сбросить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ResetClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(442, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SearchClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // zakazDataGridViewTextBoxColumn
            // 
            this.zakazDataGridViewTextBoxColumn.DataPropertyName = "Zakaz";
            this.zakazDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.zakazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zakazDataGridViewTextBoxColumn.Name = "zakazDataGridViewTextBoxColumn";
            this.zakazDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalDataGridViewTextBoxColumn
            // 
            this.personalDataGridViewTextBoxColumn.DataPropertyName = "Personal";
            this.personalDataGridViewTextBoxColumn.HeaderText = "ФИО персонала";
            this.personalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personalDataGridViewTextBoxColumn.Name = "personalDataGridViewTextBoxColumn";
            this.personalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameBludDataGridViewTextBoxColumn
            // 
            this.nameBludDataGridViewTextBoxColumn.DataPropertyName = "NameBlud";
            this.nameBludDataGridViewTextBoxColumn.HeaderText = "Название блюд";
            this.nameBludDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameBludDataGridViewTextBoxColumn.Name = "nameBludDataGridViewTextBoxColumn";
            this.nameBludDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceBludDataGridViewTextBoxColumn
            // 
            this.priceBludDataGridViewTextBoxColumn.DataPropertyName = "PriceBlud";
            this.priceBludDataGridViewTextBoxColumn.HeaderText = "Цены блюд (р.)";
            this.priceBludDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceBludDataGridViewTextBoxColumn.Name = "priceBludDataGridViewTextBoxColumn";
            this.priceBludDataGridViewTextBoxColumn.Width = 125;
            // 
            // stoimObslDataGridViewTextBoxColumn
            // 
            this.stoimObslDataGridViewTextBoxColumn.DataPropertyName = "StoimObsl";
            this.stoimObslDataGridViewTextBoxColumn.HeaderText = "Стоимость обслуживания (р.)";
            this.stoimObslDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stoimObslDataGridViewTextBoxColumn.Name = "stoimObslDataGridViewTextBoxColumn";
            this.stoimObslDataGridViewTextBoxColumn.Width = 135;
            // 
            // stolDataGridViewTextBoxColumn
            // 
            this.stolDataGridViewTextBoxColumn.DataPropertyName = "Stol";
            this.stolDataGridViewTextBoxColumn.HeaderText = "Кол-во столов";
            this.stolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stolDataGridViewTextBoxColumn.Name = "stolDataGridViewTextBoxColumn";
            this.stolDataGridViewTextBoxColumn.Width = 125;
            // 
            // itogVsegoDataGridViewTextBoxColumn
            // 
            this.itogVsegoDataGridViewTextBoxColumn.DataPropertyName = "ItogVsego";
            this.itogVsegoDataGridViewTextBoxColumn.HeaderText = "Итого (р.)";
            this.itogVsegoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itogVsegoDataGridViewTextBoxColumn.Name = "itogVsegoDataGridViewTextBoxColumn";
            this.itogVsegoDataGridViewTextBoxColumn.Width = 125;
            // 
            // zakazIdDataGridViewTextBoxColumn
            // 
            this.zakazIdDataGridViewTextBoxColumn.DataPropertyName = "ZakazId";
            this.zakazIdDataGridViewTextBoxColumn.HeaderText = "ZakazId";
            this.zakazIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zakazIdDataGridViewTextBoxColumn.Name = "zakazIdDataGridViewTextBoxColumn";
            this.zakazIdDataGridViewTextBoxColumn.Visible = false;
            this.zakazIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalIdDataGridViewTextBoxColumn
            // 
            this.personalIdDataGridViewTextBoxColumn.DataPropertyName = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.HeaderText = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personalIdDataGridViewTextBoxColumn.Name = "personalIdDataGridViewTextBoxColumn";
            this.personalIdDataGridViewTextBoxColumn.Visible = false;
            this.personalIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checkBindingSource;
        private System.Windows.Forms.BindingSource checkBindingSource1;
        private System.Windows.Forms.BindingSource checkBindingSource2;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBludDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBludDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimObslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogVsegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdDataGridViewTextBoxColumn;
    }
}