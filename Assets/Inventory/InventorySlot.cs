using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
	UseOfItems itemUse;
	public Item item;
	GameObject ItemInfo;
	public GameObject ObjectInSlot;
	bool infoShown = false;
	public bool SlotClicked = false;
	public Transform InventorySlots;
	InventorySlot[] slots;
	public Transform BeltSlots;
	InventorySlot[] beltSlots;
	public Image icon;
	public bool isWeared;
	Image info;
	Image InfoIcon;
	Text description;
	Button UnEquipButton;
	Button UseButton;
	Button WearButton;
	Button DropButton;
	GameObject Player;

	void Start () {
		InfoIcon = GameObject.Find ("ItemIcon").GetComponent<Image>();
		info = GameObject.Find ("ItemInfo").GetComponent<Image> ();
		Player = GameObject.Find ("Player");
		UseButton = GameObject.Find ("UseButton").GetComponent<Button>();
		WearButton = GameObject.Find ("WearButton").GetComponent<Button>();
		DropButton = GameObject.Find ("DropButton").GetComponent<Button>();
		UnEquipButton = GameObject.Find ("UnEquipButton").GetComponent<Button> ();
		description = GameObject.Find ("Description").GetComponent<Text>();
		itemUse = Player.GetComponent<UseOfItems> ();
		slots = InventorySlots.GetComponentsInChildren<InventorySlot> ();
		beltSlots = BeltSlots.GetComponentsInChildren<InventorySlot> ();

		UnEquipButton.enabled = false;
	}
		

	public void showInfo() {			//показывает информацию о предмете (добавить onClickEvent на все слоты инвентаря
		
		if (item != null) {
			for (int i = 0; i < slots.Length; i++) {
				if (slots [i].infoShown)
					slots [i].hideInfo ();
			}

			for (int i = 0; i < beltSlots.Length; i++) {
				if (beltSlots [i].infoShown) {					//возоможны пары багов из за того что у меня slotclicked отдельно у belt и обычных слотов!
					beltSlots [i].hideInfo();
				}
			}


			SlotClicked = true;

			if (isWeared)
				unEquipButtonAppear ();
			else
				EquipButtonAppear ();

			if (item.canUse) {
				UseButton.enabled = true;
				UseButton.image.enabled = true;
			}
			
			if (item.canWear) {
				WearButton.enabled = true;
				WearButton.image.enabled = true;
			}

			if (item.canDrop) {
				DropButton.enabled = true;
				DropButton.image.enabled = true;
			}


			InfoIcon.sprite = item.icon;
			InfoIcon.enabled = true;
			description.text = item.description;
			description.enabled = true;


			info.enabled = true;
			infoShown = true;
		}
	}

	public void hideInfo() {			//закрывает окно с информацией
		SlotClicked = false;
		UseButton.enabled = false;
		WearButton.enabled = false;
		DropButton.enabled = false;
		UseButton.image.enabled = false;
		WearButton.image.enabled = false;
		DropButton.image.enabled = false;
		description.enabled = false;
		InfoIcon.enabled = false;
		info.enabled = false;
		infoShown = false;
	}

	public void AddItem(Item newItem) {
		item = newItem;
		icon.sprite = item.icon;
		icon.enabled = true;
	}

	public void AddItemObject(GameObject itemObj) {
		ObjectInSlot = itemObj;
	}

	public void ClearSlot() {
		item = null;
		icon.sprite = null;
		icon.enabled = false;
	}

	public void UseItem() {
		if (SlotClicked) {
			itemUse.ItemFunctions (item, ObjectInSlot);
			hideInfo ();
		}
	}

	public void addOnBelt() {			//добавляем к кнопке WearButton onClickEvent с этой функцией
		if (SlotClicked) {
			itemUse.ItemFunctions (item, ObjectInSlot);
			Inventory.instance.AddOnBelt (item, ObjectInSlot);
			Inventory.instance.Remove (item, ObjectInSlot);
			ObjectInSlot = null;
			item = null;
				hideInfo ();
			}
		}

	public void DropItem() {
		if (SlotClicked) {
			hideInfo ();
			ObjectInSlot.transform.position = Player.transform.position;
			ObjectInSlot.SetActive(true);
			Inventory.instance.Remove (item, ObjectInSlot);
			ObjectInSlot = null;
		}
	}

	public void unEquipButtonAppear() {
		if (item != null) {
			WearButton.enabled = false;
			WearButton.image.enabled = false;
			UnEquipButton.image.enabled = true;
			UnEquipButton.enabled = true;
		}
	}

	public void EquipButtonAppear() {
		if (item != null) {
			WearButton.enabled = true;
			WearButton.image.enabled = true;
			UnEquipButton.image.enabled = false;
			UnEquipButton.enabled = false;
		}
	}

	public void unEquip () {							
		if (SlotClicked) {
			UnEquipButton.image.enabled = false;
			UnEquipButton.enabled = false;
			
			if (item.Ammo)
				itemUse.UnEquipAmmo (ObjectInSlot);		//функция которая отнимает количество патронов когда игрок снимает их (функция из другого скрипта не относящегося к инвентарю)
			
			Inventory.instance.Add (item, ObjectInSlot);
			Inventory.instance.removeFromBelt (item, ObjectInSlot);
			ObjectInSlot = null;
			ClearSlot ();

			hideInfo ();
		}
	}

}
