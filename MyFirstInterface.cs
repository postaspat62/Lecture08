using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture08
{

    //this is just brainstorming
    public interface MyFirstInterface
    {
        string FetchFileinformation();

        List<Student>ImportStudentsFromFile(string filepath);
    }
}
