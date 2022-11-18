Console.WriteLine("add your numbers:");
int num = Convert.ToInt32(Console.ReadLine());
string thirdNum = Convert.ToString(num);
if (thirdNum.Length > 2)
{
    Console.WriteLine($"third digit number: " + thirdNum[2]);
}
else 
{
    Console.WriteLine("third digit number is missing");
}