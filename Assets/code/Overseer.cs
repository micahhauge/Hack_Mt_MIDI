using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Overseer : MonoBehaviour
{
    public List<Enemy> EnemyList;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public int VULNERABLE_THRESHOLD = 20;
    public int DAMAGE_AMOUNT = 1;
    public bool recieveAttack(int source_MidiId)
    {
        foreach (Enemy enemy in EnemyList)
        {
			if (enemy.midiId == source_MidiId /*&& enemy.getDistance() < VULNERABLE_THRESHOLD*/)
            {
                enemy.health -= DAMAGE_AMOUNT;
                if (enemy.health <= 0)
                {
                    
                    EnemyList.Remove(enemy);
                    Destroy(enemy);
                    //send keyup event
                }
                return true;

            }
        }
        return false;
    }
    public void Add(Enemy E)
    {
        EnemyList.Add(E);
        Debug.Log(E);
        //Debug.Log(EnemyList.FindLast(x => x.getHealth() == 999).getMidiId());
        //EnemyList.FindLast(x => x.getHealth() == 999).setHealth(0);
        //Debug.Log(EnemyList.FindLast(x=> x.getHealth() == 0).getMidiId());
    }

}
