﻿namespace Core.Persistence.Paging;

public interface IPaginate<T>
{
    public int From { get; }
    public int Index { get; }
    public int Size { get; }
    public int Count { get; }
    public int Pages { get; }
    IList<T> Items { get; }
    public bool HasPrevious { get; }
    public bool HasNext { get; }
}
