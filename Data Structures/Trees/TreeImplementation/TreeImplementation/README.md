# Binary Tree and Binary Search Tree Implementation in C#

This project provides a fundamental implementation of **Binary Trees** and **Binary Search Trees** (BST) in C#. It includes functionalities for inserting, deleting, searching, and traversing the trees, along with unit tests to ensure correctness.

## BinaryTree Class
Provides basic binary tree operations:

- **Insert(int value)**: Adds a node to the tree.
- **PreOrderTraversal(TNode node)**: Traverses in pre-order (Root-Left-Right).
- **InOrderTraversal(TNode node)**: Traverses in in-order (Left-Root-Right).
- **PostOrderTraversal(TNode node)**: Traverses in post-order (Left-Right-Root).

public void Insert(int value) 
public void PreOrderTraversal(TNode node) 
public void InOrderTraversal(TNode node) 
public void PostOrderTraversal(TNode node) 

# Binary Search Tree Implementation in C#

This project provides a detailed implementation of a **Binary Search Tree (BST)** in C#. The `BinarySearchTree` class extends basic binary tree functionalities to support efficient operations like insertion, searching, and deletion while maintaining the BST properties. 

## Overview

### `BinarySearchTree` Class

The `BinarySearchTree` class offers several key operations and traversal methods:

- **Add(int value)**: Inserts a new node into the tree while maintaining BST properties.
- **Contains(int value)**: Checks whether a given value exists in the tree.
- **Delete(int value)**: Removes a node from the tree, ensuring the tree remains a valid BST.
- **InOrderTraversalBST(TNode node)**: Performs an in-order traversal of the BST (Left-Root-Right).
- **PostOrderTraversalBST(TNode node)**: Performs a post-order traversal of the BST (Left-Right-Root).
