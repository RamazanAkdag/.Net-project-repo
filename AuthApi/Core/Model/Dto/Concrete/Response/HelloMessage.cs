using Core.Model.Dto.Abstrct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Dto.Concrete.Response
{
    public class HelloMessage : IDto
    {
        public string Message { get; set; }
    }
}
