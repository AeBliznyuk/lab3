namespace lab3
{
    public class Addition : IOperation
    {
        public string GetOperationName()
        {
            return "Сложение";
        }            
        public float GetOperationResult(float firstArg, float secondArg)
        {
            return firstArg + secondArg;
        }

        public string GetOperationSign()
        {
            return "+";
        }
    }
}
