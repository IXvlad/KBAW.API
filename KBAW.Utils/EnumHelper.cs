using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KBAW.Utils;

public static class EnumHelper
{
    public static IEnumerable<PropEnum> GetListItems<TEnum>()
    {
        return Enum.GetValues(typeof(TEnum))
            .OfType<object>()
            .Select(obj => new PropEnum
            {
                Key = (int)obj,
                Value = obj.ToString() ?? string.Empty,
                Name = GetDisplayName(obj as Enum ?? throw new NullReferenceException())
            });
    }

    public static string GetDisplayName(this Enum value)
    {
        return value.GetType()
            .GetMember(value.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName()!;
    }
}