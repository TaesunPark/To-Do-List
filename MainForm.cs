using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectInSchool
{
	public partial class MainForm : Form
	{
		int index;		// listView select line number
		public MainForm()
		{
			InitializeComponent();
			// upload data before saved infomation
			RoadDataFromTextFile("saveFile",listView);
		}
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0) { 
				index = listView.SelectedItems[0].Index; 
			}
		}

		// add list infomation
		private void addButton_Click(object sender, EventArgs e)
		{
			SubForm subForm = new SubForm(listView);
			subForm.ShowDialog();
		}

		// delete list infomation
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0)
			{
				listView.Items.RemoveAt(index);
				index = 0;
			}
		}
	
		// update list infomation
		private void FinishButton_Click(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0)
			{
				index = listView.SelectedItems[0].Index;
				listView.Items[index].SubItems[3].Text = "Y";
			}
		}

		// update time all list infomation
		private void button2_Click(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0)
			{
				SetRemainTime();				
			}
		}

		public void SetRemainTime()
		{
			DateTime now = DateTime.Now;
			DateTime time;

			for (int i = 0; i < listView.Items.Count; i++)
			{
				string finishTime = listView.Items[i].SubItems[2].Text;

				time = DateTime.Parse(finishTime);

				TimeSpan remainTime = time - now;

				listView.Items[i].SubItems[1].Text = remainTime.Days + "days, " + ChangeNumberString(remainTime.Hours.ToString()) + "hour" + ":" + ChangeNumberString(remainTime.Minutes.ToString()) + "min";
			}
		}

		public string ChangeNumberString(string tmp)
		{
			if (int.Parse(tmp) >= 0 && int.Parse(tmp) <= 9)
			{
				tmp = "0" + tmp;
			}

			return tmp;
		}


		// save data to textFile
		private void SaveData_listView(string fileName, ListView LV)
		{
			File.WriteAllText(@"..\..\..\" + fileName + ".txt", String.Empty);

			using (StreamWriter sw = new StreamWriter(@"..\..\..\" + fileName + ".txt", false))
			{
				// ListView의 Item을 하나씩 가져와서..
				foreach (ListViewItem item in LV.Items)
				{
					// 원하는 형태의 문자열로 한줄씩 기록합니다.
					sw.WriteLine(string.Format("{0};{1};{2};{3}"

					, item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text));
				}
				sw.Close();
			}

		}

		private void SaveButton_Click_1(object sender, EventArgs e)
		{
			if (listView.Items.Count >= 0)
			{
				SaveData_listView("saveFile", listView);
			}
		}

		// upload text File
		private void RoadDataFromTextFile(string fileName, ListView LV)
		{
			DateTime now = DateTime.Now;
			DateTime time;
			string delimiter = ";";  // 구분자						
			
			using (var sr = new StreamReader(@"..\..\..\" + fileName + ".txt", true))
			{
				string line = null;
				LV.Items.Clear();  // 데이터 초기화

				while ((line = sr.ReadLine()) != null)
				{
					string[] columns = line.Split(new string[] { delimiter }, StringSplitOptions.None);

					ListViewItem lvt = new ListViewItem(columns[0]);					
					time = DateTime.Parse(columns[2]);
					TimeSpan remainTime = time - now;
					lvt.SubItems.Add(remainTime.Days + "days, " + ChangeNumberString(remainTime.Hours.ToString()) + "hour" + ":" + ChangeNumberString(remainTime.Minutes.ToString()) + "min");
					lvt.SubItems.Add(columns[2]);
					lvt.SubItems.Add(columns[3]);
					LV.Items.Add(lvt);
				}
				sr.Close();
			}		

		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}
		private void toolStripDropDownItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			string itemText = e.ClickedItem.Text;
			MessageBox.Show(itemText);

			switch (itemText)
			{
				case "Program Exit":
					Close();
					break;

				case "Save Data":
					SaveData_listView("saveFile", listView);
					break;
			}
		}
	
	}
}
