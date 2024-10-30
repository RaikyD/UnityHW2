using System;
using Unity.VisualScripting;
using UnityEngine;


    public class PlayerTag : MonoBehaviour
    {
        private ObservableInt _value;

        public void Init()
        {
            _value = new ObservableInt(0);
        }

        private void OnEnable()
        {
            _value.OnValueChanged += SomeMethod;
        }

        private void OnDisable()
        {
            _value.OnValueChanged -= SomeMethod;
        }

        private void SomeMethod(int obj)
        {
            
        }
    }
