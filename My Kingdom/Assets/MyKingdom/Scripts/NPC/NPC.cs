using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC /*: MonoBehaviour*/
{


































    //public Vector3 NPC_SpawnPoint;
    //public string gender;
    //private int maleIndex;
    //private int femaleIndex;
    //private int jobIndex;
    //private int houseNameIndex;
    //private int modelIndex;
    //public GameObject model;
    //private GameObject[] modelList;
    //private string[] maleFirstNames;
    //private string[] femaleFirstNames;
    //private string[] houseNameList;
    //private string[] jobList;

    //private GameObject femaleDruid;
    //private GameObject femaleGypsy;
    //private GameObject femalePeasant1;
    //private GameObject femalePeasant2;
    //private GameObject femaleQueen;
    //private GameObject femaleWitch;
    //private GameObject maleBaird;
    //private GameObject malePeasant;
    //private GameObject maleRogue;
    //private GameObject maleSorcerer;
    //private GameObject maleWizard;




    //private string NPCMaleFirstNameSelector()
    //{
    //    maleFirstNames = new string[15];

    //    maleFirstNames[0] = "Stephan";
    //    maleFirstNames[1] = "Adam";
    //    maleFirstNames[2] = "Geoffrey";
    //    maleFirstNames[3] = "Gilbert";
    //    maleFirstNames[4] = "Henry";
    //    maleFirstNames[5] = "Hugh";
    //    maleFirstNames[6] = "John";
    //    maleFirstNames[7] = "Nicholas";
    //    maleFirstNames[8] = "Peter";
    //    maleFirstNames[9] = "Roger";
    //    maleFirstNames[10] = "Simon";
    //    maleFirstNames[11] = "William";
    //    maleFirstNames[12] = "Thomas";
    //    maleFirstNames[13] = "Walter";
    //    maleFirstNames[14] = "Samwell";

    //    maleIndex = UnityEngine.Random.Range(0, maleFirstNames.Length);
    //    return maleIndex.ToString();
    //}
    //private string NPCFemaleFirstNameSelector()
    //{
    //    femaleFirstNames = new string[15];

    //    femaleFirstNames[0] = "Matilda";
    //    femaleFirstNames[1] = "Agnes";
    //    femaleFirstNames[2] = "Alice";
    //    femaleFirstNames[3] = "Joan";
    //    femaleFirstNames[4] = "Emma";
    //    femaleFirstNames[5] = "Isabella";
    //    femaleFirstNames[6] = "Juliana";
    //    femaleFirstNames[7] = "Beatrice";
    //    femaleFirstNames[8] = "Julia";
    //    femaleFirstNames[9] = "Lillian";
    //    femaleFirstNames[10] = "Cecilia";
    //    femaleFirstNames[11] = "Jasmine";
    //    femaleFirstNames[12] = "Bertha";
    //    femaleFirstNames[13] = "Olive";
    //    femaleFirstNames[14] = "Patricia";
    //    femaleIndex = UnityEngine.Random.Range(0, femaleFirstNames.Length);
    //    return femaleIndex.ToString();
    //}
    //private string NPCHouseNameSelector()
    //{
    //    houseNameList = new string[7];
    //    houseNameList[0] = "Woodmor";
    //    houseNameList[1] = "Macwell";
    //    houseNameList[2] = "Claymond";
    //    houseNameList[3] = "Dudell";
    //    houseNameList[4] = "Lochburn";
    //    houseNameList[5] = "Blackburn";
    //    houseNameList[6] = "Rooley";
    //    houseNameIndex = UnityEngine.Random.Range(0, houseNameList.Length);
    //    return houseNameIndex.ToString();
    //}
    //private GameObject NPCModelSelector(string gender)
    //{
    //    femaleDruid = Resources.Load<GameObject>("Female_Druid");
    //    femaleGypsy = Resources.Load<GameObject>("Female_Gypsy");
    //    femalePeasant1 = Resources.Load<GameObject>("Female_Peasant_1");
    //    femalePeasant2 = Resources.Load<GameObject>("Female_Peasant_2");
    //    femaleQueen = Resources.Load<GameObject>("Female_Queen");
    //    femaleWitch = Resources.Load<GameObject>("Female_Witch");
    //    maleBaird = Resources.Load<GameObject>("Male_Baird");
    //    malePeasant = Resources.Load<GameObject>("Male_Peasant");
    //    maleRogue = Resources.Load<GameObject>("Male_Rogue");
    //    maleSorcerer = Resources.Load<GameObject>("Male_Sorcerer");
    //    maleWizard = Resources.Load<GameObject>("Male_Wizard");

    //    if (gender == "female")
    //    {
    //        modelList = new GameObject[6];
    //        modelList[0] = femaleDruid;
    //        modelList[1] = femaleGypsy;
    //        modelList[2] = femalePeasant1;
    //        modelList[3] = femalePeasant2;
    //        modelList[4] = femaleQueen;
    //        modelList[5] = femaleWitch;
    //    }
    //    else
    //    {
    //        modelList = new GameObject[5];
    //        modelList[0] = maleBaird;
    //        modelList[1] = malePeasant;
    //        modelList[2] = maleRogue;
    //        modelList[3] = maleSorcerer;
    //        modelList[4] = maleWizard;
    //    }
    //    modelIndex = UnityEngine.Random.Range(0, modelList.Length);
    //    return modelList[modelIndex];
    //}

    ////Jobs
    //private void AddFarmerJobScripts()
    //{
    //    //thhis.gameObject returns the NPC empty object
    //    //this.gameObject.AddComponent<Farmer>();
    //    //this.gameObject.AddComponent<GoToFarm>();
    //    //this.gameObject.AddComponent<GoToStockPile>();
    //}


    //private string JobSelector()
    //{
    //    jobList = new string[5];
    //    jobList[0] = "Farmer";
    //    jobList[0] = "Soldier";
    //    jobList[0] = "Merchant";
    //    jobList[0] = "Baker";
    //    jobList[0] = "Farmer";
    //    jobIndex = UnityEngine.Random.Range(0, jobList.Length);
    //    return jobList[jobIndex];
    //}





    //public GameObject NPC_Create(string first, string house, string job, GameObject model)
    //{
    //    return model;
    //}
    ////Need a solution for spawning the Queen?

    //public int NPC_MaleCount;
    //public int NPC_FemaleCount;

    //void Start()
    //{
    //    SpawnNewNPC();
    //}
    //private void SpawnNewNPC()
    //{
    //    for (int m = 0; m < NPC_MaleCount; m++)
    //    {
    //        Instantiate(NPCCreator("male"), NPC_SpawnPoint, Quaternion.identity);
    //    }
    //    for (int f = 0; f < NPC_FemaleCount; f++)
    //    {
    //        Instantiate(NPCCreator("female"), NPC_SpawnPoint, Quaternion.identity);
    //    }
    //}
    //public GameObject NPCCreator(string gender)
    //{
    //    //NPC_SpawnPoint = new Vector3(xval, yval, zval);
    //    if (gender == "male")
    //    {
    //        return NPC_Create(NPCMaleFirstNameSelector(), NPCHouseNameSelector(), JobSelector(), NPCModelSelector(gender));
    //    }
    //    else
    //    {
    //        return NPC_Create(NPCFemaleFirstNameSelector(), NPCHouseNameSelector(), JobSelector(), NPCModelSelector(gender));
    //    }
    //}

}

