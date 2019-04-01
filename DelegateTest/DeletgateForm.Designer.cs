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
			this.SuspendLayout();
			// 
			// btnLog
			// 
			this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLog.Location = new System.Drawing.Point(13, 415);
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
			this.txtLog.Size = new System.Drawing.Size(775, 397);
			this.txtLog.TabIndex = 1;
			// 
			// DeletgateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

