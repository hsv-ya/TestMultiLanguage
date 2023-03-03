/*
 * Created by SharpDevelop.
 * User: OpenCNC
 * Date: 22.02.2023
 * Time: 11:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestMultiLang
{
	partial class MainForm
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
			this.lblFeedRateG0 = new System.Windows.Forms.Label();
			this.textFeedRateG0 = new System.Windows.Forms.TextBox();
			this.cmbLanguage = new System.Windows.Forms.ComboBox();
			this.chkStartZ = new System.Windows.Forms.CheckBox();
			this.rbtG0 = new System.Windows.Forms.RadioButton();
			this.rbtG1 = new System.Windows.Forms.RadioButton();
			this.btnSave = new System.Windows.Forms.Button();
			this.grb = new System.Windows.Forms.GroupBox();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.grb.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFeedRateG0
			// 
			this.lblFeedRateG0.AutoSize = true;
			this.lblFeedRateG0.Location = new System.Drawing.Point(20, 26);
			this.lblFeedRateG0.Name = "lblFeedRateG0";
			this.lblFeedRateG0.Size = new System.Drawing.Size(69, 13);
			this.lblFeedRateG0.TabIndex = 0;
			this.lblFeedRateG0.Text = "Feed rate G0";
			// 
			// textFeedRateG0
			// 
			this.textFeedRateG0.Location = new System.Drawing.Point(20, 42);
			this.textFeedRateG0.Name = "textFeedRateG0";
			this.textFeedRateG0.Size = new System.Drawing.Size(100, 20);
			this.textFeedRateG0.TabIndex = 1;
			this.textFeedRateG0.Text = "80%";
			this.textFeedRateG0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cmbLanguage
			// 
			this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLanguage.FormattingEnabled = true;
			this.cmbLanguage.Location = new System.Drawing.Point(204, 39);
			this.cmbLanguage.Name = "cmbLanguage";
			this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
			this.cmbLanguage.TabIndex = 3;
			this.cmbLanguage.SelectedValueChanged += new System.EventHandler(this.CmbLanguageSelectedValueChanged);
			// 
			// chkStartZ
			// 
			this.chkStartZ.AutoSize = true;
			this.chkStartZ.Location = new System.Drawing.Point(20, 68);
			this.chkStartZ.Name = "chkStartZ";
			this.chkStartZ.Size = new System.Drawing.Size(78, 17);
			this.chkStartZ.TabIndex = 4;
			this.chkStartZ.Text = "use Start Z";
			this.chkStartZ.UseVisualStyleBackColor = true;
			// 
			// rbtG0
			// 
			this.rbtG0.AutoSize = true;
			this.rbtG0.Location = new System.Drawing.Point(15, 23);
			this.rbtG0.Name = "rbtG0";
			this.rbtG0.Size = new System.Drawing.Size(39, 17);
			this.rbtG0.TabIndex = 5;
			this.rbtG0.TabStop = true;
			this.rbtG0.Text = "G0";
			this.rbtG0.UseVisualStyleBackColor = true;
			// 
			// rbtG1
			// 
			this.rbtG1.AutoSize = true;
			this.rbtG1.Location = new System.Drawing.Point(15, 46);
			this.rbtG1.Name = "rbtG1";
			this.rbtG1.Size = new System.Drawing.Size(39, 17);
			this.rbtG1.TabIndex = 6;
			this.rbtG1.TabStop = true;
			this.rbtG1.Text = "G1";
			this.rbtG1.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(20, 204);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 35);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// grb
			// 
			this.grb.Controls.Add(this.rbtG0);
			this.grb.Controls.Add(this.rbtG1);
			this.grb.Location = new System.Drawing.Point(20, 91);
			this.grb.Name = "grb";
			this.grb.Size = new System.Drawing.Size(121, 75);
			this.grb.TabIndex = 8;
			this.grb.TabStop = false;
			this.grb.Text = "Select G?";
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Location = new System.Drawing.Point(204, 23);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(55, 13);
			this.lblLanguage.TabIndex = 9;
			this.lblLanguage.Text = "Language";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 269);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.grb);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.chkStartZ);
			this.Controls.Add(this.cmbLanguage);
			this.Controls.Add(this.textFeedRateG0);
			this.Controls.Add(this.lblFeedRateG0);
			this.Name = "MainForm";
			this.Text = "TestMultiLang";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.grb.ResumeLayout(false);
			this.grb.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.GroupBox grb;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RadioButton rbtG1;
		private System.Windows.Forms.RadioButton rbtG0;
		private System.Windows.Forms.CheckBox chkStartZ;
		private System.Windows.Forms.ComboBox cmbLanguage;
		private System.Windows.Forms.TextBox textFeedRateG0;
		private System.Windows.Forms.Label lblFeedRateG0;
	}
}
