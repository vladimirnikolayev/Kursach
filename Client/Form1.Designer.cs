namespace Client
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Add = new System.Windows.Forms.Button();
			this.textBoxSeconds = new System.Windows.Forms.TextBox();
			this.textBoxHours = new System.Windows.Forms.TextBox();
			this.textBoxMinutes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeAdressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.CausesValidation = false;
			this.Add.Location = new System.Drawing.Point(60, 76);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 3;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxSeconds
			// 
			this.textBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSeconds.Location = new System.Drawing.Point(122, 50);
			this.textBoxSeconds.Name = "textBoxSeconds";
			this.textBoxSeconds.Size = new System.Drawing.Size(37, 22);
			this.textBoxSeconds.TabIndex = 2;
			// 
			// textBoxHours
			// 
			this.textBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxHours.Location = new System.Drawing.Point(36, 50);
			this.textBoxHours.Name = "textBoxHours";
			this.textBoxHours.Size = new System.Drawing.Size(37, 22);
			this.textBoxHours.TabIndex = 0;
			// 
			// textBoxMinutes
			// 
			this.textBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxMinutes.Location = new System.Drawing.Point(79, 50);
			this.textBoxMinutes.Name = "textBoxMinutes";
			this.textBoxMinutes.Size = new System.Drawing.Size(37, 22);
			this.textBoxMinutes.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(45, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "H";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(130, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "S";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(89, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "M";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(199, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAdressToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// changeAdressToolStripMenuItem
			// 
			this.changeAdressToolStripMenuItem.Name = "changeAdressToolStripMenuItem";
			this.changeAdressToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.changeAdressToolStripMenuItem.Text = "Change adress";
			this.changeAdressToolStripMenuItem.Click += new System.EventHandler(this.changeAdressToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 159);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxMinutes);
			this.Controls.Add(this.textBoxHours);
			this.Controls.Add(this.textBoxSeconds);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Timer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.TextBox textBoxSeconds;
		private System.Windows.Forms.TextBox textBoxHours;
		private System.Windows.Forms.TextBox textBoxMinutes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeAdressToolStripMenuItem;
	}
}

