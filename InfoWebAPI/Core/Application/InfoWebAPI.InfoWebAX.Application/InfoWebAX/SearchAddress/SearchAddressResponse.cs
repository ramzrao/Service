using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class SearchAddressResponse : ResponseEntity
    {
        public List<QASAddress> AddressList { get; set; }
    }
}