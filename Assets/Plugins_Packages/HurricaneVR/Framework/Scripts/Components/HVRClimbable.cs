using System;
using UnityEngine;

namespace HurricaneVR.Framework.Components
{
    /// <summary>
    /// Tags a grabbable object as climbable which is then used by the player controller to know if they can climb or not.
    /// For the hexabody integration it will kick in the climbing strength override set on the HexaHands component.
    /// </summary>
    public class HVRClimbable : MonoBehaviour
    {
       public HVRbool3 axisToClimb = new HVRbool3(false, true, false);
    }
}

[Serializable]
public struct HVRbool3
{
    public bool x;
    public bool y;
    public bool z;

    public HVRbool3(bool x, bool y, bool z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}