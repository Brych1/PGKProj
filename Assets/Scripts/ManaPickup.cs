using UnityEngine;
namespace Assets.Scripts
{
    [RequireComponent(typeof(BoxCollider))]
    class ManaPickup : MonoBehaviour, IPickableObject
    {
        [SerializeField] private int _manaValue;

        public int GetValue()
        {
            return _manaValue;
        }

        public void PickUp(AmmoPickup stats, PlayerStatsControll player)
        {            
        }

        public void PickUp(HealthPickup stats, PlayerStatsControll player)
        {        
        }

        public void PickUp(ManaPickup stats, PlayerStatsControll player)
        {
            player.Mana += _manaValue;
            Destroy(gameObject);
        }

        public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
        {
        }
    }
}
