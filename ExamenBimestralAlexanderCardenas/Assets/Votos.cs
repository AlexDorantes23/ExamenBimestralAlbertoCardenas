using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Votos : MonoBehaviour
{
    [SerializeField] TMP_Text IAtexto;
    [SerializeField] TMP_Text Votante1;
    [SerializeField] TMP_Text Votante2;
    [SerializeField] TMP_Text Resultados;
    [SerializeField] TMP_Text NumeroDeResultados;
    private int votante1;
    private int votante2;
    private int numeroDeResultados;

    
    // Start is called before the first frame update
    void Start()
    {
        IAtexto.text = "Da tu voto";

    }

    
    
    // Update is called once per frame
    void Update()
    {

    }

   
    public void SeleccionVotante1(int voto1)
    {
        votante1 = voto1;

        if (votante1 == 1)
        {
            Votante1.text = "Estas a Favor!, Voto 1 Registrado";     
        }
        else if (votante1 == 2)
        {
            Votante1.text = "Estas en contra!, Voto 1 Registrado";
        }
    }

   
    public void SeleccionVotante2(int voto2)
    {
        votante2 = voto2;
        
        if (votante2 == voto2)
        {
            Votante2.text = "Estas a Favor!, Voto 2 Registrado ";
        }
        else if (votante2 == 2)
        {
            Votante2.text = "Estas en contra!, Voto 2 Registrado";
        }
    }



}



