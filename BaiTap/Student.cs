using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Student
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public  bool Sex { get; set; }
        public DateTime Birth { get; set; }
        public string Class { get; set; }
        public string PresidentID { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public List<string> Selec { get; set; }

        public Student()
        {
            ID = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Sex = true;
            Birth = DateTime.Now;
            Class = string.Empty;
            PresidentID = string.Empty;
            PhoneNum = string.Empty;
            Address = string.Empty;
            Selec = [];
        }
        public Student(string iD, string lastName, string firstName, bool sex, DateTime birth, string @class, string presidentID, string phoneNum,string address, List<string> selec)
        {
            ID = iD;
            LastName = lastName;
            FirstName = firstName;
            Sex = sex;
            Birth = birth;
            Class = @class;
            PresidentID = presidentID;
            PhoneNum = phoneNum;
            Address = address;
            Selec = selec;
        }
        public string Get()
        {
            return string.Format("");
        }
        public override string ToString()
        {
            return Get();
        }
    }
}
