namespace DelegateTest
{
	partial class DeletgateForm
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
			this.btnLog = new System.Windows.Forms.Button();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLog
			// 
			this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLog.Location = new System.Drawing.Point(13, 158);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(75, 23);
			this.btnLog.TabIndex = 0;
			this.btnLog.Text = "Log";
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.Location = new System.Drawing.Point(13, 12);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLog.Size = new System.Drawing.Size(588, 140);
			this.txtLog.TabIndex = 1;
			// 
			// btnRandom
			// 
			this.btnRandom.Location = new System.Drawing.Point(256, 158);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(75, 23);
			this.btnRandom.TabIndex = 2;
			this.btnRandom.Text = "Random";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(94, 158);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(75, 23);
			this.btnWrite.TabIndex = 3;
			this.btnWrite.Text = "Write File";
			this.btnWrite.UseVisualStyleBackColor = true;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(175, 158);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(75, 23);
			this.btnRead.TabIndex = 4;
			this.btnRead.Text = "Read File";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// DeletgateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 193);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.btnRandom);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.btnLog);
			this.Name = "DeletgateForm";
			this.Text = "DelegateForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnRead;
	}
}

