
namespace ISLab
{
	partial class FindSteadForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NearTeritotyComboBox = new System.Windows.Forms.ComboBox();
            this.TransportCheckBox = new System.Windows.Forms.CheckBox();
            this.EcologyCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.SquareComboBox = new System.Windows.Forms.ComboBox();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NearTeritotyComboBox);
            this.panel1.Controls.Add(this.TransportCheckBox);
            this.panel1.Controls.Add(this.EcologyCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PositionComboBox);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.SquareComboBox);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Location = new System.Drawing.Point(21, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 221);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Прилежащая территория";
            // 
            // NearTeritotyComboBox
            // 
            this.NearTeritotyComboBox.FormattingEnabled = true;
            this.NearTeritotyComboBox.Items.AddRange(new object[] {
            "1-2",
            "3-5",
            ">5"});
            this.NearTeritotyComboBox.Location = new System.Drawing.Point(291, 101);
            this.NearTeritotyComboBox.Name = "NearTeritotyComboBox";
            this.NearTeritotyComboBox.Size = new System.Drawing.Size(222, 24);
            this.NearTeritotyComboBox.TabIndex = 24;
            this.NearTeritotyComboBox.SelectedIndexChanged += new System.EventHandler(this.NearTeritotyComboBox_SelectedIndexChanged);
            // 
            // TransportCheckBox
            // 
            this.TransportCheckBox.AutoSize = true;
            this.TransportCheckBox.Location = new System.Drawing.Point(32, 153);
            this.TransportCheckBox.Name = "TransportCheckBox";
            this.TransportCheckBox.Size = new System.Drawing.Size(211, 21);
            this.TransportCheckBox.TabIndex = 23;
            this.TransportCheckBox.Text = "Транспортная доступность";
            this.TransportCheckBox.UseVisualStyleBackColor = true;
            this.TransportCheckBox.CheckedChanged += new System.EventHandler(this.TransportCheckBox_CheckedChanged);
            // 
            // EcologyCheckBox
            // 
            this.EcologyCheckBox.AutoSize = true;
            this.EcologyCheckBox.Location = new System.Drawing.Point(291, 153);
            this.EcologyCheckBox.Name = "EcologyCheckBox";
            this.EcologyCheckBox.Size = new System.Drawing.Size(186, 21);
            this.EcologyCheckBox.TabIndex = 22;
            this.EcologyCheckBox.Text = "Экологическая чистота";
            this.EcologyCheckBox.UseVisualStyleBackColor = true;
            this.EcologyCheckBox.CheckedChanged += new System.EventHandler(this.EcologyCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Расположение";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "В пригороде",
            "В области"});
            this.PositionComboBox.Location = new System.Drawing.Point(21, 101);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(222, 24);
            this.PositionComboBox.TabIndex = 15;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(291, 16);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(68, 17);
            this.SquareLabel.TabIndex = 3;
            this.SquareLabel.Text = "Площадь";
            // 
            // SquareComboBox
            // 
            this.SquareComboBox.FormattingEnabled = true;
            this.SquareComboBox.Items.AddRange(new object[] {
            "< 1 га",
            "1 -5 га",
            "5 - 10 га",
            "> 10 га"});
            this.SquareComboBox.Location = new System.Drawing.Point(291, 36);
            this.SquareComboBox.Name = "SquareComboBox";
            this.SquareComboBox.Size = new System.Drawing.Size(222, 24);
            this.SquareComboBox.TabIndex = 2;
            this.SquareComboBox.SelectedIndexChanged += new System.EventHandler(this.SquareComboBox_SelectedIndexChanged);
            // 
            // ChoosePriceLabel
            // 
            this.ChoosePriceLabel.AutoSize = true;
            this.ChoosePriceLabel.Location = new System.Drawing.Point(21, 16);
            this.ChoosePriceLabel.Name = "ChoosePriceLabel";
            this.ChoosePriceLabel.Size = new System.Drawing.Size(59, 17);
            this.ChoosePriceLabel.TabIndex = 1;
            this.ChoosePriceLabel.Text = "Бюджет";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "< 1000000",
            "1000000 - 2000000",
            "2000000 - 3000000",
            "> 3000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(21, 36);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(222, 24);
            this.PriceComboBox.TabIndex = 0;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(356, 318);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(167, 69);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBackButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Location = new System.Drawing.Point(95, 334);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(113, 37);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // FindSteadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::ISLab.Properties.Resources.AdobeStock_45501220;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.NextButton);
            this.Name = "FindSteadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор земельного участка";
            this.Load += new System.EventHandler(this.FindSteadForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox PositionComboBox;
		private System.Windows.Forms.Label SquareLabel;
		private System.Windows.Forms.ComboBox SquareComboBox;
		private System.Windows.Forms.Label ChoosePriceLabel;
		private System.Windows.Forms.ComboBox PriceComboBox;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button GoBackButton;
		private System.Windows.Forms.CheckBox EcologyCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox NearTeritotyComboBox;
		private System.Windows.Forms.CheckBox TransportCheckBox;
	}
}