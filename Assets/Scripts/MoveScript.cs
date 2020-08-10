using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RDG
{
    public class MoveScript : MonoBehaviour
    {
        private void OnMouseDown()
        {
            if (!GameControllerScript.win)
            {
                transform.Rotate(0f, 0f, 90f);
                Vibration.Vibrate(10000, -1, false);
                //Debug.Log("+");
            }
        }

        private void OnMouseUp()
        {
            Vibration.Cancel();
            //Debug.Log("-");
        }
    }
}