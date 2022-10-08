// При условии что в числе a не будет встречаться 0 
int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (a > 0)
            {
 
                b = b + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(b);
 
 // Если в числе a встречается 0 то можно легко через массив 

int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int sum = 0;
for( int i = 1; i < a; i++)
{
arr[i] = Convert.ToInt32(Console.ReadLine()); 
sum = sum + arr[i];
}
Console.WriteLine(sum);