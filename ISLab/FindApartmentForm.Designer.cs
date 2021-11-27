
namespace ISLab
{
	partial class FindApartmentForm
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
            this.NewOrOldcheckBox = new System.Windows.Forms.CheckBox();
            this.ViewCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportСheckBox = new System.Windows.Forms.CheckBox();
            this.ParkingCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FloorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountOfRoomsComboBox = new System.Windows.Forms.ComboBox();
            this.InfastuctureLabel = new System.Windows.Forms.Label();
            this.InfastuctureComboBox = new System.Windows.Forms.ComboBox();
            this.YearsLabel = new System.Windows.Forms.Label();
            this.YearsComboBox = new System.Windows.Forms.ComboBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.SquareComboBox = new System.Windows.Forms.ComboBox();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.Elevator = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Elevator);
            this.panel1.Controls.Add(this.NewOrOldcheckBox);
            this.panel1.Controls.Add(this.ViewCheckBox);
            this.panel1.Controls.Add(this.TransportСheckBox);
            this.panel1.Controls.Add(this.ParkingCheckBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MaterialsComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PositionComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FloorComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CountOfRoomsComboBox);
            this.panel1.Controls.Add(this.InfastuctureLabel);
            this.panel1.Controls.Add(this.InfastuctureComboBox);
            this.panel1.Controls.Add(this.YearsLabel);
            this.panel1.Controls.Add(this.YearsComboBox);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.SquareComboBox);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 315);
            this.panel1.TabIndex = 7;
            // 
            // NewOrOldcheckBox
            // 
            this.NewOrOldcheckBox.AutoSize = true;
            this.NewOrOldcheckBox.Location = new System.Drawing.Point(230, 259);
            this.NewOrOldcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewOrOldcheckBox.Name = "NewOrOldcheckBox";
            this.NewOrOldcheckBox.Size = new System.Drawing.Size(93, 17);
            this.NewOrOldcheckBox.TabIndex = 26;
            this.NewOrOldcheckBox.Text = "Новостройка";
            this.NewOrOldcheckBox.UseVisualStyleBackColor = true;
            this.NewOrOldcheckBox.CheckedChanged += new System.EventHandler(this.NewOrOldcheckBox_CheckedChanged);
            // 
            // ViewCheckBox
            // 
            this.ViewCheckBox.AutoSize = true;
            this.ViewCheckBox.Location = new System.Drawing.Point(230, 237);
            this.ViewCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ViewCheckBox.Name = "ViewCheckBox";
            this.ViewCheckBox.Size = new System.Drawing.Size(98, 17);
            this.ViewCheckBox.TabIndex = 25;
            this.ViewCheckBox.Text = "Красивый вид";
            this.ViewCheckBox.UseVisualStyleBackColor = true;
            this.ViewCheckBox.CheckedChanged += new System.EventHandler(this.ViewCheckBox_CheckedChanged);
            // 
            // TransportСheckBox
            // 
            this.TransportСheckBox.AutoSize = true;
            this.TransportСheckBox.Location = new System.Drawing.Point(29, 250);
            this.TransportСheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.TransportСheckBox.Name = "TransportСheckBox";
            this.TransportСheckBox.Size = new System.Drawing.Size(164, 17);
            this.TransportСheckBox.TabIndex = 23;
            this.TransportСheckBox.Text = "Транспортная доступность";
            this.TransportСheckBox.UseVisualStyleBackColor = true;
            this.TransportСheckBox.CheckedChanged += new System.EventHandler(this.TransportСheckBox_CheckedChanged);
            // 
            // ParkingCheckBox
            // 
            this.ParkingCheckBox.AutoSize = true;
            this.ParkingCheckBox.Location = new System.Drawing.Point(29, 228);
            this.ParkingCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ParkingCheckBox.Name = "ParkingCheckBox";
            this.ParkingCheckBox.Size = new System.Drawing.Size(76, 17);
            this.ParkingCheckBox.TabIndex = 22;
            this.ParkingCheckBox.Text = "Парковка";
            this.ParkingCheckBox.UseVisualStyleBackColor = true;
            this.ParkingCheckBox.CheckedChanged += new System.EventHandler(this.ParkingCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Тип постройки дома";
            // 
            // MaterialsComboBox
            // 
            this.MaterialsComboBox.FormattingEnabled = true;
            this.MaterialsComboBox.Items.AddRange(new object[] {
            "Панельный",
            "Кирпичный",
            "Монолитный",
            "Деревянный"});
            this.MaterialsComboBox.Location = new System.Drawing.Point(227, 169);
            this.MaterialsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialsComboBox.Name = "MaterialsComboBox";
            this.MaterialsComboBox.Size = new System.Drawing.Size(165, 21);
            this.MaterialsComboBox.TabIndex = 18;
            this.MaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Расположение";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "В городе",
            "За городом"});
            this.PositionComboBox.Location = new System.Drawing.Point(7, 71);
            this.PositionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(168, 21);
            this.PositionComboBox.TabIndex = 15;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Этаж";
            // 
            // FloorComboBox
            // 
            this.FloorComboBox.FormattingEnabled = true;
            this.FloorComboBox.Items.AddRange(new object[] {
            "Первый этаж",
            "От второго до предпоследнего",
            "Последний этаж"});
            this.FloorComboBox.Location = new System.Drawing.Point(227, 71);
            this.FloorComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FloorComboBox.Name = "FloorComboBox";
            this.FloorComboBox.Size = new System.Drawing.Size(165, 21);
            this.FloorComboBox.TabIndex = 13;
            this.FloorComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество комнат";
            // 
            // CountOfRoomsComboBox
            // 
            this.CountOfRoomsComboBox.FormattingEnabled = true;
            this.CountOfRoomsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ">4"});
            this.CountOfRoomsComboBox.Location = new System.Drawing.Point(227, 119);
            this.CountOfRoomsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CountOfRoomsComboBox.Name = "CountOfRoomsComboBox";
            this.CountOfRoomsComboBox.Size = new System.Drawing.Size(165, 21);
            this.CountOfRoomsComboBox.TabIndex = 11;
            this.CountOfRoomsComboBox.SelectedIndexChanged += new System.EventHandler(this.CountOfRoomsComboBox_SelectedIndexChanged);
            // 
            // InfastuctureLabel
            // 
            this.InfastuctureLabel.AutoSize = true;
            this.InfastuctureLabel.Location = new System.Drawing.Point(7, 153);
            this.InfastuctureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfastuctureLabel.Name = "InfastuctureLabel";
            this.InfastuctureLabel.Size = new System.Drawing.Size(91, 13);
            this.InfastuctureLabel.TabIndex = 7;
            this.InfastuctureLabel.Text = "Инфраструктура";
            // 
            // InfastuctureComboBox
            // 
            this.InfastuctureComboBox.FormattingEnabled = true;
            this.InfastuctureComboBox.Items.AddRange(new object[] {
            "Развитая",
            "Не имеет значения"});
            this.InfastuctureComboBox.Location = new System.Drawing.Point(4, 169);
            this.InfastuctureComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.InfastuctureComboBox.Name = "InfastuctureComboBox";
            this.InfastuctureComboBox.Size = new System.Drawing.Size(170, 21);
            this.InfastuctureComboBox.TabIndex = 6;
            this.InfastuctureComboBox.SelectedIndexChanged += new System.EventHandler(this.InfastuctureComboBox_SelectedIndexChanged);
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.Location = new System.Drawing.Point(227, 7);
            this.YearsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(88, 13);
            this.YearsLabel.TabIndex = 5;
            this.YearsLabel.Text = "Возраст здания";
            // 
            // YearsComboBox
            // 
            this.YearsComboBox.FormattingEnabled = true;
            this.YearsComboBox.Items.AddRange(new object[] {
            "меньше 10 лет",
            "10-15 лет",
            "15-30 лет",
            "больше 30 лет"});
            this.YearsComboBox.Location = new System.Drawing.Point(227, 24);
            this.YearsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearsComboBox.Name = "YearsComboBox";
            this.YearsComboBox.Size = new System.Drawing.Size(165, 21);
            this.YearsComboBox.TabIndex = 4;
            this.YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(7, 103);
            this.SquareLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(54, 13);
            this.SquareLabel.TabIndex = 3;
            this.SquareLabel.Text = "Площадь";
            // 
            // SquareComboBox
            // 
            this.SquareComboBox.FormattingEnabled = true;
            this.SquareComboBox.Items.AddRange(new object[] {
            "< 50",
            "50 - 100",
            "> 100"});
            this.SquareComboBox.Location = new System.Drawing.Point(7, 119);
            this.SquareComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SquareComboBox.Name = "SquareComboBox";
            this.SquareComboBox.Size = new System.Drawing.Size(168, 21);
            this.SquareComboBox.TabIndex = 2;
            this.SquareComboBox.SelectedIndexChanged += new System.EventHandler(this.SquareComboBox_SelectedIndexChanged);
            // 
            // ChoosePriceLabel
            // 
            this.ChoosePriceLabel.AutoSize = true;
            this.ChoosePriceLabel.Location = new System.Drawing.Point(7, 7);
            this.ChoosePriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChoosePriceLabel.Name = "ChoosePriceLabel";
            this.ChoosePriceLabel.Size = new System.Drawing.Size(47, 13);
            this.ChoosePriceLabel.TabIndex = 1;
            this.ChoosePriceLabel.Text = "Бюджет";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "1000000 <",
            "1000000 - 2000000",
            "2000000 - 3000000",
            "> 3000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(7, 24);
            this.PriceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(168, 21);
            this.PriceComboBox.TabIndex = 0;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(238, 369);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(125, 56);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GoBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Location = new System.Drawing.Point(64, 382);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(88, 30);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Elevator
            // 
            this.Elevator.AutoSize = true;
            this.Elevator.Location = new System.Drawing.Point(29, 207);
            this.Elevator.Margin = new System.Windows.Forms.Padding(2);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(53, 17);
            this.Elevator.TabIndex = 27;
            this.Elevator.Text = "Лифт";
            this.Elevator.UseVisualStyleBackColor = true;
            this.Elevator.CheckedChanged += new System.EventHandler(this.Elevator_CheckedChanged);
            // 
            // FindApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISLab.Properties.Resources.AdobeStock_45501220;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindApartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор квартиры";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox FloorComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CountOfRoomsComboBox;
		private System.Windows.Forms.Label InfastuctureLabel;
		private System.Windows.Forms.ComboBox InfastuctureComboBox;
		private System.Windows.Forms.Label YearsLabel;
		private System.Windows.Forms.ComboBox YearsComboBox;
		private System.Windows.Forms.Label SquareLabel;
		private System.Windows.Forms.ComboBox SquareComboBox;
		private System.Windows.Forms.Label ChoosePriceLabel;
		private System.Windows.Forms.ComboBox PriceComboBox;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button GoBackButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox PositionComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox MaterialsComboBox;
		private System.Windows.Forms.CheckBox ViewCheckBox;
		private System.Windows.Forms.CheckBox TransportСheckBox;
		private System.Windows.Forms.CheckBox ParkingCheckBox;
		private System.Windows.Forms.CheckBox NewOrOldcheckBox;
        private System.Windows.Forms.CheckBox Elevator;
    }
}