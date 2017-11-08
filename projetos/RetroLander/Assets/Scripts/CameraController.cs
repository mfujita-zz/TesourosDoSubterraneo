using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;


    public float zoomMinimo = 15f;
    public float zoomMaximo = 4f;
    public float intervalo = 0.1f;

    private Camera mCamera;
    private float velocidadeZoom;
    private Vector3 velocidadeMovimento;

    // Use this for initialization
    void Start () {
        mCamera = GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update() {

        if (player != null)
        {
            if (player.position.y > 0)
            {
                mCamera.orthographicSize = Mathf.SmoothDamp(mCamera.orthographicSize, zoomMinimo, ref velocidadeZoom, intervalo);
            }
            else
            {
                Vector3 novaPosicao = new Vector3(player.position.x, player.position.y, -10);

                transform.position = Vector3.SmoothDamp(transform.position, novaPosicao, ref velocidadeMovimento, intervalo);
                mCamera.orthographicSize = Mathf.SmoothDamp(mCamera.orthographicSize, zoomMaximo, ref velocidadeZoom, intervalo);
            }
        }

	}
}
