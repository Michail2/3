int a = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[a];
double [] arr1 = new double[a];
Console.Write("Исходный массив: ");
for( int i = 1; i < a; i++)
{
arr[i]= i; 
Console.Write(arr[i]+ " ");
}
Console.WriteLine(" ");
Console.Write("Кубы каждого элемента исходного массива: ");
for( int i = 1; i < a; i++)
{
 arr1[i]= (arr[i]* arr[i]*arr[i]); 
 Console.Write(arr1[i] + " ");
}