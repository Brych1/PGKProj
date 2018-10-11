using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject _cube;
        [SerializeField] private float _delay;
        private Scheduler SchedulerInstance;
        Action a;
        void Awake()
        {
            a = () =>
            {
                Destroy(_cube);
            };
        }
        void Start()
        {
            SchedulerInstance = Scheduler.Instance;
            Debug.Log(SchedulerInstance.name);
            SchedulerInstance.ScheduleParameter(_delay, a);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

