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

        Appointment appointment1 = new Appointment(doctor1, p1, r1, DateTime.Now);
        Appointment appointment2 = new Appointment(doctor1, p4, r2, DateTime.Now);
        Appointment appointment3 = new Appointment(doctor2, p3, r2, DateTime.Now);

        appointment1.getAppointmentDetails();
        Console.WriteLine(" ");
        appointment2.getAppointmentDetails();
        Console.WriteLine(" ");
        appointment3.getAppointmentDetails();
    }
}