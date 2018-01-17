namespace CTCI_ArraysAndStrings.Problems
{
    public class ArrayString_4
    {
        /// <summary>
        /// You are supposed to replace all whitespaces in a string with %20. 
        /// Use a char array to do this in place. 
        /// For most string manipluation problems it is easier to traverse from the end of the string
        /// to the front. In this case especially so, as we do not have to worry about what character we 
        /// might overwrite. 
        /// Although the char array would have space for the additional chars after encoding, we are also
        /// presented with the true length of the string. this means that the end of the actual sentence 
        /// marked by the first null char ('\0') is given to us
        /// assumption is that the encoded string willa always fit in the char array
        /// </summary>
        /// <param name="word"></param>
        public static void HtmlEncodeSpaces(char[] word, int trueLength)
        {
            int spaceCounter = 0;
            //lets first find out the number of spaces we have to encode
            for(int i=0; i < trueLength; i++)
            {
                if (word[i] == ' ')
                    spaceCounter++;
            }

            // now that we have the number of spaces, we can find the length of encoding string
            // this is required to place the moved letters in the right positions
            // ' '  is to be converted to %20 
            // 1 space becomes three characters. 2 spaces 6 and so on. 
            // but we should find what number of chars should be added. 
            // (spaceCounter * 3) - spaceCounter
            // which evaluates to spaceCounter * 2
            int newLength = trueLength + (spaceCounter * 2);
            word[newLength] = '\0';
            // start iterating from 1 less than trueLength as the last char is for '\0'
            for (int i= trueLength - 1; i >= 0; i--)
            {
                if (word[i] == ' ')
                {
                    word[newLength - 1] = '0';
                    word[newLength - 2] = '2';
                    word[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    word[newLength - 1] = word[i];
                    newLength = newLength - 1;
                }
            }
        }
    }
}
