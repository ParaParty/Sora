using System.ComponentModel;

namespace Sora.Enumeration
{
    /// <summary>
    /// 成员权限等级
    /// </summary>
    public enum MemberRoleType
    {
        /// <summary>
        /// 成员
        /// </summary>
        [Description("member")]
        Member,
        /// <summary>
        /// 管理员
        /// </summary>
        [Description("admin")]
        Admin,
        /// <summary>
        /// 群主
        /// </summary>
        [Description("owner")]
        Owner
    }
}
