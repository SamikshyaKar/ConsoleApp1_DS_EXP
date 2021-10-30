using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_1
{
    public class Node
    {
        public object data = null;
        public Node next = null;

        public override bool Equals(object obj)
        {
           if(obj is Node) return ((Node) obj).data.Equals(obj);
            //if (obj as Node == null) return false;
            return false;
          
        }
        public override int GetHashCode()
        {
            return data.GetHashCode();
        }
    }
}
