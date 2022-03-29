using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace evitoriav2.Localization
{
    public static class evitoriav2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(evitoriav2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(evitoriav2LocalizationConfigurer).GetAssembly(),
                        "evitoriav2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
