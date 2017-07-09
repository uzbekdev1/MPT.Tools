﻿
using MPT.CSI.API.Core.Helpers;

namespace MPT.CSI.API.Core.Program.ModelBehavior
{
    /// <summary>
    /// Object can return stiffness, weight, and mass modifiers.
    /// </summary>
    public interface IObservableModifiers
    {
        /// <summary>
        /// This function retrieves the modifier assignment. 
        /// The default value for all modifiers is one.
        /// </summary>
        /// <param name="name">The name of an existing element or object.</param>
        /// <param name="modifiers">Unitless modifiers.</param>
        void GetModifiers(string name, ref Modifier modifiers);
    }
}