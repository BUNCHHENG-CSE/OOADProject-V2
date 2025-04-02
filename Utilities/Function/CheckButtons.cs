namespace OOADPROV2.Utilities.Function;

public class CheckButtons
{
    public static void Check<T>( T? effectedObject,Button btnInsert, Button btnUpdate ) 
    {
        if (effectedObject == null)
        {
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;
        }
        else
        {
            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
        }
    }
}
