# Linked List Rotate Left Challenge

## Challenge Description:
The RotateLeft method rotates a linked list to the left by k positions. It starts by setting current to the head of the list and enters a loop that continues until k becomes 0. In each iteration, the data from the current node is appended to the end of the list using InsertLast, and the current node is deleted from its original position with DeleteSpecifiedData. The pointer then moves to the next node, and k is decremented. This process shifts the first k nodes from the front of the list to the end, effectively rotating the list to the left.
### Whiteboard
![Whiteboard Image](assets/.PNG)
### output:
![Output Image](assets/.PNG)