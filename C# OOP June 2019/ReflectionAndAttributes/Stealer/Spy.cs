using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] fieldsName)
    {
        Type classType = Type.GetType(investigatedClass);

        FieldInfo[] classFields = classType.GetFields(BindingFlags.Public
            | BindingFlags.Static
            | BindingFlags.Instance
            | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => fieldsName.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }
}
