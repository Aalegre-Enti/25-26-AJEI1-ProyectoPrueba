using UnityEngine;
using UnityEngine.InputSystem;

public class Mover2D : MonoBehaviour
{
    //Variables publicas aparecen en el inspector de unity
    //Float es decimal
    //Para "guardar en un cajoncito/variable"
    //tenemos que indicar que vamos a guardar y ponerle un nombre
    public float velocidad = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        //Accedo al teclado
        //Accedo al teclado actual
        //Busco la tecla que me interese
        //Compruebo si la tecla está presionada o no


        Vector3 direccion = new Vector3(0, 0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            direccion.y = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direccion.y = -1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direccion.x = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direccion.x = 1;
        }

        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
        

        
    }
}
