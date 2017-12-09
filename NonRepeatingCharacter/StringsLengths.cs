namespace FirstNonRepeatingCharacterInStringQuestion
{
    public class StringsLengths
    {
        private int _length;
        private string _inputString;

        public int Length { get { return _length; } }
        public string InputString { get { return _inputString; } }
        public StringsLengths(int n, string input)
        {
            _length = n;
            _inputString = input;
        }
    }
}
