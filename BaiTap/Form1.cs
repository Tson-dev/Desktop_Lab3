using System.Diagnostics;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public StudentManager studentManager;
        public Form1()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to exit?", "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        bool CheckEnough()
        {
            return txtID.Text != string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckEnough())
            {
                DialogResult = MessageBox.Show("Add new student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    Student student = new()
                    {
                        ID = txtID.Text,
                        LastName = txtLName.Text,
                        FirstName = txtFName.Text,
                        Birth = Convert.ToDateTime(dtimeBirth.Text),
                        Sex = rcbxMale.Checked,
                        Class = cobxClass.Text,
                        PresidentID = mtxtPresidentID.Text,
                        PhoneNum = mtxtPhone.Text,
                        Address = txtAddress.Text
                    };
                    //foreach (var item in lcbxSelect.Selected)
                    //{
                    //    student.Selec.Add(item.ToString()!);
                    //}
                    studentManager.Add(student);
                    lvwList.Items.Add(CreateStudentLVItem(student));
                }
            }
            else
            {
                MessageBox.Show("PLs write information to the empty box.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEnough())
            {
                DialogResult = MessageBox.Show("Are you sure want to update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult == DialogResult.Yes)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("PLs write information to the empty box.","Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private ListViewItem CreateStudentLVItem(Student student)
        {
            ListViewItem item = new(student.ID);
            item.SubItems.Add(student.LastName);
            item.SubItems.Add(student.FirstName);
            item.SubItems.Add(student.Birth.ToShortDateString());
            item.SubItems.Add(student.Class);
            item.SubItems.Add(student.PresidentID);
            item.SubItems.Add(student.PhoneNum);
            item.SubItems.Add(student.Address);
            return item;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Current Directory:\t" + Environment.CurrentDirectory);
            Console.WriteLine("Base Directory:\t\t" + AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine("Project Directory:\t" + Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.FullName);

            studentManager = new(FileRead.ReadJSON("stock.json")!);
            foreach (var student in studentManager.list)
            {
                lvwList.Items.Add(CreateStudentLVItem(student));
            }
            
        }

        private void tsmiImport_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                InitialDirectory = "C:\\",
                Title = "Import",
                Filter = "All|*.*|Json|*.json|Xml|*.xml|Text|*.txt"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Import");
                switch (Path.GetExtension(ofd.FileName).ToLower())
                {
                    case ".json":
                        List<Student>? students = FileRead.ReadJSON(ofd.FileName);
                        if (students == null || !students.Any()) return;
                        Console.WriteLine("End Import.");
                        Console.WriteLine("Start Export.");
                        SaveFile(1, students);
                        Console.WriteLine("End Export.");

                        break;
                    case ".xml":
                        FileRead.ReadXML(ofd.FileName);
                        break;
                    case ".txt":
                        FileRead.Readtxt(ofd.FileName);
                        break;
                    default:
                        MessageBox.Show("Unable to read the file.", "Error", 0, MessageBoxIcon.Error);
                        return;
                }
            }
        }

        private void tsmiExport_Json_Click(object sender, EventArgs e)
        {
            SaveFile(1);
        }

        private void tsmiExport_Xml_Click(object sender, EventArgs e)
        {
            SaveFile(2);
        }

        private void tsmiExport_Text_Click(object sender, EventArgs e)
        {
            SaveFile(3);
        }
        private void SaveFile(int mode)
        {
            string filter, str;
            switch (mode)
            {
                case 1:
                    filter = "Json|*.json";
                        break;
                case 2:
                    filter = "XML|*.xml";
                    break;
                case 3:
                    filter = "Text|*.txt";
                    break;
                default:
                    return;
            }
            SaveFileDialog sfd = new()
            {
                Title = "Export",
                Filter = filter
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<Student> temp = [];
                switch (mode)
                {
                    case 1:
                        str = FileRead.WriteJSON(ref temp);
                        break;
                    case 2:
                        str = FileRead.WriteXML(ref temp);
                        break;
                    case 3:
                        str = FileRead.Writetxt(ref temp);
                        break;
                    default:
                        MessageBox.Show("What!?\nAn error happen when choose file to write?\nTF How?", "Error?", 0, MessageBoxIcon.Error);
                        return;
                }
                File.WriteAllText(sfd.FileName, str);    //WIP
                Process.Start("explorer.exe", Path.GetDirectoryName(sfd.FileName)!);
            }
        }
        private void SaveFile(int mode, List<Student> list)
        {
            string filter, str;
            switch (mode)
            {
                case 1:
                    filter = "Json|*.json";
                    break;
                case 2:
                    filter = "XML|*.xml";
                    break;
                case 3:
                    filter = "Text|*.txt";
                    break;
                default:
                    return;
            }
            SaveFileDialog sfd = new()
            {
                Title = "Export",
                Filter = filter
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (mode)
                {
                    case 1:
                        str = FileRead.WriteJSON(ref list);
                        break;
                    case 2:
                        str = FileRead.WriteXML(ref list);
                        break;
                    case 3:
                        str = FileRead.Writetxt(ref list);
                        break;
                    default:
                        MessageBox.Show("What!?\nAn error happen when choose file to write?\nTF How?", "Error?", 0, MessageBoxIcon.Error);
                        return;
                }
                File.WriteAllText(sfd.FileName, str);    //WIP
                Process.Start("explorer.exe", Path.GetDirectoryName(sfd.FileName)!);
            }
        }
    }
}
