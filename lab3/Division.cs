namespace lab3
{
    public class Division : IOperation
    {
        public string GetOperationName()
        {
            return "Деление";
        }            
        public float GetOperationResult(float firstArg, float secondArg)
        {
            return firstArg / secondArg;
        }

        public string GetOperationSign()
        {
            return "/";
        }
    }
}
