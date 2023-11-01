using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activerEtDesactiveCollider : MonoBehaviour
{
    [SerializeField]private BoxCollider colliderObject;
    private bool onOff = true;
    public void ActiveDesactiveCollider(){
        if(onOff){
            onOff = false;
            colliderObject.enabled = !colliderObject.enabled;
        }else{
            onOff = true;
            colliderObject.enabled = !colliderObject.enabled;
        }
    }
}
