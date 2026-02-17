
public class Doctor
{
    public string Did {get;}
    public string Name {get;}
    private readonly List<string> Appointment = new List<string>();

    public Doctor(string Did, string Name)
    {
        this.Did = Did;
        this.Name = Name;
    }

    public void AddAppointment(string Appointment)
    {
        this.Appointment.Add(Appointment);
    }
}