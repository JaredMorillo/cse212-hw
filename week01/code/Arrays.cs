public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // PLAN:
        // 1. Create an array of type double with size 'length'
        // 2. Use a for loop that goes from 0 to length - 1
        // 3. At each index i, store the value of number multiplied by (i + 1)
        // 4. Return the completed array

        double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = number * (i + 1);
            }

    return result;
}

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // PLAN:
        // 1. Calculate how many elements will remain at the beginning (data.Count - amount)
        // 2. Get a list containing the last 'amount' elements
        // 3. Get a list containing the remaining elements from the beginning
        // 4. Clear the original list
        // 5. Add the last elements first
        // 6. Add the beginning elements after that

        int splitIndex = data.Count - amount;

        List<int> endPart = data.GetRange(splitIndex, amount);
        List<int> startPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);

    }
}
