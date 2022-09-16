using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1generics
{
    public class Binaryst<T> where T : IComparable<T> //interface class icomparables
    {
        public T NodeData
        {
            get; set;
        }
        public Binaryst<T> leftTree { get; set; }
        public Binaryst<T> rightTree { get; set; }

        public Binaryst(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0) 
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new Binaryst<T>(item);
                }
                else
                    this.leftTree.Add(item);

            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new Binaryst<T>(item);
                }
                else
                    this.rightTree.Add(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}