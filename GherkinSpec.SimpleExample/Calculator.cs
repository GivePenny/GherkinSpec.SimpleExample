namespace GherkinSpec.SimpleExample
{
    public class Calculator
    {
        public void Store(int number)
            => Result = number;

        public void Add(int number)
            => Result += number;

        public int Result { get; private set; }
    }
}
