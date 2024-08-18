# Mirror Tree
Finding the Second Maximum Value:
FindSecondMax Method: This method identifies the second largest value in the tree.
It first checks if the tree is empty or has only one node, throwing an exception in those cases.
It then traverses to the rightmost node (the largest value).
If this node has a left subtree, the second largest value is found in that subtree.
Otherwise, the second largest value is the parent of the largest node.
### WhiteBored
![WhiteBored](assets/SecondMaximumWhitPord.PNG)
### Output
![Output](assets/SecondMaximumOutput.PNG)