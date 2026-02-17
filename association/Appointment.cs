public class Appointment
{
    public Doctor DoctorName;
    public Patient PatientName;
    public Room Room;
    public DateTime Time;

    public Appointment(Doctor Doctor, Patient Patient, Room room, DateTime Time)
    {
        this.DoctorName = Doctor;
        this.PatientName = Patient;
        this.Room = room;
        this.Time = Time; 

        Doctor.AddAppointment(Patient.Name);
        Patient.addAppointmentForPatient(Doctor.Name);

    }

    public void getAppointmentDetails()
    {
        Console.WriteLine("Doctor Name: " + DoctorName.Name);
        Console.WriteLine("Patient Name: " + PatientName.Name);
        Console.WriteLine("Room Number: " + Room.RoomId);
        Console.WriteLine("Time: " + Time);
    }   
}