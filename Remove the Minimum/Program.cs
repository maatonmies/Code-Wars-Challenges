//Task
//Given an array of integers, remove the smallest value. Do not mutate the original array/list.
//If there are multiple elements with the same value, remove the one with a lower index. If you get an empty array/list, return an empty array/list.
//Don't change the order of the elements that are left.

using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        var filter = numbers.TakeWhile(x => x > numbers.Min()).ToList();
        if (numbers.Count > 0) numbers.RemoveAt(filter.Count);
        return numbers;
    }
}