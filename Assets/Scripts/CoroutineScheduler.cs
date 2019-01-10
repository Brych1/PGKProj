using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
	internal class CoroutineScheduler : MonoBehaviour, IScheduler
	{
		#region PublicMethods

		public void ScheduleParameter(float delay, Action a)
		{
			Debug.Log("Delay is " + delay);
			StartCoroutine(RunDelayed(delay, a));
		}

		#endregion

		#region PrivateMethods

		private IEnumerator RunDelayed(float t, Action action)
		{
			var wait = new WaitForSeconds(t);
			yield return wait;

			action();
		}

		#endregion
	}
}
