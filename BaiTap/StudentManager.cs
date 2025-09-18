using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class StudentManager
    {
        public List<Student> list;

        public StudentManager()
        {
            list = [];
        }
        public StudentManager(List<Student> list)
        {
            this.list = new(list);
        }
        public Student this[int index]
        {
            get { return list[index]; }
            set { this.list[index] = value; }
        }
        public void Add(Student student)
        {
            this.list.Add(student);
        }
        public void Remove(Student student)
        {
            this.list.Remove(student);
        }
    }
}
