// Task 8: You are given one natural number and your task is to find the sum of the digits of this number.

int number = 347;
int sum = SumOfDigits(number);
Console.WriteLine("Sum of digits: " + sum);


static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10; 
        number /= 10; 
    }
    return sum;
}

