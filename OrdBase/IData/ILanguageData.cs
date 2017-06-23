
using OrdBase.Models;

namespace OrdBase.IData
{
    public interface ILanguageData
    {
        Language[] Get();
        Language[] GetOnClient(string client);
    }	
}
