// switch

//int.TryParse(Console.ReadLine(), out int weekday);

//switch ((WeekDays)weekday)
//{
//    case WeekDays.MONDAY:
//        Console.WriteLine("Bazar Ertesi");
//        break;
//    case WeekDays.TUESDAY:
//        Console.WriteLine("Ch. Axshami");
//        break;
//    case WeekDays.WEDNESDAY:
//        Console.WriteLine("Chershenbe");
//        break;
//    case WeekDays.THURSDAY:
//        Console.WriteLine("C. Axshami");
//        break;
//    case WeekDays.FRIDAY:
//        Console.WriteLine("Cume");
//        break;
//    case WeekDays.SATURDAY:
//        Console.WriteLine("Shenbe");
//        break;
//    case WeekDays.SUNDAY:
//        Console.WriteLine("Bazar");
//        break;
//    default:
//        Console.WriteLine("Incorrect data");
//        break;
//}

//double.TryParse(Console.ReadLine(), out double numb);

//switch (numb)
//{
//    case 0.6:
//        break;
//    case 2.3:
//        break;
//    default:
//        break;
//}

//var name = Console.ReadLine();
//switch (name)
//{
//    case "Nadir":
//        break;
//    case "Salam":
//        break;
//    default:
//        break;
//}


#region Months
int.TryParse(Console.ReadLine(), out int month);
switch ((Months)month)
{
    case Months.JANUARY:
    case Months.MARCH:  
    case Months.MAY:
    case Months.JULY:
    case Months.AUGUST:
    case Months.OCTOBER:
        goto case Months.DECEMBER;    
    case Months.FEBRUARY:
        Console.WriteLine("28 or 29 days");
        break;
    case Months.APRIL:
    case Months.JUNE:    
    case Months.SEPTEMBER:    
    case Months.NOVEMBER:
        Console.WriteLine("30 days");
        break;
    case Months.DECEMBER:
        Console.WriteLine("31 days");
        break;
    default:
        break;
}
#endregion

enum WeekDays
{
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
};

enum Months
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER
}


