using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionChaudronPoints : MonoBehaviour
{

    [SerializeField] private GameObject _bonbon;
    [SerializeField] private GameObject _chaudron;
    [SerializeField] private TMP_Text _textPoints;
    private int _nbPoints;
    void Start()
    {
        _nbPoints = 0;
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Bonbon"){
            _nbPoints += 1;
            _textPoints.text = _nbPoints.ToString();
           
        }
    }
}
