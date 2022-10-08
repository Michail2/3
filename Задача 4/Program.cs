int N = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[N];
double [] arr1 = new double[N];
Console.Write("Исходный массив: ");
for( int i = 1; i < N; i++)
{
int t = 0;
arr[i]= i; 
Console.Write(arr[i]+ " ");
}
Console.WriteLine(" ");
Console.Write("Кубы элементов заканчивающихся на четное число: ");
for( int i = 1; i < N; i++)
{
    int t = 0;
    if ( t == i % 2 )
    {
arr1[i]= (arr[i] * arr[i] * arr[i]); 
Console.Write(arr1[i] + " ");
    }
}
