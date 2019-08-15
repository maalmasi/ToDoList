using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class List
    {
        public string title;
        public string[] listItems;
        public bool[] checks;

        public List() { }

        public List(string newtitle, string[] items)
        {
            title = newtitle;
            listItems = new string[items.Count()];
            listItems = (string[])items.Clone();
        }

        public List(string newtitle, string[] items, bool[] checkBoxes)
        {
            title = newtitle;
            listItems = new string[items.Count()];
            listItems = (string[])items.Clone();
            checks = new bool[items.Count()];
            checks = (bool[])checkBoxes.Clone();
        }
    }
}
