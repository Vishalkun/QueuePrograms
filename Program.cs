namespace QueuePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueExamples obj = new QueueExamples();
            obj.enqueData(56);
            obj.enqueData(30);
            obj.enqueData(70);

            obj.DisplayData();
        }
    }
}