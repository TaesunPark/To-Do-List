
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectInSchool
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>		

		private void InitializeComponent()
		{
			System.Windows.Forms.ColumnHeader columnHeader1;

			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.addButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.FinishButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FILE = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			listView = new System.Windows.Forms.ListView();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "To do List";
			columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Remain Time";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Finish Time";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Y/N";
			this.columnHeader4.Width = 50;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(60, 87);
			this.addButton.Margin = new System.Windows.Forms.Padding(4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(134, 73);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(60, 205);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(134, 73);
			this.DeleteButton.TabIndex = 1;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// FinishButton
			// 
			this.FinishButton.Location = new System.Drawing.Point(60, 320);
			this.FinishButton.Margin = new System.Windows.Forms.Padding(4);
			this.FinishButton.Name = "FinishButton";
			this.FinishButton.Size = new System.Drawing.Size(134, 73);
			this.FinishButton.TabIndex = 2;
			this.FinishButton.Text = "Finish";
			this.FinishButton.UseVisualStyleBackColor = true;
			this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(773, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(106, 31);
			this.button2.TabIndex = 5;
			this.button2.Text = "Time Refresh";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(662, 38);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(94, 29);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save File";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(930, 28);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			
			
			// FILE
			// 
			this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2});
			this.FILE.Name = "FILE";
			this.FILE.Size = new System.Drawing.Size(46, 24);
			this.FILE.Text = "File";
			// 
			// MenuItem1
			// 
			this.MenuItem1.Name = "MenuItem1";
			this.MenuItem1.Size = new System.Drawing.Size(179, 26);
			this.MenuItem1.Text = "Save Data";
			// 
			// MenuItem2
			// 
			this.MenuItem2.Name = "MenuItem2";
			this.MenuItem2.Size = new System.Drawing.Size(179, 26);
			this.MenuItem2.Text = "Program Exit";
			// 
			// listView
			// 
			listView.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			listView.AllowColumnReorder = true;
			listView.AllowDrop = true;
			listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			listView.Cursor = System.Windows.Forms.Cursors.Default;
			listView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.HideSelection = false;
			listView.Location = new System.Drawing.Point(260, 87);
			listView.Margin = new System.Windows.Forms.Padding(4);
			listView.Name = "listView";
			listView.Size = new System.Drawing.Size(639, 305);
			listView.TabIndex = 3;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = System.Windows.Forms.View.Details;
			listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 464);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(listView);
			this.Controls.Add(this.FinishButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "ToDoList";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button FinishButton;
		private System.Windows.Forms.ListView listView;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Button button2;
		private Button SaveButton;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem FILE;
		private ToolStripMenuItem MenuItem1;
		private ToolStripMenuItem MenuItem2;
	}
}