﻿namespace MPT.CSI.API.Core.Program.ModelBehavior.Definition.Function
{
#if !BUILD_ETABS2015 && !BUILD_ETABS2016
    /// <summary>
    /// Value type used in files defining loading functions.
    /// </summary>
    public enum eFileValueType
    {
        /// <summary>
        /// Values at equal time intervals.
        /// </summary>
        EqualTimeIntervals = 1,

        /// <summary>
        /// Time and function values.
        /// </summary>
        TimeAndFunction = 2
    }
#endif
}