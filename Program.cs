// Time complexity is O(1) and space complexity is O(n)

int[] array = { 5, 8, 3, -5, 7, 13, 16, 40, -21 };
int[] sequence = { 8, 7, 13, -21 };
Console.WriteLine(IsSubsequence(array, sequence));
bool IsSubsequence(int[] array, int[] sequence)
{
    // Write your code here.
    int arrayCounter = 0;
    int seqCounter = 0;
    while(arrayCounter < array.Length)
    {
        if (sequence[seqCounter] == array[arrayCounter]) seqCounter++;
        arrayCounter++;
        if (seqCounter == sequence.Length - 1)
        {
            return true;
        }
    }
    return false;
}