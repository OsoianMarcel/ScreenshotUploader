using System;
using System.Collections.Generic;
using Threading = System.Threading;

namespace App.Helper
{
	public static class Thread
	{
		private static readonly List<Threading.Thread> threads = new List<Threading.Thread>();
		
		// Add new thread instance
		public static void addThread(Threading.Thread thread)
		{
			removeNotAliveThreads();
			
			threads.Add(thread);
		}
		
		// Check if collection has active threads
		public static bool hasActiveThread()
		{
			return countAliveThreads() > 0;
		}
		
		// Get number of alive threads
		public static int countAliveThreads()
        {
			removeNotAliveThreads();
			
			return threads.Count;
		}
		
		// Abort all active threads
		public static void abortAllThreads() 
        {
			removeNotAliveThreads();
			
			foreach (Threading.Thread thread in threads) {
				thread.Abort();
			}
		}
		
		// Remove inactive threads
		private static void removeNotAliveThreads()
		{
			threads.RemoveAll((Threading.Thread item) => item.IsAlive == false);
		}
	}
}
