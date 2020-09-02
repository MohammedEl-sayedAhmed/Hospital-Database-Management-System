using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        /*-----------------------Login Form-----------------------*/

        // Checks the patient username/password and returns the patient id
        // Returns -1 in patient is not found
        public int PatientPasswordCheck(string username, string password)
        {
            string query = "SELECT PID FROM Patient where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the doctor username/password and returns the doctor id
        // Returns -1 in doctor is not found
        public int DoctorPasswordCheck(string username, string password)
        {
            string query = "SELECT DID FROM Doctor where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the receptionist username/password and returns the receptionist id
        // Returns -1 in receptionist is not found
        public int ReceptionistPasswordCheck(string username, string password)
        {
            string query = "SELECT RecID FROM Receptionist where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the admin username/password and returns the admin id
        // Returns -1 in admin is not found
        public int AdminPasswordCheck(string username, string password)
        {
            string query = "SELECT AID FROM Admin where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        /*-----------------------A_ViewDoctorRatings Form-----------------------*/

        public DataTable SelectDoctorIDsNames()
        {
            string query = "SELECT DID, Name FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAvgDrsRatings()
        {
            string query = "SELECT Name as 'Doctor Name', Avg_Rating as 'Average Rating' FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewDrRatings(int did)
        {
            string query = "SELECT DR.Date as 'Date', P.Name as 'Patient Name', DR.Rate as 'Rating' FROM Doctor_Ratings as DR, Patient as P, Doctor as D WHERE DR.Doctor_ID = " + did + " AND DR.Doctor_ID = D.DID AND DR.Patient_ID = P.PID ORDER BY DR.Date;";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------A_ViewPatientRegistrationss Form-----------------------*/

        public DataTable SelectPatientIDsNames()
        {
            string query = "SELECT PID, Name FROM Patient;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewPatientRegistrations(int pid)
        {
            string query = "SELECT Reg.Date, Reg.Reserved_Time_Slot as 'Reserved Time Slot', Reg.RegID as 'Registration ID', Rec.Name as 'Receptionist', D.Name as 'Doctor', R.RID as 'Room Number', R.Type as 'Room Type', Reg.State, Reg.Diagnosis, Reg.Comments "
                            + "FROM Registration as Reg, Doctor as D, Receptionist as Rec, Patient as P, Room as R "
                            + "WHERE P.PID = " + pid + " AND Reg.Doctor_ID = D.DID AND Reg.Patient_ID = P.PID AND Reg.Reciptionist_ID = Rec.RecID AND Reg.Room_ID = R.RID "
                            + "ORDER BY Reg.Date, Reg.Reserved_Time_Slot;";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------A_ViewOrderedScans Form-----------------------*/

        public DataTable ViewOrderedScans()
        {
            string query = "SELECT Reg.Date, S.Name as 'Scan', Reg.RegID as 'Registration ID', P.Name as 'Patient', D.Name as 'Doctor', OS.Scan_Start_Time as 'Start Time', OS.Scan_End_Time as 'End Time' "
                            + "FROM Registration as Reg, Doctor as D, Patient as P, Scan as S, Ordered_Scans as OS "
                            + "WHERE Reg.Doctor_ID = D.DID AND Reg.Patient_ID = P.PID AND Reg.RegID = OS.Registration_ID AND OS.Scan_ID = S.SID "
                            + "ORDER BY Reg.Date, OS.Scan_Start_Time";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewScanOrders(int sid)
        {
            string query = "SELECT Reg.Date, S.Name as 'Scan', Reg.RegID as 'Registration ID', P.Name as 'Patient', D.Name as 'Doctor', OS.Scan_Start_Time as 'Start Time', OS.Scan_End_Time as 'End Time' "
                            + "FROM Registration as Reg, Doctor as D, Patient as P, Scan as S, Ordered_Scans as OS "
                            + "WHERE OS.Scan_ID = " + sid + " AND Reg.Doctor_ID = D.DID AND Reg.Patient_ID = P.PID AND Reg.RegID = OS.Registration_ID AND OS.Scan_ID = S.SID "
                            + "ORDER BY Reg.Date, OS.Scan_Start_Time";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectScanIDsNames()
        {
            string query = "SELECT SID, Name FROM Scan;";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------A_ViewPrescribedMedications Form-----------------------*/
        public DataTable SelectMedsIDsNames()
        {
            string query = "SELECT MID, Name FROM Medication;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewPrescribedMeds()
        {
            string query = "SELECT Reg.Date, M.Name as 'Medication', Reg.RegID as 'Registration ID', P.Name as 'Patient', D.Name as 'Doctor', PM.Prescription_Time, PM.Dosage "
                            + "FROM Registration as Reg, Doctor as D, Patient as P, Medication as M, Prescribed_Medications as PM "
                            + "WHERE Reg.Doctor_ID = D.DID AND Reg.Patient_ID = P.PID AND Reg.RegID = PM.Registration_ID AND PM.Medication_ID = M.MID "
                            + "ORDER BY Reg.Date, PM.Prescription_Time";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewMedPrescriptions(int mid)
        {
            string query = "SELECT Reg.Date, M.Name as 'Medication', Reg.RegID as 'Registration ID', P.Name as 'Patient', D.Name as 'Doctor', PM.Prescription_Time, PM.Dosage "
                            + "FROM Registration as Reg, Doctor as D, Patient as P, Medication as M, Prescribed_Medications as PM "
                            + "WHERE PM.Medication_ID = " + mid + " AND Reg.Doctor_ID = D.DID AND Reg.Patient_ID = P.PID AND Reg.RegID = PM.Registration_ID AND PM.Medication_ID = M.MID "
                            + "ORDER BY Reg.Date, PM.Prescription_Time";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------A_PersonnelSearch and R_PersonnelSearch Forms-----------------------*/

        public DataTable SelectReceptionistIDsNames()
        {
            string query = "SELECT RecID, Name FROM Receptionist;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAdminIDsNames()
        {
            string query = "SELECT AID, Name FROM Admin;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPersonnel(string category, int? id)
        {
            string query = "";

            if (category == "Patient")
            {
                query = "SELECT PID as 'Patient ID', Name, Username, Gender, Age, Mobile_Number as 'Mobile Number', Address "
                            + "FROM Patient";

                if (id != null)
                {
                    query += " WHERE PID = " + id;
                }
            }
            else if (category == "Doctor")
            {
                query = "SELECT D.DID as 'Doctor ID', D.Name, D.Username, D.Gender, D.Age, D.Mobile_Number as 'Mobile Number', D.Address, Dep.Name as 'Department', Salary, Start_of_Working_Hours as 'Shift Start',End_of_Working_Hours as 'Shift End', Avg_Rating as 'Average Rating' "
                            + "FROM Doctor as D, Department as Dep "
                            + "WHERE D.Department_ID = Dep.DepID";

                if (id != null)
                {
                    query += " AND D.DID = " + id;
                }
            }
            else if (category == "Receptionist")
            {
                query = "SELECT RecID as 'Receptionist ID', Name, Username, Gender, Age, Mobile_Number as 'Mobile Number', Address, Salary "
                            + "FROM Receptionist";

                if (id != null)
                {
                    query += " WHERE RecID = " + id;
                }
            }
            else if (category == "Admin")
            {
                query = "SELECT AID as 'Admin ID', Name, Username "
                            + "FROM Admin";

                if (id != null)
                {
                    query += " WHERE AID = " + id;
                }
            }

            return dbMan.ExecuteReader(query);
        }

        /*-----------------------P_ViewHistory Form-----------------------*/

        public DataTable ViewPatientHistory(int pid, string category)
        {
            string query = "";

            if (category == "Medications")
            {
                query = "SELECT R.Date, PM.Prescription_Time as 'Prescription Time', R.RegID as 'Registration ID', D.Name as 'Doctor', M.Name as 'Medication', PM.Dosage, M.Price "
                        + "FROM Prescribed_Medications as PM, Registration as R, Medication as M, Doctor as D "
                        + "WHERE R.Patient_ID = " + pid + " AND R.RegID = PM.Registration_ID AND PM.Medication_ID = M.MID AND R.Doctor_ID = D.DID "
                        + "ORDER BY R.Date, PM.Prescription_Time";
            }
            else if (category == "Scans")
            {
                query = "SELECT R.Date, OS.Scan_Start_Time as 'Scan Time', R.RegID as 'Registration ID', D.Name as 'Doctor', S.Name as 'Scan', S.Price "
                        + "FROM Ordered_Scans as OS, Registration as R, Scan as S, Doctor as D "
                        + "WHERE R.Patient_ID = " + pid + " AND R.RegID = OS.Registration_ID AND OS.Scan_ID = S.SID AND R.Doctor_ID = D.DID "
                        + "ORDER BY R.Date, OS.Scan_Start_Time";
            }
            else if (category == "Diagnosis/Comments")
            {
                query = "SELECT R.Date, R.Reserved_Time_Slot as 'Time Slot', R.RegID as 'Registration ID', D.Name as 'Doctor', R.Diagnosis, R.Comments "
                        + "FROM Registration as R, Doctor as D "
                        + "WHERE R.Patient_ID = " + pid + " AND R.Doctor_ID = D.DID "
                        + "ORDER BY R.Date, R.Reserved_Time_Slot";
            }

            return dbMan.ExecuteReader(query);
        }

        /*-----------------------P_ViewBills Form-----------------------*/

        public DataTable ViewPatientBills(int pid)
        {
            string query = "SELECT Date, Time_Slot as 'Time Slot', Registration_ID as 'Registration ID', Doctor_Fees as 'Doctor Fees', Room_Price as 'Room Price', Medications_Price as 'Medications Price', Scans_Price as 'Scans Price' "
                            + "FROM Registration_Bills "
                            + "WHERE Patient_ID = " + pid
                            + " ORDER BY Date, Time_Slot";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------D_ViewSchedule Form-----------------------*/

        public DataTable ViewDoctorSchedule(int did)
        {
            string query = "SELECT Reg.Reserved_Time_Slot as 'Time Slot', Reg.Room_ID as 'Room Number', P.Name as 'Patient' "
                            + "FROM Registration as Reg, Patient as P "
                            + "WHERE Reg.Doctor_ID = " + did + " AND Reg.Date = CAST(GETDATE() AS DATE) AND Reg.Patient_ID = P.PID "
                            + "ORDER BY Reg.Reserved_Time_Slot";
            return dbMan.ExecuteReader(query);
        }

        /*-----------------------------------------------------------------*/
        /*-----------------------------------------------------------------*/

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectMedications()
        {
            string query = "select * from Medication";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatients()
        {
            string query = "select * from Patient";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectNonReleasedPatients(long Doctor_ID)
        {
            string query = "select distinct Name from patient where PID in  (select TOP 100 PERCENT Patient_ID from Registration where State!='Released' AND (Doctor_ID =" + Doctor_ID+") Order By Date Desc )";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectScans()
        {
            string query = "select * from Scan";
            return dbMan.ExecuteReader(query);
        }

        public int DAssignMedications(long DoctorID,string PatientName, string MedicationName, string Dosage="")
        {
            string query;
            if (Dosage.Length == 0)
            {

                query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time)" +
                  " select MID, RegID, GETDATE()" +
                  " From Registration as R, Medication as M" +
                   " where M.MID = (select MID from Medication where Name = '" + MedicationName + "') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc );";
            }
            else
            {
                query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time, Dosage) "
                          + " select MID, RegID, GETDATE(), '" + Dosage + "' "
                          + "From Registration as R, Medication as M "
                          + "where M.MID = (select MID from Medication where Name = '" + MedicationName + "') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc )";
            }

            return dbMan.ExecuteNonQuery(query);
        }

        public int DRequestScans(long DoctorID, String PatientName, String ScanName)
        {
           string query = "Insert into Ordered_Scans(Scan_ID, Registration_ID, Scan_Start_Time, Scan_End_Time) "
           + " select SID, RegID,GETDATE(),dateadd(hh,+1,R.Reserved_Time_Slot)"
           + " From Registration as R, Scan as S"
           + " where S.SID = (select SID from Scan where Name ='"+ScanName+"') AND R.RegID =(select Top 1 RegID from Registration where (Patient_ID = (select PID from Patient where Name='"+PatientName+"')) AND (Doctor_ID ="+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query);
        }

        public string GetScanEndTime(long DoctorID, string PatientName,string ScanName)
        {

            string query = "Select Scan_End_Time from Ordered_Scans as O, Registration as R, Scan as S"
                        +" where O.Registration_ID = R.RegID And O.Scan_ID = S.SID AND S.SID = (select SID from Scan where Name = '"+ScanName+"') AND R.RegID = (select top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '"+PatientName+"')) AND(Doctor_ID = "+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string GetDoctorNameFromPatientID(long patientID)
        {
            string query = "select Name from Doctor" +
                        " where DID = (select Doctor_ID from Registration where RegID = (select top 1 RegID from Registration where Patient_ID ="+ patientID +"Order By Date Desc))";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public long GetDoctorIDFromName(string DoctorName)
        {
            string query = "select DID from Doctor where Name = '" + DoctorName + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int InsertDoctorRate(long patientID,long DoctorID,int Rate)
        {
            string query = "insert into Doctor_Ratings" +
                                                " Values" +
                                    "("+patientID+", "+DoctorID+", GETDATE(), "+Rate+")";

            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable GetDrAvgRating(int did)
        {
            string query = "SELECT AVG(Rate) as 'Avg_Rating' FROM Doctor_Ratings WHERE Doctor_ID = " + did;
            return dbMan.ExecuteReader(query);
        }

        public int UpdateDrAvgRating(int did, double avgRating)
        {
            string query = "Update Doctor SET Avg_Rating = " + avgRating +" Where DID = " + did;

            return dbMan.ExecuteNonQuery(query);

        }


        public int UpdatePatientState(string PatientNAme, long DoctorID, string state)
        {
            string query = "Update Registration" +
                          " set State =  '" + state + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatientDiagnosis(string PatientNAme, long DoctorID, string Diagnosis)
        {
            string query = "Update Registration" +
                          " set Diagnosis =  '" + Diagnosis + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatientComments(string PatientNAme, long DoctorID, string Comments)
        {
            string query = "Update Registration" +
                          " set Comments =  '" + Comments + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public long GetReceptionistIDFromName(string Name)
        {
            string query = "select RecID from Receptionist where Name = '" + Name + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public long GetPatientIDFromName(string Name)
        {
            string query = "select PID from Patient where Name='"+Name+"'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public long DoctorFreeCheck(long DoctorID,int Date,DataTable table)
        {

            string query1 = "select Doctor_ID, Reserved_Time_Slot,Date from Registration where Doctor_ID =" + DoctorID + "and Reserved_Time_Slot = '" + Date + ":00' AND Date= CAST(getdate() AS date)";
            DataTable result1 = dbMan.ExecuteReader(query1);
            if(result1 != null)
            {
                return 0;
            }
            if (table == null)
            {
                return 0;
            }
            for (int i =0; i< table.Rows.Count; i++)
            {
                string query = "select Doctor_ID, Reserved_Time_Slot,Date,Room_ID from Registration where Doctor_ID =" + DoctorID + "and Reserved_Time_Slot = '" + Date + ":00' AND Date= CAST(getdate() AS date) AND Room_ID="+ (int)table.Rows[i]["RID"] + "";
                DataTable result = dbMan.ExecuteReader(query);
                if (result == null)
                {
                    return (int)table.Rows[i]["RID"];
                }
            }
            return 0;
            
        }

        public DataTable SelectAllDoctors()
        {
            string query = "select * from Doctor";
            return dbMan.ExecuteReader(query);   
        }

        public DataTable SelectAllUnRelievedPatients()
        {
            string query = "select distinct Name from patient where PID in  (select TOP 100 PERCENT Patient_ID from Registration where State!='Released' Order By Date Desc )";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllReciptionists()
        {
            string query = "select * from Receptionist";
            return dbMan.ExecuteReader(query);
        }

        public long GetRoomIDFromType( string type)
        {
            string query = "select top 1 RID from Room where Room_Availability=1 AND Type='" + type + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int setRoomUnavailable(long RoomID)
        {
            string query = "Update Room" +
                           "set Room_Availability = 0" +
                            "where RID = " + RoomID + "";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int insertRegisteration(long recID, long DocID, long PID, long RoomID, int Date)
        {
            string query = " Insert into Registration(Reciptionist_ID, Doctor_ID, Patient_ID, Room_ID, Date, Reserved_Time_Slot)" +
                           "values(" + recID + "," + DocID + "," + PID + "," + RoomID + ",CAST(getdate() AS date),'" + Date + ":00')";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetRoomsIDsOfCertainType(string type)
        {
            string query = "select RID from Room where Type='" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public string GetRoomTypeFromPatientID(long patientID)
        {
            string query = "select type" +
                            " from Room" +
                            " where RID = (select Top 1 Room_ID from Registration where Patient_ID = "+patientID+"  Order By Date Desc )";
            return dbMan.ExecuteScalar(query).ToString();        
        }

        public string GetReservedTimeSlotFromRegisterationByPatientID(long patientID)
        {
            string query = "select Top 1 Reserved_Time_Slot from Registration where Patient_ID = "+patientID+ " Order By Date Desc";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string GetDateFromRegisterationByPatientID(long patientID)
        {
            string query = "select Top 1 Date from Registration where Patient_ID = " + patientID + " Order By Date Desc";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public int CheckRoomChangeAbility(DataTable table,string date)
        {
            if (table == null)
            {
                return 0;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //string query = "select  Reserved_Time_Slot,Date,Room_ID from Registration where  Reserved_Time_Slot = '" + date[0]+date[1] + ":00' AND Date= CAST(getdate() AS date) AND Room_ID=" + (int)table.Rows[i]["RID"] + "";
                string query = "select Room_ID, Reserved_Time_Slot, Date from Registration where Room_ID =" + (int)table.Rows[i]["RID"] + " and Reserved_Time_Slot='" + date[0] + date[1] + ":00' AND Date=CAST(getdate() AS date)";
               // MessageBox.Show(query);
                DataTable result = dbMan.ExecuteReader(query);
                //MessageBox.Show(result.Rows.Count.ToString());
                if (result == null)
                {
                    return (int)table.Rows[i]["RID"];
                }
            }
            return 0;
        }

        public long selectRegistrationIDFromPatientID(long pid)
        {
            string query = " select Top 1 RegID from Registration where Patient_ID ="+ pid + " Order By Date Desc";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int ChangeRoom(long RoomID, long RegID)
        {
            string query = "Update Registration" +
                           " set Room_ID = "+RoomID+"" +
                            " where regID = "+RegID+"";

            return (int)dbMan.ExecuteNonQuery(query);
        }


        /*------------------------A_AddUpdateAdmin and A_UpdateInfo-----------------------*/

        public int A_AddAdmin(string name, string username, string password)
        {
            string query = "INSERT INTO Admin (Name, Username, Password) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "')";

            return dbMan.ExecuteNonQuery(query);

        }
        public int A_UpdateAdmin(string name, string username, string password, int selectedAdmin)
        {
            string query = "update Admin set " +
               "Name='" + name + "'," +
               "Username='" + username + "'," +
               "Password='" + password + "'" +
               "where AID = " + selectedAdmin + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable SelectAdmin_name_id()
        {
            string query = "SELECT Name, AID FROM Admin;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAdmin(int aid)
        {
            string query = "SELECT Name, Username, Password FROM Admin where AID = " + aid;
            return dbMan.ExecuteReader(query);
        }

        /*------------------------A_AddUpdateReceptionist and D_UpdateInfo-----------------------*/

        public DataTable SelectDepIDsNames()
        {
            string query = "SELECT Name, DepID FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public int A_AddDoctor(string name, string username, string password, string gender, int age, string mobile, string address, int deptID, string startWH, string endWH, int salary)
        {
            string query = "INSERT INTO Doctor (Name, Username, Password, Gender, Age, Mobile_Number, Address, Department_ID, Start_of_Working_Hours,End_of_Working_Hours,Salary) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + ",";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            if (address == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + address + "',";
            }
            
            query += "" + deptID + "," +
               "'" + startWH + "'," +
               "'" + endWH + "'," +
               "" + salary + ")";
            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable SelectDoctor(int did)
        {
            string query = "SELECT * FROM Doctor where DID = " + did;
            return dbMan.ExecuteReader(query);
        }

        public int A_UpdateDoctor(int selectedDrID, string name, string username, string password, string gender, int age, string mobile, string address, int deptID, string startWH, string endWH, int salary)
        {
            string query = "update Doctor set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number = ";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            query += "Address = ";

            if (address == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + address + "',";
            }

            if (deptID != -1)
            {
                query += "Department_ID=" + deptID + ",";
            }
            query += "Start_of_Working_Hours='" + startWH + "'," +
               "End_of_Working_Hours='" + endWH + "'";

            if (salary != -1)
            {
                query += ", Salary=" + salary;
            }
            
            query += " where DID = " + selectedDrID;

            return dbMan.ExecuteNonQuery(query);
        }

        /*------------------------A_AddUpdateReceptionist and R_UpdateInfo-----------------------*/

        public DataTable SelectReceptionist(int recid)
        {
            string query = "SELECT * FROM Receptionist where RecID = " + recid;
            return dbMan.ExecuteReader(query);
        }

        public int A_AddReceptionist(string name, string username, string password, string gender, int age, string mobile, string address, int salary)
        {
            string query = "INSERT INTO Receptionist (Name, Username, Password, Gender, Age, Mobile_Number, Address, Salary) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + ",";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            if (address == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + address + "',";
            }

            query += "" + salary + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public int A_UpdateReceptionist(int selectedRecepID, string name, string username, string password, string gender, int age, string mobile, string address,int salary)
        {
            string query = "update Receptionist set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number = ";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            query += "Address = ";

            if (address == "")
            {
                query += "NULL";
            }
            else
            {
                query += "'" + address + "'";
            }

            if (salary != -1)
            {
                query += ", Salary=" + salary;
            }

            query += " where RecID = " + selectedRecepID;

            return dbMan.ExecuteNonQuery(query);
        }

        /*----------------------------R_AddUpdatePatient and P_UpdateInfo------------------------*/

        public DataTable SelectPatient(int pid)
        {
            string query = "SELECT * FROM Patient where PID = " + pid;
            return dbMan.ExecuteReader(query);
        }

        public int R_AddPatient(string name, string username, string password, string gender, int age, string mobile, string address)
        {
            string query = "INSERT INTO Patient (Name, Username, Password, Gender, Age, Mobile_Number, Address) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + ",";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            if (address == "")
            {
                query += "NULL)";
            }
            else
            {
                query += "'" + address + "')";
            }

            return dbMan.ExecuteNonQuery(query);

        }

        public int R_UpdatePatient(int selectedPatientID, string name, string username, string password, string gender, int age, string mobile, string address)
        {
            string query = "update Patient set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number = ";

            if (mobile == "")
            {
                query += "NULL,";
            }
            else
            {
                query += "'" + mobile + "',";
            }

            query += "Address = ";

            if (address == "")
            {
                query += "NULL ";
            }
            else
            {
                query += "'" + address + "' ";
            }

            query += "where PID = " + selectedPatientID;

            return dbMan.ExecuteNonQuery(query);

        }



        /*-----------------------------------------*/
        /*-------------------GROUP D---------------*/
        /*-----------------------------------------*/

        /*-------------A_AddUpdateDepartment--------------*/

        public DataTable SelectDepartment(int depid)
        {
            string query = "SELECT * FROM Department where DepID = " + depid;
            return dbMan.ExecuteReader(query);
        }

        public int A_AddDepartment(string name)
        {
            string query = "INSERT INTO Department (Name) VALUES (" +
               "'" + name + "'" +")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateDepartment(int selectedDeptID, string name)
        {
            string query = "update Department set " +
               "Name='" + name + "'" +
               "where DepID = " + selectedDeptID + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        /*----------------A_AddUpdateRoom----------------*/

        public DataTable SelectRoom(int rid)
        {
            string query = "SELECT * FROM Room WHERE RID = " + rid;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomIDs()
        {
            string query = "SELECT RID FROM Room";
            return dbMan.ExecuteReader(query);
        }

        public int A_AddRoom(string type, string size, int price, int deptID)
        {
            string query = "INSERT INTO Room (Type,Size,Price,Department_ID) VALUES (" +
               "'" + type + "',";
            if (size == "")
            {
                query += "NULL, ";
            }
            else
            {
                query += " " + size + ", ";
            }
            
            query += "" + price + "," +
               "" + deptID + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateRoom(int selectedRoomID , string type, string size, int price, int deptID)
        {
            string query = "update Room set " +
               "Type='" + type + "',";

            if (size != "")
            {
                query += "Size=" + size + ",";
            }

            query += "Price=" + price + "," +
               "Department_ID=" + deptID + " " +
               "where RID = " + selectedRoomID + ";";

            return dbMan.ExecuteNonQuery(query);
        }

        /*--------------A_AddUpdateMedication--------------*/

        public DataTable SelectMedication(int mid)
        {
            string query = "SELECT * FROM Medication WHERE MID = " + mid;
            return dbMan.ExecuteReader(query);
        }
        
        public int A_AddMedication(string name, int price, string exp_date)
        {
            string query = "INSERT INTO Medication (Name,Price,Exp_Date)  VALUES (" +
               "'" + name + "'," +
               "" + price + "," +
               "'" + exp_date + "'" +")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateMedication(int selectedMedicationID, string name, int price, string exp_date)
        {
            string query = "update Medication set " +
               "Name='" + name + "'," +
               "Price=" + price + "," +
               "Exp_Date = '" + exp_date + "'" +
               "where MID = " + selectedMedicationID + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        /*-------------A_AddUpdateScan-----------*/

        public DataTable SelectScan(int sid)
        {
            string query = "SELECT * FROM Scan WHERE SID = " + sid;
            return dbMan.ExecuteReader(query);
        }

        public int A_AddScan(string name, int price)
        {
            string query = "INSERT INTO Scan (Name,Price)  VALUES (" +
               "'" + name + "'," +
               "" + price  + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateScan(int selectedScanID, string name, double price)
        {
            string query = "update Scan set " +
               "Name='" + name + "'," +
               "Price=" + price +
               "where SID = " + selectedScanID + ";";

            return dbMan.ExecuteNonQuery(query);

        }
    }
}
