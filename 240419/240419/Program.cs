// 4. 컬렉션 연습

//배열: 고정형
string[] names = { "민형기", "김현수", "양희문" };

//리스트: 가변형
List<string> names2 = new List<string>()
{
    "민형기",
    "김현수",
    "양희문"
};

Console.WriteLine(names[0]);
Console.WriteLine(names2[0]);
names2.Add("장재원");
Console.WriteLine(names2[3]);

// 배열의 반복
for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// 리스트의 반복
for(int i = 0;i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}

// 리스트에서 이름 찾기
int index = names2.IndexOf("양희문");
Console.WriteLine("양희문은 " + index + "번째에 있습니다.");

// 존재 여부 확인
bool isExist = names2.Contains("민형기");
if (isExist)
    Console.WriteLine("존재합니다");

//리스트를 정렬
names2.Sort();
for(int i = 0; i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}

//딕셔너리: "example"(key), 5번째(value)
Dictionary<string,int> dicionary = new Dictionary<string, int>();
dicionary.Add("book", 0);
dicionary.Add("computer", 1);
dicionary.Add("mouse", 2);

index = dicionary["mouse"];
Console.WriteLine("mouse는 " + index + "번째에 있습니다.");
bool isContain = dicionary.ContainsKey("book");
if (isContain)
    Console.WriteLine("book이 존재합니다.");

// 실습
// 1.도서관에 가로 3칸, 세로 2층의 책꽂이가 있습니다.
// (미리 책꽂이에 책들을 꽂아놓은 상태)
// 2. 특정 책의 이름을 입력받아 책의 일련번호(위치)를
// 출력하는 책꽂이 시스템을 만드세요.

// 예시
// 도서의 이름을 입력해 주세요.
// _
// 도서의 위치는 (3,2) 입니다.

// 오른쪽 버튼을 눌러주세요. 등록(0), 검색(1), 제거(2)
// 0
// 삼국지
// 3,5
// 오른쪽 버튼을 눌러주세요. 등록(0), 검색(1), 제거(2)
// 1
// 삼국지
// 3,5

Dictionary<string, string> library = new Dictionary<string, string>();
library.Add("책1", "1,1");
library.Add("책2", "1,2");
library.Add("책3", "1,3");
library.Add("책4", "2,3");
library.Add("책5", "2,3");
library.Add("책6", "2,3");

Console.WriteLine("도서의 이름을 입력해 주세요.");
string bookName = Console.ReadLine();
string location = library[bookName];
Console.WriteLine("도서의 위치는 " + location + "입니다.");
