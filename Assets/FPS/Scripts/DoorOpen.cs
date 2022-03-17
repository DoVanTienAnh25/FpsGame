using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource doorFX;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            doorFX.Play();
            theDoor.GetComponent<Animator>().Play("DoorOpen");
            StartCoroutine(closedoor());
        }
    }

    IEnumerator closedoor()
    {
        yield return new WaitForSeconds(10);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorClose");
    }
}
