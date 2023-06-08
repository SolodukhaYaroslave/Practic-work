namespace Завдання_3
{
    partial class frmSector
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColvoEl = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartSector = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateDiag = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtColvoEl);
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входящие данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество элементов:";
            // 
            // txtColvoEl
            // 
            this.txtColvoEl.Location = new System.Drawing.Point(404, 37);
            this.txtColvoEl.Name = "txtColvoEl";
            this.txtColvoEl.Size = new System.Drawing.Size(165, 35);
            this.txtColvoEl.TabIndex = 2;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(11, 90);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(558, 71);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Сгенерировать пустой одномерный массив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(645, 34);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 62;
            this.dgvMass.RowTemplate.Height = 28;
            this.dgvMass.Size = new System.Drawing.Size(569, 147);
            this.dgvMass.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.chartSector);
            this.groupBox2.Controls.Add(this.btCreateDiag);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 418);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение диаграммы";
            // 
            // chartSector
            // 
            this.chartSector.BackColor = System.Drawing.Color.SkyBlue;
            this.chartSector.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartSector.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea3.Name = "ChartArea1";
            this.chartSector.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSector.Legends.Add(legend3);
            this.chartSector.Location = new System.Drawing.Point(11, 34);
            this.chartSector.Name = "chartSector";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSector.Series.Add(series3);
            this.chartSector.Size = new System.Drawing.Size(720, 366);
            this.chartSector.TabIndex = 6;
            this.chartSector.Text = "chart1";
            // 
            // btCreateDiag
            // 
            this.btCreateDiag.Location = new System.Drawing.Point(780, 182);
            this.btCreateDiag.Name = "btCreateDiag";
            this.btCreateDiag.Size = new System.Drawing.Size(414, 44);
            this.btCreateDiag.TabIndex = 7;
            this.btCreateDiag.Text = "Построить секторную диаграмму";
            this.btCreateDiag.UseVisualStyleBackColor = true;
            this.btCreateDiag.Click += new System.EventHandler(this.btCreateDiag_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(780, 232);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(414, 44);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSector";
            this.Text = "Секторная диаграмма";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColvoEl;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSector;
        private System.Windows.Forms.Button btCreateDiag;
    }
}

