using DevExtreme.AspNet.Mvc;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs
{
    public class TagControlConfig : SelectionBaseControlConfig
    {
        public bool SeachEnabled { get; set; } = true;
        public int MaxDisplayTags { get; set; } = 10;
    }
}
