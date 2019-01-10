using System;

namespace Assets.Scripts
{
	internal interface IScheduler
	{
		#region PublicMethods

		void ScheduleParameter(float delay, Action a);

		#endregion
	}
}
