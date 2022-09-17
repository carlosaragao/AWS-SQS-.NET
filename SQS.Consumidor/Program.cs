using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var queueUrl = "https://sqs.sa-east-1.amazonaws.com/283546918190/fila-teste";
var request = new ReceiveMessageRequest()
{
    QueueUrl = queueUrl
};
while (true)
{
    var response = await client.ReceiveMessageAsync(request);
    foreach (var message in response.Messages)
    {
        Console.WriteLine(message.Body);
        await client.DeleteMessageAsync(queueUrl, message.ReceiptHandle);
    }
}
