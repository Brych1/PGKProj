namespace Assets.Scripts
{
	internal interface IPickableObject
	{
		#region PublicMethods

		void PickUp(AmmoPickup pickUp, PlayerStatsControll player);
		void PickUp(HealthPickup pickUp, PlayerStatsControll player);
		void PickUp(ManaPickup pickUp, PlayerStatsControll player);
		void PickUp(ImmortalPickup pickUp, PlayerStatsControll player);
		int GetValue();

		#endregion
	}
}
