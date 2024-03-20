using UnityEngine;
using UnityEngine.UI;

public class milkManager : MonoBehaviour
{
    public int milkCount;
    public Text milkText;
    
    void Update()
    {
        milkText.text = milkCount.ToString();
        
    }


}

