using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPr
{
    class Group
    {
        //public T this[int i]
        //{
        //    get { return arr[i]; }
        //    set { arr[i] = value; }
        //}
        private static int ID;
        public readonly int unique;
        public string Name { get; set; }
        private readonly Student[] students;


        public Student this[int i]
        {
            get
            {
                return students[i];
            }
            set
            {
                students[i] = value;
            }
        }
        public int CountGroup { get; set; }
        public Group(string name, int countgroup)
        {
            ID++;
            unique = ID;
            Name = name;
            CountGroup = countgroup;
            students = new Student[countgroup];
        }
        
                public override string ToString()
        {
            string result = "";
            //  return $"{students[i].Name} {students[i].Surname}";

            foreach (var item in students)
            {
                if (item != null)
                {
                    result += item.Surname + item.Surname;
                }

            }

            return result;

        }


    }
}
