using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    /// <summary>
    /// Base class for all common controls
    /// </summary>
    public abstract class BaseControlConfig
    {
        /// <summary>
        /// Used to add css class.
        /// </summary>
        public string CssClass = string.Empty;
        /// <summary>
        /// Set disable property
        /// </summary>
        public bool Disabled = false;
    }
}
