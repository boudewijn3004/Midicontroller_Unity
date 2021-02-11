using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    MidiControls controls;
    // Start is called before the first frame update
    void Awake()
    {
        controls = new MidiControls();
        controls.Gameplay.Rotate.performed += ctx => Grow();
    }

    // Update is called once per frame
    void Grow()
    {
        transform.localScale *= 1.1f;
       // Console.WriteLine("hij doet het");
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
