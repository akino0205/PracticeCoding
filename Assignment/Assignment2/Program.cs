// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Numerics;
using System.Text;

#region Console write
Console.WriteLine("================ 기본수학1 ================");
Console.WriteLine("1.백준 1712번 손익분기점");
Console.WriteLine("2.백준 2292번 벌집");
Console.WriteLine("3.백준 1193번 분수찾기");
Console.WriteLine("4.백준 2775번 부녀회장이 될테야");
Console.WriteLine("5.백준 10757번 큰수 A+B");
Console.WriteLine("6.백준 1978번 소수찾기");
#endregion Console write

switch (Console.ReadLine())
{
    case "1": BreakEvenPoint(); break;
    case "2": Honeycomb(); break;
    case "3": FindFraction(); break;
    case "4": WomensPresident(); break;
    case "5": BigNumAPlusB(); break;
    case "6": FindSosu(); break;
    default: break;
}
#region 백준 기본수학
/// <summary>
/// 백준 1712번 손익분기점
/// https://www.acmicpc.net/problem/1712 
/// </summary>
void BreakEvenPoint()
{
    string[] input = Console.ReadLine().Split();
    int fixedCost = int.Parse(input[0]);
    int variableCost = int.Parse(input[1]);
    int price = int.Parse(input[2]);

    if (variableCost >= price)
        Console.WriteLine(-1);
    else
        Console.WriteLine((fixedCost / (price - variableCost))+1);
}
/// <summary>
/// 백준 2292번 벌집
/// https://www.acmicpc.net/problem/2292
/// </summary>
void Honeycomb()
{
    int inputNum = int.Parse(Console.ReadLine());
    int maxNum = 1;
    int result = 0;
    for (int i = 0; i < inputNum; i++)
    {
        maxNum += 6 * i;
        if (maxNum >= inputNum)
        {
            result = i + 1;
            break;
        }
    }
    Console.WriteLine(result);
}
/// <summary>
/// 백준 1193번 분수찾기
/// https://www.acmicpc.net/problem/11193
/// </summary>
void FindFraction()
{
    var num = int.Parse(Console.ReadLine());
    int level = 0;
    int sum = 0;

    while(sum < num)
    {
        level++;
        sum += level;
    }
    int index = num - (sum - level);
    string result = level % 2 == 1 ? $"{level - index + 1}/{index}" : $"{index}/{level - index + 1}";
    Console.WriteLine(result);
}
#endregion 백준 기본수학

#region 0707
/// <summary>
/// 백준 2775번 부녀회장이 될테야
/// </summary>
void WomensPresident()
{
    int caseCnt = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < caseCnt; i++)
    {
        int floor = int.Parse(Console.ReadLine());
        int ho = int.Parse(Console.ReadLine());
        sb.AppendLine(CountResident(floor, ho).ToString());
    }
    Console.WriteLine(sb.ToString());
}
/// <summary>
/// k층(floor) n호(ho)
/// </summary>
int CountResident(int floor, int ho)
{
    int[,] records = new int[floor+1, ho];
    for(int k = 0; k <= floor; k++)
    {
        for(int n = 1; n<= ho; n++)
        {
            if (k == 0)
                records[k, n-1] = n;
            else
            {
                for (int b = 1; b <= n; b++)
                    records[k, n-1] += records[k - 1, b-1];
            }
        }
    }
    return records[floor, ho-1];
}
/// <summary>
/// 백준 10757번 큰수 A+B
/// </summary>
void BigNumAPlusB()
{
    string[] inputArr = Console.ReadLine().Split();
    BigInteger firstNum = BigInteger.Parse(inputArr[0]);
    BigInteger secondNum = BigInteger.Parse(inputArr[1]);
    BigInteger result = firstNum + secondNum;
    Console.WriteLine(result.ToString());
}
/// <summary>
/// 백준 1978번 소수찾기
/// </summary>
void FindSosu()
{
    var count = Console.ReadLine();
    int[] nums = Console.ReadLine().Split().Select(s => Int32.Parse(s)).ToArray();
    int sosuCount = 0; 
    foreach(int num in nums)
    {
        if (IsSosu(num))
            sosuCount++;
    }
    Console.WriteLine(sosuCount);
}
bool IsSosu(int num)
{
    if (num == 1)
        return false;

    for (int i = 2; i < num; i++)
    {
        if (num/i != 1 && num % i == 0) return false;
    }
    return true;
}

#endregion 0707
