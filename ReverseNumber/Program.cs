Console.WriteLine("enter number ");
double rem = 0, revers = 0;
int number = Convert.ToInt32(Console.ReadLine());


while(number != 0)
{
    rem = number % 10;     // 234 % 10 = 4 
    revers = (revers*10)+rem;
   // Console.WriteLine(+revers);
    number = number / 10;
   
}

Console.WriteLine(+revers);
