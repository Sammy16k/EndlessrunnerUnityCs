using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour
{
   public GameObject[] sections;
   public float zPos;
   public bool creatingSections=false;
   public int secNum;

    void Update()
    {
        if (creatingSections == false)
        {
            creatingSections = true;
            StartCoroutine(GenerateSection());
        }
    }

        IEnumerator GenerateSection()
        {
            secNum = Random.Range(0,3);
            Instantiate(sections[secNum], new Vector3(0,0,zPos),Quaternion.identity);
            zPos += 60;
            yield return new WaitForSeconds(2);
            creatingSections=false;
        }

}
