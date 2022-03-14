string string1, string2;
int flag = 0;
int i = 0, length1, length2, Finalstr = 0;

Console.Write("\n\nCompare two strings whether they are equal or not :\n");
Console.Write("Input the 1st string : ");
string1 = Console.ReadLine();

Console.Write("Input the 2nd string : ");
string2 = Console.ReadLine();

length1 = string1.Length;
length2 = string2.Length;
/*compare checking when they are equal in length*/
if (length1 == length2)
{
    for (i = 0; i < length1; i++)
    {
        if (string1[i] != string2[i])
        {
            Finalstr = 1;
            i = length1;

        }
    }
}

/*initialize the flage where they are equal, smaller and greater in length*/
if (length1 == length2)
{
    flag = 0;
}
    
else if (length1 > length2)
{
    flag = 1;
}
    
else if (length1 < length2)
{
    flag = -1;
}
  

/*display the message where the strings are same or smaller or greater*/
if (flag == 0)
{
    if (Finalstr == 0)
    {
        Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
    }
    else
    {
        Console.Write("\nThe length of both strings are equal \nbut they are not same.\n\n");
    }
        
}
else if (flag == -1)
{
    Console.Write("\nThe length of the first string is smaller than second.\n\n");
}
else
{
    Console.Write("\nThe length of the first string is greater than second.\n\n");
}