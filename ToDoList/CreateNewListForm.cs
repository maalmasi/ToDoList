using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ToDoList
{
    public partial class CreateNewListForm : Form
    {
        string[] items;
        string title, fileName;
        MainForm main;
        public List list;
        ToDoListForm toDoList;

        //default constructors
        public CreateNewListForm()
        {
            InitializeComponent();
        }

        //construct form using string as title
        public CreateNewListForm(string newtitle)
        {
            InitializeComponent();
            this.Text = "Create new list";
            LTitle.Text += newtitle;
            title = newtitle;
        }

        //get reference to object of main form
        public void GetMainReference(MainForm mainForm)
        {
            main = mainForm;
        }

        //add item to list on click
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (LbItems.Items.Count >= 20)
                MessageBox.Show(
                    "List can only have 20 items!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else if (TbAddItem.Text != null)
            {
                LbItems.Items.Add(TbAddItem.Text);
                TbAddItem.Text = "";
                TbAddItem.Select();
            }
            else
                MessageBox.Show(
                    "List item cannot be empty!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void TbEnterKey(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (LbItems.Items.Count >= 20)
                    MessageBox.Show(
                        "List can only have 20 items!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else if (TbAddItem.Text != null)
                {
                    LbItems.Items.Add(TbAddItem.Text);
                    TbAddItem.Text = "";
                    TbAddItem.Select();
                }
                else
                    MessageBox.Show(
                        "List item cannot be empty!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        //create list object, create todo form and display it
        public void BtnCreateList_Click(object sender, EventArgs e)
        {
            if (InitializeItemArray())
            {
                list = new List(title, items);
                toDoList = new ToDoListForm(list);
                toDoList.Show();
                AddListToExisting();
                SaveListObjectToFile();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Item list is empty!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //create a json file for list
        public void SaveListObjectToFile()
        {
            GenerateFileNameAndDirectory();
            string json = JsonConvert.SerializeObject(list);
            TextWriter writeDataToFile = new StreamWriter(fileName);
            writeDataToFile.Write(json);
            writeDataToFile.Close();
        }

        //generate file name and directory for json file
        private void GenerateFileNameAndDirectory()
        {
            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            fileName = Path.Combine(dir, title + ".json");
        }

        //add list title to item box on main form
        private void AddListToExisting()
        {
            main.LbExistingLists.Items.Add(title);
            main.UpdateListFile();
        }

        //create an array of todo list items
        private bool InitializeItemArray()
        {
            int NOfItems = LbItems.Items.Count, i=0;
            if (NOfItems != 0)
            {
                items = new string[NOfItems];
                foreach (string item in LbItems.Items)
                {
                    items[i] = item;
                    i++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
