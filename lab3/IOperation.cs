namespace lab3
{
    interface IOperation
    {
        string GetOperationName();
        string GetOperationSign();
        float GetOperationResult(float firstArg, float secondArg);
    }
}
