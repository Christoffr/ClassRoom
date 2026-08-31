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

    public string Season(int birthMonth)
    {
        switch (birthMonth)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Invalid month";
        }
    }

    public void BirthdaysPerSeasons()
    {
        var seasonCount = StudentList
            .GroupBy(student => Season(student.BirthMonth))
            .ToDictionary(group => group.Key, group => group.Count());

        foreach (var item in seasonCount)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    public override string ToString()
    {
        string students = string.Join("\n", StudentList.Select(student => $"{student.GetInfo()}, {Season(student.BirthMonth)}"));
        return $"Name: {ClassName}\n Starts at : {SemesterStart}\n Students:\n{students}";
    }
}
