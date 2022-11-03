using System.Collections;
namespace queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();  

            queue.Enqueue(1);
            queue.Enqueue("my_queue");
            
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}