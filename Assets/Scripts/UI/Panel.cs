using UnityEngine;
using UnityEngine.Events;
using Transform = UnityEngine.Transform;

namespace UI
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private GameObject _luzes;
        [SerializeField] protected internal UnityEvent onTriggerEnter = new UnityEvent();

        private void AcenderLuzes()
        {
            if (_luzes == null) return;
            foreach (Transform child in _luzes.transform)
            {
                var component = child.GetComponent<Renderer>();

                if (component == null) continue;
                var material = component.material;
                material.EnableKeyword("_EMISSION");
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            AcenderLuzes();
            onTriggerEnter.Invoke();
        }
    }
}
