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
            this.checkBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource2)).BeginInit();
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
            this.priceBludDataGridViewTextBoxColumn.HeaderText = "Цены блюд (руб.)";
            this.priceBludDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceBludDataGridViewTextBoxColumn.Name = "priceBludDataGridViewTextBoxColumn";
            this.priceBludDataGridViewTextBoxColumn.Width = 125;
            // 
            // stoimObslDataGridViewTextBoxColumn
            // 
            this.stoimObslDataGridViewTextBoxColumn.DataPropertyName = "StoimObsl";
            this.stoimObslDataGridViewTextBoxColumn.HeaderText = "Стоимость обслуживания (руб.)";
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
            this.itogVsegoDataGridViewTextBoxColumn.HeaderText = "Итого (руб.)";
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
            // checkBindingSource2
            // 
            this.checkBindingSource2.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // checkBindingSource1
            // 
            this.checkBindingSource1.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // checkBindingSource
            // 
            this.checkBindingSource.DataSource = typeof(Kursovaya.Model.Check);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
    }
}