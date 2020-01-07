using System;
using System.Collections.Generic;
using System.Text;

namespace CTCISolutions
{
    public class ChapterOne
    {
        #region Is Permutation Implementation(s)
        //Keeps track of the frequency of each character in order to tell if the given strings are permutations of one another
        //ie. if str1 and str2 are permutations, each character will appear with the same frequency in each
        public bool CheckPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            //Keep a count of each character in the string by incrementing a count in a dictionary for that character
            for (int i = 0; i < str1.Length; i++)
            {
                if (charCount.ContainsKey(str1[i]))
                {
                    charCount[str1[i]]++;
                }
                else
                {
                    charCount[str1[i]] = 1;
                }
            }
            //Go through str2, if the character is present, decrement its count
            //Thus by the end, the count should be back at 0 for each character if the strings are permutations of one another
            for (int i = 0; i < str2.Length; i++)
            {
                if (charCount.ContainsKey(str2[i]))
                {
                    charCount[str2[i]]--;
                    if (charCount[str2[i]] < 0) return false;
                }
                else return false;
            }
            return true;
        }
        #endregion

        #region Is Unique Implementation(s)
        //Naive solution in which we simply loop through each character and compare it with each character that follows it
        public bool IsUniqueBasic(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j <= str.Length - 1; j++)
                {
                    if (str[i] == str[j]) return false;
                }
            }
            return true;
        }

        //Better solution in which we add each character to a HashSet and check for its presence therein
        public bool IsUniqueBetter(string str)
        {
            HashSet<char> hastSet = new HashSet<char>();
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (hastSet.Contains(str[i])) return false;
                hastSet.Add(str[i]);
            }
            return true;
        }
        #endregion

        #region String Compression Implementation(s)
        //Progresses through input counting occurences of the current repeated character, appending the character and its occurence count
        //Finally, returns the compressed string if its shorter than the input, else returns the input
        public string compressString(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int count = 1;
                sb.Append(input[i]);
                int j = i + 1;
                while (j < input.Length && input[i] == input[j])
                {
                    count++;
                    j++;
                }
                i = j - 1;
                sb.Append(count);
            }
            string output = sb.ToString();

            return (output.Length >= input.Length) ? input : output;
        }
        #endregion

        #region URLify Implementation(s)
        //Initial implementation of URLify
        //Constructs output string by passing through input and appending characters, with '%20' in place of spaces
        //Does not perform operation in place
        public string URLifyStringInitial(string input)
        {

            StringBuilder output = new StringBuilder();
            input = input.Trim();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    output.Append(input[i]);
                else output.Append("%20");
            }

            return output.ToString();
        }

        //Attempt at in-place URLify, using char array and length as described in CTCI
        //input is assumed to contain padding for the URLification ie. "im a string    "
        public string URLifyStringInPlace(char[] input, int length)
        {
            int index = input.Length - 1;
            for (int i = length - 1; i >= 0; i--)
            {
                if (input[i] != ' ')
                {
                    input[index--] = input[i];
                }
                else
                {
                    char[] spaceReplacement = new[] { '0', '2', '%' };
                    foreach (char character in spaceReplacement)
                    {
                        input[index--] = character;
                    }
                }
            }
            return new string(input);
        }
        #endregion
    }
}
