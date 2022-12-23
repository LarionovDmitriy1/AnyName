using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyName;

public class Find
{
    public static string FindUniq(string[] array)
    {
        string result = "";
        foreach (var arr in array)
        {
            if (arr.Length == 0 || string.IsNullOrEmpty(arr) || array.Length < 2) { return null; }
            int counter = 0;
            string word = array[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (char.ToLower(arr[i]) == char.ToLower(word[j]))
                    {
                        counter++;
                        if (counter > 0)
                        {
                            break;
                        }
                    }
                }
                if (counter == 0)
                {
                    result = arr;
                    break;
                }
            }
        }
        return result;
    }
}
