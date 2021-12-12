namespace lab3
{
    public class Multiplication : IOperation 
    {
        public string GetOperationName()
        {
            return "Умножение";
        }            
        public float GetOperationResult(float firstArg, float secondArg)
        {
            return firstArg * secondArg;
        }

        public string GetOperationSign()
        {
            return "*";
        }
    }
}
