using SampleASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.DAL
{
    public interface IRumahmakan : ICrud<Rumahmakan>
    {
        IEnumerable<RumahmakanWithJenis> GetRumahmakanWithJenis();
    }
}
