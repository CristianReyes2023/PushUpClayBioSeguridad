using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }
        public string NameCity { get; set; }

        public int IdStateFk { get; set; }
    }
}