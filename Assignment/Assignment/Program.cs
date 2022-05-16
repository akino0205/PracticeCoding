// See https://aka.ms/new-console-template for more information

using System.Collections;
Console.WriteLine("================ Select Number! ================");
Console.WriteLine("1.백준 14719 빗물");
Console.WriteLine("2.백준 9498 시험 성적");
Console.WriteLine("3.백준 2753 윤년");
switch (Console.ReadLine())
{
    case "1": RainWaterSum(); break;
    case "2": ExamResult(); break;
    case "3": IsLeapYear(); break;
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

