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
using System.Threading;
using Newtonsoft.Json;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        string title, fileName, line, dir;
        public string[] existingLists;
        public MainForm()
        {
            InitializeComponent();
            LoadExistingLists();
            this.Text = "ToDoLists";
        }

        //load existing lists from AppData/Local/ToDoList/existingLists.txt
        public void LoadExistingLists()
        {
            GenerateFileNameAndDirectory();
            if (File.Exists(fileName))
            {
                TextReader readDataFromFile = new StreamReader(fileName);
                existingLists = new string[File.ReadLines(fileName).Count()];
                int i = 0;
                while ((line = readDataFromFile.ReadLine()) != null)
                {
                    existingLists[i] = line;
                    i++;
                }
                readDataFromFile.Close();
                DisplayExistingLists();
            }
        }

        //display existing lists in item box
        private void DisplayExistingLists()
        {
            foreach (string item in existingLists)
            {
                LbExistingLists.Items.Add(item);
                CreateToDoListFormFromFile(item);
            }
        }

        //initialize forms for lists from file and display them
        private void CreateToDoListFormFromFile(string file)
        {
            file += ".json";
            fileName = Path.Combine(dir, file);
            string json = File.ReadAllText(fileName);
            List list = new List();
            list = JsonConvert.DeserializeObject<List>(json);
            ToDoListForm toDo = new ToDoListForm(list);
            toDo.Show();
        }

        //update AppData/Local/ToDoList/existingLists.txt
        public void UpdateListFile()
        {
            CreateStringArray();
            CreateExistingListsFile();
        }

        //create AppData/Local/ToDoList/existingLists.txt
        public void CreateExistingListsFile()
        {
            GenerateFileNameAndDirectory();
            TextWriter writeDataToFile = new StreamWriter(fileName);
            foreach (string item in existingLists)
            {
                writeDataToFile.WriteLine(item);
            }
            writeDataToFile.Close();
        }

        //generate file name and create directory if needed
        private void GenerateFileNameAndDirectory()
        {
            dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            fileName = Path.Combine(dir, "existingLists.txt");
        }

        //create an array from item box strings
        private void CreateStringArray()
        {
            existingLists = new string[LbExistingLists.Items.Count];
            int i = 0;
            foreach (string item in LbExistingLists.Items)
            {
                existingLists[i] = item.ToString();
                i++;
            }
        }

        //deletes list from item box and deletes file for the list
        private void BtnDeleteList_Click(object sender, EventArgs e)
        {
            string name = LbExistingLists.GetItemText(LbExistingLists.SelectedItem);
            dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            fileName = Path.Combine(dir, name + ".json");
            File.Delete(fileName);
            LbExistingLists.Items.Remove(LbExistingLists.SelectedItem);
            UpdateListFile();
        }

        //create a form for selected string in item box and display it
        private void BtnOpenList_Click(object sender, EventArgs e)
        {
            if (LbExistingLists.SelectedItem != null)
            {
                CreateToDoListFormFromFile(LbExistingLists.GetItemText(LbExistingLists.SelectedItem));
            }
            else
            {
                MessageBox.Show(
                    "You did not select a list to open!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //create and display create list form
        private void BtnCreateList_Click(object sender, EventArgs e)
        {
            if (LbExistingLists.Items.Count >= 20)
                MessageBox.Show(
                    "This app only supports up to 20 todo lists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else if (TbTitle.Text != null)
            {
                title = TbTitle.Text;
                TbTitle.Text = "";
                CreateNewListForm list = new CreateNewListForm(title);
                list.Show();
                list.GetMainReference(this);
            }
            else
                MessageBox.Show(
                    "List title cannot be empty!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
