using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;


namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMemberObject(MemberObject memberObject) => MemberDAO.Instance.AddNew(memberObject);

        public void DeleteMemberObject(int memberId) => MemberDAO.Instance.Remove(memberId);

        public void UpdateMemberObject(MemberObject memberObject) => MemberDAO.Instance.Update(memberObject);

        public IEnumerable<MemberObject> SortNameDesc() => MemberDAO.Instance.SortNameDesc();
     
    }
}
