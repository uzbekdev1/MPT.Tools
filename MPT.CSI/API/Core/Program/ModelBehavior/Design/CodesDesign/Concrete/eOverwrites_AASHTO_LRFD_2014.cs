﻿#if BUILD_CSiBridgev18 || BUILD_CSiBridgev19
namespace MPT.CSI.API.Core.Program.ModelBehavior.Design.CodesDesign.Concrete
{
    /// <summary>
    /// Overwrites available for <see cref="AASHTO_LRFD_2014"/> concrete design in the application.
    /// </summary>
    public enum eOverwrites_AASHTO_LRFD_2014
    {
        /// <summary>
        /// The live load reduction factor.
        /// </summary>
        LiveLoadReductionFactor = 1,

        /// <summary>
        /// The unbraced length ratio, major.
        /// </summary>
        UnbracedLengthRatio_Major = 2,

        /// <summary>
        /// The unbraced length ratio, minor.
        /// </summary>
        UnbracedLengthRatio_Minor = 3,

        /// <summary>
        /// The effective length factor, K major.
        /// </summary>
        EffectiveLengthFactor_K_Major = 4,

        /// <summary>
        /// The effective length factor, K minor.
        /// </summary>
        EffectiveLengthFactor_K_Minor = 5,

        /// <summary>
        /// The moment coefficient, Cm major.
        /// </summary>
        MomentCoefficient_Cm_Major = 6,

        /// <summary>
        /// The moment coefficient, Cm minor.
        /// </summary>
        MomentCoefficient_Cm_Minor = 7,

        /// <summary>
        /// The non-sway moment factor, Db major.
        /// </summary>
        NonswayMomentFactor_Db_Major = 8,

        /// <summary>
        /// The non-sway moment factor, Db minor.
        /// </summary>
        NonswayMomentFactor_Db_Minor = 9,

        /// <summary>
        /// The sway moment factor, Ds major.
        /// </summary>
        SwayMomentFactor_Ds_Major = 10,

        /// <summary>
        /// The sway moment factor, Ds minor.
        /// </summary>
        SwayMomentFactor_Ds_Minor = 11,
    }
}
  #endif