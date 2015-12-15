using System;
using Owin;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;

namespace RedditChatService
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseCors(CorsOptions.AllowAll);
			app.MapSignalR();
		}
	}
}

