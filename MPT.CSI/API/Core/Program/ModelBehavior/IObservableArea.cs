﻿
namespace MPT.CSI.API.Core.Program.ModelBehavior
{
    /// <summary>
    /// Object can return area-unique properties.
    /// </summary>
    public interface IObservableArea
    {
        /// <summary>
        /// This function retrieves the joint offset assignments for area elements.
        /// </summary>
        /// <param name="name">The name of an existing area element.</param>
        /// <param name="offsetType">Indicates the joint offset type.</param>
        /// <param name="offsetPattern">This item applies only when <paramref name="offsetType"/> = <see cref="eAreaOffsetType.OffsetByJointPattern"/>. 
        /// It is the name of the defined joint pattern that is used to calculate the thicknesses.</param>
        /// <param name="offsetPatternScaleFactor">This item applies only when <paramref name="offsetType"/> = <see cref="eAreaOffsetType.OffsetByJointPattern"/>. 
        /// It is the scale factor applied to the joint pattern when calculating the thicknesses. [L]</param>
        /// <param name="offsets">This item applies only when <paramref name="offsetType"/> = <see cref="eAreaOffsetType.OffsetByPoint"/>. 
        /// It is an array of thicknesses at each of the points that define the area element. [L]</param>
        void GetOffsets(string name,
            ref eAreaOffsetType offsetType,
            ref string offsetPattern,
            ref double offsetPatternScaleFactor,
            ref double[] offsets);

        /// <summary>
        /// This function retrieves the thickness overwrite assignments for area elements.
        /// </summary>
        /// <param name="name">The name of an existing area element.</param>
        /// <param name="thicknessType">Indicates the thickness overwrite type.</param>
        /// <param name="thicknessPattern">This item applies only when <paramref name="thicknessType"/> = <see cref="eAreaThicknessType.OverwriteByJointPattern"/>. 
        /// It is the name of the defined joint pattern that is used to calculate the thicknesses.</param>
        /// <param name="thicknessPatternScaleFactor">This item applies only when <paramref name="thicknessType"/> = <see cref="eAreaThicknessType.OverwriteByJointPattern"/>. 
        /// It is the scale factor applied to the joint pattern when calculating the thicknesses. [L]</param>
        /// <param name="thicknesses">This item applies only when <paramref name="thicknessType"/> = <see cref="eAreaThicknessType.OverwriteByPoint"/>. 
        /// It is an array of thicknesses at each of the points that define the area element. [L]</param>
        void GetThickness(string name,
            ref eAreaThicknessType thicknessType,
            ref string thicknessPattern,
            ref double thicknessPatternScaleFactor,
            ref double[] thicknesses);
    }
}
