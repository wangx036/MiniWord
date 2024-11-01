using System;
using System.Collections;
using System.Collections.Generic;

namespace MiniSoftware
{

    public interface ITransverseList : IList {}
    /// <summary>
    /// 横向渲染的 List
    /// </summary>
    public class TransverseList<T> : List<T>, ITransverseList
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