using System;
using UnityEngine;

namespace BioSpectra.Scripts.Utility
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public bool doNotDestroy = false;

        private static T m_instance;

        public static T Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = GameObject.FindObjectOfType<T>();
                    if (m_instance == null)
                    {
                        var singleton = new GameObject(typeof(T).Name);
                        m_instance = singleton.AddComponent<T>();
                    }
                }

                return m_instance;
            }
        }

        protected virtual void Awake()
        {
            if (m_instance == null)
            {
                if (doNotDestroy)
                {
                    transform.parent = null;
                }
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}