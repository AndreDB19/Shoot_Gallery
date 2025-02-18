using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;

    // Variáveis para o zoom
    public float zoomFOV = 80f; // Campo de visão durante o zoom
    public float zoomSpeed = 10f; // Velocidade do zoom
    private float defaultFOV; // Campo de visão padrão
    private Camera cam; // Referência para o componente Camera

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Inicializa a câmera e armazena o FOV padrão
        cam = GetComponent<Camera>();
        defaultFOV = cam.fieldOfView;
    }

    private void Update()
    {
        // Movimento da câmera
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotaciona a câmera e a orientação
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        // Lógica do zoom
        if (Input.GetMouseButton(1)) // Botão direito do mouse pressionado
        {
            // Aplica o zoom
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, zoomFOV, zoomSpeed * Time.deltaTime);
            sensX = 50;
            sensY = 50;
            if (cam.fieldOfView < 3)
            {
                zoomSpeed = 1;
                sensX = 15;
                sensY = 15;
                if (cam.fieldOfView < 1)
                {
                    zoomSpeed = 0.5f;
                    sensX = 5;
                    sensY = 5;
                    if (cam.fieldOfView < 0.15)
                    {
                        zoomSpeed = 0.1f;
                        sensX = 1;
                        sensY = 1;

                    }
                    

                }
            }
        }
        else
        {
            // Volta ao FOV padrão
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, defaultFOV, zoomSpeed * Time.deltaTime);
            zoomSpeed = 3;
            sensX = 400;
            sensY = 400;
        }
    }
}