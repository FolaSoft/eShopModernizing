using Microsoft.Configuration.ConfigurationBuilders;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace eShopLegacyWebForms
{
    /// <summary> 
    /// A version of <see cref="AzureKeyVaultConfigBuilder"/> that correctly handles optional. See https://github.com/aspnet/MicrosoftConfigurationBuilders/pull/56 
    /// for general fix. 
    /// </summary> 
    public class OptionalKeyVaultConfigurationBuilder : AzureKeyVaultConfigBuilder
    {
        protected override void LazyInitialize(string name, NameValueCollection config)
        {
            try
            {
                base.LazyInitialize(name, config);
            }
            catch (Exception) when (Optional)
            {
            }
        }
    }

}