using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public string itemName;
    public Sprite icon;
}

public class InventoryScrollList : MonoBehaviour
{
    public List<Item> itemList;
    public Transform contentPanel;
    public InventoryScrollList otherInventory;
    public SimpleObjectPool buttonObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        AddButton();
    }
    private void AddButton()
    {
        for(int i = 0; i < itemList.Count; i++)
        {
            Item item = itemList[i];
            GameObject newButton = buttonObjectPool.GetObject();
            newButton.transform.SetParent(contentPanel);

            SampleButton sampleButton = newButton.GetComponent<SampleButton>();
            sampleButton.Setup(item, this);
        }
    }
}
