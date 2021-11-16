using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1key"))
        {
            player.GetComponent<Animator>().Play("capoeira_com_chute");
        }

        if (Input.GetButtonDown("2key"))
        {
            player.GetComponent<Animator>().Play("chute");
        }

        if (Input.GetButtonDown("3key"))
        {
            player.GetComponent<Animator>().Play("esquiva");
        }
    }
}
