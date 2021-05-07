using DataAccessLayerDapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class PhoneService : IPhoneService
    {
        protected readonly IPhoneRepository _phoneRepository;

        public PhoneService(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public Task<IEnumerable<Phone>> GetAllPhones()
        {
            return _phoneRepository.GetAllPhonesAsync();
        }

        public Phone CreatePhone(Phone phone)
        {
           return _phoneRepository.CreatePhone(phone);
        }
    }
}
