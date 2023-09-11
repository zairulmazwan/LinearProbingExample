public class LinearProb 
{
    static int [] data = {34,9,41,8,51,12};
    static int m = data.Length;
    static int [] hashtable = new int [data.Length];

    public static void linearProb ()
    {
        
        int i = 0;

        for (int j=0; j<data.Length; j++)
        {
            int k = data[j];
            int h = (k+i)%m;
            
            while (hashtable[h] != 0)
            {
                i++;
                h = (k+i)%m;
            }
            hashtable[h] = data[j];
        }
        printData(hashtable);
    }

    public static void printData(int [] x)
    {
        foreach(var item in x)
        {
            Console.WriteLine(item);
        }
    }
}