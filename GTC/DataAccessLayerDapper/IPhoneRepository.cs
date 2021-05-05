using System;
using System.Collections.Generic;
using Domain;
using System.Threading.Tasks;

namespace DataAccessLayerDapper
{
    public interface IPhoneRepository
    {
       Task<IEnumerable<Phone>> GetAllPhonesAsync();

        void CreatePhone(Phone phone);
    }
}
