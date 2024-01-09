void array(string [] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива: ");
     stringArray[i] = Console.ReadLine()!;
  }
}


