using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ControlMonedas : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    int contador;
    public GameObject point_txt;
    public GameObject PuertaProto;
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
    public virtual void OnMMEvent(PickableItemEvent e)
    {
        
        Coin coin = e.PickedItem.GetComponent<Coin>();
        if (coin != null)
        {
            //contador = contador + coin.PointsToAdd;
            //Debug.Log(contador);
            //if (contador >= 50)
            //{
            //    PuertaProto.SetActive(false);
            //    Debug.Log("PuertaProto desactivada");
            //}


        }
    }
}
