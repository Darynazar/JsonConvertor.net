using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Services
{
    public interface IConvertor
    {
        string Run(string jsonInput);
    }
}
