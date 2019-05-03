using UnityEngine;
using UnityEditor;

public class GuiArtefactController : MonoBehaviour
{

    ///// Variables

    private bool _on;
    private bool _broken;

    ///// Functions
<<<<<<< HEAD
    // basic switches
    public bool OnOffChceck() { return _on; }
    public bool SwitchOn() { return _on = true; }
    public bool SwitchOff() { return _on = false; }
    public bool ToggleOnOff() { return _on = !_on; }
    public bool DeclareBroken() { return _broken = true; }
    public bool DeclareUnbroken() { return _broken = false; }
=======
    
    // Checks
    public bool CheckIfOn() { return _on; }
    public bool CheckIfBroken() { return _broken; }

    // Switches
    public bool ToggleOnOff() { return _on = !_on; }
    public void SwitchOn() { _on = true; }
    public void SwitchOff() { _on = false; }
    public void SetBroken() { _broken = true; }
    public void SetNotbroken() { _broken = false; }
>>>>>>> parent of ab06775... Refactor
}