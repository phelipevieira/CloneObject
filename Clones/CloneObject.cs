using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class CloneObject
    {
        public static void CopyValues<T>(T target, T source)
        {
            Type t = typeof(T);

            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(source, null);

                if (value != null)
                {
                    if (prop.GetValue(target, null) == null)
                    {
                        prop.SetValue(target, value, null);
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Boolean))
                    {
                        prop.SetValue(target, value, null);
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(DateTime))
                    {
                        if ((DateTime)prop.GetValue(target, null) == DateTime.MinValue)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(String))
                    {
                        if (String.IsNullOrEmpty((String)prop.GetValue(target, null)))
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Int16))
                    {
                        if ((Int16)prop.GetValue(target, null) == 0)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Int32))
                    {
                        if ((Int32)prop.GetValue(target, null) == 0)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Int64))
                    {
                        if ((Int64)prop.GetValue(target, null) == 0)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Decimal))
                    {
                        if ((Decimal)prop.GetValue(target, null) == 0)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                    else if (prop.GetValue(target, null).GetType() == typeof(Double))
                    {
                        if ((Double)prop.GetValue(target, null) == 0)
                        {
                            prop.SetValue(target, value, null);
                        }
                    }
                }
            }
        }
    }
}
