namespace Joke_and_Punch_Line {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.JokeLabel = new System.Windows.Forms.Label();
			this.SetupBtn = new System.Windows.Forms.Button();
			this.PunchlineBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// JokeLabel
			// 
			this.JokeLabel.AutoSize = true;
			this.JokeLabel.Location = new System.Drawing.Point(12, 9);
			this.JokeLabel.Name = "JokeLabel";
			this.JokeLabel.Size = new System.Drawing.Size(172, 26);
			this.JokeLabel.TabIndex = 0;
			this.JokeLabel.Text = "I don\'t really understand your code.\r\nlol You should comment.";
			// 
			// SetupBtn
			// 
			this.SetupBtn.Location = new System.Drawing.Point(15, 38);
			this.SetupBtn.Name = "SetupBtn";
			this.SetupBtn.Size = new System.Drawing.Size(75, 23);
			this.SetupBtn.TabIndex = 1;
			this.SetupBtn.Text = "Setup";
			this.SetupBtn.UseVisualStyleBackColor = true;
			this.SetupBtn.Click += new System.EventHandler(this.SetupBtn_Click);
			// 
			// PunchlineBtn
			// 
			this.PunchlineBtn.Location = new System.Drawing.Point(109, 38);
			this.PunchlineBtn.Name = "PunchlineBtn";
			this.PunchlineBtn.Size = new System.Drawing.Size(75, 23);
			this.PunchlineBtn.TabIndex = 2;
			this.PunchlineBtn.Text = "Punchline";
			this.PunchlineBtn.UseVisualStyleBackColor = true;
			this.PunchlineBtn.Click += new System.EventHandler(this.PunchlineBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Location = new System.Drawing.Point(191, 9);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(94, 56);
			this.CloseBtn.TabIndex = 3;
			this.CloseBtn.Text = "Close";
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 77);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.PunchlineBtn);
			this.Controls.Add(this.SetupBtn);
			this.Controls.Add(this.JokeLabel);
			this.Name = "Form1";
			this.Text = "Joke and Punch Line";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label JokeLabel;
		private System.Windows.Forms.Button SetupBtn;
		private System.Windows.Forms.Button PunchlineBtn;
		private System.Windows.Forms.Button CloseBtn;
	}
}

