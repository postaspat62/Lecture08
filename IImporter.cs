using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture08
{
    public interface IImporter
    {
        List<FileInfo> ImportFile();
    }
}
