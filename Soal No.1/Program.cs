using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        GetVowelConsonant();
        Console.ReadLine();
    }

    private static void GetVowelConsonant()
    {
        string InputStr;
        InputStr = "Sample Case";

        int totalVowel = 0;
        int totalConsonant = 0;

        var ListVowel = new List<char>();
        var ListConsonant = new List<char>();
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        Console.WriteLine(InputStr+"\n");
        for (int i = 0; i < InputStr.ToLower().Length; i++)
        {
            if (vowels.Contains(InputStr.ToLower()[i]))
            {
                ListVowel.Add(InputStr.ToLower()[i]);
                totalVowel++;
            }
            else
            {
                ListConsonant.Add(InputStr.ToLower()[i]);
                totalConsonant++;
            }
        }

        Console.WriteLine("Vowel Characters  :");
        var VowelsResult = from x in ListVowel
                           orderby x ascending
                           select x;

        foreach (char _sentence in VowelsResult)
        {
            Console.Write(_sentence);
        }

        Console.WriteLine();
        Console.WriteLine("Consonant Characters :");
        var ConsonantResult = from x in ListConsonant
                              orderby x descending
                              select x;

        foreach (char _sentenceConsonant in ConsonantResult)
        {
            Console.Write(_sentenceConsonant);
        }
    }
}