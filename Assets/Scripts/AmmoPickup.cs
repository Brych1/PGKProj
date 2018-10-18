using UnityEngine;
namespace Assets.Scripts
{
    [RequireComponent(typeof(BoxCollider))]
    class AmmoPickup : MonoBehaviour, IPickableObject
    {
        [SerializeField] private int _ammoValue;

        public int GetValue()
        {
            return _ammoValue;
        }

        public void PickUp(AmmoPickup stats, PlayerStatsControll player)
        {
            player.Ammo += _ammoValue;
            Destroy(this.gameObject);
        }

        public void PickUp(HealthPickup stats, PlayerStatsControll player)
        {

        }

        public void PickUp(ManaPickup stats, PlayerStatsControll player)
        {

        }

        public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
        {
        }
    }
}
