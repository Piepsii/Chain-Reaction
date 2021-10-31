using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woodpecker : MonoBehaviour
{
    Animator woodpecker;
    IEnumerator coroutine;

	void Start ()
    {
        woodpecker = GetComponent<Animator>();
	}
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            woodpecker.SetBool("idle", true);
            woodpecker.SetBool("hop", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            woodpecker.SetBool("hop", true);
            woodpecker.SetBool("idle", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            woodpecker.SetBool("flyleft", true);
            woodpecker.SetBool("flyright", false);
            woodpecker.SetBool("fly", false);
            woodpecker.SetBool("landing", false);
            woodpecker.SetBool("idle", false);
            woodpecker.SetBool("hopleft", true);
            woodpecker.SetBool("hopright", false);
            woodpecker.SetBool("hop", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            woodpecker.SetBool("flyright", true);
            woodpecker.SetBool("flyleft", false);
            woodpecker.SetBool("fly", false);
            woodpecker.SetBool("landing", false);
            woodpecker.SetBool("idle", false);
            woodpecker.SetBool("hopleft", false);
            woodpecker.SetBool("hopright", true);
            woodpecker.SetBool("hop", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            woodpecker.SetBool("flyleft", false);
            woodpecker.SetBool("flyright", false);
            woodpecker.SetBool("fly", true);
            woodpecker.SetBool("idle", true);
            woodpecker.SetBool("hopleft", false);
            woodpecker.SetBool("hopright", false);
            woodpecker.SetBool("hop", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            woodpecker.SetBool("flyright", false);
            woodpecker.SetBool("flyleft", false);
            woodpecker.SetBool("fly", true);
            woodpecker.SetBool("idle", true);
            woodpecker.SetBool("hopleft", false);
            woodpecker.SetBool("hopright", false);
            woodpecker.SetBool("hop", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            woodpecker.SetBool("idle", false);
            woodpecker.SetBool("takeoff", true);
            StartCoroutine("fly");
            fly();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            woodpecker.SetBool("landing", true);
            woodpecker.SetBool("fly", false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            woodpecker.SetBool("glide", true);
            woodpecker.SetBool("fly", false);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            woodpecker.SetBool("glide", false);
            woodpecker.SetBool("fly", true);
        }
        if ((Input.GetKey("down"))||(Input.GetKeyUp("up")))
        {
            woodpecker.SetBool("landing2", true);
            woodpecker.SetBool("fly", false);
            woodpecker.SetBool("climb", false);
            woodpecker.SetBool("landing", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKeyDown("up"))
        {
            woodpecker.SetBool("climb", true);
            woodpecker.SetBool("idle2", false);
        }
        if (Input.GetKey("left"))
        {
            woodpecker.SetBool("fly", true);
            woodpecker.SetBool("idle2", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            woodpecker.SetBool("takeoff2", true);
            woodpecker.SetBool("idle2", false);
            StartCoroutine("fly");
            fly();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            woodpecker.SetBool("eat", true);
            woodpecker.SetBool("idle2", false);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            woodpecker.SetBool("idle2", true);
            woodpecker.SetBool("eat", false);
        }
	}
   IEnumerator fly()
    {
        yield return new WaitForSeconds(0.3f);
        woodpecker.SetBool("takeoff", false);
        woodpecker.SetBool("takeoff2", false);
        woodpecker.SetBool("fly", true);
    }
    IEnumerator idle()
    {
        yield return new WaitForSeconds(0.2f);
        woodpecker.SetBool("idle", true);
        woodpecker.SetBool("landing", false);
    }
    IEnumerator idle2()
    {
        yield return new WaitForSeconds(0.1f);
        woodpecker.SetBool("idle2", true);
        woodpecker.SetBool("landing2", false);
    }
}
