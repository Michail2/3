int N = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[N];
double b = 1;
for( int i = 1; i < N; i++)
{
arr[i]= i; 
b = b * arr[i];
}
Console.WriteLine(b);

