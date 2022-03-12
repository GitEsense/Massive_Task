int[] arr = { 15, 6, -4, 12, -11, 8, -1 }; //ручной массив
bool msgerror;
int index = 0;

Console.Write("Введире размер массива : ");
msgerror = int.TryParse(Console.ReadLine(), out int k);
if (k == 0)
	msgerror = false;
while (!msgerror)
{
	Console.Write("Введите ТОЛЬКО число не равное нулю : ");
	msgerror = int.TryParse(Console.ReadLine(), out k);
}

int[] array = new int[k];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
	array[i] = rand.Next(-50, 50); // генерируемый

int min = Math.Abs(array[0]);

for (int i = 0; i != array.Length; i++)
{
	if (min > Math.Abs(array[i]))
	{
		min = Math.Abs(array[i]);
		index = i;
	}
}

Console.WriteLine(); //декоративно

Console.WriteLine($"Исходное значение массива : {array[index]}");
Console.WriteLine($"Значение минимального значениия по модулю : {Math.Abs(array[index])}");
Console.WriteLine($"Позиция элемента массива : {index}");

Console.WriteLine(); //декоративно

index = 0; //обнуляем индекс

Console.Write("array = [");
foreach (int i in array)
{
	if (index == array.Length - 1)
		Console.WriteLine($"{i}]");
	else
		Console.Write($"{i}, ");
	index++;
}