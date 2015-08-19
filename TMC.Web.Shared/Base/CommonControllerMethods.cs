#region Namespace

using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Resources;
using System.Web;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.Mvc;
using TMC.Shared;

#endregion

namespace TMC.Web.Shared
{
    /// <summary>
    /// Provides static utility methods for Grid View
    /// Author : Nagarro
    /// </summary>
    public static class CommonControllerMethods
    {

        /// <summary>
        /// Get type of dual list items
        /// </summary>
        /// <returns></returns>
        public static IDualListItem AddDualListItems(int id, string displayText)
        {
            IDualListItem retVal = new SelectColumnsDualListItem();

            retVal.Id = id;
            retVal.DisplayText = displayText;

            return retVal;
        }

        /// <summary>
        /// Get salutation values.
        /// </summary>
        /// <returns>
        /// List of salutation as enumerable <see cref="IEnumerable"/>.
        /// </returns>
        public static IEnumerable<SelectListItem> GetSalutationValues()
        {
            IEnumerable<SelectListItem> retVal = null;

      /*      retVal = Enum.GetValues(typeof(IndividualSalutation)).Cast<IndividualSalutation>().
                     Where(salutationType =>
                     salutationType != IndividualSalutation.None).
                     Select(salutationType => new SelectListItem()
                                            {
                                                Text = salutationType.ToString(),
                                                Value = ((int)salutationType).ToString()
                                            });*/

            return retVal;
        }
    }
}