using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class PlayerStatsControll : MonoBehaviour
    {
        public bool Immortal;
        public int Ammo;
        public int Health;
        public int Mana;

        private void OnTriggerEnter(Collider other)
        {
            IPickableObject pickUp = other.GetComponent<IPickableObject>();
            if (pickUp != null)
            {
                pickUp.PickUp(pickUp as AmmoPickup, this);
                pickUp.PickUp(pickUp as HealthPickup, this);
                pickUp.PickUp(pickUp as ManaPickup, this);
                pickUp.PickUp(pickUp as ImmortalPickup, this);
            }

        }


        // Use this for initialization
        void Start()
        {
            Ammo = 0;
            Health = 0;
            Mana = 0;
            Immortal = false;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
