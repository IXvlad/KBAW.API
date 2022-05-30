using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace KBAW.Utils
{
    public static class EnumHelper
    {
        public static string DisplayName(this Enum value)
        {
            return value.GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName()!;
        }
    }
}