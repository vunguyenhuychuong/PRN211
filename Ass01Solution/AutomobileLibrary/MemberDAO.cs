using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using BussinessObject;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        //---------------------------------        
        //---------Using Singleton------------------
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO()
        {

        }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        //-----------------------------
        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = " Select MemberID, MemberName, Email, Password, RoleID, City, Country from Members ";
            var Members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    Members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        RoleID = dataReader.GetString(4),
                        City = dataReader.GetString(5),
                        Country = dataReader.GetString(6),
                    });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Members;
        }
        //-----------------------------------------------------------


      
        //-----------------------------------------------------------
        public MemberObject GetMemberByID(int MemberID)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = " SELECT MemberID, MemberName, Email, Password, RoleID ,City, Country, Email " +
                " FROM Members WHERE MemberID = @MemberID ";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        //--------------------------------------------

        //---------------------------------------------------

        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Members values(@MemberID,@MemberName,@Password,@RoleID,@City,@Country,@Email)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@RoleID", 50, member.RoleID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                    throw new Exception("The member added ");
                }
                else
                {
                    throw new Exception("The member does not already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //------------------------------------------
        public void Update(MemberObject member)
        {
            try
            {
                MemberObject mb = GetMemberByID(member.MemberID);
                if (mb != null)
                {
                    string SQLUpdate = "Update Members set MemberName = @MemberName, Email = @Email, " +
                        "Password = @Password, City=@City, Country=@Country where MemberID=@MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4,member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int memberId)
        {
            try
            {
                MemberObject member = GetMemberByID(memberId);
                if (member != null)
                {
                    string SQLDelete = "DELETE Members WHERE MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("The member does not exist");
            }
            finally
            {
                CloseConnection();
            }
        }//end Remove


        public IEnumerable<MemberObject> SortNameDesc()
        {
            var members = this.GetMemberList();

            members = new List<MemberObject>(members.OrderByDescending(members => members.MemberName));

            return members;
        }
        //-------------------------------------

    }//end class
}

