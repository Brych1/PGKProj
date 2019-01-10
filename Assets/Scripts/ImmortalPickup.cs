using System;
using UnityEngine;

namespace Assets.Scripts
{
	internal class ImmortalPickup : MonoBehaviour, IPickableObject
	{
		#region SerializeFields

		[SerializeField] private int _time;

		#endregion

		#region PrivateFields

		private CoroutineScheduler m_coroutineSchedulerInstance;
		private Action a;

		#endregion

		#region UnityMethods

		private void Start()
		{
			//_schedulerInstance = Scheduler.Instance;
		}

		#endregion

		#region PublicMethods

		public int GetValue()
		{
			return _time;
		}

		public void PickUp(AmmoPickup pickUp, PlayerStatsControll player)
		{ }

		public void PickUp(HealthPickup pickUp, PlayerStatsControll player)
		{ }

		public void PickUp(ManaPickup pickUp, PlayerStatsControll player)
		{ }

		public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
		{
			player.Immortal = true;
			a = () => { player.Immortal = false; };
			m_coroutineSchedulerInstance.ScheduleParameter(_time, a);
			Destroy(gameObject);
		}

		#endregion
	}
}
