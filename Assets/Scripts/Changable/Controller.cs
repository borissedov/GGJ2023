using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private int i;
    private int y = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i = Random.Range(0, 4);

            Debug.Log("i = " + i);

            if (i == 0 && y == 4)
            {
                i += 1;

                Debug.Log("Y was 4");
            }

            else if (i == y)
            {
                i += 1;

                Debug.Log("new i = " + i);
            }

            //FindObjectOfType<PlayerController>().Off();
            //FindObjectOfType<PlayerControllerMinus>().On();

            //gameObject.GetComponent<PlayerController>().enabled = false;
            //gameObject.GetComponent<PlayerControllerMinus>().enabled = true;

            y = i;
        }

        if (i == 0 | i == 4)
        {
            gameObject.GetComponent<PlayerController>().enabled = true;
            gameObject.GetComponent<PlayerControllerMinus>().enabled = false;
            gameObject.GetComponent<PlayerControllerX>().enabled = false;
            gameObject.GetComponent<PlayerControllerY>().enabled = false;
        }

        else if (i == 1)
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponent<PlayerControllerMinus>().enabled = true;
            gameObject.GetComponent<PlayerControllerX>().enabled = false;
            gameObject.GetComponent<PlayerControllerY>().enabled = false;
        }

        else if (i == 2)
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponent<PlayerControllerMinus>().enabled = false;
            gameObject.GetComponent<PlayerControllerX>().enabled = true;
            gameObject.GetComponent<PlayerControllerY>().enabled = false;
        }

        else if (i == 3)
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponent<PlayerControllerMinus>().enabled = false;
            gameObject.GetComponent<PlayerControllerX>().enabled = false;
            gameObject.GetComponent<PlayerControllerY>().enabled = true;
        }

    }
}
