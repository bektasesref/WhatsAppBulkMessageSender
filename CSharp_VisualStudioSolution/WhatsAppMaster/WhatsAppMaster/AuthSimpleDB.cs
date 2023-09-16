using System.Configuration;

namespace WhatsAppMaster
{
    public class AuthSimpleDB : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string UserName
        {
            get
            {
                return ((string)this["UserName"]);
            }
            set
            {
                this["UserName"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string Password
        {
            get
            {
                return ((string)this["Password"]);
            }
            set
            {
                this["Password"] = value;
            }
        }
    }
}