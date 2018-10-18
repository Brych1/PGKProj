using UnityEngine;
namespace Assets.Scripts
{
    [RequireComponent(typeof(BoxCollider))]
    class HealthPickup : MonoBehaviour, IPickableObject
    {
        [SerializeField] private int _healthValue;

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
    }
}
