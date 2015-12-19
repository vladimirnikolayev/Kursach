namespace Client
{
	partial class Dialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonRepeat = new System.Windows.Forms.Button();
			this.buttonOneMinute = new System.Windows.Forms.Button();
			this.buttonEnd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(106, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "00:00:00";
			// 
			// buttonRepeat
			// 
			this.buttonRepeat.Location = new System.Drawing.Point(76, 74);
			this.buttonRepeat.Name = "buttonRepeat";
			this.buttonRepeat.Size = new System.Drawing.Size(75, 23);
			this.buttonRepeat.TabIndex = 1;
			this.buttonRepeat.Text = "Repeat";
			this.buttonRepeat.UseVisualStyleBackColor = true;
			this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
			// 
			// buttonOneMinute
			// 
			this.buttonOneMinute.Location = new System.Drawing.Point(157, 74);
			this.buttonOneMinute.Name = "buttonOneMinute";
			this.buttonOneMinute.Size = new System.Drawing.Size(75, 23);
			this.buttonOneMinute.TabIndex = 2;
			this.buttonOneMinute.Text = "One minute";
			this.buttonOneMinute.UseVisualStyleBackColor = true;
			this.buttonOneMinute.Click += new System.EventHandler(this.buttonOneMinute_Click);
			// 
			// buttonEnd
			// 
			this.buttonEnd.Location = new System.Drawing.Point(238, 74);
			this.buttonEnd.Name = "buttonEnd";
			this.buttonEnd.Size = new System.Drawing.Size(75, 23);
			this.buttonEnd.TabIndex = 3;
			this.buttonEnd.Text = "End";
			this.buttonEnd.UseVisualStyleBackColor = true;
			this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
			// 
			// Dialog
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 145);
			this.ControlBox = false;
			this.Controls.Add(this.buttonEnd);
			this.Controls.Add(this.buttonOneMinute);
			this.Controls.Add(this.buttonRepeat);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Dialog";
			this.Text = "Timer end";
			this.Load += new System.EventHandler(this.Dialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonRepeat;
		private System.Windows.Forms.Button buttonOneMinute;
		private System.Windows.Forms.Button buttonEnd;
	}
}