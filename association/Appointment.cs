public class Appointment
{
    public Doctor DoctorName;
    public Patient PatientName;
    public Room Room;
    public DateTime Time;

    public Appointment(Doctor Doctor, Patient Patient, RoomId room, DateTime Time)
    {
        this.Doctor = Doctor;
        this.Patient = Patient;
        this.room = room;
        this.Time = Time; 
    }
}