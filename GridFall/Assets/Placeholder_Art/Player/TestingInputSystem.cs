using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour {

    public Animator anim;
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }


    public void Stab() {
        Debug.Log("Stab!");
        anim.SetTrigger("Stabby");
    }


}
