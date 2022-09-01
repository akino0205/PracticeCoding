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
Console.WriteLine("7.백준 24416번 알고리즘 수업 피보나치 수1");
Console.WriteLine("8.백준 9184번 신나는 함수 실행");
Console.WriteLine("9.백준 9461번 파도반 수열");
Console.WriteLine("================ 동적계획법 ================");
Console.WriteLine("10.백준 1932번 정수삼각형");
Console.WriteLine("11.백준 1149번 ");
Console.WriteLine("12.백준 11054번 ");
Console.WriteLine("13.백준 11729번 ");
#endregion Console write

switch (Console.ReadLine())
{
    case "1": BreakEvenPoint(); break;
    case "2": Honeycomb(); break;
    case "3": FindFraction(); break;
    #region 0707
    case "4": WomensPresident(); break;
    case "5": BigNumAPlusB(); break;
    case "6": FindSosu(); break;
    #endregion 0707
    #region 0714
    case "7": Fibonacci(); break;
    case "8": ExecuteFunction(); break;
    case "9": PadovanSequence(); break;
    #endregion 0714
    #region 0721
    case "10": Triangle(); break;
    case "11": RGBStreet(); break;
    case "12": LongestBiotonic(); break;
    case "13": HanoiTop(); break;
    #endregion 0721
    #region 20220901 그래프
    case "14": DFS1(); break;
    #endregion 20220901
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
#region 0714
/// <summary>
/// 백준 24416번 알고리즘 수업 피보나치 수1
/// https://www.acmicpc.net/problem/24416
/// </summary>
void Fibonacci()
{
    int input = int.Parse(Console.ReadLine());
    int result1 = fib(input);
    int result2 = fibonacci(input);
    Console.WriteLine($"{result1} {result2}");
}
int fib(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return (fib(n - 1) + fib(n - 2));
}
int fibonacci(int n)
{
    int result = 0;
    int[] f = new int[n+1];
    f[1] = f[2] = 1;
    for(int i = 3; i <= n; i++)
    {
        f[i] = f[i - 1] + f[i - 2];
        result++;
    }
    return result;
}
/// <summary>
/// 백준 9184번 신나는 함수 실행
/// https://www.acmicpc.net/problem/9184
/// </summary>
void ExecuteFunction()
{
    w = new int[101, 101, 101];
    StringBuilder sb = new StringBuilder();
    while (true)
    {
        var input = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
        int result = 0;
        if (input[0] == -1 && input[1] == -1 && input[2] == -1)
            break;
        result = GetWMemoization(input[0], input[1], input[2]);
        //result = GetW(input[0], input[1], input[2]);
        sb.AppendLine($"w({input[0]}, {input[1]}, {input[2]}) = {result}");
    }
    Console.WriteLine(sb.ToString());
}
int GetWMemoization(int a, int b, int c)
{
    (int aIdx, int bIdx, int cIdx) = (a + 50, b + 50, c + 50);
    //int aIdx = a + 50;
    //int bIdx = b + 50;
    //int cIdx = c + 50;
    if (w[aIdx, bIdx, cIdx] != 0)
        return w[aIdx, bIdx, cIdx];
    if (a <= 0 || b <= 0 || c <= 0)
        w[aIdx, bIdx, cIdx] = 1;
    else if (a > 20 || b > 20 || c > 20)
        w[aIdx, bIdx, cIdx] = GetWMemoization(20, 20, 20);
    else if (a < b && b < c)
        w[aIdx, bIdx, cIdx] = GetWMemoization(a, b, c - 1) + GetWMemoization(a, b - 1, c - 1) - GetWMemoization(a, b - 1, c);
    else
        w[aIdx, bIdx, cIdx] = GetWMemoization(a - 1, b, c) + GetWMemoization(a - 1, b - 1, c) + GetWMemoization(a - 1, b, c - 1) - GetWMemoization(a - 1, b - 1, c - 1);
    return w[aIdx, bIdx, cIdx];
}
int GetW(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return 1;
    else if (a > 20 || b > 20 || c > 20)
        return GetW(20, 20, 20);
    else if (a < b && b < c)
        return GetW(a, b, c - 1) + GetW(a, b - 1, c - 1) - GetW(a, b - 1, c);
    else
        return GetW(a - 1, b, c) + GetW(a - 1, b - 1, c) + GetW(a - 1, b, c - 1) - GetW(a - 1, b - 1, c - 1);
}
/// <summary>
/// 9.백준 9461번 파도반 수열
/// https://www.acmicpc.net/problem/9461
/// </summary>
void PadovanSequence()
{
    padovanSequenceArr = new long[100];
    StringBuilder sb = new StringBuilder();
    int caseCount = int.Parse(Console.ReadLine());
    for(int idx = 0; idx < caseCount; idx++)
    {
        int input = int.Parse(Console.ReadLine());
        sb.AppendLine(GetPadovanSequence(input).ToString());
    }
    Console.WriteLine(sb.ToString());
}
long GetPadovanSequence(int cnt)
{
    int idx = cnt - 1;
    if (padovanSequenceArr[idx] != 0)
        return padovanSequenceArr[idx];
    else if (cnt == 1 || cnt == 2 || cnt == 3)
        padovanSequenceArr[idx] = 1;
    else
        padovanSequenceArr[idx] = GetPadovanSequence(cnt - 2) + GetPadovanSequence(cnt - 3);
    return padovanSequenceArr[idx];
}
#endregion 0714
#region 0721
/// <summary>
/// https://www.acmicpc.net/problem/1932
/// </summary>
void Triangle()
{
    int line = int.Parse(Console.ReadLine());
    int[,] inputArr = new int[line, line];
    for(int i = 0; i < line; i++)
    {
        string[] temp = Console.ReadLine().Split();
        for (int j = 0; j < temp.Length; j++)
        {
            inputArr[i,j] = int.Parse(temp[j]);
        }
    }
    int[,] resultArr = new int[line, line];
    for (int i = 0; i < line; i++)
    {
        int idxF = line - i - 1;
        for (int idxS = 0; idxS < line - i; idxS++)
        {
            if (line - i == line)
                resultArr[idxF, idxS] = inputArr[idxF, idxS];
            else
            {
                int max = resultArr[idxF + 1, idxS] > resultArr[idxF + 1, idxS + 1] ? resultArr[idxF + 1, idxS] : resultArr[idxF + 1, idxS + 1];
                resultArr[idxF, idxS] = inputArr[idxF, idxS] + max;
            }
        }
    }
    Console.WriteLine(resultArr[0,0]);
}
/// <summary>
/// https://www.acmicpc.net/problem/1149
/// </summary>
void RGBStreet()
{
    int line = int.Parse(Console.ReadLine());
    //input
    _rgbCostArr = new int[line,3];
    for(int idxF = 0; idxF < line; idxF++)
    {
        string[] temp = Console.ReadLine().Split();
        _rgbCostArr[idxF, 0] = int.Parse(temp[0]);
        _rgbCostArr[idxF, 1] = int.Parse(temp[1]);
        _rgbCostArr[idxF, 2] = int.Parse(temp[2]);
    }

    //fill
    _houseCostArr = new int[line, 3];
    for (int idx = 0; idx < line; idx++)
    {
        if (idx == 0)
        {
            _houseCostArr[idx, 0] = _rgbCostArr[idx, 0];
            _houseCostArr[idx, 1] = _rgbCostArr[idx, 1];
            _houseCostArr[idx, 2] = _rgbCostArr[idx, 2];
        }
        else
        {
            _houseCostArr[idx, 0] = Math.Min(_houseCostArr[idx-1, 1] , _houseCostArr[idx - 1, 2]) + _rgbCostArr[idx, 0];
            _houseCostArr[idx, 1] = Math.Min(_houseCostArr[idx-1, 0] , _houseCostArr[idx - 1, 2]) + _rgbCostArr[idx, 1];
            _houseCostArr[idx, 2] = Math.Min(_houseCostArr[idx-1, 0] , _houseCostArr[idx - 1, 1]) + _rgbCostArr[idx, 2];
        }
    }

    //get result
    int[] resultArr = new int[3];
    resultArr[0] = _houseCostArr[line-1, 0];
    resultArr[1] = _houseCostArr[line-1, 1];
    resultArr[2] = _houseCostArr[line-1, 2];

    Console.WriteLine(resultArr.Min());
}
/// <summary>
/// https://www.acmicpc.net/problem/11054
/// </summary>
void LongestBiotonic()
{
    int size = int.Parse(Console.ReadLine());
    int[] numbers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
    int[] numbersForLeft = (int[])numbers.Clone();
    int[] numbersForRight = (int[])numbers.Clone();
    int[] leftSum = new int[size];
    int[] leftCnt = new int[size];
    int[] rightSum = new int[size];
    int[] rightCnt = new int[size];
    for(int idx = 0; idx < size; idx++)
    {
        //left
        if (idx == 0)
            leftCnt[idx] = 1;
        else if (numbersForLeft[idx - 1] < numbersForLeft[idx])
            leftCnt[idx] += 1;
        else
            numbersForLeft[idx] = numbersForLeft[idx - 1];

        //right
        int idxForRight = size - idx - 1;
        if (idxForRight == size-1)
            rightCnt[idxForRight] = 1;
        else if (numbersForRight[idxForRight] > numbersForRight[idxForRight + 1])
            rightCnt[idxForRight] += 1;
        else
            numbersForLeft[idxForRight] = numbersForRight[idxForRight + 1];
    }

    //get result
    int[] result = new int[size];
    for (int idx = 0; idx < size; idx++)
    {
        result[idx] = leftCnt[idx] + rightCnt[idx];
    }
     Console.WriteLine(result.Max());
}
/// <summary>
/// https://www.acmicpc.net/problem/11729
/// </summary>
void HanoiTop()
{

}
#endregion 0721 
#region 20220901 그래프
///<summary>
///https://www.acmicpc.net/problem/24479
///</summary>
void DFS1()
{
    makeGraph();
    //key : 정점, value : 방문순서
    int[] answer = new int[_nodeCnt+1];
    dfs(ref answer);
    for(int idx = 1; idx <= _nodeCnt; idx++)
    {
        Console.WriteLine(answer[idx]);    
    }
}
#region graph
void makeGraph()
{
    int[] input = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
    _nodeCnt = input[0]; //정점의 수
    int M = input[1]; //간선의 수
    int R = input[2]; //시작 정점
    _graph = new Dictionary<int, List<int>>();
    for (int idx = 0; idx < M; idx++)
    {
        input = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
        addGraph(input[0], input[1]);
        addGraph(input[1], input[0]);
    }
}
void addGraph(int key, int value)
{
    if (_graph.ContainsKey(key))
        _graph[key].Add(value);
    else
        _graph.Add(key, new List<int>() { value });
}
#endregion graph
#region dfs 
void dfs(ref int[] answer)// 깊이우선탐색 with _graph, startnode by Stack
{
    int startNode = 1; // 시작 노드
    Queue<int> visited = new(); //방문한 노드
    Stack<int> needVisited = new(); //방문해야 하는 노드

    //for start node
    needVisited.Push(startNode);
    answer[startNode] = 1;

    int count = 1;
    while(needVisited.Count > 0)
    {
        int node = needVisited.Pop();
        if(!visited.Contains(node))
        {
            answer[node] = count;
            visited.Enqueue(node);
            count++;
            var tempList = needVisited.ToList();
            tempList.AddRange(_graph[node]);
            needVisited = new Stack<int>(tempList.ToArray());
        }
    }
}
#endregion dfs
#endregion 20220901
public partial class Program
{
    static int[,,] w;
    static long[] padovanSequenceArr;
    #region RGBStreet
    static int[,] _rgbCostArr;
    static int[,] _houseCostArr;
    #endregion RGBStreet
    #region DFS1
    static int _nodeCnt; //정점의 수
    //key : 정점, value : 연결된 정점들
    static Dictionary<int, List<int>> _graph;
    #endregion DFS1
}