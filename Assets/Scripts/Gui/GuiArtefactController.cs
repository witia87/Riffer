using UnityEngine;
using UnityEditor;

public class GuiArtefactController : MonoBehaviour
{

    ///// Variables

    private bool _on;
    private bool _broken;

    ///// Functions
    // basic switches
    public bool OnOffChceck() { return _on; }
    public bool SwitchOn() { return _on = true; }
    public bool SwitchOff() { return _on = false; }
    public bool ToggleOnOff() { return _on = !_on; }
    public bool DeclareBroken() { return _broken = true; }
    public bool DeclareUnbroken() { return _broken = false; }
}