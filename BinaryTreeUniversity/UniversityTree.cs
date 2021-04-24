using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUniversity
{
    //Every tree has a root node where everything begins
    class UniversityTree
    {
        //Root this is an attribute of the class
        public PositionNode Root;
               
        public void CreatePosition(PositionNode parent,
            Position positionToCreate,
            string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
        
            if (Root == null)
            {
                Root = newNode;
                return;
            }
       
            if (parent == null)
            {
                return;
            }
              
            if (parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
         
                parent.Right = newNode;
                return;
            }
            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }

        //Method to print the tree from a node
        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : $ {from.Position.Salary}");

            //Recursive call to print left and right
            PrintTree(from.Left);
            PrintTree(from.Right);
        }
        //Method of adding salaries
        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            //Call recursive
            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);

            //Recursive call to print left and right
            PrintTree(from.Left);
            PrintTree(from.Right);
        }
    }
}
