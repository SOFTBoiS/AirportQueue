using System;

namespace Sorting
{
    public interface IPriorityQueue<T> : IQueue<T> where T : IComparable<T> 
    {
        
    }
}