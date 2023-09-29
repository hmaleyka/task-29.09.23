//TASK1
//find the root numbers between 1 and 25.

for (int i = 1; i * i < 26; i++)
{
    Console.WriteLine("the number which is square between the 1-25:  " + i * i);
}



//TASK2
//print the odd numbers which is located inside the array.

int[] numbers = { 2, 4, 7, 9, 17 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 1)
    {
        sum += numbers[i];
    }

}
Console.WriteLine(sum);

//TASK3
//print the numbers which is placed in the odd place inside the array.

int[] numbers = { 7, 8, 21, 19, 15 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += numbers[i];
    }
}
Console.WriteLine(" the sum of given odd numbers: " + sum);

//TASK4
//find the word if it is palindrome or not

string givenWord = "ata";
char[] characters = new char[givenWord.Length];
for (int i = 0; i < givenWord.Length; i++)
{
    characters[i] = givenWord[i];
}
bool Palindrome = true;
for (int i = 0; i < characters.Length / 2; i++)
{
    if (characters[i] != characters[characters.Length - 1 - i])
    {
        Palindrome = false;
        break;
    }
}
if (Palindrome)
    Console.WriteLine($"'{givenWord}' is a palindrome");
else
{
    Console.WriteLine($"'{givenWord}' is not a palindrome");
}