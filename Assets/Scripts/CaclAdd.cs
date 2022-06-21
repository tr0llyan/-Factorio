using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaclAdd : MonoBehaviour
{
    [SerializeField] private GameObject PanelName;  
    [SerializeField] private Text TextName;
    [SerializeField] private InputField InputName;
    [SerializeField] private Text ClockTime;
    [SerializeField] private Text MaterialTime;
    [SerializeField] private Image ChoosenItem;
    [SerializeField] private Text SecondMaterialCount;
    [SerializeField] private Text ThirdMaterialCount;
    [SerializeField] private Text FourthMaterialCount;
    [SerializeField] private Text FifthMaterialCount;


    public void SetCount(double time, double count, double secondCoun, double thirdCount, double fourhCount, double fifthCount)
    {
        if (InputName.text == "")  Debug.Log("Ошибка");
        else
        {
            TextName.text = InputName.text;
            if (PanelName == false) TextName.text = "";
            var convertedInputText = Convert.ToDouble(InputName.text);
            ClockTime.text = (convertedInputText * time).ToString();
            MaterialTime.text = (convertedInputText * count).ToString();
            SecondMaterialCount.text = (convertedInputText * secondCoun).ToString();
            ThirdMaterialCount.text = (convertedInputText * thirdCount).ToString();
            FourthMaterialCount.text = (convertedInputText * fourhCount).ToString();
            FifthMaterialCount.text = (convertedInputText * fifthCount).ToString();
            Debug.Log("Успешно");
        }
    }
    
    public void SelectButton()
    {
        string ItemName = ChoosenItem.GetComponent<Image>().sprite.name;
        if (ItemName == "WoodenChessst_0") SetCount(0.5,2,0,0,0,0);
        if (ItemName == "iron-chest_0") SetCount(0.5,8,0,0,0, 0);
        if (ItemName == "steel-chest_0") SetCount(0.5,8,0,0, 0, 0);
        if (ItemName == "storage-tank_0") SetCount(3,20,5,0, 0, 0);
        if (ItemName == "1234_2") SetCount(0.5 / 2.0, 1.0 / 2.0, 1.0 / 2.0,0, 0, 0);
        if (ItemName == "fast-transport-belt_0") SetCount(0.5, 1, 5,0, 0, 0);
        if (ItemName == "express-transport-belt_0") SetCount(0.5, 1, 10, 20, 0, 0);
        if (ItemName == "underground-belt_0") SetCount(1.0 / 2.0, 10.0 / 2.0, 5.0 / 2.0, 0, 0, 0);
        if (ItemName == "fast-underground-belt_0") SetCount(2.0 / 2.0, 40.0 / 2.0, 2.0 / 2.0, 0, 0, 0);
        if (ItemName == "express-underground-belt_0") SetCount(2.0 / 2.0, 2.0 / 2.0, 80.0 / 2.0, 40.0 / 2.0, 0, 0);
        if (ItemName == "splitter_0") SetCount(1, 5, 5, 4, 0, 0);
        if (ItemName == "fast-splitter_0") SetCount(2, 10, 10, 1, 0, 0);
        if (ItemName == "express-splitter_0") SetCount(2, 10, 1, 10, 80, 0);
        if (ItemName == "burner-inserter_0") SetCount(0.5, 1, 1, 0, 0, 0);
        if (ItemName == "1234_62") SetCount(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "long-handed-inserter_3") SetCount(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "fast-inserter_3") SetCount(0.5, 2, 1, 2, 0, 0);
        if (ItemName == "filter-inserter_0") SetCount(0.5, 4, 1, 0, 0, 0);
        if (ItemName == "stack-inserter_3") SetCount(0.5, 1, 15, 1, 15, 0);
        if (ItemName == "stack-filter-inserter_3") SetCount(0.5, 5, 1, 0, 0, 0);
        if (ItemName == "small-electric-pole_0") SetCount(0.25, 1, 0.5, 0, 0, 0);
        if (ItemName == "medium-electric-pole_0") SetCount(0.5, 2, 4, 2, 0, 0);
        if (ItemName == "1234_5") SetCount(0.5, 5, 8, 5, 0, 0);
        if (ItemName == "1234_30") SetCount(0.5, 5, 5, 10, 0, 0);
        if (ItemName == "pipe_0") SetCount(0.5, 1, 0, 0, 0, 0);
        if (ItemName == "pipe-to-ground_0") SetCount(0.25, 2.5, 5, 0, 0, 0);
        if (ItemName == "pump_0") SetCount(2, 1, 1, 1, 0, 0);
        if (ItemName == "rail_0") SetCount(0.25, 0.5, 0.5, 0.5, 0, 0);
        if (ItemName == "train-stop_0") SetCount(0.5, 5, 6, 6, 3, 0);
        if (ItemName == "rail-signal_0") SetCount(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "rail-chain-signal_3") SetCount(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "locomotive_0") SetCount(4, 10, 20, 30, 0, 0);
        if (ItemName == "cargo-wagon_0") SetCount(1, 10, 20, 20, 0, 0);
        if (ItemName == "fluid-wagon_0") SetCount(1.5, 10, 8, 16, 1,0);
        if (ItemName == "artillery-wagon_0") SetCount(4, 20, 64, 10, 16, 40);
        if (ItemName == "car_0") SetCount(2, 8, 20, 5, double.NaN, double.NaN);
        if (ItemName == "tank_0") SetCount(5, 10, 32, 15, 50, double.NaN);
        if (ItemName == "spidertron-remote_0") SetCount(0.5, 1, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "logistic-robot_0") SetCount(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "construction-robot_0") SetCount(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "active-provider-chest-remnants_0" || ItemName == "passive-provider-chest-remnants_0"
            || ItemName == "storage-chest-remnants_0"
            || ItemName == "buffer-chest-remnants_0"
            || ItemName == "requester-chest-remnants") SetCount(0.5, 1, 3, 1, double.NaN, double.NaN);
        if (ItemName == "roboport_0") SetCount(5, 45, 45, 45, double.NaN, double.NaN);
    }
    
    public void SelectRemoveItem()
    {
        string ItemName = ChoosenItem.GetComponent<Image>().sprite.name;
        if (ItemName == "WoodenChessst_0") clickedRemove(0.5,2,0, 0, 0, 0);
        if (ItemName == "iron-chest_0" || ItemName == "steel-chest_0") clickedRemove(0.5,8,0, 0, 0, 0);
        if (ItemName == "storage-tank_0") clickedRemove(3,20,5, 0, 0, 0);
        if (ItemName == "1234_2") clickedRemove(0.5 / 2.0, 1.0 / 2.0, 1.0 / 2.0, 0, 0, 0);
        if (ItemName == "fast-transport-belt_0") clickedRemove(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "express-transport-belt_0") clickedRemove(0.5, 1, 10, 20, 0, 0);
        if (ItemName == "underground-belt_0") clickedRemove(1.0 / 2.0, 10.0 / 2, 5.0 / 2.0, 0, 0, 0);
        if (ItemName == "fast-underground-belt_0") clickedRemove(2.0 / 2.0, 40.0 / 2.0, 2.0 / 2.0, 0, 0, 0);
        if (ItemName == "express-underground-belt_0") clickedRemove(2.0 / 2.0, 2.0 / 2.0, 80.0 / 2.0, 40.0 / 2.0, 0, 0);
        if (ItemName == "splitter_0") clickedRemove(1, 5, 5, 4, 0, 0);
        if (ItemName == "fast-splitter_0") clickedRemove(2, 10, 10, 1, 0, 0);
        if (ItemName == "express-splitter_0") clickedRemove(2, 10, 1, 10, 80, 0);
        if (ItemName == "burner-inserter_0") clickedRemove(0.5, 1, 1, 0, 0, 0);
        if (ItemName == "1234_62") clickedRemove(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "long-handed-inserter_3") clickedRemove(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "fast-inserter_3") clickedRemove(0.5, 2, 1, 2, 0, 0);
        if (ItemName == "filter-inserter_0") clickedRemove(0.5, 4, 1, 0, 0, 0);
        if (ItemName == "stack-inserter_3") clickedRemove(0.5, 1, 15, 1, 15, 0);
        if (ItemName == "stack-filter-inserter_3") clickedRemove(0.5, 5, 1, 0, 0, 0);
        if (ItemName == "small-electric-pole_0") clickedRemove(0.25, 1, 0.5, 0, 0, 0);
        if (ItemName == "medium-electric-pole_0") clickedRemove(0.5, 2, 4, 2, 0, 0);
        if (ItemName == "1234_5") clickedRemove(0.5, 5, 8, 5, 0, 0);
        if (ItemName == "1234_30") clickedRemove(0.5, 5, 5, 10, 0, 0);
        if (ItemName == "pipe_0") clickedRemove(0.5, 1, 0, 0, 0, 0);
        if (ItemName == "pipe-to-ground_0") clickedRemove(0.25, 2.5, 5, 0, 0, 0);
        if (ItemName == "pump_0") clickedRemove(2, 1, 1, 1, 0, 0);
        if (ItemName == "rail_0") clickedRemove(0.25, 0.5, 0.5, 0.5, 0, 0);
        if (ItemName == "train-stop_0") clickedRemove(0.5, 5, 6, 6, 3, 0);
        if (ItemName == "rail-signal_0") clickedRemove(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "rail-chain-signal_3") clickedRemove(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "locomotive_0") clickedRemove(4, 10, 20, 30, 0, 0);
        if (ItemName == "cargo-wagon_0") clickedRemove(1, 10, 20, 20, 0, 0);
        if (ItemName == "fluid-wagon_0") clickedRemove(1.5, 10, 8, 16, 1, 0);
        if (ItemName == "artillery-wagon_0") clickedRemove(4, 20, 64, 10, 16, 40);
        if (ItemName == "car_0") clickedRemove(2, 8, 20, 5, double.NaN, double.NaN);
        if (ItemName == "tank_0") clickedRemove(5, 10, 32, 15, 50, double.NaN);
        if (ItemName == "spidertron-remote_0") clickedRemove(0.5, 1, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "logistic-robot_0") clickedRemove(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "construction-robot_0") clickedRemove(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "active-provider-chest-remnants_0" || ItemName == "passive-provider-chest-remnants_0"
            || ItemName == "storage-chest-remnants_0"
            || ItemName == "buffer-chest-remnants_0"
            || ItemName == "requester-chest-remnants") clickedRemove(0.5, 1, 3, 1, double.NaN, double.NaN);
        if (ItemName == "roboport_0")   clickedRemove(5, 45, 45, 45, double.NaN, double.NaN);
    }

    public void SelectAddItem() 
    {
        string ItemName = ChoosenItem.GetComponent<Image>().sprite.name;
        if (ItemName == "WoodenChessst_0") clickedAdd(0.5,2,0, 0, 0, 0);
        if (ItemName == "iron-chest_0" || ItemName == "steel-chest_0") clickedAdd(0.5,8,0, 0, 0, 0);
        if (ItemName == "storage-tank_0") clickedAdd(3, 20, 5, 0, 0, 0);
        if (ItemName == "1234_2") clickedAdd(0.5 / 2.0, 1.0 / 2.0, 1.0 / 2.0,0, 0, 0);
        if (ItemName == "fast-transport-belt_0") clickedAdd(0.5, 1, 5,0, 0, 0);
        if (ItemName == "express-transport-belt_0") clickedAdd(0.5, 1, 10, 20, 0, 0);
        if (ItemName == "underground-belt_0") clickedAdd(1.0 / 2.0, 10.0 / 2, 5.0 / 2.0, 0, 0, 0);
        if (ItemName == "fast-underground-belt_0") clickedAdd(2.0 / 2.0, 40.0 / 2.0, 2.0 / 2.0, 0, 0, 0);
        if (ItemName == "express-underground-belt_0") clickedAdd(2.0 / 2.0, 2.0 / 2.0, 80.0 / 2.0, 40.0 / 2.0, 0, 0);
        if (ItemName == "splitter_0") clickedAdd(1, 5, 5, 4, 0, 0);
        if (ItemName == "fast-splitter_0") clickedAdd(2, 10, 10, 1, 0, 0);
        if (ItemName == "express-splitter_0") clickedAdd(2, 10, 1, 10, 80, 0);
        if (ItemName == "burner-inserter_0") clickedAdd(0.5, 1, 1, 0, 0, 0);
        if (ItemName == "1234_62") clickedAdd(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "long-handed-inserter_3") clickedAdd(0.5, 1, 1, 1, 0, 0);
        if (ItemName == "fast-inserter_3") clickedAdd(0.5, 2, 1, 2, 0, 0);
        if (ItemName == "filter-inserter_0") clickedAdd(0.5, 4, 1, 0, 0, 0);
        if (ItemName == "stack-inserter_3") clickedAdd(0.5, 1, 15, 1, 15, 0);
        if (ItemName == "stack-filter-inserter_3") clickedAdd(0.5, 5, 1, 0, 0, 0);
        if (ItemName == "small-electric-pole_0") clickedAdd(0.25, 1, 0.5, 0, 0, 0);
        if (ItemName == "medium-electric-pole_0") clickedAdd(0.5, 2, 4, 2, 0, 0);
        if (ItemName == "1234_5") clickedAdd(0.5, 5, 8, 5, 0, 0);
        if (ItemName == "1234_30") clickedAdd(0.5, 5, 5, 10, 0, 0);
        if (ItemName == "pipe_0") clickedAdd(0.5, 1, 0, 0, 0, 0);
        if (ItemName == "pipe-to-ground_0") clickedAdd(0.25, 2.5, 5, 0, 0, 0);
        if (ItemName == "pump_0") clickedAdd(2, 1, 1, 1, 0, 0);
        if (ItemName == "rail_0") clickedAdd(0.25, 0.5, 0.5, 0.5, 0, 0);
        if (ItemName == "train-stop_0") clickedAdd(0.5, 5, 6, 6, 3, 0);
        if (ItemName == "rail-signal_0") clickedAdd(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "rail-chain-signal_3") clickedAdd(0.5, 1, 5, 0, 0, 0);
        if (ItemName == "locomotive_0") clickedAdd(4, 10, 20, 30, 0, 0);
        if (ItemName == "cargo-wagon_0") clickedAdd(1, 10, 20, 20, 0, 0);
        if (ItemName == "fluid-wagon_0") clickedAdd(1.5, 10, 8, 16, 1, 0);
        if (ItemName == "artillery-wagon_0") clickedAdd(4, 20, 64, 10, 16, 40);
        if (ItemName == "car_0") clickedAdd(2, 8, 20, 5, double.NaN, double.NaN);
        if (ItemName == "tank_0") clickedAdd(5, 10, 32, 15, 50, double.NaN);
        if (ItemName == "spidertron-remote_0") clickedAdd(0.5, 1, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "logistic-robot_0") clickedAdd(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "construction-robot_0") clickedAdd(0.5, 2, 1, double.NaN, double.NaN, double.NaN);
        if (ItemName == "active-provider-chest-remnants_0" || ItemName == "passive-provider-chest-remnants_0"
            || ItemName == "storage-chest-remnants_0"
            || ItemName == "buffer-chest-remnants_0"
            || ItemName == "requester-chest-remnants") clickedAdd(0.5, 1, 3, 1, double.NaN, double.NaN);
        if (ItemName == "roboport_0") clickedAdd(5, 45, 45, 45, double.NaN, double.NaN);
    }

    public void clickedAdd(double time, double count, double secondCount, double thirdCount, double fourhCount, double fifthCount)
    {

        var convertedInputText = Convert.ToInt32(TextName.text);
        if (convertedInputText < 99)
        {
            TextName.text = (convertedInputText + 1).ToString();
            convertedInputText = Convert.ToInt32(TextName.text);
            
        }
        ClockTime.text = (convertedInputText * time).ToString();
        MaterialTime.text = (convertedInputText * count).ToString();
        SecondMaterialCount.text = (convertedInputText * secondCount).ToString();
        ThirdMaterialCount.text = (convertedInputText * thirdCount).ToString();
        FourthMaterialCount.text = (convertedInputText * fourhCount).ToString();
        FifthMaterialCount.text = (convertedInputText * fifthCount).ToString();

    }

    public void clickedRemove(double time, double count, double secondCount, double thirdCount, double fourhCount,double fifthCount)
    {
        var convertedInputText = Convert.ToInt32(TextName.text);
        if (convertedInputText > 1)
        {
            TextName.text = (convertedInputText - 1).ToString();    
            convertedInputText = Convert.ToInt32(TextName.text);
        }
        ClockTime.text = (convertedInputText * time).ToString();
        MaterialTime.text = (convertedInputText * count).ToString();
        SecondMaterialCount.text = (convertedInputText * secondCount).ToString();
        ThirdMaterialCount.text = (convertedInputText * thirdCount).ToString();
        FourthMaterialCount.text = (convertedInputText * fourhCount).ToString();
        FifthMaterialCount.text = (convertedInputText * fifthCount).ToString();
    }
}
