using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Camera cam;
    public MeshRenderer table;
    public MeshRenderer ball;

    public Material tableMaterial;
    public Material ballMaterial;
    public Material blank;

    private bool textured = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textured = !textured;
        }

        if (textured)
        {
            cam.clearFlags = CameraClearFlags.Skybox;
            table.material = tableMaterial;
            ball.material = ballMaterial;
        }
        else
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            table.material = blank;
            ball.material = blank;
        }
    }
}
