using UnityEngine;

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
    public void SetOnOffStatus(bool newOnOffStatus) { _on = newOnOffStatus; }

    public void SetToBroken() { _broken = true; }
    public void SetToNotbroken() { _broken = false; }
    public void SetBrokenStatus(bool newBrokenStatus) { _broken = newBrokenStatus; }
}