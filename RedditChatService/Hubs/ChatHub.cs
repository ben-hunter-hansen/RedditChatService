using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;

namespace RedditChatService.Hubs
{
	public class ChatHub : Hub
	{
		public async Task JoinGroup(string groupName) {
			await Groups.Add (Context.ConnectionId, groupName);
			Clients.Group(groupName).GreetAll();
		}

		public async Task LeaveGroup(string groupName) {
			await Groups.Remove (Context.ConnectionId, groupName);
		}

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

