using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace FeetControl.Shared.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDisplayName<TEnum>(this TEnum value) where TEnum : System.Enum
        {
            var member = value.GetType()
                .GetMember(value.ToString())
                .FirstOrDefault();

            if (member is null)
                return value.ToString();

            var display = member.GetCustomAttribute<DisplayAttribute>();
            if (display is null)
                return value.ToString();

            return display.GetName() ?? value.ToString();
        }
    }
}
