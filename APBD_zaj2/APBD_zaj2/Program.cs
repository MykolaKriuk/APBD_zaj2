﻿
Console.WriteLine("Hello World!");
Console.WriteLine("Hello Modification 1!");
Console.WriteLine("Hello Modification 2!");
Console.WriteLine("Hello Modification 3!");

Console.WriteLine(GetAverage([1,2,3,4,5]));
Console.WriteLine(GetMaxValue([1,23,45,-1,255]));

return;

// Method for finding an average value
static string GetAverage(int[] array)
{
    int sum = 0;
    foreach (var i in array)
    {
        sum += i;
    }

    return "Average is " + (double)sum / array.Length;
}

//Method for finding max value.
static string GetMaxValue(int[] array)
{
    int max = array[0];
    foreach (int j in array)
    {
        if (j > max) max = j;
    }

    return "Max value is " + max;
}