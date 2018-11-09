using System;
using System.Collections.Generic;
using System.Text;


   public class Implementation
    {

    public bool CheckPermutation(string StringA , string StringB)
    {

        char[] StringCharA = StringA.ToCharArray();
        char[] StringCharB = StringB.ToCharArray();
        int matchingletters = 0;
      //  bool ispermutation = true;

        foreach (char letterA in StringCharA)
        {
            foreach (char letterB in StringCharB)
            {

                if (letterA == letterB)
                {
                    matchingletters++;
                }


            }
        }


        if (matchingletters == StringB.Length)

        {
            return true;

        }

        else
        { 
        return false;
        }


    }

}
