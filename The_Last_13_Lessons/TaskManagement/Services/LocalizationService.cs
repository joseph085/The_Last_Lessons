using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Exceptions;
using TaskManagement.Utilities;

namespace TaskManagement.Services
{
    public class LocalizationService
    {
        public static SupportedCulture CurrentCulture { get; set; } = SupportedCulture.Azerbaijani;

        private static List<TranslationContainer> _translations = new List<TranslationContainer>
        {
            new TranslationContainer
            (TranslationKey.AccountBlocked, AzerbaijaniTranlations.AccountBlocked, RussianTranlations.AccountBlocked, EnglishTranslations.AccountBlocked ),
            new TranslationContainer
            (TranslationKey.GetAdminName, AzerbaijaniTranlations.GetAdminName, RussianTranlations.GetAdminName, EnglishTranslations.GetAdminName),
        };

        public static string GetTranslation(TranslationKey key)
        {
            foreach (TranslationContainer translation in _translations)
            {
                if (translation.Key == key)
                {
                    if (CurrentCulture == SupportedCulture.Azerbaijani)
                    {
                        return translation.Azerbaijani;
                    }
                    else if(CurrentCulture == SupportedCulture.Russian)
                    {
                        return translation.Russian;
                    }
                    else if(CurrentCulture == SupportedCulture.English)
                    {
                        return translation.English;
                    }
                }
            }

            throw new LocalizationException("Translation key not found");
        }

    }
}
