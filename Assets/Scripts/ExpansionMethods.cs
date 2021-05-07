using System.Collections;
using System.Collections.Generic;

public static class Extensions
{
    public static int Max(this int value, int maxValue)
    {
        if (value > maxValue)
            return maxValue;
        return value;
    }

    public static int Min(this int value, int minValue)
    {
        if (value < minValue)
            return minValue;
        return value;
    }

    public static string ToUpperStart(this string str)
    {
        if (str.Length > 0)
            return str.Substring(0, 1).ToUpper() + str.Substring(1 % str.Length, str.Length - 1);
        else return str;
    }

    public static string Escape(this string str)
    {
        char[] escapeCharacter = new char[] {'\'' };

        foreach(char character in escapeCharacter)
        {
            str = str.Replace(character, '_');
        }

        return str;
    }

    /// <summary>
    /// Inspired by https://stackoverflow.com/questions/273313/randomize-a-listt
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    public static void Shuffle<T>(this IList<T> list)
    {
        int i = list.Count;

        while (i > 1)
        {
            i--;
            int indexRand = UnityEngine.Random.Range(0, list.Count);
            T value = list[indexRand];
            list[indexRand] = list[i];
            list[i] = value;
        }
    }
}
