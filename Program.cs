
var data = new Data();

var consumer = new Consumer(data);
var producer = new Producer(data);

var consumerThread = new Thread(new ThreadStart(() => consumer.Consume()));
var producerThread = new Thread(new ThreadStart(() => producer.Produce()));

consumerThread.Start();
producerThread.Start();
