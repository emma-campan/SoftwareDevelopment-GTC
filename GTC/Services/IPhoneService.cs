using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IPhoneService
    {
        Task<IEnumerable<Phone>> GetAllPhones();
        Phone CreatePhone(Phone phone);
    }
}
