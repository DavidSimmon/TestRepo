using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepoInt.DataLayer
{
    public interface IUserDL
    {
        TestRepoEntity.User Get(int id);
        IList<TestRepoEntity.User> List();
        void Save(TestRepoEntity.User user);
    }
}
