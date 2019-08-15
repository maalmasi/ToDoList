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
    public partial class ToDoListForm : Form
    {
        public string title;
        public string[] items = new string[20];
        public bool[] done;
        string fileName;
        List list;

        //default constructor
        public ToDoListForm()
        {
            InitializeComponent();
        }

        //construct from List object
        public ToDoListForm(List list)
        {
            InitializeComponent();
            title = list.title;
            items = (string[])list.listItems.Clone();
            if (list.checks != null)
            {
                done = new bool[list.checks.Count()];
                done = (bool[])list.checks.Clone();
            }
            DisplayListData();
            InitializeBackgroundWorkerHandlers();
        }

        //background thread to write to file
        //created to avoid errors
        private void InitializeBackgroundWorkerHandlers()
        {
            backgroundWorker.DoWork += (s, e) =>
            {
                UpdateToDoListFile();
            };

            backgroundWorker.RunWorkerCompleted += (s, e) =>
            {
                Console.Write("done");
            };
        }

        //updates bool array to write in json file
        private void UpdateToDoListFile()
        {
            Thread.Sleep(100);
            done = new bool[ClbItems.Items.Count];
            for (int i = 0; i < ClbItems.Items.Count; i++)
            {
                if (ClbItems.GetItemChecked(i))
                    done[i] = true;
                else
                    done[i] = false;
            }
            list = new List(title, items, done);
            UpdateListFile();
        }

        //displays data from object properties
        private void DisplayListData()
        {
            this.Text = title;
            foreach (string item in items)
            {
                ClbItems.Items.Add(item);
                this.Height += ClbItems.GetItemRectangle(0).Height;
            }
            ClbItems.ClientSize = new Size(ClbItems.ClientSize.Width, ClbItems.GetItemRectangle(0).Height * ClbItems.Items.Count);

            if (done != null)
            {
                int i = 0;
                foreach (bool check in done)
                {
                    ClbItems.SetItemChecked(i, check);
                    i++;
                }
            }
        }

        //run background thread on check/unckeck list item
        private void ClbItems_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        //update json file with bool array
        private void UpdateListFile()
        {
            GenerateFileNameAndDirectory();
            string json = JsonConvert.SerializeObject(list);
            TextWriter writeDataToFile = new StreamWriter(fileName);
            writeDataToFile.Write(json);
            writeDataToFile.Close();
        }

        //generates file name and path for writing
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
    }
}
