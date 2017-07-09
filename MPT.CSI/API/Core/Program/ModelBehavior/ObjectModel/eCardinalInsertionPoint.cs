﻿namespace MPT.CSI.API.Core.Program.ModelBehavior.ObjectModel
{
    /// <summary>
    /// Cardinal insertion points for frames available in the application.
    /// The cardinal point specifies the relative position of the frame section on the line representing the frame object.
    /// </summary>
    public enum eCardinalInsertionPoint
    {
        /// <summary>
        /// Bottom left.
        /// </summary>
        BottomLeft = 1,


        /// <summary>
        /// Bottom center.
        /// </summary>
        BottomCenter = 2,

        /// <summary>
        /// Bottom right.
        /// </summary>
        BottomRight = 3,


        /// <summary>
        /// Middle left.
        /// </summary>
        MiddleLeft = 4,


        /// <summary>
        /// Middle center.
        /// </summary>
        MiddleCenter = 5,


        /// <summary>
        /// Middle right.
        /// </summary>
        MiddleRight = 6,


        /// <summary>
        /// Top left.
        /// </summary>
        TopLeft = 7,


        /// <summary>
        /// Top center.
        /// </summary>
        TopCenter = 8,


        /// <summary>
        /// Top right.
        /// </summary>
        TopRight = 9,


        /// <summary>
        /// Centroid.
        /// </summary>
        Centroid = 10,

        /// <summary>
        /// Shear center.
        /// </summary>
        ShearCenter = 11
    }
}