﻿#if BUILD_SAP2000v16
using SAP2000v16;
#elif BUILD_SAP2000v17
using SAP2000v17;
#elif BUILD_SAP2000v18
using SAP2000v18;
#elif BUILD_SAP2000v19
using SAP2000v19;
#elif BUILD_CSiBridgev18
using CSiBridge18;
#elif BUILD_CSiBridgev19
using CSiBridge19;
#elif BUILD_ETABS2013
using ETABS2013;
#elif BUILD_ETABS2015
using ETABS2015;
#elif BUILD_ETABS2016
using ETABS2016;
#endif

namespace MPT.CSI.API.Core.Support
{
    /// <summary>
    /// Stores references to the basic, fundamental objects of the program for implementing a listener pattern.
    /// </summary>
    /// <seealso cref="MPT.CSI.API.Core.Support.CSiApiBase" />
    public class CSiApiBase
    {
        #region Fields
#if BUILD_SAP2000v16
        protected SAP2000v16.SapObject _sapObject;
#else        
        /// <summary>
        /// The base application object.
        /// </summary>
        protected cOAPI _sapObject;
#endif        
        /// <summary>
        /// The base model object that contains most of the application API calls.
        /// </summary>
        protected cSapModel _sapModel;

        /// <summary>
        /// Code returned by a call to an API method.
        /// </summary>
        protected int _callCode;
        #endregion

        #region Properties        
        /// <summary>
        /// True: Class will throw an exception if the API call fails.
        /// </summary>
        /// <value><c>true</c> if the class will throw an exception if an API call fails; otherwise, <c>false</c>.</value>
        public bool ThrowApiExceptions { get; set; } = true;

        #endregion

        #region Initialization        
        /// <summary>
        /// Initializes a new instance of the <see cref="CSiApiBase"/> class.
        /// </summary>
        public CSiApiBase(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSiApiBase"/> class.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public CSiApiBase(CSiApiSeed seed)
        {
            _sapObject = seed.SapObject;
            _sapModel = seed.SapModel;
        }

#if BUILD_SAP2000v16
        /// <summary>
        /// Initializes a new instance of the <see cref="CSiApiBase"/> class.
        /// </summary>
        /// <param name="sapObject">The sap object.</param>
        /// <param name="sapModel">The sap model.</param>
        public CSiApiBase(SAP2000v16.SapObject sapObject, cSapModel sapModel)
        {
            _sapObject = sapObject;
            _sapModel = sapModel;
        }
#else        
        /// <summary>
        /// Initializes a new instance of the <see cref="CSiApiBase"/> class.
        /// </summary>
        /// <param name="sapObject">The sap object.</param>
        /// <param name="sapModel">The sap model.</param>
        public CSiApiBase(cOAPI sapObject, cSapModel sapModel)
        {
            _sapObject = sapObject;
            _sapModel = sapModel;
        }
#endif

        #endregion

        #region Methods
        /// <summary>
        /// Returns 'true' if the API success code indicates a successful call.
        /// </summary>
        /// <param name="successCode">Code returned by the API call.
        /// 0 means the call was successful.
        /// Any other code indicates failure.</param>
        /// <returns></returns>
        protected bool apiCallIsSuccessful(int successCode)
        {
            return (successCode == 0);
        }

        /// <summary>
        /// Returns 'true' if the API success code indicates a failed call and exceptions are set by this object to be thrown.
        /// </summary>
        /// <param name="successCode">Code returned by the API call.
        /// 0 means the call was successful.
        /// Any other code indicates failure.</param>
        /// <returns></returns>
        protected bool throwCurrentApiException(int successCode)
        {
            return (ThrowApiExceptions && !apiCallIsSuccessful(successCode));
        }
        #endregion
    }
}
