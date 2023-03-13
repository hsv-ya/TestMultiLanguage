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

public partial class frmMainForm : Form {
	Dictionary<string, string> translation = new Dictionary<string, string>();

	public frmMainForm() {
		InitializeComponent();

		loadLanguage();
	}

	void loadLanguage() {
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
		string[] ss = {"", ""};

		TextReader textFile;

		for (int i = 0; i < files_lang.Length; i++) {
			textFile = File.OpenText(files_lang[i]);

			lang = textFile.ReadLine();

			while ((s = textFile.ReadLine()) != null) {
				if (s.Length == 0)
					continue;
				if (s.IndexOf('=') == -1)
					continue;
				ss[0] = s.Substring(0, s.IndexOf('=')).Trim();
				ss[1] = s.Substring(s.IndexOf('=') + 1).Trim();
				translation.Add(lang + "|" + ss[0], ss[1]);
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

		cmbLanguageChange(this);
	}

	void cmbLanguageChange(Form form) {
		string lang = cmbLanguage.Text;
		string[] ss;
		foreach (KeyValuePair<string,string> item in translation) {
			ss = item.Key.Split('|');
			if (!lang.Equals(ss[0]))
				continue;
			if (form.Controls.ContainsKey(ss[1]))
				form.Controls[ss[1]].Text = item.Value;
			else if (form.Name.Equals(ss[1]))
				form.Text = item.Value;
		}
	}

	void BtnShowForm2Click(object sender, EventArgs e) {
		frmForm2 form2 = new frmForm2();
		cmbLanguageChange(form2);
		form2.ShowDialog();
	}
}

}
