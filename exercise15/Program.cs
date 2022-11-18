Console.WriteLine("add week day:");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay == 6 || weekDay == 7 )
{
    Console.WriteLine("day off");
}
else if ( weekDay <1 || weekDay > 7 )
{
    Console.WriteLine("wrong day");
}
else 
{
    Console.WriteLine("weekday");
}
