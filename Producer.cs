




public class Producer
{
    Data data;
    public Producer(Data data)
    {
        this.data = data;
    }

    public void Produce()
    {
        int i = 1;
        do
        {
            lock (data)
            {

                if (data.Flag)
                {
                    data.Value++;
                    Console.WriteLine($"Producer : {data.Value } ---- {i++}");
                    data.Flag = !data.Flag;
                }

            }
            Thread.Sleep(1000);
        } while (true);


    }
}