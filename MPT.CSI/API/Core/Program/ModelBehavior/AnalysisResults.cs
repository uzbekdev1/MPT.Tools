﻿using MPT.CSI.API.Core.Program.ModelBehavior.AnalysisResult;
using MPT.CSI.API.Core.Support;

namespace MPT.CSI.API.Core.Program.ModelBehavior
{
    /// <summary>
    /// Represents the analysis setup and results in the application.
    /// </summary>
    /// <seealso cref="MPT.CSI.API.Core.Support.CSiApiBase" />
    public class AnalysisResults : CSiApiBase
    {

        #region Fields
        private readonly CSiApiSeed _seed;

        private AnalysisResultsSetup _analysisResultsSetup;
        private Results _results;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets the analysis results setup.
        /// </summary>
        /// <value>The analysis results setup.</value>
        public AnalysisResultsSetup AnalysisResultsSetup => _analysisResultsSetup ?? (_analysisResultsSetup = new AnalysisResultsSetup(_seed));

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public Results Results => _results ?? (_results = new Results(_seed));
        #endregion


        #region Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisResults"/> class.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public AnalysisResults(CSiApiSeed seed) : base(seed)
        {
            _seed = seed;
        }


        #endregion
    }
}
