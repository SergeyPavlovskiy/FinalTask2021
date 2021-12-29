
int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  {
  	Console.Write($"{array[i]} ");
  }
}