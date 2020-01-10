using System;
using System.Collections.Generic;
using System.Text;
using DSA;

namespace CTCISolutions
{
    public class ChapterTwo
    {
        public LinkedList RemoveDups(LinkedList inputList)
        {
            LinkedList outputList = new LinkedList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                for(int j = i + 1; j < inputList.Count - 1; j++)
                {
                    if (inputList.ValueAt(i) == inputList.ValueAt(j))
                        inputList.RemoveAtIndex(j);
                }
            }
            return inputList;
        }
    }
}
