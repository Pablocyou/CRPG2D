using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class testInteract : MonoBehaviour, IPointerDownHandler

{
    private void Start()
    {
        AddPhysics2DRaycaster();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
        //test para ehhh obtener datos de un objeto

        //la idea es la siguiente, definimos una clase (DatosEntidad) que va a tener todas las posibles variables comunes que podamos esperar en todos los objetos
        //(idk cuales serian ahora mismo) pero el tema es usar eso de template. Luego, creas otra clase para el objeto que quieras en especifico
        //por ejemplo, un bicho concreto, el "theWokChino", que tiene hp 1000 y ataque 50
        //con esta linea puedes acceder a los datos del objeto concreto
        //y para saber que tipo de cosa estas viendo, pues puedes poner una var tipo o algo
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.GetComponent<DatosEntidad>().test);
    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }

}
