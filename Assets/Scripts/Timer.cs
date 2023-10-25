using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] private TMP_Text _textNBTemps;
    private float _tempsRestant;
    public bool tempsActif = false;
    [SerializeField] private InfosNiveau _infosNiveau;

    // Start is called before the first frame update
    void Start()
    {
        tempsActif = true;
        _infosNiveau.tempsDeJeu = 120;
    }

    // Update is called once per frame
    void Update()
    {
        VerifierTemps();

        
    }

    void CalculTime(){
        
        _infosNiveau.tempsDeJeu -= Time.deltaTime;
         AfficheTemps(_infosNiveau.tempsDeJeu );
         Debug.Log(_infosNiveau.tempsDeJeu );
    }

    void VerifierTemps(){
        if(tempsActif == true){
            CalculTime();
        }
    }

    void AfficheTemps(float temps){
        temps += 1;
        float minutes = Mathf.FloorToInt(temps / 60);
        float seconds = Mathf.FloorToInt(temps % 60);
        _textNBTemps.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
