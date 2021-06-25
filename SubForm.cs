using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectInSchool
{
	public partial class SubForm : Form
	{
		SettingTimeVO settingTime;
		ListView listView;
		ListViewItem item;


		// receive listView
		public SubForm(ListView listView)
		{
			this.listView = listView;
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

		private void SubForm_Load(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
		}

		// set finish time
		private void button1_Click(object sender, EventArgs e)
		{
			settingTime = new SettingTimeVO(dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker1.Value.ToString("yyyy"),
											dateTimePicker1.Value.ToString("MM"), dateTimePicker1.Value.ToString("dd"),
											numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString());

			label3.Text = settingTime.GetTextInfo();
		}

		// send infomation to listView 
		private void button2_Click(object sender, EventArgs e)
		{
			if (settingTime == null)
			{
				MessageBox.Show("Please Set Time");
				return;
			}

			item = new ListViewItem(new string[] {
			textBox3.Text,
			settingTime.GetRemainTime(),
			settingTime.GetTextInfo(),
			"N"}, -1);

			listView.Items.Add(item);
			
		}

		private void label3_Click(object sender, EventArgs e)
		{
			
		}
		
	}
}
