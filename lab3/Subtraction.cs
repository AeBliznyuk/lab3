namespace lab3
{
    public class Subtraction : IOperation
    {
        public string GetOperationName()
        {
            return "Вычитание";
        }            
        public float GetOperationResult(float firstArg, float secondArg)
        {
            return firstArg - secondArg;
        }
        public string GetOperationSign()
        {
            return "-";
        }
    }
}
