using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUI : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            panel.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        panel.SetActive(false);
    }
}
