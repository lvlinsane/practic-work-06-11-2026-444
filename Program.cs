Console.OutputEncoding = System.Text.Encoding.UTF8;

Person[] people = new Person[5];

people[0] = new Student("Петров Пётр Петрович", 19, "petrov@mail.com", "ИС-21", 4.3);
people[1] = new Student("Каримова Алия Ермековна", 20, "aliya@mail.com", "ИС-21", 4.8);
people[2] = new Student("Нурланов Нурлан Нурланович", 22, "nurlan@mail.com", "ПО-23", 3.6);
people[3] = new Teacher("Сидорова Анна Сергеевна", 45, "sidorova@mail.com", "Программирование", 20);
people[4] = new Teacher("Ахметов Ержан Маратович", 52, "ahmetov@mail.com", "Математика", 27);

Console.WriteLine("=== Информация обо всех людях ===");
Console.WriteLine();

foreach (Person p in people)
{
    p.DisplayInfo();
    Console.WriteLine("----------------------------");
}

int students = 0;
int teachers = 0;

foreach (Person p in people)
{
    if (p is Student)
    {
        students++;
    }
    else if (p is Teacher)
    {
        teachers++;
    }
}

Console.WriteLine();
Console.WriteLine("=== Количество по ролям ===");
Console.WriteLine();
Console.WriteLine("Студентов: " + students);
Console.WriteLine("Преподавателей: " + teachers);
Console.WriteLine("Всего: " + people.Length);

Person oldest = people[0];

foreach (Person p in people)
{
    if (p.Age > oldest.Age)
    {
        oldest = p;
    }
}

Console.WriteLine();
Console.WriteLine("=== Самый старший человек ===");
Console.WriteLine();
Console.WriteLine(oldest.FullName + ", " + oldest.Age + " лет");
