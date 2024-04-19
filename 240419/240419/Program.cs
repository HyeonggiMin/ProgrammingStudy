// 3. 배열 연습

int number1;
int number2;
int number3;

int[] numbers = new int[3]; // 배열의 크기를 정의

// 배열의 초기화1
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

int[] numbers2 = { 4, 5, 6 }; // 배열의 초기화2
int[] numbers3 = new int[3] { 7, 8, 9 }; // 배열의 초기화3

// 배열의 길이
int length = numbers.Length;
Console.WriteLine("배열의 길이: " + numbers.Length);

numbers.Reverse(); // 배열을 역순으로

//불가
/*int[.] array1 = new int[3, 3]
{
    numbers,
    numbers2,
    numbers3;
};*/

int[][] num = new int[3][]
{
    numbers, numbers2, numbers3
};
// int[][] num = {numbers, numbers2, numbers3};
/* {1, 2, 3}
   {4, 5, 6}
   {7, 8, 9}*/
Console.WriteLine(num[0][1]);
Console.WriteLine(num[1][1]);
Console.WriteLine(num[2][1]);

// (3x3)배열의 2차원 선언
int[,] coordinates = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
Console.WriteLine("0,1의 값: " + coordinates[0, 1]);
Console.WriteLine("2,1의 값: " + coordinates[2, 1]);
Console.WriteLine("배열의 길이: " + coordinates.Length);

/* 실습1) 가로 3칸, 세로 2칸의 책꽂이에 문자열형 책 이름을 넣고,
   2번째 쭐의 3번째 칸의 책이름을 출력한다.*/

string[,] bookShelf =
{
    {"책1", "책2", "책3"},
    {"책4", "책5", "책6"}
};
bookShelf[1, 2] = "책60";
Console.WriteLine("1,2의 책 이름: " + bookShelf[1, 2]);

// 실습2) 두 개의 숫자, 연산자를 입력을 받아 4칙 연산 계산기 만들기
/*string strA = Console.ReadLine();
int numberA = int.Parse(strA); // String을 문자열로 변환
Console.WriteLine(name);*/

// 입력 예시
// 3
// +
// 5
// 결과 = 8

Console.WriteLine("첫 번째 숫자를 입력해 주세요.");
string strA = Console.ReadLine();
int numberA = int.Parse(strA);

Console.WriteLine("연산자를 입력해 주세요.(+,-,*./)");
string oper = Console.ReadLine();

Console.WriteLine("두 번째 숫자를 입력해 주세요.");
string strB = Console.ReadLine();
int numberB = int.Parse(strB);
float result = 0;

switch (oper)
{
    case "+":
        result = numberA + numberB;
        break;
    case "-":
        result = numberA - numberB;
        break;
    case "*":
        result = numberA * numberB;
        break;
    case "/":
        result = numberA / (float)numberB; //명시적 형 변환
        break;
}

Console.WriteLine("결과는:" + result + "입니다.");