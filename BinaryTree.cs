﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreee
{
    // Единичен възел на двоичното дърво
    public class BinaryNode
    {
        public int Item;
        public BinaryNode Right;
        public BinaryNode Left;
        public BinaryNode(int item)
        {
            this.Item = item;
        }
    }
        internal class BinaryTree
    {
      
        // Структура двоично дърво
 
            public BinaryNode Root { get; set; }
            public int Count { get; private set; }
            public BinaryTree()
            {
                this.Root = null;
                this.Count = 0;
            }
            public void Add(int item)
            {
                var node = new BinaryNode(item);
                if (this.Root == null)
                {
                    this.Root = node;
                    return;
                }
                BinaryNode it = this.Root;
                while (true)
                {
                    if (it.Left != null && it.Item.CompareTo(item) >= 0) it = it.Left;
                    else if (it.Right != null && it.Item.CompareTo(item) < 0) it = it.Right;
                    else break;
                }
                if (it.Item.CompareTo(item) >= 0) it.Left = node;
                else if (it.Item.CompareTo(item) < 0) it.Right = node;
                this.Count++;
            }

            public bool Contains(int Item)
            {
                if (this.Root == null) return false;
                BinaryNode it = this.Root;
                while (true)
                {
                    if (it == null) return false;
                    else if (it.Item.CompareTo(Item) == 0) return true;
                    else if (it.Item.CompareTo(Item) > 0) it = it.Left;
                    else if (it.Item.CompareTo(Item) < 0) it = it.Right;
                }
            }
        }
    }

 
