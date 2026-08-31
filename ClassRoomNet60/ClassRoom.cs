using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; private set; }
    public List<Student> StudentList { get; private set; }
    public DateTime SemesterStart { get; private set; }

    public ClassRoom(string className, List<Student> studentList, DateTime semesterStart)
    {
        ClassName = className;
        StudentList = studentList;
        SemesterStart = semesterStart;
    }

    public override string ToString()
    {
        string students = "";

        foreach (var item in StudentList)
        {
            students += item.GetInfo();
        }

        return $"Name: {ClassName}\n Starts at : {SemesterStart}\n Students: " + students;
    }
}
