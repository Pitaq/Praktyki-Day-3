using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3 : MonoBehaviour
{
    // dzisiaj iteracja 
    public int goldValue = 50;
    void Start()
    {
       int playerLives = 3;

       while (playerLives > 0)
       {
        Debug.Log("jeszcze nadal żyjesz!");
        playerLives--;

       }
       Debug.Log("Gracz odszedł z tego świata");






        List<string> questPartyMembers1 = new List<string>()
        {"Mag", "Czarodziej", "Adam"};
        foreach(string partyMember in questPartyMembers1)
        {
            Debug.LogFormat("Oto - {0}!", partyMember);
        }






        List<string> questPartyMembers = new List<string>()
        {"Barbarzyńca", "Mędrzec", "Królowa"};
        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Indeks: {0} - {1}", i, questPartyMembers[i]);

            if (questPartyMembers[i] == "Barbarzyńca")
            {
                Debug.Log("Cieszę się że jesteś Barbarzyńco");
            }
        }









        Dictionary<string, int> itemInventory = new Dictionary<string , int>()
        {
        {"Eliksir", 5 },
        {"Antidotum", 1},
        {"Aspiryna", 1 }
        };
        foreach(KeyValuePair<string, int> kvp in itemInventory)
        {

        
        Debug.LogFormat("Pozycji: {0} - {1}g", kvp.Key, kvp.Value);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 