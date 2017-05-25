using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepoBL
{
    public class UserBL : TestRepoInt.BusinessLayer.IUserBL
    {
        private TestRepoInt.DataLayer.IUserDL datalayer;

        public UserBL(TestRepoInt.DataLayer.IUserDL dl)
        {
            if(dl == null)
            {
                throw new ArgumentNullException("Datalayer cannot be null.");
            }

            this.datalayer = dl;
        }


        public TestRepoEntity.User Get(int id)
        {
            return this.datalayer.Get(id);
        }

        public IList<TestRepoEntity.User> List()
        {
            return this.datalayer.List();
        }

        public void Save(TestRepoEntity.User user)
        {
            this.datalayer.Save(user);
        }
    }
}
