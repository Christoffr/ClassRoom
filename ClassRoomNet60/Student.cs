using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60;

public class Student
{
    public string Name { get; private set; }
    public int BirthMonth { get; private set; }
    public int Birthday { get; private set; }

    public Student(string name, int birthMonth, int birthday)
    {
        Name = name;
        BirthMonth = birthMonth;
        Birthday = birthday;
    }

    public string GetInfo()
    {
        return $"{Name}, born at: {Birthday}/{BirthMonth}\n";
    }
}
