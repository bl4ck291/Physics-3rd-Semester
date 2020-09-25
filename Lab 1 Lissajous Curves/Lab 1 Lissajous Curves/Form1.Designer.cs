namespace Lab_1_Lissajous_Curves
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLissajous = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.XUpDown = new System.Windows.Forms.NumericUpDown();
            this.YUpDown = new System.Windows.Forms.NumericUpDown();
            this.PhaseUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelXFrequency = new System.Windows.Forms.Label();
            this.LabelXHz = new System.Windows.Forms.Label();
            this.LabelYFrequency = new System.Windows.Forms.Label();
            this.LabelYHz = new System.Windows.Forms.Label();
            this.LabelPhaseShift = new System.Windows.Forms.Label();
            this.LabelDegrees = new System.Windows.Forms.Label();
            this.labelMyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartLissajous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLissajous
            // 
            this.chartLissajous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartLissajous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.chartLissajous.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartLissajous.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartLissajous.BorderlineWidth = 0;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Interval = 0.5D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.Maximum = 1.5D;
            chartArea1.AxisX.Minimum = -1.5D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Interval = 0.5D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.Maximum = 1.5D;
            chartArea1.AxisY.Minimum = -1.5D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 5;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chartLissajous.ChartAreas.Add(chartArea1);
            this.chartLissajous.Location = new System.Drawing.Point(12, 49);
            this.chartLissajous.Name = "chartLissajous";
            this.chartLissajous.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Yellow;
            series1.BorderWidth = 6;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            this.chartLissajous.Series.Add(series1);
            this.chartLissajous.Size = new System.Drawing.Size(700, 700);
            this.chartLissajous.TabIndex = 0;
            this.chartLissajous.Text = "chart1";
            // 
            // XUpDown
            // 
            this.XUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XUpDown.Location = new System.Drawing.Point(115, 12);
            this.XUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.XUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XUpDown.Name = "XUpDown";
            this.XUpDown.Size = new System.Drawing.Size(40, 20);
            this.XUpDown.TabIndex = 1;
            this.XUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XUpDown.ValueChanged += new System.EventHandler(this.XUpDown_ValueChanged);
            // 
            // YUpDown
            // 
            this.YUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YUpDown.Location = new System.Drawing.Point(349, 12);
            this.YUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.YUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YUpDown.Name = "YUpDown";
            this.YUpDown.Size = new System.Drawing.Size(40, 20);
            this.YUpDown.TabIndex = 2;
            this.YUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YUpDown.ValueChanged += new System.EventHandler(this.YUpDown_ValueChanged);
            // 
            // PhaseUpDown
            // 
            this.PhaseUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhaseUpDown.Location = new System.Drawing.Point(655, 12);
            this.PhaseUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.PhaseUpDown.Name = "PhaseUpDown";
            this.PhaseUpDown.Size = new System.Drawing.Size(40, 20);
            this.PhaseUpDown.TabIndex = 3;
            this.PhaseUpDown.ValueChanged += new System.EventHandler(this.PhaseUpDown_ValueChanged);
            // 
            // LabelXFrequency
            // 
            this.LabelXFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelXFrequency.AutoSize = true;
            this.LabelXFrequency.Location = new System.Drawing.Point(12, 14);
            this.LabelXFrequency.Name = "LabelXFrequency";
            this.LabelXFrequency.Size = new System.Drawing.Size(97, 13);
            this.LabelXFrequency.TabIndex = 4;
            this.LabelXFrequency.Text = "CH1 Frequency (X)";
            // 
            // LabelXHz
            // 
            this.LabelXHz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelXHz.AutoSize = true;
            this.LabelXHz.Location = new System.Drawing.Point(161, 14);
            this.LabelXHz.Name = "LabelXHz";
            this.LabelXHz.Size = new System.Drawing.Size(20, 13);
            this.LabelXHz.TabIndex = 5;
            this.LabelXHz.Text = "Hz";
            // 
            // LabelYFrequency
            // 
            this.LabelYFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelYFrequency.AutoSize = true;
            this.LabelYFrequency.Location = new System.Drawing.Point(246, 14);
            this.LabelYFrequency.Name = "LabelYFrequency";
            this.LabelYFrequency.Size = new System.Drawing.Size(97, 13);
            this.LabelYFrequency.TabIndex = 6;
            this.LabelYFrequency.Text = "CH2 Frequency (Y)";
            // 
            // LabelYHz
            // 
            this.LabelYHz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelYHz.AutoSize = true;
            this.LabelYHz.Location = new System.Drawing.Point(395, 14);
            this.LabelYHz.Name = "LabelYHz";
            this.LabelYHz.Size = new System.Drawing.Size(20, 13);
            this.LabelYHz.TabIndex = 7;
            this.LabelYHz.Text = "Hz";
            // 
            // LabelPhaseShift
            // 
            this.LabelPhaseShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPhaseShift.AutoSize = true;
            this.LabelPhaseShift.Location = new System.Drawing.Point(588, 14);
            this.LabelPhaseShift.Name = "LabelPhaseShift";
            this.LabelPhaseShift.Size = new System.Drawing.Size(61, 13);
            this.LabelPhaseShift.TabIndex = 8;
            this.LabelPhaseShift.Text = "Phase Shift";
            // 
            // LabelDegrees
            // 
            this.LabelDegrees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDegrees.AutoSize = true;
            this.LabelDegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDegrees.Location = new System.Drawing.Point(701, 12);
            this.LabelDegrees.Name = "LabelDegrees";
            this.LabelDegrees.Size = new System.Drawing.Size(14, 20);
            this.LabelDegrees.TabIndex = 9;
            this.LabelDegrees.Text = "°";
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Location = new System.Drawing.Point(10, 736);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(109, 13);
            this.labelMyName.TabIndex = 10;
            this.labelMyName.Text = "By Harith Al-Dabbagh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 761);
            this.Controls.Add(this.labelMyName);
            this.Controls.Add(this.LabelDegrees);
            this.Controls.Add(this.LabelPhaseShift);
            this.Controls.Add(this.LabelYHz);
            this.Controls.Add(this.LabelYFrequency);
            this.Controls.Add(this.LabelXHz);
            this.Controls.Add(this.LabelXFrequency);
            this.Controls.Add(this.PhaseUpDown);
            this.Controls.Add(this.YUpDown);
            this.Controls.Add(this.XUpDown);
            this.Controls.Add(this.chartLissajous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lissajous curves simulation";
            ((System.ComponentModel.ISupportInitialize)(this.chartLissajous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLissajous;
        private System.Windows.Forms.NumericUpDown XUpDown;
        private System.Windows.Forms.NumericUpDown YUpDown;
        private System.Windows.Forms.NumericUpDown PhaseUpDown;
        private System.Windows.Forms.Label LabelXFrequency;
        private System.Windows.Forms.Label LabelXHz;
        private System.Windows.Forms.Label LabelYFrequency;
        private System.Windows.Forms.Label LabelYHz;
        private System.Windows.Forms.Label LabelPhaseShift;
        private System.Windows.Forms.Label LabelDegrees;
        private System.Windows.Forms.Label labelMyName;
    }
}

