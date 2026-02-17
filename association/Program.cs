class Program
{
    public static void Main()
    {
        Console.WriteLine("Hospital Management System");
        Console.WriteLine(" ");

        Doctor doctor1 = new Doctor("d1", "Gurudas");
        Doctor doctor2 = new Doctor("d2", "Mahesh");

        Patient p1 = new Patient("Rohit");
        Patient p2 = new Patient("Suresh");
        Patient p3 = new Patient("Palash");
        Patient p4 = new Patient("Mukehs");

        Room r1 = new Room("R1", 1);
        Room r2 = new Room("R2", 3);

        p1.addAppointmentForPatient(doctor1.Name);
        p1.addAppointmentForPatient(doctor2.Name);

        doctor1.AddAppointment(p1.Name);
        doctor1.AddAppointment(p4.Name);
        doctor2.AddAppointment(p2.Name);
        doctor2.AddAppointment(p3.Name);

        Appointment appointment1 = new Appointment(doctor1.Name, p1.Name, r1.RoomId, DateTime.Now);
        Appointment appointment2 = new Appointment(doctor1.Name, p4.Name, r2.RoomId, DateTime.Now);
        Appointment appointment3 = new Appointment(doctor2.Name, p3.Name, r3.RoomId, DateTime.Now);
    }
}

