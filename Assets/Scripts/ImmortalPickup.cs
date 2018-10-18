using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assets.Scripts
{
    class ImmortalPickup : MonoBehaviour, IPickableObject
    {
        private Scheduler _schedulerInstance;
        [SerializeField] int _time;
        Action a;
        public int GetValue()
        {
            return _time;
        }

        public void PickUp(AmmoPickup pickUp, PlayerStatsControll player)
        {   
        }

        public void PickUp(HealthPickup pickUp, PlayerStatsControll player)
        {            
        }

        public void PickUp(ManaPickup pickUp, PlayerStatsControll player)
        {            
        }

        public void PickUp(ImmortalPickup pickUp, PlayerStatsControll player)
        {
            player.Immortal = true;
            a = () =>
            {
                player.Immortal = false;
            };
            _schedulerInstance.ScheduleParameter((float)_time, a);
            Destroy(gameObject);
        }
        void Start()
        {
            _schedulerInstance = Scheduler.Instance;            
        }
    }
}
