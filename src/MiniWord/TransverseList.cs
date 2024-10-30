using System;
using System.Collections.Generic;

namespace MiniSoftware
{
    /// <summary>
    /// 横向渲染的 List
    /// </summary>
    public class TransverseList<T> : List<T>
    {
        public TransverseList(){}
        public TransverseList(List<T> list)
        {
            if (list == null)
                return;

            foreach (var item in list)
            {
                if (item is T castedItem)
                {
                    Add(castedItem);
                }
                else
                {
                    throw new InvalidCastException($"Cannot cast item of type {item.GetType()} to {typeof(T)}");
                }
            }
        }
    }



}