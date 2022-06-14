// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Text;
#region Console write
Console.WriteLine("================ Select Number! ================");
Console.WriteLine("1-1.백준 14719 빗물");
Console.WriteLine("================     조건문     ================");
Console.WriteLine("2-1.백준 9498 시험 성적");
Console.WriteLine("2-2.백준 2753 윤년");
Console.WriteLine("2-3.백준 14681 사분면고르기");
Console.WriteLine("2-4.백준 2525 오븐시계");
Console.WriteLine("2-5.백준 2480 주사위 세개");
Console.WriteLine("================     반복문     ================");
Console.WriteLine("3-1.백준 2741 N찍기");
Console.WriteLine("3-2.백준 2742 기찍 N");
Console.WriteLine("3-3.백준 11021 A+B - 7");
Console.WriteLine("3-4.백준 11022 A+B - 8");
Console.WriteLine("3-5.백준 2438 별찍기 - 1");
Console.WriteLine("3-6.백준 2439 별찍기 - 2");
Console.WriteLine("3-7.백준 10871 X보다 작은 수");
Console.WriteLine("================     1차원 배열     ================");
Console.WriteLine("5-1.백준 10818 최소, 최대");
Console.WriteLine("5-2.백준 2562 최댓값");
Console.WriteLine("5-3.백준 2577 숫자의 개수");
Console.WriteLine("5-4.백준 3052 나머지");
Console.WriteLine("================     함수     ================");
Console.WriteLine("6-1.백준 4673 셀프 넘버");
Console.WriteLine("6-2.백준 1065 한수");
Console.WriteLine("================     문자열     ================");
Console.WriteLine("4-1.백준 11654 아스키 코드");
Console.WriteLine("4-2.백준 11720 숫자의 합");
Console.WriteLine("4-3.백준 10809 알파벳 찾기");
Console.WriteLine("4-4.백준 2675 문자열 반복");
Console.WriteLine("4-5.백준 1157 단어 공부");
Console.WriteLine("4-6.백준 1152 단어의 개수");
Console.WriteLine("4-7.백준 9012 괄호");
Console.WriteLine("4-8.백준 5622 다이얼");
Console.WriteLine("4-8.백준 2941 크로아티아알파벳");
#endregion Console write

switch (Console.ReadLine())
{
    #region -06.02
    case "1-1": RainWaterSum(); break;
    case "2-1": ExamResult(); break;
    case "2-2": IsLeapYear(); break;
    case "2-3": WhichQuadrant(); break;
    case "2-4": OvenWatch(); break;
    case "2-5": ThreeDice(); break;
    case "3-1": WriteN(); break;
    case "3-2": WriteNReverse(); break;
    case "3-3": WriteSum7(); break;
    case "3-4": WriteSum8(); break;
    case "3-5": WriteStars(); break;
    case "4-1": AsciiCode(); break;
    case "4-2": SumNumbers(); break;
    case "4-3": FindAlphabet(); break;
    case "4-4": RepeatString(); break;
    case "4-5": StudyWord(); break;
    case "4-6": WordCount(); break;
    case "4-7": ParenthesisString(); break;
    #endregion -06.02
    #region -06.09
    case "3-6": WriteStars2(); break;
    case "3-7": LessThanX(); break;
    case "5-1": MinMax(); break;
    case "5-2": Max(); break;
    case "5-3": NumberCount(); break;
    case "5-4": Remainder42(); break;
    case "6-1": SelfNumber(); break;
    #endregion -06.09
    case "6-2": HanSu(); break;
    case "4-8": Dial(); break;
    case "4-9": CroatiaAlphabet(); break;
    default: break;
}
/// <summary>
/// 백준 14719 빗물
/// </summary>
void RainWaterSum()
{
    Console.WriteLine("================ 백준 14719 빗물 ================");
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
    int rainwater = 0;

    string[] hw = Console.ReadLine().Split();
    int height = int.Parse(hw[0]); //2차원 세계의 세로 길이
    int width = int.Parse(hw[1]); //2차원 세계의 가로 길이

    string[] blockStr = Console.ReadLine().Split();
    int[] blocks = blockStr.Select(s => int.Parse(s)).ToArray();

    for (int tower = 1; tower < width - 1; tower++)
    {
        int maxL = blocks[0..tower].Max();
        int maxR = blocks[tower..width].Max();
        int minH = Math.Min(maxL, maxR);
        if (minH > blocks[tower])
            rainwater += minH - blocks[tower];
    }

    Console.WriteLine(rainwater);
}
#region 조건문
/// <summary>
/// 백준 9498 시험 성적 : 
/// 시험 점수를 입력받아
/// 90 ~ 100점은 A,
/// 80 ~ 89점은 B,
/// 70 ~ 79점은 C,
/// 60 ~ 69점은 D,
///나머지 점수는 F를 출력하는 프로그램을 작성하시오.
/// </summary>
void ExamResult()
{
    Console.WriteLine("================ 백준 9498 시험 성적 ================");
    //시험 점수를 입력받아
    //90 ~ 100점은 A,
    //80 ~ 89점은 B,
    //70 ~ 79점은 C,
    //60 ~ 69점은 D,
    //나머지 점수는 F를 출력하는 프로그램을 작성하시오.
    int score = int.Parse(Console.ReadLine());
    string grade = string.Empty;
    if (score >= 90) grade = "A";
    else if (score >= 80) grade = "B";
    else if (score >= 70) grade = "C";
    else if (score >= 60) grade = "D";
    else grade = "F";

    Console.WriteLine(grade);
}
/// <summary>
/// 백준 2753 윤년 : 
/// 연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.
/// 윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.
/// 예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다. 
/// 1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다. 
/// 하지만, 2000년은 400의 배수이기 때문에 윤년이다.
/// </summary>
void IsLeapYear()
{
    int inputYear = int.Parse(Console.ReadLine());

    bool isLeapYear = ((inputYear%4 == 0) && (inputYear%100 != 0)) || inputYear%400 == 0;

    Console.WriteLine(isLeapYear ? "1" : "0");

}
/// <summary>
/// 백준 14681 사분면고르기
/// : 점의 좌표를 입력받아 그 점이 어느 사분면에 속하는지 알아내는 프로그램을 작성하시오. 단, x좌표와 y좌표는 모두 양수나 음수라고 가정한다.
/// </summary>
void WhichQuadrant()
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int quadrant = 0;
    if (x > 0 )
    {
        if (y > 0) quadrant = 1;
        else quadrant = 4;
    }
    else
    {
        if (y > 0) quadrant = 2;
        else quadrant = 3;
    }
    Console.WriteLine(quadrant);
}
/// <summary>
/// 백준 2525 오븐시계
/// : 훈제오리구이를 시작하는 시각과 오븐구이를 하는 데 필요한 시간이 분단위로 주어졌을 때, 오븐구이가 끝나는 시각을 계산하는 프로그램을 작성하시오.
/// 입력 : 첫째 줄에는 현재 시각이 나온다. 현재 시각은 시 A (0 ≤ A ≤ 23) 와 분 B (0 ≤ B ≤ 59)가 정수로 빈칸을 사이에 두고 순서대로 주어진다. 두 번째 줄에는 요리하는 데 필요한 시간 C (0 ≤ C ≤ 1,000)가 분 단위로 주어진다. 
/// 출력 : 첫째 줄에 종료되는 시각의 시와 분을 공백을 사이에 두고 출력한다. (단, 시는 0부터 23까지의 정수, 분은 0부터 59까지의 정수이다. 디지털 시계는 23시 59분에서 1분이 지나면 0시 0분이 된다.)
/// </summary>
void OvenWatch()
{
    string[] timeStr = Console.ReadLine().Split();
    int hourNow = int.Parse(timeStr[0]);
    int minuteNow = int.Parse(timeStr[1]);
    int cookingMinute = int.Parse(Console.ReadLine());
    minuteNow += cookingMinute;

    int finishMinute = minuteNow % 60;
    int finishHour = hourNow + minuteNow / 60;

    Console.WriteLine($"{finishHour%24} {finishMinute}");
}
/// <summary>
/// 백준 2480 주사위 세개
/// : 1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다. 
/// 1. 같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다. 
/// 2. 같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다. 
/// 3. 모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.  
/// </summary>
void ThreeDice()
{
    string[] temp = Console.ReadLine().Split();
    int dice1 = int.Parse(temp[0]);
    int dice2 = int.Parse(temp[1]);
    int dice3 = int.Parse(temp[2]);
    int reward;
    if (dice1 == dice2 && dice2 == dice3)
        reward = 10000 + dice1 * 1000;
    else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
    {
        int spots = dice1 == dice2 || dice1 == dice3 ? dice1 : dice2;
        reward = 1000 + spots * 100;
    }
    else
    {
        int max = dice1 > dice2 ? dice1 : dice2;
        max = max > dice3 ? max : dice3;
        reward = max * 100;
    }
    Console.WriteLine(reward);
}
#endregion 조건문
#region 반복문
/// <summary>
/// 백준 2741 N찍기
/// : 자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
/// 시간 제한 1초, 메모리 제한 128MB
/// </summary>
void WriteN()
{
    int inputN = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = 1; i <= inputN; i++)
    {
        sb.AppendLine(i.ToString());
    }
    Console.Write(sb.ToString());
}
/// <summary>
/// 백준 2742 기찍 N
/// : 자연수 N이 주어졌을 때, N부터 1까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
/// 시간 제한 1초, 메모리 제한 128MB
/// </summary>
void WriteNReverse()
{
    int inputN = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = inputN; i > 0; i-- )
    {
        sb.AppendLine(i.ToString());
    }
    Console.Write(sb.ToString());
}
/// <summary>
/// 백준 11021 A+B - 7
///: 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
/// 입력 : 첫째 줄에 테스트 케이스의 개수 T가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
///시간 제한 1초, 메모리 제한 256MB
/// </summary>
void WriteSum7()
{
    int count = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = 1; i <= count; i++)
    {
        string[] num = Console.ReadLine().Split();
        sb.AppendLine($"Case #{i}: {int.Parse(num[0]) + int.Parse(num[1])}");
    }
    Console.Write(sb.ToString());
}
/// <summary>
/// 백준 11022 A+B - 8
///: 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
/// 입력 : 첫째 줄에 테스트 케이스의 개수 T가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
///시간 제한 1초, 메모리 제한 256MB
/// </summary>
void WriteSum8()
{
    int count = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for (int i = 1; i <= count; i++)
    {
        string[] num = Console.ReadLine().Split();
        sb.AppendLine($"Case #{i}: {num[0]} + {num[1]} = {int.Parse(num[0]) + int.Parse(num[1])}");
    }
    Console.Write(sb.ToString());
}
/// <summary>
/// 3-5.백준 2438 별찍기 - 1
/// : 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
/// 시간 제한 1초 메모리제한 128MB
/// </summary>
void WriteStars()
{
    int inputN = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = 1; i <= inputN; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            sb.Append("*");
        }
        sb.Append("\n");
    }
    Console.WriteLine(sb.ToString());
}
/// <summary>
/// 3-6. 백준 2439 별찍기 - 2 
/// 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제.
/// 하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.
/// </summary>
void WriteStars2()
{
    int lines = int.Parse(Console.ReadLine());
    StringBuilder sb = new();
    for(int line = 1; line <= lines; line++)
    {
        for(int space= 1; space <= lines - line; space++)
        {
            sb.Append(" ");
        }
        for (int star = 1; star <= line; star++)
        {
            sb.Append("*");
        }
        sb.Append("\n");
    }
    Console.Write(sb.ToString());
}
/// <summary>
/// 3-7.백준 10871 X보다 작은 수
/// 정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
/// </summary>
void LessThanX()
{
    string[] temp = Console.ReadLine().Split();
    int N = int.Parse(temp[0]);
    int X = int.Parse(temp[1]);
    int[] numbers = Console.ReadLine().Split().Select( s=> int.Parse(s)).ToArray();
    StringBuilder sb = new();
    foreach(var num in numbers)
    {
        if (num < X) sb.Append(num + " ");
    }
    Console.WriteLine(sb.ToString().Trim());
}
#endregion 반복문
#region 1차원 배열
/// <summary>
/// 5-1.백준 10818 최소, 최대
/// N개의 정수가 주어진다. 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오.
/// </summary>
void MinMax()
{
    int count = int.Parse(Console.ReadLine());
    int[] numbers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
    Console.Write($"{numbers.Min()} {numbers.Max()}");
}
/// <summary>
/// 5-2.백준 2562 최댓값
/// 9개의 서로 다른 자연수가 주어질 때, 이들 중 최댓값을 찾고 그 최댓값이 몇 번째 수인지를 구하는 프로그램을 작성하시오.
/// 예를 들어, 서로 다른 9개의 자연수
/// 3, 29, 38, 12, 57, 74, 40, 85, 61
/// 이 주어지면, 이들 중 최댓값은 85이고, 이 값은 8번째 수이다.
/// </summary>
void Max()
{
    int[] numbers = new int[9];
    for(int i = 0; i < 9; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }
    int max = numbers.Max();
    int index = Array.IndexOf(numbers, max);
    Console.WriteLine($"{max}\n{index+1}");
}
/// <summary>
/// 5-3.백준 2577 숫자의 개수
/// 세 개의 자연수 A, B, C가 주어질 때 A × B × C를 계산한 결과에 0부터 9까지 각각의 숫자가 몇 번씩 쓰였는지를 구하는 프로그램을 작성하시오.
/// 예를 들어 A = 150, B = 266, C = 427 이라면 A × B × C = 150 × 266 × 427 = 17037300 이 되고, 계산한 결과 17037300 에는 0이 3번, 1이 1번, 3이 2번, 7이 2번 쓰였다.
/// </summary>
void NumberCount()
{
    int[] numbers = new int[3];
    for (int i = 0; i < 3; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }
    int result = numbers[0] * numbers[1] * numbers[2];

    int[] numberCount = new int[10];
    foreach(var numChar in result.ToString())
    {
        numberCount[int.Parse(numChar.ToString())] += 1;
    }
    foreach(var count in numberCount)
    {
        Console.WriteLine(count);
    }
}
/// <summary>
/// 5-4.백준 3052 나머지
/// 두 자연수 A와 B가 있을 때, A%B는 A를 B로 나눈 나머지 이다. 예를 들어, 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0, 2이다. 
/// 수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.
/// </summary>
void Remainder42()
{
    int[] remainders = new int[10];
    for (int i = 0; i < 10; i++)
    {
        remainders[i] = -1;
    }

    int count = 1;
    for (int i = 0; i < 10; i++)
    {
        int num = int.Parse(Console.ReadLine());
        int current = num % 42;
        if (i != 0)
        {
            if (!remainders.Contains(current))
                count++;
        }
        remainders[i] = current;
    }
    Console.WriteLine(count);
}
#endregion 1차원 배열
#region 함수
/// <summary>
/// 6-1.백준 4673 셀프 넘버 
/// </summary>
void SelfNumber()
{
    bool[] nonSelfNumbers = new bool[10001];

    for (int i = 1; i < nonSelfNumbers.Length; i++)
    {
        int result = d(i);
        if (result < 10001)
            nonSelfNumbers[result] = true;
    }
    for (int i = 1;i < nonSelfNumbers.Length; i++)
    {
        if(!nonSelfNumbers[i])
            Console.WriteLine(i);
    }
}
int d(int number)
{     
    foreach(var numChar in number.ToString())
    {
        number += int.Parse(numChar.ToString());
    }
    return number;
}
/// <summary>
/// 6-2.백준 1065 한수
/// </summary>
void HanSu()
{
    int num = int.Parse(Console.ReadLine());
    if(num < 100)
        Console.WriteLine(num);
    else
    {
        int hansu = 99;
        for(int currentNum = 100; currentNum <= num; currentNum++)
        {
            int hundred = currentNum / 100;
            int ten = currentNum / 10 % 10;
            int one = currentNum % 10;
            if ((hundred - ten) == (ten - one))
                hansu++;
        }
        Console.WriteLine(hansu);
    }
}
#endregion 함수
#region 문자열
/// <summary>
/// 백준 11654 아스키 코드
/// : 알파벳 소문자, 대문자, 숫자 0-9중 하나가 주어졌을 때, 주어진 글자의 아스키 코드값을 출력하는 프로그램을 작성하시오.
/// </summary>
void AsciiCode()
{
    char inputChar = char.Parse(Console.ReadLine());
    Console.Write((byte)inputChar);
}
/// <summary>
/// 백준 11720 숫자의 합
/// : N개의 숫자가 공백 없이 쓰여있다. 이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.
/// 입력 : 첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다. 둘째 줄에 숫자 N개가 공백없이 주어진다.
/// </summary>
void SumNumbers()
{
    int count = int.Parse(Console.ReadLine());
    var input = Console.ReadLine().ToArray();
    int result = 0;
    foreach(char numChar in input)
    {
        result += int.Parse(numChar.ToString());
    }
    Console.Write(result);
}
/// <summary>
/// 백준 10809 알파벳 찾기
/// : 알파벳 소문자로만 이루어진 단어 S가 주어진다. 각각의 알파벳에 대해서, 단어에 포함되어 있는 경우에는 처음 등장하는 위치를, 포함되어 있지 않은 경우에는 -1을 출력하는 프로그램을 작성하시오.
/// </summary>
void FindAlphabet()
{
    string word = Console.ReadLine();
    int a = 97;
    int z = 122;
    int size = z - a + 1;
    int[] alphabetArr = new int[size];
    for (int i = 0; i < size; i++) alphabetArr[i] = -1;
    foreach(var item in word.Select( (item, seq) => new { Letter = item, Seq = seq}))
    {
        int alphabetArrSeq = item.Letter - a;
        if (alphabetArr[alphabetArrSeq] == -1)
            alphabetArr[alphabetArrSeq] = item.Seq;
    }
    Console.Write(String.Join(" ", alphabetArr));
}
/// <summary>
/// 2675 문자열 반복
/// : 문자열 S를 입력받은 후에, 각 문자를 R번 반복해 새 문자열 P를 만든 후 출력하는 프로그램을 작성하시오. 
/// 즉, 첫 번째 문자를 R번 반복하고, 두 번째 문자를 R번 반복하는 식으로 P를 만들면 된다. 
/// S에는 QR Code "alphanumeric" 문자만 들어있다. 
/// QR Code "alphanumeric" 문자는 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\$%*+-./: 이다.
/// </summary>
void RepeatString()
{
    int caseCount = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < caseCount; i++)
    {
        string[] input = Console.ReadLine().Split();
        int repeatCount = int.Parse(input[0]);
        foreach(var letter in input[1])
        {
            for (int j = 0; j < repeatCount; j++) sb.Append(letter);
        }
        sb.Append("\n");
    }
    Console.WriteLine(sb.ToString());
}
/// <summary>
/// 백준 1157 단어 공부
/// : 알파벳 대소문자로 된 단어가 주어지면, 이 단어에서 가장 많이 사용된 알파벳이 무엇인지 알아내는 프로그램을 작성하시오. 
/// 단, 대문자와 소문자를 구분하지 않는다.
/// 입력 : 첫째 줄에 알파벳 대소문자로 이루어진 단어가 주어진다. 주어지는 단어의 길이는 1,000,000을 넘지 않는다.
/// 출력 : 첫째 줄에 이 단어에서 가장 많이 사용된 알파벳을 대문자로 출력한다. 단, 가장 많이 사용된 알파벳이 여러 개 존재하는 경우에는 ?를 출력한다.
/// </summary>
void StudyWord()
{
    string inputUpperWord = Console.ReadLine().ToUpper();
    Dictionary<char, int> letterDic = inputUpperWord.GroupBy(g => g).ToDictionary( k=> k.Key, v => v.Count());
    var maxCount = letterDic.Max(m => m.Value);
    var maxLetters = letterDic.Where(w => w.Value.Equals(maxCount));
    if (maxLetters.Count() > 1) Console.WriteLine("?");
    else Console.WriteLine(maxLetters.SingleOrDefault().Key);
}
/// <summary>
/// 백준 1152 단어의 개수
///  : 영어 대소문자와 공백으로 이루어진 문자열이 주어진다. 
///  이 문자열에는 몇 개의 단어가 있을까? 이를 구하는 프로그램을 작성하시오. 
///  단, 한 단어가 여러 번 등장하면 등장한 횟수만큼 모두 세어야 한다.
///  (주의) 입력에서 공백이 연속해서 나오는 경우는 없다고 하나, 채점기준에서는 공백이 연속으로 나오는 경우도 함께 채점됨. 
/// </summary>
void WordCount()
{
    string[] input = Console.ReadLine().Trim().Split();
    string[] exceptBlank = input.Where(w => !w.Equals(string.Empty)).ToArray();
    Console.WriteLine(exceptBlank.Count());
}
/// <summary>
/// 백준 9012 괄호 
/// : 괄호 문자열(Parenthesis String, PS)은 두 개의 괄호 기호인 ‘(’ 와 ‘)’ 만으로 구성되어 있는 문자열이다. 
/// 그 중에서 괄호의 모양이 바르게 구성된 문자열을 올바른 괄호 문자열(Valid PS, VPS)이라고 부른다. 
/// 한 쌍의 괄호 기호로 된 “( )” 문자열은 기본 VPS 이라고 부른다. 
/// 만일 x 가 VPS 라면 이것을 하나의 괄호에 넣은 새로운 문자열 “(x)”도 VPS 가 된다. 
/// 그리고 두 VPS x 와 y를 접합(concatenation)시킨 새로운 문자열 xy도 VPS 가 된다. 
/// 예를 들어 “(())()”와 “((()))” 는 VPS 이지만 “(()(”, “(())()))” , 그리고 “(()” 는 모두 VPS 가 아닌 문자열이다. 
/// 여러분은 입력으로 주어진 괄호 문자열이 VPS 인지 아닌지를 판단해서 그 결과를 YES 와 NO 로 나타내어야 한다. 
/// </summary>
void ParenthesisString()
{
    int caseCount = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    for(int seq = 0; seq < caseCount; seq++)
    {
        string ps = Console.ReadLine();
        int checkInt = 0;
        bool isVPS = true;
        foreach(var str in ps)
        {
            checkInt = str.Equals('(') ? checkInt+1 : checkInt-1;
            if (checkInt < 0)
            {
                isVPS = false; 
                break;
            }
        }
        isVPS = checkInt == 0 ? true : false;
        sb.Append(isVPS ? "YES" : "NO");
        sb.Append("\n");
    }
    Console.WriteLine(sb.ToString());
}
/// <summary>
/// 백준 5622 다이얼 : 
/// </summary>
void Dial()
{
    string word = Console.ReadLine();
    int second = 0;
    int A = 65;
    int[] SVYZ = { 83, 86, 89, 90 };
    foreach(char item in word)
    {
        int additionSecond = (item - A) / 3 + 3;
        if (SVYZ.Contains(item))
            additionSecond -= 1;
        second += additionSecond;
    }
    Console.WriteLine(second);
}
/// <summary>
/// 백준 2941 크로아티아알파벳 :
/// </summary>
void CroatiaAlphabet()
{
    string croatiaWords = Console.ReadLine();
    string[] countOneArr = {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
    foreach(var item in countOneArr)
    {
        croatiaWords = croatiaWords.Replace(item, "#");
    }
    Console.WriteLine(croatiaWords.ToCharArray().Count());
}
#endregion 문자열



