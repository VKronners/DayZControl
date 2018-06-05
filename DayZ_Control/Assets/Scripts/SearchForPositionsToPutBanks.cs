using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutBanks : MonoBehaviour {

    public List<GameObject> positionsToPutBanks;

    void Start()
    {
        positionsToPutBanks = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToBank"));

        for (int i = 0; i < positionsToPutBanks.Count; i++)
        {
            int whatBank = Random.Range(0, 2);
            if (whatBank == 0)
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Banks/Bank"), new Vector3(positionsToPutBanks[i].transform.position.x,
                                                                                            positionsToPutBanks[i].transform.position.y,
                                                                                            positionsToPutBanks[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutBanks[i].transform);
            }
            else
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Banks/Bank2"), new Vector3(positionsToPutBanks[i].transform.position.x,
                                                                                            positionsToPutBanks[i].transform.position.y,
                                                                                            positionsToPutBanks[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutBanks[i].transform);
            }

        }
    }
}
