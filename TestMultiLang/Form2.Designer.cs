/*
 * Created by SharpDevelop.
 * User: OpenCNC
 * Date: 13.03.2023
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestMultiLang
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblForTest = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblForTest
			// 
			this.lblForTest.AutoSize = true;
			this.lblForTest.Location = new System.Drawing.Point(13, 13);
			this.lblForTest.Name = "lblForTest";
			this.lblForTest.Size = new System.Drawing.Size(28, 13);
			this.lblForTest.TabIndex = 0;
			this.lblForTest.Text = "Test";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.lblForTest);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblForTest;
	}
}
