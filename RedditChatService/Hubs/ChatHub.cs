using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace RedditChatService.Hubs
{
	public class ChatHub : Hub
	{
		public void Send(string name, string message)
		{
			Clients.All.addMessage(name, message);
		}

		public void GreetAll(string userName)
		{
			Console.WriteLine ("User: {0} has connected.", userName);
		}
	}
}

