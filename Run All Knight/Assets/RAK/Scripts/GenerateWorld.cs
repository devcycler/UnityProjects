using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    [Header("Outside Platform List")]
    public GameObject[] outsidePlatforms;
    public float oPlatforms;

    [Header("Inside Platform List")]
    public GameObject[] insidePlatforms;
    public float iPlatforms;

    public bool isOutside = false;

    // Start is called before the first frame update
    void Start()
    {
        if (isOutside)
        {
            GenerateOutsidePlatforms();
        }
        else
        {
            GenerateInsidePlatforms();
        }
    }


    private void GenerateOutsidePlatforms()
    {
        Vector3 pos = new Vector3(0f, 0f, 0f);
        for (int i = 0; i < oPlatforms; i++)
        {
            int platformNumber = Random.Range(0, outsidePlatforms.Length);
            pos.z += 30f;
            switch (outsidePlatforms[platformNumber].tag)
            {
                case "Small":
                    Instantiate(outsidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                case "Medium":
                    Instantiate(outsidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                case "Large":
                    Instantiate(outsidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                default:
                    Debug.LogWarning("GenerateWorld: Outside Platforms: Platform switch statement returned default case. :::" + outsidePlatforms[platformNumber].name.ToString() + "::: is not tagged or tagged as something else");
                    break;
            }
        }
    }

    private void GenerateInsidePlatforms()
    {
        Vector3 pos = new Vector3(0f, 0f, 0f);
        for (int i = 0; i < iPlatforms; i++)
        {
            int platformNumber = Random.Range(0, insidePlatforms.Length);
            pos.z += 30f;
            switch (insidePlatforms[platformNumber].tag)
            {
                case "Small":
                    Instantiate(insidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                case "Medium":
                    Instantiate(insidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                case "Large":
                    Instantiate(insidePlatforms[platformNumber], pos, Quaternion.identity);
                    break;
                default:
                    Debug.LogWarning("GenerateWorld: Inside Platforms: Platform switch statement returned default case. :::" + outsidePlatforms[platformNumber].name.ToString() + "::: is not tagged or tagged as something else");
                    break;
            }
        }
    }
}
