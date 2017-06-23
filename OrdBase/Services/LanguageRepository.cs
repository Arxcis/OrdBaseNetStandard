using System.Linq;

using OrdBase.Models;
using OrdBase.IData;

namespace OrdBase.Services
{
	// 
	// @class LanguageRepository
	//  @brief Get language data
	//
    public class LanguageRepository : ILanguageData
    {
        private readonly TranslationDb _context;
        public LanguageRepository(TranslationDb context) 
        { 
            _context = context; 
        }

        public Language[] Get()
        {
            return (from l in _context.Language
                    select l).ToArray();
        }

        public Language[] GetOnClient(string client)
        {
            return (from t in _context.Translation
                    join l in _context.Language on t.LanguageShortName equals l.ShortName
                    join c in _context.Client on t.ClientName equals c.Name
                    where c.Name == client
                    select l)
                        .ToArray();
        }
    }
}