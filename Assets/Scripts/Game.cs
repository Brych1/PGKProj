using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class Game : MonoBehaviour
	{
		#region SerializeFields

		[SerializeField] private GameObject _cube;
		[SerializeField] private float _delay;

		#endregion

		#region PrivateFields

		private CoroutineScheduler m_coroutineSchedulerInstance;
		private Action a;

		#endregion

		#region UnityMethods

		private void Awake()
		{
			a = () => { Destroy(_cube); };
		}

		private void Start()
		{
			//SchedulerInstance = Scheduler.Instance;
			Debug.Log(m_coroutineSchedulerInstance.name);
			m_coroutineSchedulerInstance.ScheduleParameter(_delay, a);
		}

		// Update is called once per frame
		private void Update()
		{ }

		#endregion
	}
}
