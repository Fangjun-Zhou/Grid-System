﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fangjun.PriorityQueue
{
    public interface PriorityQueueADT<T>
    {
        /// <summary>
        /// Push a new element into the PriorityQueue
        /// </summary>
        /// <param name="data">the data you want to store</param>
        /// <returns>return true if success</returns>
        bool Push(T data);

        /// <summary>
        /// Return and remove the largest node in the PriorityQueue
        /// </summary>
        /// <returns>the largest node in the PriorityQueue</returns>
        T Pop();

        /// <summary>
        /// Return but not remove the largest node in the PriorityQueue
        /// </summary>
        /// <returns>the largest node in the PriorityQueue</returns>
        T Peek();

        /// <summary>
        /// Check if the PriorityQueue is empty
        /// </summary>
        /// <returns>return true if empty</returns>
        bool isEmpty { get; }

        /// <summary>
        /// Get the length of the whole PriorityQueue
        /// </summary>
        /// <returns>the length of the whole PriorityQueue</returns>
        int length { get; }
    }
}
