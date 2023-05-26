using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Color inactiveColor;
    [SerializeField] private Color gazedAtColor;
    [SerializeField] private GameObject playerCameraGameObject;
    private MeshRenderer myRenderer;

    private bool colorChaning = false;

    private float myTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;


    }

    // Update is called once per frame
    void Update()
    {
       
        if (colorChaning)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, gazedAtColor, Time.deltaTime/2f);
            myTimer= Time.deltaTime;

            if (myTimer > 2f) 
            {
              Vector3 TeleportPose = new Vector3(transform.position.x, playerCameraGameObject.transform.position.y,transform.position.z);
                playerCameraGameObject.transform.position = TeleportPose;

            }
        }
    }

    public void OnPointerEnter()
    {
        GazeAt(true);

    }
    public void OnPointerExit()
    {
        GazeAt(false);

    }

    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            colorChaning= true;
            //myRenderer.material.color = gazedAtColor;

        }
        else
        {
            myTimer = 0f;
            colorChaning= false;
            myRenderer.material.color = inactiveColor;
        }
    }
}
