using UnityEngine;
using UnityEngine.UI;

public class DisableCollider : MonoBehaviour
{
  private Collider collider;
  public Toggle toggle;

  void Start()
  {
    collider = GetComponent<Collider>();

    if (toggle != null)
    {
      toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }
  }

  void OnToggleValueChanged(bool isOn)
  {
    collider.enabled = isOn;
  }
}
