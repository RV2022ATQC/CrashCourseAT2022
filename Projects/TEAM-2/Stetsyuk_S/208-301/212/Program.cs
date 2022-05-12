//4.Користувач вводить з клавіатури число - 
//  програма повинна показати скільки в даному числі цифр. 
//  Число вводиться повністю в одну змінну.

string ch = Console.ReadLine();
List<char> l = new List<char>();
l.Add(ch[0]);
bool check = true;
for(int i = 1; i < ch.Length; i++)
{
    for (int j = 0; j < l.Count; j++)
    {
        if (ch[i] == l[j])
        {
            check = false;
            break;
        }
    }
    if ((check)&&(Char.IsDigit(ch[i])))
    {
        l.Add(ch[i]);
    }
    check = true;
}

Console.WriteLine(l.Count);