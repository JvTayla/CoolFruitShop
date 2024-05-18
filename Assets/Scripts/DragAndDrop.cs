using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Vector3 startPosition;
    private Transform startParent;

    private void Start()
    {
        startPosition = transform.position;
        startParent = transform.parent;
    }

    private void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPosition();
        isDragging = true;
        startPosition = transform.position;
        startParent = transform.parent;
    }

    private void OnMouseUp()
    {
        isDragging = false;

        Collider2D[] slots = Physics2D.OverlapBoxAll(GetMouseWorldPosition(), new Vector2(1f, 1f), 0f);

        foreach (Collider2D slot in slots)
        {
            if (slot.CompareTag("Chest Slot") && slot.transform.childCount == 0)
            {
                SnapToSlot(slot.transform);
                return;
            }
            else if (slot.CompareTag("Backpack Slot") && slot.transform.childCount == 0)
            {
                SnapToSlot(slot.transform);
                return;
            }
        }

        ReturnToStart();
    }

    private void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void SnapToSlot(Transform slot)
    {
        Vector3 snapPosition = slot.position;
        snapPosition.z = -2f; // Set the z position to -2
        transform.position = snapPosition;
        transform.parent = slot;
    }

    private void ReturnToStart()
    {
        transform.position = startPosition;
        transform.parent = startParent;
    }
}
