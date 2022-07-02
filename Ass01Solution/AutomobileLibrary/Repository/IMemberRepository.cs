using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace DataAccess.Repository
{
    public interface  IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();

        MemberObject GetMemberByID(int memberId);

        void  InsertMemberObject(MemberObject memberObject);

        void DeleteMemberObject(int memberId);

        void UpdateMemberObject(MemberObject memberObject);
    }
}
