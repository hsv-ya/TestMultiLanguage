/*
 * Created by SharpDevelop.
 * User: OpenCNC
 * Date: 22.02.2023
 * Time: 11:05
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestMultiLang {

public partial class MainForm : Form {
	Dictionary<string, string> translation = new Dictionary<string, string>();

	public MainForm() {
		InitializeComponent();

		string[] files_lang;

		try {
			files_lang = Directory.GetFiles("Language/", "*.txt");
		} catch {
			lblLanguage.Visible = false;
			cmbLanguage.Visible = false;
			return;
		}

		string lang = "";
		string s = "";
		string[] ss;

		TextReader textFile;

		for (int i = 0; i < files_lang.Length; i++) {
			textFile = File.OpenText(files_lang[i]);

			lang = textFile.ReadLine();

			while ((s = textFile.ReadLine()) != null) {
				if (s.Length == 0)
					continue;
				ss = s.Split('=');
				translation.Add(lang + "|" + ss[0].Trim(), ss[1].Trim());
			}

			textFile.Close();

			cmbLanguage.Items.Add(lang);
		}
	}

	void MainFormShown(object sender, EventArgs e) {
		if (cmbLanguage.Items.Count == 1) {
			cmbLanguage.SelectedIndex = 0;
			lblLanguage.Visible = false;
			cmbLanguage.Visible = false;
		}
	}

	void CmbLanguageSelectedValueChanged(object sender, EventArgs e) {
		if (cmbLanguage.SelectedIndex < 0)
			return;
		string lang = cmbLanguage.Text;
		string[] ss;
		Label formLabel;
		Button formButton;
		CheckBox formCheckBox;
		RadioButton formRadioButton;
		GroupBox formGroupBox;
		foreach (KeyValuePair<string,string> item in translation) {
			ss = item.Key.Split('|');
			if (lang.CompareTo(ss[0]) != 0)
				continue;
			if (Controls.ContainsKey(ss[1])) {
				if (ss[1].Substring(0,3) == "lbl") {
					formLabel = (Label)Controls[ss[1]];
					formLabel.Text = item.Value;
				} else if (ss[1].Substring(0,3) == "rbt") {
					formRadioButton = (RadioButton)Controls[ss[1]];
					formRadioButton.Text = item.Value;
				} else if (ss[1].Substring(0,3) == "chk") {
					formCheckBox = (CheckBox)Controls[ss[1]];
					formCheckBox.Text = item.Value;
				} else if (ss[1].Substring(0,3) == "btn") {
					formButton = (Button)Controls[ss[1]];
					formButton.Text = item.Value;
				} else if (ss[1].Substring(0,3) == "grb") {
					formGroupBox = (GroupBox)Controls[ss[1]];
					formGroupBox.Text = item.Value;
				}
			}
		}
	}
}

}
