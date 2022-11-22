// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        //Console.WriteLine(a);
        string b="abcdefghijklmnopqrstuvwxyzabcd";
        string ans="";
        for(int i=0;i<a.Length;i++)
        {
            for(int j=0;j<b.Length;j++)
            {
                if(a[i]==b[j])
                {
                    ans=ans+b[j+3];
                    break;
                }
            }
        }
        Console.WriteLine(ans);
    }
}