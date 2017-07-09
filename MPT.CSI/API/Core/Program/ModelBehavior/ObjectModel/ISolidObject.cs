﻿
namespace MPT.CSI.API.Core.Program.ModelBehavior.ObjectModel
{
    /// <summary>
    /// Represents the Solid Object in the application.
    /// </summary>
    public interface ISolidObject :
        IAddableObject,
        ICountable, IListableNames, IChangeableName, IGroupAssignable, ISelectable, IDeletable,
        ILocalAxes, ILocalAxesAdvancedWithPoints, IGUID, ISolidAutoMesh, IEdgeConstraints, 
        ISurfaceSpring, IDeletableSpring,

        IObservableTransformationMatrix, IObservablePoints, IObservableElement,
             
        IObservableSection, IChangeableSection, 
        IObservableMaterialTemperature, IChangeableMaterialTemperature,

        // Loads
        ILoadGravity, 
        ILoadPorePressure, 
        ILoadStrain, 
        ILoadSurfacePressure, 
        ILoadTemperatureConstant 
    {
        
    }
}