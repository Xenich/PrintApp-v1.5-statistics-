using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintApp
{
    class Node
    {
        public string text;
        public int parentID;
        public Node parent;

        public Node(int parentID, string text)
        {
            this.text = text;
            this.parentID = parentID;
        }
    }
}
