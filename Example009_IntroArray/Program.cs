int Max(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}//             0   1   2   3   4   5   6   7   8
int[] array = {15, 27, 38, 43, 51, 67, 75, 88, 99};
// array[0] = 12;
// Console.WriteLine(array[4]);

int max = Max( Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]) );

Console.WriteLine(max);
