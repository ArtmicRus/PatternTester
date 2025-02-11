﻿namespace ObserverPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IObservable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void Notify();
    }
}
