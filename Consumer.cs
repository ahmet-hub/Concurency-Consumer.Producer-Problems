




public class Consumer
{
    private Data data;
    public Consumer(Data data)
    {
        this.data = data;
    }
    public void Consume()
    {
        int i = 1;
        do
        {
            lock (data)
            {
               
                if (!data.Flag)
                {

                    data.Value--;
                    Console.WriteLine($"Consumer : {data.Value } ---- {i++}");
                    data.Flag = !data.Flag;
                }

            }
            Thread.Sleep(1000);

        } while (true);

    }
}
