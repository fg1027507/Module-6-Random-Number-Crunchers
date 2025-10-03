/*
Random Number Crunchers
Created by finn gilbert on 10-3-2025
*/
using System;
using System.Collections.Generic;
// sets an array of ten numbers
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

int[] numbers = new int[10];
List<int> modes = new List<int>();
Random rand = new Random();
int sum = 0;
int maxCount = 0;
// Makes the numbers in numbers all be random using a for loop
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}
// Uses a foreach loop to print the numbers
foreach (int num in numbers)
{
    Console.WriteLine(num);
    // Adding all the numbers together in the foreach loop
    sum += num;
}
// Writing out the sum of all the numbers
Console.WriteLine($"The sum is: {sum}");
// Taking the sum then dividing it by 10 to get the average and printing
double mean = (double)sum / numbers.Length;
Console.WriteLine($"The mean is: {mean}");
// Sorting the array into ascending order, taking the 5th and 6th number then dividing them by 2, and printing the median
Array.Sort(numbers);
double median = (numbers[5] + numbers[6]) / 2;
Console.WriteLine($"The median is: {median}");

// Outer loop: pick one number
for (int i = 0; i < numbers.Length; i++)
{
    int count = 0;

    // Inner loop: compare numbers[i] with every other number
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            count++;
        }
    }

    // Check if this number is a new mode
    if (count > maxCount)
    {
        maxCount = count;
        modes.Clear();
        modes.Add(numbers[i]);
    }
    // If count ties with the best, and it's not already in the list
    else if (count == maxCount && !modes.Contains(numbers[i]))
    {
        modes.Add(numbers[i]);
    }
}

// Display the results
if (maxCount == 1)
{
    Console.WriteLine("No mode — all numbers appear only once.");
}
else
{
    Console.WriteLine("Mode(s): " + string.Join(", ", modes));
    Console.WriteLine("Each appears " + maxCount + " times.");
}