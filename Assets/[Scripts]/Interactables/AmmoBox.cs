using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : Interactable, IDataPersistence
{
    [SerializeField] private string id;
    [SerializeField] private int minAmmo = 20;
    [SerializeField] private int maxAmmo = 30;

    private bool collected = false;
    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public void LoadData(GameData data)
    {
        data.AmmoBoxesCollected.TryGetValue(id, out collected);

        if (collected)
        {
            this.gameObject.SetActive(false);
        }
    }
    public void SaveData(GameData data)
    {
        if (data.AmmoBoxesCollected.ContainsKey(id))
        {
            data.AmmoBoxesCollected.Remove(id);
        }
        
        data.AmmoBoxesCollected.Add(id, collected);
    }

    public GameObject fpsController;

    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
    }

    public override void OnInteract()
    {
        fpsController.GetComponentInChildren<Gun>().AddAmmo(Random.Range(minAmmo, maxAmmo));
        collected = true;
        this.gameObject.SetActive(false);
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
    }
}