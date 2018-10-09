using SampleASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.DAL
{
    public interface IJenis : ICrud<Jenis>
    {
        IEnumerable<Jenis> GetByNamaJenis(string nama);
    }
}
