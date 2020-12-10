using System;
using System.Collections.Generic;

namespace _20.TreesAndGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Each Tree is a special type of Graph !!! //not the opposite !
            // three are branched recursive data structures ! / branched --each-root has -node-each node-has a children(node = node)
            // consisting of nodes (elements-children ->)/

            //Binary Tree -> each parent has only/exactly  two children;
            // the tree structure is like a network !
            // graph is a system of connected things !->  the road system in our country is a graph 
            // trees are tye of graph. --example of tree structure is the management system into the company.  Owner-> ChiefLeader> workers;
            // Project Magaers- > TeamLeader -Defelopers /
            // each tree which has a loop is a graph, the nodes has connestions and we can iterate trhough.
            // network --has one connection from one place to another;

             //Tree -dataStructure --management of a company !!
             //graph  data STtucture - > has multiple connections from one place to another ;-- Roads system of the country 
            //  network  DAta Structure - > connection from rooter to computers into local network ;
            // network and grap are almost the same, but graph nhas more connections, and in the two directions 
            //height -its the dictance from its root to its furthest leaf
            // depth --it is a level of distance 
            // the root is always depth = 0 ; level  = 0 ;
            // thenode is the every element is the tree, 
            // each of the connections between the nodes are edges !
            // the root node is the parent to everyone 
            // ancestor meanes -parent in the trees 
            // descendant pretty the same as child

            // siblings = brothers or systers of teh same level-depths
            //binary tree--- each node has only two other nodes-childeren
            //  root node -> left subtree, right subree
            // all the elements on the left side are <= x root node, 
            // all the elements on the right side are > x root node
            //binary searched trees can be balanced 
            // binary balances tree -have height of ~ log(x)
            //balanced trees have for each node  nearly eaqual number of nodes it its subtrees
            //searching in the binary tree is fast it takes  log(n) steps
            // each single node is a tree, 
            // each tree has nodes
            //leaf--is a node that doesnt have child !


        }
        public class TreeNode<T> 
        {
            private T value;
            private List<TreeNode<T>> children; // <TreeNode> is a pointers to the children of the node !
        } //this is how to define a tree
        //We use trees to store some values in specific way !
    }
}
