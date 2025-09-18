using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaiTap
{
    public static class FileRead
    {
        public static List<Student>? Readtxt(string file)
        {
            try
            {
                using StreamReader sr = new(file);
                string[] list = sr.ReadToEnd().Split('\t');
                sr.Close();
                int i = 0;
                List<Student> ls = [];
                while (i != list.Length - 1)
                {
                    Student temp = new()
                    {
                        ID = list[i],
                        LastName = list[++i],
                        FirstName = list[++i],
                        Sex = list[++i] == "1",
                        Birth = Convert.ToDateTime(list[++i]),
                        Class = list[++i],
                        PresidentID = list[++i],
                        PhoneNum = list[++i],
                        Selec = [.. list[++i].Split('|')]
                    };
                    ls.Add(temp);
                    i++;
                }
                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static string Writetxt(ref List<Student> ls)
        {
            return string.Empty;
        }
        public static List<Student>? ReadJSON(string file)
        {
            List<Student> list = [];
            HashSet<string> ids = [];
            HashSet<string> duplicate = []; //set of id that duplicate in file
            try
            {
                Console.WriteLine("Read file at: " +  file);
                using (StreamReader sr = new(file))
                {
                    using JsonTextReader reader = new(sr);
                    JsonSerializer serializer = new();
                    Console.WriteLine("Reading");
                    int i = 0;
                    while (reader.Read())
                    {
                        Console.WriteLine("index: " + ++i);
                        if (i == 100) Console.ReadKey();
                        
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            Console.WriteLine("True");
                            Student student = serializer.Deserialize<Student>(reader)!;
                            if (ids.Contains(student.ID))
                            {
                                duplicate.Add(student.ID);
                            }
                            else
                            {
                                list.Add(student);
                                ids.Add(student.ID);
                            }
                        }
                    }
                    sr.Close();
                    Console.WriteLine("Closed.");
                }
                if (duplicate.Count > 0)
                {
                    string str = "";
                    foreach (var v in duplicate)
                        str += v + "\n";
                    MessageBox.Show("Duplicate:\n" + str, "Nofitication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (list.Count == 0)
                    return null;
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading file or file unreadable.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static string WriteJSON(ref List<Student> ls)
        {
            return JsonConvert.SerializeObject(ls, Newtonsoft.Json.Formatting.Indented);
        }
        public static List<Student>? ReadXML(string file)
        {
            List<Student> ls = [];
            return ls;
        }
        public static string WriteXML(ref List<Student> ls)
        {
            return string.Empty;
        }
    }
}
