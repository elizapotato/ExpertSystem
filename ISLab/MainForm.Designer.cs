
namespace ISLab
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.officeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SteadButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.ApartmentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeButton
            // 
            this.officeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.officeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.officeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officeButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeButton.ForeColor = System.Drawing.Color.Black;
            this.officeButton.Location = new System.Drawing.Point(269, 186);
            this.officeButton.Name = "officeButton";
            this.officeButton.Size = new System.Drawing.Size(158, 75);
            this.officeButton.TabIndex = 0;
            this.officeButton.Text = "Коммерческая недвижимость";
            this.officeButton.UseVisualStyleBackColor = false;
            this.officeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип недвижимости, которую желаете приобрести:\r\n";
            // 
            // SteadButton
            // 
            this.SteadButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SteadButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteadButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteadButton.ForeColor = System.Drawing.Color.Black;
            this.SteadButton.Location = new System.Drawing.Point(54, 186);
            this.SteadButton.Name = "SteadButton";
            this.SteadButton.Size = new System.Drawing.Size(158, 75);
            this.SteadButton.TabIndex = 2;
            this.SteadButton.Text = "Земельный участок";
            this.SteadButton.UseVisualStyleBackColor = false;
            this.SteadButton.Click += new System.EventHandler(this.SteadButton_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HouseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HouseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseButton.ForeColor = System.Drawing.Color.Black;
            this.HouseButton.Location = new System.Drawing.Point(269, 105);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(158, 75);
            this.HouseButton.TabIndex = 4;
            this.HouseButton.Text = "Дом";
            this.HouseButton.UseVisualStyleBackColor = false;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // ApartmentButton
            // 
            this.ApartmentButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ApartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ApartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApartmentButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartmentButton.ForeColor = System.Drawing.Color.Black;
            this.ApartmentButton.Location = new System.Drawing.Point(54, 105);
            this.ApartmentButton.Name = "ApartmentButton";
            this.ApartmentButton.Size = new System.Drawing.Size(158, 75);
            this.ApartmentButton.TabIndex = 3;
            this.ApartmentButton.Text = "Квартира";
            this.ApartmentButton.UseVisualStyleBackColor = false;
            this.ApartmentButton.Click += new System.EventHandler(this.ApartmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "ЭС по покупке недвижимости";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.officeButton);
            this.panel1.Controls.Add(this.SteadButton);
            this.panel1.Controls.Add(this.HouseButton);
            this.panel1.Controls.Add(this.ApartmentButton);
            this.panel1.Location = new System.Drawing.Point(168, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 282);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISLab.Properties.Resources.AdobeStock_45501220;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(802, 513);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЭС по подбору недвижимости";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button officeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SteadButton;
		private System.Windows.Forms.Button HouseButton;
		private System.Windows.Forms.Button ApartmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

