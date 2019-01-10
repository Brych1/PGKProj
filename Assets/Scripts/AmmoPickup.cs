using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(BoxCollider))]
	internal class AmmoPickup : MonoBehaviour, IPickableObject
	{
		#region SerializeFields

		[SerializeField] private int _ammoValue;

		#endregion

		#region PublicMethods

		public int GetValue()
		{
			return _ammoValue;
		}

		public void PickUp(AmmoPickup stats, PlayerStatsControll player)
		{
			player.Ammo += _ammoValue;
			Destroy(gameObject);
		}

		public void PickUp(HealthPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(ManaPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
		{ }

		#endregion
	}
}
