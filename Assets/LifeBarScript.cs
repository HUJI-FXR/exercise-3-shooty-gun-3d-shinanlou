using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarScript : MonoBehaviour
{
    [SerializeField] private LifeTotalScript playerlife;
    private TextMeshProUGUI lifetext;
    // Start is called before the first frame update
    void Start()
    {
        lifetext = GetComponent<TextMeshProUGUI>();
        UpdateLifeBar();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLifeBar();
    }

    void UpdateLifeBar(){
        lifetext.text = "HP:" + playerlife.lifeTotal;
    }
}
