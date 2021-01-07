using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickTeaServaer : MonoBehaviour
{
    public GimmickTanuki tanuki;

    public void clickTeaServer()
    {
        bool movedTanuki = tanuki.moved;
        if(movedTanuki == true)
        {
            gameObject.SetActive(false);
        }
        else
        {

        }
    }
}
