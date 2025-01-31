using System.Data.Odbc;
using System.Reflection;

namespace GoldenBoots
{

    partial class RepeatFunctions
    {
        public static void OpenForm(Form actForm, Form nextForm)
        {
            nextForm.Show();
            actForm.Hide();
            //Type actForm = MethodBase.GetCurrentMethod().DeclaringType;
            //MethodInfo formMethod = actForm.GetMethod("Hide", BindingFlags.Static | BindingFlags.Public);
            //formMethod.Invoke(null, null);
        }
    }
}