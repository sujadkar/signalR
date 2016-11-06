using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstSignalR
{
	public class MyHub : Microsoft.AspNet.SignalR.Hub
	{
		public void Announce(string messsage)
		{
			
			Clients.Caller.Announce(messsage);
			//Clients.All.Announce(messsage);
		}
	}
}