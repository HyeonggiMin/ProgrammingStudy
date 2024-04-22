/*//5. 컬렉션 연습2

Stack<int> numbers = new Stack<int>();
numbers.Push(10); // 값을 쌓아 올린다.
numbers.Push(100);
numbers.Push(1000);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("--------------");

int peekNumber = numbers.Peek();
Console.WriteLine(peekNumber);

bool isExist = numbers.Contains(100);
if (isExist)
    Console.WriteLine("100이 존재합니다.");

int value = numbers.Pop(); // 쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); // 쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); // 쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

Queue<string> waitingPeople = new Queue<string>();
waitingPeople.Enqueue("민형기");
waitingPeople.Enqueue("김현수");
waitingPeople.Enqueue("양희문");

foreach(string people in waitingPeople)
{
    Console.WriteLine(people);
}

string name  = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);*/

// 실습1. 작업(파워포인트)을 되돌리기 상태로 만들어주는 예제
// 1. 특정 횟수 만큼 파워포인트 각 작업 반복해서 넣고
// 2. (넣는 과정이 끝나면) 1번 입력(되돌리기 버튼)을 누를 경우
// 되돌리기 작업과 현재 진행된 작업의 이름을 Stack에 쌓인 순서대로 출력

// PPT 작업 리스트 입력 예시
// 1. 삽입 메뉴 클릭
// 2. 표 아이콘 클릭
// 3. 표 크기 설정 및 표 생성
// 4. 0,0에 안녕하세요 입력 
// 5. 0,1에 반갑습니다 입력
// 6. 0,2에 저는 민형기입니다 입력

// 입출력 예시
// "명령을 입력해 주세요. 되돌리기(1)을 입력해주세요." 
// 1번(Undo) 클릭
// 0,2에 저는 민형기입니다 입력 <- POP
// 0,1에 반갑습니다 입력
// 0,0에 안녕하세요 입력 
// 표 크기 설정 및 표 생성
// 표 아이콘 클릭
// 삽입 메뉴 클릭

/*Stack<string> jobs = new Stack<string>();
Console.WriteLine("< Jobs List >");
jobs.Push("1.삽입 메뉴 클릭");
jobs.Push("2. 표 아이콘 클릭");
jobs.Push("3. 표 크기 설정 및 표 생성");
jobs.Push("4. 0,0에 안녕하세요 입력");
jobs.Push("5. 0,1에 반갑습니다 입력");
jobs.Push("6. 0,2에 저는 민형기입니다 입력");

foreach (string job in jobs)
{
    Console.WriteLine(job);
}

Console.WriteLine("--------------------------------");

for (int i = 0; i < jobs.Count;)
{
    Console.WriteLine("jobs Count: " + jobs.Count);
    Console.WriteLine("명령을 입력해 주세요. 되돌리기(1)을 입력해주세요.");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("아래 명령을 되돌렸습니다.");
        Console.WriteLine(jobs.Peek());
      
        jobs.Pop();

        Console.WriteLine("< Jobs List >");

        foreach (string newJob in jobs)
        {
            Console.WriteLine(newJob);
        }
    }
}*/

/* 실습 2 - Queue
 * 도서관 대출자 대기열
 * 1. 대출자 대기열에 맞춰 대출자의 이름과 도서의 이름을 대기열(Queue)에 등록
 * 2. 도서관 직원이 대기열에 맞춰 대출목록에 업데이트
 * 
 * 입출력 예시
 * "대출자 이름을 입력해 주세요."
 * 민형기
 * "도서 권수를 입력해 주세요."
 * 2
 * "대출을 위한 도서 목록을 입력해 주세요."
 * 퓨처셀프
 * "대출을 위한 도서 목록을 입력해 주세요."
 * 삼국지
 * 
 * Queue에 들어갈 내용 -> 이름: 민형기\도서1. 퓨처셀프\n도서2. 삼국지
 * 
 * "도서가 등록되었습니다."
 * 이름: 민형기
 * 도서1: 퓨처셀프
 * 도서2: 삼국지
 * 
 * 
 */

Queue<string> libraryQueue = new Queue<string>();
string totalInfo = "";

Console.WriteLine("대출자 이름을 입력해 주세요.");
string name = Console.ReadLine();
Console.WriteLine("도서 권수를 입력해 주세요.");
string bookNumber = Console.ReadLine();
int count = int.Parse(bookNumber);

totalInfo = name + "\n" + count + "\n";

for(int i = 0; i < count; i++)
{
    Console.WriteLine("대출을 위한 도서 목록을 입력해 주세요.");
    string bookName = Console.ReadLine();
    totalInfo += totalInfo + "\n";
}

Console.WriteLine("입력된 내용은 아래와 같습니다.");
Console.WriteLine(totalInfo);
libraryQueue.Enqueue(totalInfo);

/* 도서관 직원이 내용 확인 후 시스템에 입력.
 * 
 * 최종실습 도서관 시스템
 * 1. 도서 검색
 * 2. 도서 입력
 * 3. 도서 반납 리스트
 * 4. 대출 리스트
 */