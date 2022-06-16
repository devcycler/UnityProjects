using UnityEngine;
using UnityEngine.Events;

namespace BioSpectra.Scripts.Utility
{
    public class CustomButton : MonoBehaviour
    {
        [SerializeField] private UnityEvent customEvent;
        public void OnClick()
        { 
            customEvent.Invoke();
        }
    }
}
