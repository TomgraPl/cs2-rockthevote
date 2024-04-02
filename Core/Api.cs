using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrikeSharp.API.Core;
using RTVapi;

namespace cs2_rockthevote {
	public class Api : iRTVapi {
		public event Action? OnRTVReached;
		public event Action? OnEndMapVote;
		public void RTVReached() {
			OnRTVReached?.Invoke();
		}
		public void EndMapVote() {
			OnEndMapVote?.Invoke();
		}
	} 
}
