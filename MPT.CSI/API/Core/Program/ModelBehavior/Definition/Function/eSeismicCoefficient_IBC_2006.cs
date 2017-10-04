﻿namespace MPT.CSI.API.Core.Program.ModelBehavior.Definition.Function
{
#if !BUILD_ETABS2015 && !BUILD_ETABS2016
    /// <summary>
    /// Seismic coefficient for IBC 2006 response spectrum function.
    /// </summary>
    public enum eSeismicCoefficient_IBC_2006
    {
        /// <summary>
        /// Ss and S1 are from USGS by latitiude and longitude.
        /// </summary>
        SsAndS1FromUSGSLatLong = 0,

        /// <summary>
        /// Ss and S1 are from USGS by zip code.
        /// </summary>
        SsAndS1FromUSGSZipCode = 1,

        /// <summary>
        /// Ss and S1 are user defined.
        /// </summary>
        SsAndS1UserDefined = 2
    }
#endif
}