using System.Net;
using System.Net.Sockets;
using System.Text;



using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try
{

    System.Console.WriteLine("Введите команду для сервера");
    await tcpClient.ConnectAsync("192.168.220.241", 12345);
    while (true) 
    {

        string command = Console.ReadLine() + '\n';
        byte[] requestData = Encoding.UTF8.GetBytes(command);
        await tcpClient.SendAsync(requestData, new SocketFlags());

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}