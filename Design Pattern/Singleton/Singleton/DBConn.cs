using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DBConn
    {
        private static DBConn instance;
        private string Name { get; set; }
        private string Dept { get; set; }
        private DBConn()
        {
            Console.WriteLine("Welcome");
            Name = "kavitha";
            Dept = "IT";
        }
        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();
                
            }
            return instance;
        }
        
        public void Show()
        {
            Console.WriteLine("Information is : Name={0} & Dept={1}", Name,Dept);
        }
    }
}

