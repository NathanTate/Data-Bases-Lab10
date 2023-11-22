using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasesLab10
{
    public interface ISubjectsDAO
    {
        int CreateSubject(Subjects subject);
        void UpdateSubject(Subjects subject);
        List<Subjects> GetAllSubjects();
        List<Subjects> GetSubject(int id);
        int DeleteSubject(int id);

    }
}
