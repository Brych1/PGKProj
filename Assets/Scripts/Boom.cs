using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Scripts
{
	public class Boom : MonoBehaviour
	{
		#region SerializeFields

		[SerializeField] private Text m_text;
		[SerializeField] private int m_ticks;

		[SerializeField] private bool m_isDetonated;

		#endregion

		#region PrivateFields

		private IScheduler m_coroutineSchedulerInstance;

		#endregion

		#region UnityMethods

		private void Start()
		{
			m_text.text = m_ticks.ToString();
		}

		private void Update()
		{ }

		#endregion

		#region PublicMethods

		public void OnDetonate()
		{
			if (!m_isDetonated)
			{
				DetonationTick();
				m_isDetonated = true;
			}
		}

		public void DetonationTick()
		{
			m_ticks--;
			m_text.text = m_ticks.ToString();
			if (m_ticks > 0)
			{
				m_coroutineSchedulerInstance.ScheduleParameter(1, DetonationTick);
			}
			else
			{
				Destroy(gameObject);
			}
		}

		#endregion

		#region PrivateMethods

		[Inject]
		private void Construct(IScheduler coroutineScheduler)
		{
			m_coroutineSchedulerInstance = coroutineScheduler;
		}

		#endregion
	}
}
