using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour
{
    public Button button;
    public Text nameLabel;
    public Image iconImage;

    private Item item;
    private InventoryScrollList scrollList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setup(Item currentItem, InventoryScrollList currentScrollList)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        iconImage.sprite = item.icon;

        scrollList = currentScrollList;
    }

}
