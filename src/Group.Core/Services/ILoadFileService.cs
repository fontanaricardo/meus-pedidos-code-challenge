using System;
using System.Collections.Generic;
using System.IO;
using Group.Core.Models;

namespace Group.Core.Services
{
    public interface ILoadFileService
    {
         Uri Parse(string address);

         bool IsLocal(Uri address);

         string Load(Uri address);
    }
}