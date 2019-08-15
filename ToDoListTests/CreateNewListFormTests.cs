using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ToDoList.Tests
{
    [TestClass()]
    public class CreateNewListFormTests
    {
        //create a list object
        [TestMethod()]
        public void CreateListTest()
        {
            string[] items = new string[] { "item1", "item2" };
            bool[] checkBoxes = new bool[] { true, false };
            List list = new List("test", items, checkBoxes);
            Assert.AreEqual("test", list.title, "List title does not match entered title.");
            Assert.AreEqual("item1", list.listItems[0], "List item does not match entered item.");
            Assert.AreEqual("item2", list.listItems[1], "List item does not match entered item.");
            Assert.AreEqual(true, list.checks[0], "Checkbox status does not match entered status.");
            Assert.AreEqual(false, list.checks[1], "Checkbox status does not match entered status.");
        }

        //create a form from list object
        [TestMethod()]
        public void CreateToDoListTest()
        {
            string[] items = new string[] { "item1", "item2" };
            bool[] checkBoxes = new bool[] { true, false };
            List list = new List("test", items, checkBoxes);
            ToDoListForm toDo = new ToDoListForm(list);
            Assert.AreEqual("test", toDo.title, "List title does not match entered title.");
            Assert.AreEqual("item1", toDo.items[0], "List item does not match entered item.");
            Assert.AreEqual("item2", toDo.items[1], "List item does not match entered item.");
            Assert.AreEqual(true, toDo.done[0], "Checkbox status does not match entered status.");
            Assert.AreEqual(false, toDo.done[1], "Checkbox status does not match entered status.");
        }

        //write list to file
        [TestMethod()]
        public void FileWriteTest()
        {
            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            dir = Path.Combine(dir, "testlist.json");
            string json = "{\"title\":\"testlist\",\"listItems\":[\"item1\",\"item2\"],\"checks\":[true,false]}";
            string[] items = new string[] { "item1", "item2" };
            bool[] checkBoxes = new bool[] { true, false };

            CreateNewListForm CNLF = new CreateNewListForm("testlist");
            CNLF.list = new List("testlist", items, checkBoxes);
            CNLF.SaveListObjectToFile();
            string file = File.ReadAllText(dir);

            Assert.AreEqual(json, file, "Written file is not correct.");
        }

        //read list from file
        [TestMethod()]
        public void FileReadTest()
        {
            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            dir = Path.Combine(dir, "testlist.json");

            string json = File.ReadAllText(dir);
            List list = new List();
            list = JsonConvert.DeserializeObject<List>(json);
            ToDoListForm toDo = new ToDoListForm(list);

            Assert.AreEqual("testlist", toDo.title, "Form title does not match title from file.");
            Assert.AreEqual("item1", toDo.items[0], "List item does not match item from file.");
            Assert.AreEqual("item2", toDo.items[1], "List item does not match item from file.");
            Assert.AreEqual(true, toDo.done[0], "Checkbox status does not match one from file.");
            Assert.AreEqual(false, toDo.done[1], "Checkbox status does not match one from file.");
        }

        //load existing lists from file and store them in main object
        [TestMethod()]
        public void LoadExistingListsTest()
        {
            string line;
            MainForm main = new MainForm();
            main.LoadExistingLists();
            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ToDoList");
            dir = Path.Combine(dir, "existingLists.txt");
            TextReader readDataFromFile = new StreamReader(dir);
            int i = 0;
            while ((line = readDataFromFile.ReadLine()) != null)
            {
                Assert.AreEqual(line, main.existingLists[i]);
                i++;
            }
            readDataFromFile.Close();
        }
    }
}