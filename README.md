HTSV: Nguyễn Khải Hoàn 
MSV: 24810320086
Câu 1. Phân biệt Value Types và Reference Types

Trong C#, kiểu dữ liệu được chia thành hai nhóm chính:

* **Value Types (kiểu giá trị)**
* **Reference Types (kiểu tham chiếu)**

 1. Value Types

Value Type lưu **trực tiếp giá trị của biến**.

Một số kiểu thường gặp:

```text
int
float
double
bool
char
struct
enum
```

Ví dụ:

```csharp
int a = 10;
int b = a;

b = 20;
```

Kết quả:

```text
a = 10
b = 20
```

`b` nhận một bản sao của giá trị `a`, vì vậy thay đổi `b` không làm thay đổi `a`.

### 2. Reference Types

Reference Type lưu **tham chiếu đến một đối tượng**.

Một số kiểu thường gặp:

```text
class
array
string
object
```

Ví dụ:

```csharp
class Student
{
    public string Name;
}

Student s1 = new Student();
s1.Name = "Hoan";

Student s2 = s1;
s2.Name = "Nam";
```

Kết quả:

```text
s1.Name = Nam
s2.Name = Nam
```

Nguyên nhân là `s1` và `s2` cùng tham chiếu đến một đối tượng.

### So sánh

| Đặc điểm            | Value Type                        | Reference Type                       |
| ------------------- | --------------------------------- | ------------------------------------ |
| Cách lưu            | Lưu trực tiếp giá trị             | Lưu tham chiếu đến đối tượng         |
| Vùng nhớ thường gặp | Stack khi là biến cục bộ          | Đối tượng thường nằm trên Heap       |
| Khi gán             | Sao chép giá trị                  | Sao chép tham chiếu                  |
| Ví dụ               | `int`, `double`, `bool`, `struct` | `class`, `array`, `string`, `object` |

> **Lưu ý:** Không nên hiểu tuyệt đối rằng Value Type luôn nằm trên Stack và Reference Type luôn nằm trên Heap. Vị trí thực tế còn phụ thuộc vào cách biến được sử dụng và cơ chế thực thi của .NET.

---

## Câu 2. Init-only Properties (`init`) và `set`

### 1. `set` thông thường

`set` cho phép thuộc tính được thay đổi sau khi đối tượng đã được tạo.

```csharp
class Student
{
    public string Name { get; set; }
}

Student sv = new Student();

sv.Name = "Hoan";
sv.Name = "Nam";
```

Giá trị `Name` có thể thay đổi nhiều lần.

### 2. `init`

`init` được giới thiệu từ **C# 9**.

Nó cho phép thiết lập giá trị trong quá trình khởi tạo đối tượng nhưng không cho phép gán lại sau khi đối tượng đã được khởi tạo.

```csharp
class Student
{
    public string Name { get; init; }
    public int Age { get; init; }
}

Student sv = new Student
{
    Name = "Hoan",
    Age = 20
};
```

Sau khi khởi tạo:

```csharp
sv.Name = "Nam"; // Lỗi
```

### So sánh

| `set`                            | `init`                             |
| -------------------------------- | ---------------------------------- |
| Có thể gán khi khởi tạo          | Có thể gán khi khởi tạo            |
| Có thể thay đổi sau khi khởi tạo | Không thể gán lại sau khi khởi tạo |
| Phù hợp với dữ liệu cần cập nhật | Phù hợp với dữ liệu cần cố định    |

### Trường hợp sử dụng thực tế

`init` phù hợp với những thông tin chỉ cần thiết lập một lần, ví dụ:

```csharp
class User
{
    public int Id { get; init; }
    public string Username { get; init; }
}

User user = new User
{
    Id = 1001,
    Username = "hoan"
};
```

Các thông tin như `Id` hoặc `Username` có thể được thiết lập lúc tạo tài khoản và hạn chế việc thay đổi ngoài ý muốn sau đó.

---

## Câu 3. `virtual` và `override` trong tính đa hình

`virtual` và `override` được sử dụng để triển khai **Polymorphism – tính đa hình** trong C#.

### 1. `virtual` ở lớp cha

`virtual` cho phép phương thức của lớp cha được lớp con ghi đè.

```csharp
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Dong vat phat ra am thanh");
    }
}
```

### 2. `override` ở lớp con

`override` được sử dụng để thay đổi cách thực hiện phương thức `virtual` của lớp cha.

```csharp
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cho sua gau gau");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Meo keu meo meo");
    }
}
```

### 3. Thể hiện tính đa hình

```csharp
Animal a1 = new Dog();
Animal a2 = new Cat();

a1.Sound();
a2.Sound();
```

Kết quả:

```text
Cho sua gau gau
Meo keu meo meo
```

Mặc dù `a1` và `a2` có kiểu khai báo là `Animal`, chương trình vẫn gọi phương thức tương ứng với đối tượng thực tế.

### So sánh

| `virtual`                 | `override`                   |
| ------------------------- | ---------------------------- |
| Được khai báo ở lớp cha   | Được khai báo ở lớp con      |
| Cho phép ghi đè           | Thực hiện ghi đè             |
| Cung cấp hành vi mặc định | Thay đổi hành vi của lớp cha |
| Là cơ sở cho đa hình      | Thể hiện đa hình ở lớp con   |

**Tóm lại:**

```text
Lớp cha
   ↓
virtual
   ↓
Lớp con
   ↓
override
```

---

## Câu 4. Tại sao `static` không thể truy xuất thông qua Object Instance?

`static` có nghĩa là thành phần đó **thuộc về Class**, không thuộc về từng Object.

Ví dụ:

```csharp
class Student
{
    public static string School = "EPU";

    public string Name;
}
```

Tạo một đối tượng:

```csharp
Student sv = new Student();
```

`Name` là thuộc tính của từng đối tượng nên có thể truy cập:

```csharp
sv.Name = "Hoan";
```

Trong khi đó `School` là thành phần `static`, nên phải truy cập thông qua tên lớp:

```csharp
Student.School
```

### Vì sao?

Giả sử có nhiều đối tượng:

```csharp
Student sv1 = new Student();
Student sv2 = new Student();
Student sv3 = new Student();
```

`School` vẫn chỉ có **một thành phần dùng chung** cho toàn bộ lớp:

```text
              Student
                 |
          static School
                 |
      +----------+----------+
      |          |          |
     sv1        sv2        sv3
```

Vì vậy:

```csharp
Student.School
```

là cách truy cập đúng.

### Ví dụ đầy đủ

```csharp
class Student
{
    public static string School = "EPU";

    public string Name;
}

class Program
{
    static void Main()
    {
        Student sv = new Student();

        sv.Name = "Hoan";

        Console.WriteLine(sv.Name);
        Console.WriteLine(Student.School);
    }
}
```

Kết quả:

```text
Hoan
EPU
```

### Kết luận

* Thành phần **không `static`** → thuộc về từng Object.
* Thành phần **`static`** → thuộc về Class.
* Thành phần `static` được truy cập bằng:

```csharp
ClassName.MemberName
```

thay vì:

```csharp
object.MemberName
```

---

# Tổng kết

| Nội dung           | Ý chính                                              |
| ------------------ | ---------------------------------------------------- |
| **Value Type**     | Lưu trực tiếp giá trị                                |
| **Reference Type** | Lưu tham chiếu đến đối tượng                         |
| **`set`**          | Có thể thay đổi giá trị sau khi khởi tạo             |
| **`init`**         | Chỉ thiết lập trong quá trình khởi tạo               |
| **`virtual`**      | Cho phép lớp con ghi đè phương thức                  |
| **`override`**     | Ghi đè phương thức của lớp cha                       |
| **`static`**       | Thành phần thuộc về Class, dùng chung cho các Object |

## Kiến thức trọng tâm

```text
Value Type
    → Lưu giá trị

Reference Type
    → Lưu tham chiếu

set
    → Có thể thay đổi sau khi tạo Object

init
    → Chỉ thiết lập khi khởi tạo Object

virtual
    → Cho phép ghi đè

override
    → Thực hiện ghi đè

static
    → Thuộc về Class
```

