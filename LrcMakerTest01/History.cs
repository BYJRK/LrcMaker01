using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LrcMakerTest01
{
    class History
    {
        private List<object> collection = new List<object>();
        public List<object> List
        {
            get
            {
                return collection;
            }
        }
        public string Info
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                foreach (var c in List)
                {
                    temp.Append(c.ToString());
                    temp.Append("\n");
                }
                return temp.ToString();
            }
        }
        private int index = 0;
        public int Index
        {
            get
            {
                return index;
            }
        }
        public History(ListBox listBox)
        {
            index = listBox.SelectedIndex;
            foreach (var c in listBox.Items)
                collection.Add(c);
        }
    }
}
