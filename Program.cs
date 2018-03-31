using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example;

namespace propertisAndIndexers
{
    class Example
    {
        string[] m_Name =null;
        char[,] m_BoardOfGame = null;
        public Example(string[] arr)

        {
            m_BoardOfGame = new char[6, 6];
            m_Name = arr;
            m_Age = 0;
            myVar = 0;

        }



        public char this[char i_Row, char i_Col]
        {
            get
            {
                return m_BoardOfGame[i_Row - 'A', i_Col -'a'];
            }
            set
            {
                m_BoardOfGame[i_Row-'A', i_Col-'a'] = value;
            }
        }

        //indexr
        public string this[int i]                  
        {
            get { return m_Name[i-1]; }            // start arry is 1 and not 0
            set { m_Name[i-1] = value; }
        }


        // another indexr
        //public bool this [string i_str]
        //{
        //    get
        //    {
        //        foreach (var item in m_Name)
        //        {
        //            if(i_str == item)
        //            {
        //                return true;
        //            }

        //        }

        //        return false;
        //    }
        //}


        // more indexr
        public int this[string i_str]
        {
            get
            {
                for (int i = 0; i < m_Name.Length; i++)
                {
                    if (i_str == m_Name[i])
                    {
                        return i;
                    }

                }

                return -1;
            }
        }




        public int m_Age { get; set; } = 0;      // prop

        private int myVar;                        // full prop 

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }


    class Program
    {
        public static void Main()
        {
            string[] name = new string[3] { "one", "two", "tree" }; 

            Example x = new Example(name) ;

            Console.WriteLine(x[1]);
            Console.WriteLine(x[3]);

            Console.WriteLine("tree is in :{0}",x["tree"]);


            //this for Af be like 1,6
            x['A', 'f'] = 'x';
            Console.WriteLine(x['A','f']);



            Console.WriteLine(x.m_Age);
            x.m_Age = 6;
            Console.WriteLine(x.m_Age);


            Console.WriteLine(x.MyProperty);   // why is work? myvar not was initialized
            x.MyProperty = 8;
            Console.WriteLine(x.MyProperty);
        }
    }
}
