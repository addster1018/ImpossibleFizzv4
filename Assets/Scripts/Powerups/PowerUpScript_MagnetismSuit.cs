using UnityEngine;
using System.Collections;

public class PowerUpScript_MagnetismSuit : PowerUpScript
{

    // Use this for initialization
    void Start()
    {
        this.scene = "MagnetismSuitPowerupScene";
        UnityStandardAssets._2D.PlatformerCharacter2D.movementMode = UnityStandardAssets._2D.PlatformerCharacter2D.MOVEMENT_MODES.standard;
    }

    protected override void doAction()
    {
        UnityStandardAssets._2D.PlatformerCharacter2D.movementMode =
                UnityStandardAssets._2D.PlatformerCharacter2D.MOVEMENT_MODES.magnetism;
        //Debug.Log("Action Done");
    }
}
