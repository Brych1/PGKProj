using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IPickableObject
    {
        void PickUp(AmmoPickup pickUp, PlayerStatsControll player);
        void PickUp(HealthPickup pickUp, PlayerStatsControll player);
        void PickUp(ManaPickup pickUp, PlayerStatsControll player);
        void PickUp(ImmortalPickup pickUp, PlayerStatsControll player);
        int GetValue();
    }
}
