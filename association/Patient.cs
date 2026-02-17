
public class Patient
{
    public string Name;
    private readonly List<string> appointment = new List<string>();

    public Patient(string Name){
        this.Name = Name; 
    }
    
    public void addAppointmentForPatient(string Appointment)
    {
        appointment.Add(Appointment);
    }

    public List<string> getAppointment()
    {
        return appointment;
    }

    public string GetName()
    {
        return Name;
    }
}