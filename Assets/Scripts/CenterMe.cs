using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMe : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == Constants.PlayerTag){
            GameManager.Instance.CenterMe = true;
            GameManager.Instance.CenterPosition = this.gameObject.transform.position;
        }
    }
}
