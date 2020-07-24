namespace WindowsFormsControls
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.ucPoint1 = new MJControls.UCPoint();
			this.ucWaveChart1 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart2 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart3 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart4 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart5 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart6 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart7 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart8 = new HZH_Controls.Controls.UCWaveChart();
			this.ucWaveChart9 = new HZH_Controls.Controls.UCWaveChart();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(46, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ucPoint1
			// 
			this.ucPoint1.DoseArray = new int[] {
        10,
        20,
        30,
        20,
        20};
			this.ucPoint1.LeftUnit = MJControls.Unit.None;
			this.ucPoint1.LMaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.ucPoint1.LMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ucPoint1.Location = new System.Drawing.Point(55, 21);
			this.ucPoint1.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucPoint1.Name = "ucPoint1";
			this.ucPoint1.RightUnit = MJControls.Unit.mu;
			this.ucPoint1.Size = new System.Drawing.Size(111, 417);
			this.ucPoint1.SplitCount = 10;
			this.ucPoint1.TabIndex = 2;
			this.ucPoint1.TrocarColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.ucPoint1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// ucWaveChart1
			// 
			this.ucWaveChart1.ConerRadius = 10;
			this.ucWaveChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart1.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart1.IsRadius = true;
			this.ucWaveChart1.IsShowRect = true;
			this.ucWaveChart1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart1.LineTension = 0.5F;
			this.ucWaveChart1.Location = new System.Drawing.Point(208, 5);
			this.ucWaveChart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart1.Name = "ucWaveChart1";
			this.ucWaveChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart1.RectWidth = 1;
			this.ucWaveChart1.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart1.SleepTime = 1000;
			this.ucWaveChart1.TabIndex = 3;
			this.ucWaveChart1.TopY = 10;
			this.ucWaveChart1.WaveWidth = 50;
			// 
			// ucWaveChart2
			// 
			this.ucWaveChart2.ConerRadius = 10;
			this.ucWaveChart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart2.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart2.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart2.IsRadius = true;
			this.ucWaveChart2.IsShowRect = true;
			this.ucWaveChart2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart2.LineTension = 0.5F;
			this.ucWaveChart2.Location = new System.Drawing.Point(530, 5);
			this.ucWaveChart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart2.Name = "ucWaveChart2";
			this.ucWaveChart2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart2.RectWidth = 1;
			this.ucWaveChart2.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart2.SleepTime = 1000;
			this.ucWaveChart2.TabIndex = 3;
			this.ucWaveChart2.TopY = 10;
			this.ucWaveChart2.WaveWidth = 50;
			// 
			// ucWaveChart3
			// 
			this.ucWaveChart3.ConerRadius = 10;
			this.ucWaveChart3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart3.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart3.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart3.IsRadius = true;
			this.ucWaveChart3.IsShowRect = true;
			this.ucWaveChart3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart3.LineTension = 0.5F;
			this.ucWaveChart3.Location = new System.Drawing.Point(208, 215);
			this.ucWaveChart3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart3.Name = "ucWaveChart3";
			this.ucWaveChart3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart3.RectWidth = 1;
			this.ucWaveChart3.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart3.SleepTime = 1000;
			this.ucWaveChart3.TabIndex = 3;
			this.ucWaveChart3.TopY = 10;
			this.ucWaveChart3.WaveWidth = 50;
			// 
			// ucWaveChart4
			// 
			this.ucWaveChart4.ConerRadius = 10;
			this.ucWaveChart4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart4.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart4.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart4.IsRadius = true;
			this.ucWaveChart4.IsShowRect = true;
			this.ucWaveChart4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart4.LineTension = 0.5F;
			this.ucWaveChart4.Location = new System.Drawing.Point(208, 449);
			this.ucWaveChart4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart4.Name = "ucWaveChart4";
			this.ucWaveChart4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart4.RectWidth = 1;
			this.ucWaveChart4.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart4.SleepTime = 1000;
			this.ucWaveChart4.TabIndex = 3;
			this.ucWaveChart4.TopY = 10;
			this.ucWaveChart4.WaveWidth = 50;
			// 
			// ucWaveChart5
			// 
			this.ucWaveChart5.ConerRadius = 10;
			this.ucWaveChart5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart5.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart5.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart5.IsRadius = true;
			this.ucWaveChart5.IsShowRect = true;
			this.ucWaveChart5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart5.LineTension = 0.5F;
			this.ucWaveChart5.Location = new System.Drawing.Point(530, 215);
			this.ucWaveChart5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart5.Name = "ucWaveChart5";
			this.ucWaveChart5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart5.RectWidth = 1;
			this.ucWaveChart5.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart5.SleepTime = 1000;
			this.ucWaveChart5.TabIndex = 3;
			this.ucWaveChart5.TopY = 10;
			this.ucWaveChart5.WaveWidth = 50;
			// 
			// ucWaveChart6
			// 
			this.ucWaveChart6.ConerRadius = 10;
			this.ucWaveChart6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart6.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart6.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart6.IsRadius = true;
			this.ucWaveChart6.IsShowRect = true;
			this.ucWaveChart6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart6.LineTension = 0.5F;
			this.ucWaveChart6.Location = new System.Drawing.Point(530, 449);
			this.ucWaveChart6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart6.Name = "ucWaveChart6";
			this.ucWaveChart6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart6.RectWidth = 1;
			this.ucWaveChart6.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart6.SleepTime = 1000;
			this.ucWaveChart6.TabIndex = 3;
			this.ucWaveChart6.TopY = 10;
			this.ucWaveChart6.WaveWidth = 50;
			// 
			// ucWaveChart7
			// 
			this.ucWaveChart7.ConerRadius = 10;
			this.ucWaveChart7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart7.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart7.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart7.IsRadius = true;
			this.ucWaveChart7.IsShowRect = true;
			this.ucWaveChart7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart7.LineTension = 0.5F;
			this.ucWaveChart7.Location = new System.Drawing.Point(838, 5);
			this.ucWaveChart7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart7.Name = "ucWaveChart7";
			this.ucWaveChart7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart7.RectWidth = 1;
			this.ucWaveChart7.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart7.SleepTime = 1000;
			this.ucWaveChart7.TabIndex = 3;
			this.ucWaveChart7.TopY = 10;
			this.ucWaveChart7.WaveWidth = 50;
			// 
			// ucWaveChart8
			// 
			this.ucWaveChart8.ConerRadius = 10;
			this.ucWaveChart8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart8.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart8.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart8.IsRadius = true;
			this.ucWaveChart8.IsShowRect = true;
			this.ucWaveChart8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart8.LineTension = 0.5F;
			this.ucWaveChart8.Location = new System.Drawing.Point(838, 215);
			this.ucWaveChart8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart8.Name = "ucWaveChart8";
			this.ucWaveChart8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart8.RectWidth = 1;
			this.ucWaveChart8.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart8.SleepTime = 1000;
			this.ucWaveChart8.TabIndex = 3;
			this.ucWaveChart8.TopY = 10;
			this.ucWaveChart8.WaveWidth = 50;
			// 
			// ucWaveChart9
			// 
			this.ucWaveChart9.ConerRadius = 10;
			this.ucWaveChart9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveChart9.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart9.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart9.IsRadius = true;
			this.ucWaveChart9.IsShowRect = true;
			this.ucWaveChart9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveChart9.LineTension = 0.5F;
			this.ucWaveChart9.Location = new System.Drawing.Point(838, 449);
			this.ucWaveChart9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveChart9.Name = "ucWaveChart9";
			this.ucWaveChart9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveChart9.RectWidth = 1;
			this.ucWaveChart9.Size = new System.Drawing.Size(300, 200);
			this.ucWaveChart9.SleepTime = 1000;
			this.ucWaveChart9.TabIndex = 3;
			this.ucWaveChart9.TopY = 10;
			this.ucWaveChart9.WaveWidth = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 693);
			this.Controls.Add(this.ucWaveChart4);
			this.Controls.Add(this.ucWaveChart3);
			this.Controls.Add(this.ucWaveChart9);
			this.Controls.Add(this.ucWaveChart8);
			this.Controls.Add(this.ucWaveChart7);
			this.Controls.Add(this.ucWaveChart6);
			this.Controls.Add(this.ucWaveChart5);
			this.Controls.Add(this.ucWaveChart2);
			this.Controls.Add(this.ucWaveChart1);
			this.Controls.Add(this.ucPoint1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private MJControls.UCPoint ucPoint1;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart1;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart2;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart3;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart4;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart5;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart6;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart7;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart8;
		private HZH_Controls.Controls.UCWaveChart ucWaveChart9;
	}
}

