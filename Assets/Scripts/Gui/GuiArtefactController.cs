using UnityEngine;
using UnityEditor;

public class GuiArtefactController : MonoBehaviour
{

    ///// Variables

    private bool _on;
    private bool _broken;

    ///// Functions
    
    // Checks
    public bool CheckIfOn() { return _on; }
    public bool CheckIfBroken() { return _broken; }

    // Switches
    public bool ToggleOnOff() { return _on = !_on; }
    public void SwitchOn() { _on = true; }
    public void SwitchOff() { _on = false; }
    public void SetBroken() { _broken = true; }
    public void SetNotbroken() { _broken = false; }
}