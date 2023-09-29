namespace COP_2513__002
{
    partial class FormStockLoader
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
            this.labelLoadTicker = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.aCandleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDatabaseDataSet = new COP_2513__002.aDatabaseDataSet();
            this.radioButtonChart = new System.Windows.Forms.RadioButton();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.groupBoxViewPicker = new System.Windows.Forms.GroupBox();
            this.aCandleStickTableAdapter = new COP_2513__002.aDatabaseDataSetTableAdapters.aCandleStickTableAdapter();
            this.aComboBox_Ticker = new System.Windows.Forms.ComboBox();
            this.labelTicker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseDataSet)).BeginInit();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxViewPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLoadTicker
            // 
            this.labelLoadTicker.Location = new System.Drawing.Point(12, 255);
            this.labelLoadTicker.Name = "labelLoadTicker";
            this.labelLoadTicker.Size = new System.Drawing.Size(175, 101);
            this.labelLoadTicker.TabIndex = 1;
            this.labelLoadTicker.Text = "Load Ticker";
            this.labelLoadTicker.UseVisualStyleBackColor = true;
            this.labelLoadTicker.Click += new System.EventHandler(this.buttonLoadTicker);
            this.labelLoadTicker.Enter += new System.EventHandler(this.labelLoadTicker_Enter);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(94, 54);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(281, 26);
            this.dateTimePickerStartDate.TabIndex = 2;
            this.dateTimePickerStartDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(5, 54);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(83, 20);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(11, 94);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(77, 20);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(94, 94);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(281, 26);
            this.dateTimePickerEndDate.TabIndex = 3;
            this.dateTimePickerEndDate.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(0, 25);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(68, 24);
            this.radioButtonDaily.TabIndex = 7;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.radioButtonDaily_CheckedChanged);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(0, 55);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(85, 24);
            this.radioButtonWeekly.TabIndex = 8;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.radioButtonWeekly_CheckedChanged);
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(0, 84);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(89, 24);
            this.radioButtonMonthly.TabIndex = 9;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // aCandleStickBindingSource
            // 
            this.aCandleStickBindingSource.DataMember = "aCandleStick";
            this.aCandleStickBindingSource.DataSource = this.aDatabaseDataSet;
            // 
            // aDatabaseDataSet
            // 
            this.aDatabaseDataSet.DataSetName = "aDatabaseDataSet";
            this.aDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButtonChart
            // 
            this.radioButtonChart.AutoSize = true;
            this.radioButtonChart.Checked = true;
            this.radioButtonChart.Location = new System.Drawing.Point(17, 34);
            this.radioButtonChart.Name = "radioButtonChart";
            this.radioButtonChart.Size = new System.Drawing.Size(144, 24);
            this.radioButtonChart.TabIndex = 13;
            this.radioButtonChart.TabStop = true;
            this.radioButtonChart.Text = "Use Chart View";
            this.radioButtonChart.UseVisualStyleBackColor = true;
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxPeriod.Location = new System.Drawing.Point(15, 126);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(150, 123);
            this.groupBoxPeriod.TabIndex = 14;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // groupBoxViewPicker
            // 
            this.groupBoxViewPicker.Controls.Add(this.radioButtonChart);
            this.groupBoxViewPicker.Location = new System.Drawing.Point(193, 134);
            this.groupBoxViewPicker.Name = "groupBoxViewPicker";
            this.groupBoxViewPicker.Size = new System.Drawing.Size(167, 71);
            this.groupBoxViewPicker.TabIndex = 15;
            this.groupBoxViewPicker.TabStop = false;
            this.groupBoxViewPicker.Text = "View Type";
            // 
            // aCandleStickTableAdapter
            // 
            this.aCandleStickTableAdapter.ClearBeforeFill = true;
            // 
            // aComboBox_Ticker
            // 
            this.aComboBox_Ticker.FormattingEnabled = true;
            this.aComboBox_Ticker.Location = new System.Drawing.Point(94, 12);
            this.aComboBox_Ticker.Name = "aComboBox_Ticker";
            this.aComboBox_Ticker.Size = new System.Drawing.Size(281, 28);
            this.aComboBox_Ticker.TabIndex = 17;
            this.aComboBox_Ticker.Text = "Choose Period";
            this.aComboBox_Ticker.SelectedIndexChanged += new System.EventHandler(this.aComboBox_Ticker_SelectedIndexChanged);
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(37, 12);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(51, 20);
            this.labelTicker.TabIndex = 4;
            this.labelTicker.Text = "Ticker";
            // 
            // FormStockLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 403);
            this.Controls.Add(this.aComboBox_Ticker);
            this.Controls.Add(this.groupBoxViewPicker);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelLoadTicker);
            this.Name = "FormStockLoader";
            this.Text = "Stock Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseDataSet)).EndInit();
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxViewPicker.ResumeLayout(false);
            this.groupBoxViewPicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button labelLoadTicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButtonChart;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.GroupBox groupBoxViewPicker;
        private aDatabaseDataSet aDatabaseDataSet;
        private System.Windows.Forms.BindingSource aCandleStickBindingSource;
        private aDatabaseDataSetTableAdapters.aCandleStickTableAdapter aCandleStickTableAdapter;
        private System.Windows.Forms.ComboBox aComboBox_Ticker;
        private System.Windows.Forms.Label labelTicker;
    }
}

