using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[ExecuteInEditMode]

public class Enviroment : MonoBehaviour
{
    [SerializeField] private SpriteShapeController spriteShapeController;

    [SerializeField, Range(3f, 100f)] private int levelLenght = 50;
    [SerializeField, Range(1f, 50f)] private float xMultiplayer = 2f;
    [SerializeField, Range(1f, 50f)] private float yMultiplayer = 2f;
    [SerializeField, Range(0f, 1f)] private float curveSmothness = 0.5f;
    [SerializeField] private float noiseStep = 0.5f;
    [SerializeField] private float bottom = 10f;

    private Vector3 lastPosition;

    private void OnValidate()
    {
                
    }
}
