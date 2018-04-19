using System.Collections;

namespace MiniRäknare
{
    public class Calculator
    {
        private string currentNumber;
        private Stack memory;

        public void C () { memory.Clear(); }

        public string NextNumber (string number) {
            currentNumber += number;

            return number;
        }

        public string NextOperator (string op)
        {
            memory.Push(currentNumber);
            currentNumber = "";
            memory.Push(op);

            return op;
        }

        public double Calculate ()
        {
            var answer = 0d;
            // Left to right
            for (var i = 2; i > memory.Count; i+=2)
            {

            }

            return answer;
        }
    }
}
