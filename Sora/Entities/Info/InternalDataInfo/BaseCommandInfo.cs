﻿using System;
using System.Text.RegularExpressions;
using Sora.Enumeration;
using Sora.Enumeration.EventParamsType;

namespace Sora.Entities.Info.InternalDataInfo;

internal abstract record BaseCommandInfo
{
    internal readonly string            Desc;             //注释
    internal readonly string[]          Regex;            //正则表达式
    internal readonly MemberRoleType    PermissionType;   //指令执行权限,私聊无效
    internal readonly bool              SuperUserCommand; //机器人管理员指令
    internal readonly SourceFlag        SourceType;       //指令匹配源类型
    internal readonly int               Priority;         //优先级
    internal readonly RegexOptions      RegexOptions;     //正则设置
    internal readonly Action<Exception> ExceptionHandler; //异常回调
    internal readonly long[]            SourceGroups;     //群组限制,私聊无效
    internal readonly long[]            SourceUsers;      //用户限制

    internal BaseCommandInfo(
        string            desc,             string[]     regex,        MemberRoleType permissionType, bool suCommand,
        int               priority,         RegexOptions regexOptions, SourceFlag     source,
        Action<Exception> exceptionHandler, long[]       sourceGroups, long[]         sourceUsers)
    {
        Desc             = desc;
        Regex            = regex;
        PermissionType   = permissionType;
        SuperUserCommand = suCommand;
        Priority         = priority;
        RegexOptions     = regexOptions;
        SourceType       = source;
        SourceGroups     = sourceGroups;
        SourceUsers      = sourceUsers;
        ExceptionHandler = exceptionHandler;
    }

    public virtual bool Equals(BaseCommandInfo commandInfo)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine((int) PermissionType, SuperUserCommand, (int) SourceType, Priority, (int) RegexOptions);
    }
}