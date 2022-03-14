bool msgerror;

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
	if (Math.Abs(min) > Math.Abs(array[i]))
		min = array[i];
}

Console.WriteLine(); //декоративно
int idx = Array.IndexOf(array, min);
Console.WriteLine($"Исходное значение массива : {min}");
Console.WriteLine($"Значение минимального значениия по модулю : {Math.Abs(min)}");
Console.Write($"Позиция элемента массива : {idx}");

while (idx != -1) 
{
	if (Array.IndexOf(array, min, idx + 1) != -1)
	{
		idx = Array.IndexOf(array, min, idx + 1);
		Console.WriteLine($", {idx}");
	}
	else break;
}
Console.WriteLine(); //декоративно

	idx = 0; //обнуляем индекс

Console.Write("array = [");
foreach (int i in array)
{
	if (idx == array.Length - 1)
		Console.WriteLine($"{i}]");
	else
		Console.Write($"{i}, ");
	idx++;
}