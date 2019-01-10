using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(BoxCollider))]
	internal class HealthPickup : MonoBehaviour, IPickableObject
	{
		#region SerializeFields

		[SerializeField] private int _healthValue;

		#endregion

		#region PublicMethods

		public int GetValue()
		{
			return _healthValue;
		}

		public void PickUp(AmmoPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(HealthPickup stats, PlayerStatsControll player)
		{
			player.Health += _healthValue;
			Destroy(gameObject);
		}

		public void PickUp(ManaPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
		{ }

		#endregion
	}
}
