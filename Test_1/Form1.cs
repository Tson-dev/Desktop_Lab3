using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Title = "Select Json File.",
                Filter = "Json|*.json"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            List<StudentInfo> list = LoadJSON(ofd.FileName);
            string str = string.Empty;
            int i = 0;
            foreach(StudentInfo student in list)
            {
                str += string.Format("Sinh Viên {0} có mã {1} tên {2} điểm {3}\n\r", ++i, student.MSSV, student.HoTen, student.Diem);
            }
            MessageBox.Show(str);
        }
        private List<StudentInfo> LoadJSON(string path)
        {
            List<StudentInfo> list = new();
            StreamReader sr = new(path);
            var arr = (JObject)JsonConvert.DeserializeObject(sr.ReadToEnd())!;
            var students = arr["sinhvien"].Children();
            foreach(var item in students)
            {
                list.Add(new(item["MSSV"].Value<string>(), item["hoten"].Value<string>(), item["tuoi"].Value<int>(), item["diem"].Value<double>(), item["tongiao"].Value<bool>()));
            }
            return list;
        }
    }
}
