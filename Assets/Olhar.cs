using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olhar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float Sensibilidade = 1500;
    public float minAngulo = -45;
    public float maxAngulo = 45;
    float mouseY = 0;
    float mouseX = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        mouseX += Input.GetAxis("Mouse X") * Sensibilidade * Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y") * Sensibilidade * Time.deltaTime;
        mouseY = Mathf.Clamp(mouseY, minAngulo, maxAngulo);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
