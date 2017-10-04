﻿#if BUILD_SAP2000v16 || BUILD_SAP2000v17 || BUILD_SAP2000v18 || BUILD_SAP2000v19
namespace MPT.CSI.API.Core.Program.ModelBehavior.Design.CodesDesign.Concrete
{
    /// <summary>
    /// Overwrites available for <see cref="TS_500_2000"/> concrete design in the application.
    /// </summary>
    public enum eOverwrites_TS_500_2000
    {
        /// <summary>
        /// Framing type.
        /// </summary>
        FramingType = 1,

        /// <summary>
        /// The live load reduction factor.
        /// </summary>
        LiveLoadReductionFactor = 2,

        /// <summary>
        /// The unbraced length ratio, major.
        /// </summary>
        UnbracedLengthRatio_Major = 3,

        /// <summary>
        /// The unbraced length ratio, minor.
        /// </summary>
        UnbracedLengthRatio_Minor = 4,

        /// <summary>
        /// The effective length factor, K major.
        /// </summary>
        EffectiveLengthFactor_K_Major = 5,

        /// <summary>
        /// The effective length factor, K minor.
        /// </summary>
        EffectiveLengthFactor_K_Minor = 6,

        /// <summary>
        /// The moment coefficient, Cm major.
        /// </summary>
        MomentCoefficient_Cm_Major = 7,

        /// <summary>
        /// The moment coefficient, Cm minor.
        /// </summary>
        MomentCoefficient_Cm_Minor = 8,

        /// <summary>
        /// The non-sway moment factor, Bns major.
        /// </summary>
        NonswayMomentFactor_Bns_Major = 9,

        /// <summary>
        /// The non-sway moment factor, Bns minor.
        /// </summary>
        NonswayMomentFactor_Bns_Minor = 10,

        /// <summary>
        /// The sway moment factor, Bs major.
        /// </summary>
        SwayMomentFactor_Bs_Major = 11,

        /// <summary>
        /// The sway moment factor, Bs minor.
        /// </summary>
        SwayMomentFactor_Bs_Minor = 12,
    }
}
#endif