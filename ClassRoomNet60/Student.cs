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
        return $"{Name}, born at: {Birthday}/{BirthMonth}, {Season()}\n";
    }

    public string Season()
    {
        switch (BirthMonth)
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
}
