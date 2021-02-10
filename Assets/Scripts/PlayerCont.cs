using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson; // Used this standard asset for character.

public class PlayerCont : MonoBehaviour
{
    public FixedJoystick joystick;
    protected ThirdPersonUserControl Control;
    // Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Control.Hinput = joystick.input.x;
        Control.Vinput = joystick.input.y;
    }
}
