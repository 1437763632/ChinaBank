using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBank.Service
{
    using Model;
    using IService;
    public class RoleServices : IRoleServices
    {
       /// <summary>
       /// 角色添加
       /// </summary>
       /// <param name="role"></param>
       /// <returns></returns>

        public int RoleAdd(Role role)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int RoleUpdate(Role role)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShowRole> showRoles()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowRole> showRolesID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
