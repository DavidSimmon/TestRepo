using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepoDL
{
    public class UserDL : TestRepoInt.DataLayer.IUserDL
    {
        public UserDL()
        {
        }

        public TestRepoEntity.User Get(int id)
        {
            return new TestRepoEntity.User();
        }

        public IList<TestRepoEntity.User> List()
        {
            return new List<TestRepoEntity.User>();
        }

        public void Save(TestRepoEntity.User user)
        {
        }
    }
}
