using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_adding
{
    public class Binarytree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null;
            Node after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public void TravesePreOrder(Node Parent)
        {
            if (Parent != null)
            {
                Console.Write("  " + Parent.Data + "");
                TravesePreOrder(Parent.LeftNode);
                TravesePreOrder(Parent.RightNode);
            }

        }
        public void TraveseInOrder(Node Parent)
        {
            if (Parent != null)
            {

                TraveseInOrder(Parent.LeftNode);

                Console.Write("  " + Parent.Data + "  ");

                TraveseInOrder(Parent.RightNode);
            }

        }
        public void TravesePostOrder(Node Parent)
        {
            if (Parent != null)
            {

                TravesePostOrder(Parent.LeftNode);

                TravesePostOrder(Parent.RightNode);

                Console.Write("  " + Parent.Data + "  ");
            }

        }

    }
}
