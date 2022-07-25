Console.WriteLine("enter any number ");
int Number = Convert.ToInt32(Console.ReadLine());
int flag = 0;
if (Number == 0 || Number == 1)
{
    Console.WriteLine( "Number is not prime " + Number);
}
for (int i = 2; i < Number; i++)
{
    if (Number % i == 0)
    {
        Console.WriteLine("number is not prime " + Number);
        flag = 1;
    }
 }
 if (flag  == 0)
    Console.WriteLine("Number is prime" +Number);