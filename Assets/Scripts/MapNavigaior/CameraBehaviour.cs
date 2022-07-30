using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] Camera Cam;

    void Start()
    {
    }

   public void Zoom(float val)
    {
        Cam.orthographicSize = val;
        //CinemachineComponentBase componentBase = Cam.GetCinemachineComponent(CinemachineCore.Stage.Body);
        //if (componentBase is CinemachineFramingTransposer)
        //{
        //    Debug.Log((componentBase as CinemachineFramingTransposer).m_ScreenX); // your value
        //    Debug.Log((componentBase as CinemachineFramingTransposer).m_ScreenY); // your value
        //}
    }
    public void TakeTile(Tile tile)
    {
        Debug.Log(tile.gameObject.name);
    }
}
