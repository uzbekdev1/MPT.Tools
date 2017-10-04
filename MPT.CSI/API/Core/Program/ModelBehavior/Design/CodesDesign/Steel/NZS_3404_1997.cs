﻿#if !BUILD_CSiBridgev18 && !BUILD_CSiBridgev19
using MPT.CSI.API.Core.Support;

namespace MPT.CSI.API.Core.Program.ModelBehavior.Design.CodesDesign.Steel
{
    /// <summary>
    /// Steel design code <see cref="NZS_3404_1997"/>.
    /// </summary>
    /// <seealso cref="MPT.CSI.API.Core.Support.CSiApiBase" />
    public class NZS_3404_1997 : CSiApiBase
    {
        #region Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="NZS_3404_1997"/> class.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public NZS_3404_1997(CSiApiSeed seed) : base(seed)
        {
        }


        #endregion

        #region Methods: Public

        /// <summary>
        /// This function retrieves the value of a steel design overwrite item.
        /// </summary>
        /// <param name="name">The name of a frame object with a steel frame design procedure.</param>
        /// <param name="item">The overwrite item considered.</param>
        /// <param name="value">The value of the considered overwrite item.</param>
        /// <param name="programDetermined">True: The specified value is program determined.</param>
        /// <exception cref="CSiException"></exception>
        public void GetOverwrite(string name,
            eOverwrites_NZS_3404_1997 item,
            ref double value,
            ref bool programDetermined)
        {
            _callCode = _sapModel.DesignSteel.NewZealand_NZS3404_97.GetOverwrite(name, (int) item, ref value,
                ref programDetermined);
            if (throwCurrentApiException(_callCode))
            {
                throw new CSiException();
            }
        }

        /// <summary>
        /// This function sets the value of a steel design overwrite item.
        /// </summary>
        /// <param name="name">The name of an existing frame object or group, depending on the value of the <paramref name="itemType"/> item.</param>
        /// <param name="item">The overwrite item considered.</param>
        /// <param name="value">The value of the considered overwrite item.</param>
        /// <param name="itemType">If this item is <see cref="eItemType.Object" />, the assignment is made to the frame object specified by the <paramref name="name"/> item.
        /// If this item is <see cref="eItemType.Group" />, the assignment is made to all frame objects in the group specified by the <paramref name="name"/> item.
        /// If this item is <see cref="eItemType.SelectedObjects" />, assignment is made to all selected frame objects, and the <paramref name="name"/> item is ignored.</param>
        /// <exception cref="CSiException"></exception>
        public void SetOverwrite(string name,
            eOverwrites_NZS_3404_1997 item,
            double value,
            eItemType itemType = eItemType.Object)
        {
            _callCode = _sapModel.DesignSteel.NewZealand_NZS3404_97.SetOverwrite(name, (int) item, value,
                CSiEnumConverter.ToCSi(itemType));
            if (throwCurrentApiException(_callCode))
            {
                throw new CSiException();
            }
        }




        /// <summary>
        /// This function retrieves the value of a steel design preference item.
        /// </summary>
        /// <param name="item">The preference item considered.</param>
        /// <param name="value">The value of the considered preference item.</param>
        /// <exception cref="CSiException"></exception>
        public void GetPreference(ePreferences_NZS_3404_1997 item,
            ref double value)
        {
            _callCode = _sapModel.DesignSteel.NewZealand_NZS3404_97.GetPreference((int) item, ref value);
            if (throwCurrentApiException(_callCode))
            {
                throw new CSiException();
            }
        }

        /// <summary>
        /// This function sets the value of a steel design preference item.
        /// </summary>
        /// <param name="item">The preference item considered.</param>
        /// <param name="value">The value of the considered preference item.</param>
        /// <exception cref="CSiException"></exception>
        public void SetPreference(ePreferences_NZS_3404_1997 item,
            double value)
        {
            _callCode = _sapModel.DesignSteel.NewZealand_NZS3404_97.SetPreference((int) item, value);
            if (throwCurrentApiException(_callCode))
            {
                throw new CSiException();
            }
        }

        #endregion
    }
}
#endif