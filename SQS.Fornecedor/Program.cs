using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new SendMessageRequest()
{
    QueueUrl = "https://sqs.sa-east-1.amazonaws.com/283546918190/fila-teste",
    MessageBody = "Mensagem"
};
await client.SendMessageAsync(request);
