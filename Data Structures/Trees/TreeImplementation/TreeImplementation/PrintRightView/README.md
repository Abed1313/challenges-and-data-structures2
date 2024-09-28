# Print Right View
The PrintRightView method aims to print the right view of a binary tree but contains issues in its logic. It starts by traversing the right subtree from the root node, printing each node along the right edge. However, the second loop attempts to handle the left subtree by moving to the rightmost nodes, but the control flow is unclear, potentially skipping nodes or failing to capture the correct right view. The traversal and reassignment of current and temp introduce complexity without correctly managing the right view of the tree, especially for nodes in the left subtree. This method needs refinement to ensure it properly captures and prints the nodes visible from the right side.
### WhiteBored
[Link](https://github.com/Abed1313/challenges-and-data-structures2/blob/master/Data%20Structures/Trees/TreeImplementation/TreeImplementation/assets/OutputPrintRight.PNG)
### Output
[Link](https://github.com/Abed1313/challenges-and-data-structures2/blob/master/Data%20Structures/Trees/TreeImplementation/TreeImplementation/assets/PrintRightWhitPord.PNG)
