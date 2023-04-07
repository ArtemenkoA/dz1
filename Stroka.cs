using System.ComponentModel;
namespace dz1;

class Stroka
{
    private int number, error;
    private TimeSpan time;
    public Stroka(int Number, TimeSpan Time, int Error)
    {
        this.number = Number;
        this.time = Time;
        this.error = Error;
    }
    public int Number
    {
        get { return number; }
        set { value = Number; }
    }

    public TimeSpan Time
    {
        get { return time; }
        set { value = Time; }
    }

    public int Error
    {
        get { return error; }
        set { value = Error; }
    }
}