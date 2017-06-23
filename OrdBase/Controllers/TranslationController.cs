using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using System;

using OrdBase.Models;
using OrdBase.IData;

namespace OrdBase.Controllers
{
    public class TranslationController : ApiController, ITranslationData
    {   
        private readonly ITranslationData _translationRepo;

        public TranslationController(ITranslationData translationRepo)
        {
            _translationRepo = translationRepo;
        }

        //
        // GET REQUESTS
        //
        [Route("api/{client}/translation/{container}/{accessKey}/{language}")]
        [HttpGet]
    	public Translation[] Get(string client, string language, string container, string accesskey)
        {
            return _translationRepo.Get(client, language, container, accesskey); 
        }
        
        [Route("api/{client}/translation")]
        [HttpGet]
        public Translation[] GetOnClient(string client)
        {
            return _translationRepo.GetOnClient(client); 
        }
        
        [Route("api/{client}/translation/container/{container}")]
        [HttpGet]
        public Translation[] GetOnContainer(string client, string container)
        {
            return _translationRepo.GetOnContainer(client, container); 
        }

        [Route("api/{client}/translation/container/{container}/{language}")]
        [HttpGet]
        public Dictionary<string, string> GetOnContainer(string client, string language, string container)
        {
            return _translationRepo.GetOnContainer(client, language, container); 
        }

        [Route("api/{client}/translation/accesskey/{accesskey}")]
        [HttpGet]
        public Translation[] GetOnAccessKey(string client, string accesskey)
        {
            return _translationRepo.GetOnAccessKey(client, accesskey); 
        }

        [Route("api/{client}/translation/language/{language}")]
        [HttpGet]
        public Translation[] GetOnLanguage(string client, string language)
        {
            return _translationRepo.GetOnLanguage(client, language); 
        }
        
        //
        // CREATE, UPDATE, DELETE REQUESTS
        //
        [Route("api/translation")]
        [HttpPost]
        public IActionResults

    }
}
