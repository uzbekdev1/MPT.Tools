﻿// ***********************************************************************
// Assembly         : MPT.CSI.API
// Author           : Mark Thomas
// Created          : 10-09-2017
//
// Last Modified By : Mark Thomas
// Last Modified On : 10-09-2017
// ***********************************************************************
// <copyright file="eSpectrumDirection_CJJ_166_2011.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
#if !BUILD_ETABS2015 && !BUILD_ETABS2016
namespace MPT.CSI.API.Core.Program.ModelBehavior.Definition.LoadLateralCode.Seismic
{
    /// <summary>
    /// The direction to which the CJJ 166-2011 response spectrum is applied.
    /// </summary>
    public enum eSpectrumDirection_CJJ_166_2011
    {
        /// <summary>
        /// Response spectrum is applied in the horizontal direction.
        /// </summary>
        Horizontal = 1,

        /// <summary>
        /// Response spectrum is applied in the vertical direction.
        /// </summary>
        Vertical = 2
    }
}
#endif
