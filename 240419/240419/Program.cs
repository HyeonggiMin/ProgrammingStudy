// 1. 공부내용1
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); // 한줄 주석: Ctrl+K+C
Console.WriteLine("Hello, World!"); // 한줄 주석 해제: Ctrl+K+U
Console.WriteLine("Hello, World!"); // 영역 주석 & 주석 해제: Ctrl+Shift+/

// 변수의 이름은 명사, 형용사
int countNumber = 0; // camelCase
int a = 10; //(나쁜 예) 변수의 의미는 00입니다.
int totalNumber = 10;
bool isActive = true;

//함수의 이름은 동사
//함수(function): 클래스 외에서 사용시
//메서드(method): 클래스 내부에서 사용시
void Move()
{

}

void RotateHouse()
{

}
void LoopSystem() // PascalCase
{
    for (int i = 0; i < a; i++)
    {
        countNumber++;
    }
    for (int i = 0; i < totalNumber; i++)
    {
        countNumber++;
    }
}

if (countNumber == 0)
{
    countNumber = 1;

    LoopSystem();

    if (countNumber == 1)
    {

    }
}