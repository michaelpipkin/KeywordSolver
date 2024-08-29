namespace KeywordSolverForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			FirstLetter = new TextBox();
			SecondLetter = new TextBox();
			label2 = new Label();
			FourthLetter = new TextBox();
			label3 = new Label();
			ThirdLetter = new TextBox();
			label4 = new Label();
			SixthLetter = new TextBox();
			label5 = new Label();
			FifthLetter = new TextBox();
			label6 = new Label();
			FindWordsButton = new Button();
			ClearButton = new Button();
			StopButton = new Button();
			Answers = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 0;
			label1.Text = "First letter";
			// 
			// FirstLetter
			// 
			FirstLetter.Location = new Point(77, 6);
			FirstLetter.Name = "FirstLetter";
			FirstLetter.Size = new Size(100, 23);
			FirstLetter.TabIndex = 1;
			FirstLetter.Leave += EnterLetters;
			// 
			// SecondLetter
			// 
			SecondLetter.Location = new Point(265, 6);
			SecondLetter.Name = "SecondLetter";
			SecondLetter.Size = new Size(100, 23);
			SecondLetter.TabIndex = 3;
			SecondLetter.Leave += EnterLetters;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(183, 9);
			label2.Name = "label2";
			label2.Size = new Size(76, 15);
			label2.TabIndex = 2;
			label2.Text = "Second letter";
			// 
			// FourthLetter
			// 
			FourthLetter.Location = new Point(265, 35);
			FourthLetter.Name = "FourthLetter";
			FourthLetter.Size = new Size(100, 23);
			FourthLetter.TabIndex = 7;
			FourthLetter.Leave += EnterLetters;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(183, 38);
			label3.Name = "label3";
			label3.Size = new Size(72, 15);
			label3.TabIndex = 6;
			label3.Text = "Fourth letter";
			// 
			// ThirdLetter
			// 
			ThirdLetter.Location = new Point(77, 35);
			ThirdLetter.Name = "ThirdLetter";
			ThirdLetter.Size = new Size(100, 23);
			ThirdLetter.TabIndex = 5;
			ThirdLetter.Leave += EnterLetters;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 38);
			label4.Name = "label4";
			label4.Size = new Size(64, 15);
			label4.TabIndex = 4;
			label4.Text = "Third letter";
			// 
			// SixthLetter
			// 
			SixthLetter.Location = new Point(265, 64);
			SixthLetter.Name = "SixthLetter";
			SixthLetter.Size = new Size(100, 23);
			SixthLetter.TabIndex = 11;
			SixthLetter.Leave += EnterLetters;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(183, 67);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 10;
			label5.Text = "Sixth letter";
			// 
			// FifthLetter
			// 
			FifthLetter.Location = new Point(77, 64);
			FifthLetter.Name = "FifthLetter";
			FifthLetter.Size = new Size(100, 23);
			FifthLetter.TabIndex = 9;
			FifthLetter.Leave += EnterLetters;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 67);
			label6.Name = "label6";
			label6.Size = new Size(61, 15);
			label6.TabIndex = 8;
			label6.Text = "Fifth letter";
			// 
			// FindWordsButton
			// 
			FindWordsButton.Location = new Point(64, 98);
			FindWordsButton.Name = "FindWordsButton";
			FindWordsButton.Size = new Size(75, 23);
			FindWordsButton.TabIndex = 12;
			FindWordsButton.Text = "Find Words";
			FindWordsButton.UseVisualStyleBackColor = true;
			FindWordsButton.Click += FindWordsButton_ClickAsync;
			// 
			// ClearButton
			// 
			ClearButton.Location = new Point(145, 98);
			ClearButton.Name = "ClearButton";
			ClearButton.Size = new Size(75, 23);
			ClearButton.TabIndex = 14;
			ClearButton.Text = "Clear";
			ClearButton.UseVisualStyleBackColor = true;
			ClearButton.Click += ClearButton_Click;
			// 
			// StopButton
			// 
			StopButton.Enabled = false;
			StopButton.Location = new Point(226, 98);
			StopButton.Name = "StopButton";
			StopButton.Size = new Size(75, 23);
			StopButton.TabIndex = 16;
			StopButton.Text = "Stop";
			StopButton.UseVisualStyleBackColor = true;
			StopButton.Click += StopButton_Click;
			// 
			// Answers
			// 
			Answers.AutoSize = true;
			Answers.Location = new Point(12, 134);
			Answers.Name = "Answers";
			Answers.Size = new Size(0, 15);
			Answers.TabIndex = 17;
			// 
			// Form1
			// 
			AcceptButton = FindWordsButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(384, 195);
			Controls.Add(Answers);
			Controls.Add(StopButton);
			Controls.Add(ClearButton);
			Controls.Add(FindWordsButton);
			Controls.Add(SixthLetter);
			Controls.Add(label5);
			Controls.Add(FifthLetter);
			Controls.Add(label6);
			Controls.Add(FourthLetter);
			Controls.Add(label3);
			Controls.Add(ThirdLetter);
			Controls.Add(label4);
			Controls.Add(SecondLetter);
			Controls.Add(label2);
			Controls.Add(FirstLetter);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Keyword Finder";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox FirstLetter;
		private TextBox SecondLetter;
		private Label label2;
		private TextBox FourthLetter;
		private Label label3;
		private TextBox ThirdLetter;
		private Label label4;
		private TextBox SixthLetter;
		private Label label5;
		private TextBox FifthLetter;
		private Label label6;
		private Button FindWordsButton;
		private Button ClearButton;
		private Button StopButton;
		private Label Answers;
	}
}
