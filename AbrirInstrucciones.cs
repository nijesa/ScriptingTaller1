using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using Unity.VisualScripting;

public class AbrirInstrucciones : MonoBehaviour
{
    public string escena;
    public void IrAInstrucciones()
    {
        if(escena == null)
        {
            Debug.Log("Variable escena vacía");
        }
        else
        {
            MMSceneLoadingManager.LoadScene(escena); 
        }

    }
}
