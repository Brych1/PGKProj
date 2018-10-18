using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    class Scheduler : MonoBehaviour
    {
        private static Scheduler _instance;
        private void Awake()
        {
            Instance = this;
        }
        public static Scheduler Instance
        { get; private set; }
        private IEnumerator RunDelayed(float t, Action action)
        {
            WaitForSeconds wait = new WaitForSeconds(t);
            yield return wait;
            action();
        }
        public void ScheduleParameter(float delay, Action a)
        {
            Debug.Log("Delay is " + delay);
            StartCoroutine(RunDelayed(delay, a));
        }
    }
}

//cqs