// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Text;

#region Console write
Console.WriteLine("================ 기본수학1 ================");
Console.WriteLine("1.백준 1712번 손익분기점");
Console.WriteLine("2.백준 2292번 벌집");
Console.WriteLine("3.백준 1193번 분수찾기");
#endregion Console write

switch (Console.ReadLine())
{
    case "1": BreakEvenPoint(); break;
    case "2": Honeycomb(); break;
    case "3": FindFraction(); break;
    default: break;
}

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
