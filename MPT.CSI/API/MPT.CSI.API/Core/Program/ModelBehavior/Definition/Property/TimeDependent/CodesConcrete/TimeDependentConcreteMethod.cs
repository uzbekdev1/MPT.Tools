﻿// ***********************************************************************
// Assembly         : MPT.CSI.API
// Author           : Mark Thomas
// Created          : 10-07-2017
//
// Last Modified By : Mark Thomas
// Last Modified On : 10-07-2017
// ***********************************************************************
// <copyright file="TimeDependentConcreteMethod.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
#if !BUILD_ETABS2015 && !BUILD_ETABS2016
using MPT.CSI.API.Core.Support;

namespace MPT.CSI.API.Core.Program.ModelBehavior.Definition.Property.TimeDependent.CodesConcrete
{
    /// <summary>
    /// Represents the time dependent concrete material code in the application.
    /// </summary>
    /// <seealso cref="MPT.CSI.API.Core.Support.CSiApiBase" />
    public abstract class TimeDependentConcreteMethod : CSiApiBase
    {
        #region Initialization        
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDependentConcreteMethod" /> class.
        /// </summary>
        /// <param name="seed">The seed.</param>
        protected TimeDependentConcreteMethod(CSiApiSeed seed) : base(seed) { }
        #endregion

        // No methods created, as this is meant to be a shared type for all response spectrum functions.
    }
}
#endif