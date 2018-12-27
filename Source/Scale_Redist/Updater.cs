using System.Collections.Generic;
using KSP;

namespace TweakScale
{
    public interface IRescalable
    {
        void OnRescale(ScalingFactor factor);
    }
    public interface IRescalable<T> : IRescalable{}

    public interface IFactory20
	{
        int GetPriority();
        bool IsSupported(Part part);
        HashSet<string> GetSupportedModules();
        HashSet<string> GetUnsupportedModules();
        
        IRescalable20 CreateRescalableFor(Part part);
        IDryCost20 CreateDryCostFor(Part part);
	}
    public interface IFactory20<T> : IFactory20{}

    public interface IRescalable20 : IRescalable
    {
        void OnUpdate();
        void OnShipModified();
    }
    public interface IRescalable20<T> : IRescalable20 {}

    public interface IDryCost20
	{
        float Calculate();
	}
    public interface IDryCost20<T> : IDryCost20 {}

    public interface ISanityCheck20
    {
        string Check();
    }
    public interface ISanityCheck20<T> : IDryCost20 {}
}