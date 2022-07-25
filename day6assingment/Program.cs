int first = -1;
int secound = 1;
int Value =0;

for (int i = 1; i < 8; i++)
{

    Value = first + secound;
    first = secound;
    secound = Value;
    Console.WriteLine(Value);

}
//Console.WriteLine(first);
//Console.WriteLine(secound);
