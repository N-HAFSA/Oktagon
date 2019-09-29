using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHAndler : MonoBehaviour
{

    //charachtere in battle
    [SerializeField] private Transform pfCharBattele;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pfCharBattele, new Vector3(-10, 0), Quaternion.identity);
        Instantiate(pfCharBattele, new Vector3(+10, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnCharacter(bool isPlayerTeam)
    {
        Vector3 position;
        if (isPlayerTeam)
        {
            position = new Vector3(-10, 0);
        }
        else
        {
            position = new Vector3(+10, 0);
        }
        Instantiate(pfCharBattele, position, Quaternion.identity);
    }
}
