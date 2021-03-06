﻿using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(BoxCollider))]
	internal class ManaPickup : MonoBehaviour, IPickableObject
	{
		#region SerializeFields

		[SerializeField] private int _manaValue;

		#endregion

		#region PublicMethods

		public int GetValue()
		{
			return _manaValue;
		}

		public void PickUp(AmmoPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(HealthPickup stats, PlayerStatsControll player)
		{ }

		public void PickUp(ManaPickup stats, PlayerStatsControll player)
		{
			player.Mana += _manaValue;
			Destroy(gameObject);
		}

		public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
		{ }

		#endregion
	}
}
