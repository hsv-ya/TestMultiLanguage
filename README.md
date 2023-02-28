My simple first version multi-language forms on C#

## How to use:

1. create in folder 'Language' .txt file with name for new language
   example file `Italiano.txt`
1. inside the file structure "FormFieldName = Text"
   example string in file `btnSave = Salva`
1. insert on Forms `ComboBox` with name `cmbLanguage`
1. add `Events - SelectedValueChanged` on `cmbLanguage` with next code:
```
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
```