-------------Database creation-------------
--create database hospital
Create database Hospital
GO
use Hospital
------------Table Creation-----------------
Create Table Patient
(
PID bigint identity (1,1) NOT NULL,
Name VARCHAR(30) NOT NULL, 
Username VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F') NOT NULL,
Age INTEGER CHECK (Age > 0) NOT NULL,
Mobile_Number  CHAR(11),
Address VARCHAR(30),
PRIMARY KEY (PID),
UNIQUE (Name),
UNIQUE (Username)
);

Create Table Admin
(
 AID bigint identity (10,10) NOT NULL,
 Name VARCHAR(30) NOT NULL,
 Username VARCHAR(15) NOT NULL, 
 Password VARCHAR(15) NOT NULL,
 PRIMARY KEY (AID),
 UNIQUE (Username),
 UNIQUE (Name)
);

Create Table Receptionist
(
RecID bigint identity (1,1) NOT NULL,
Name VARCHAR(30) NOT NULL, 
Username VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F') NOT NULL,
Age INTEGER CHECK (Age > 0) NOT NULL,
Mobile_Number  CHAR(11),
Address VARCHAR(30),
Salary int CHECK (Salary > 0) NOT NULL,
PRIMARY KEY (RecID),
UNIQUE (Name),
UNIQUE (Username)
);

Create Table Department
(
 DepID int identity (1,1) NOT NULL CHECK (DepID >= 1 AND DepID <= 100),
 Name VARCHAR(30) NOT NULL,
 PRIMARY KEY (DepID),
 UNIQUE (Name)
);

Create Table Doctor
(
DID bigint identity (1,1) NOT NULL,
Name VARCHAR(30) NOT NULL,
Username VARCHAR(15) NOT NULL, 
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F') NOT NULL,
Age INTEGER CHECK (Age > 0) NOT NULL,
Mobile_Number  CHAR(11),
Address VARCHAR(30),
Department_ID int NOT NULL,
Start_of_Working_Hours TIME CHECK (Start_of_Working_Hours >= '08 AM' AND Start_of_Working_Hours <= '06 PM') DEFAULT '08 AM', 
End_of_Working_Hours TIME CHECK (End_of_Working_Hours >= '08 AM' AND End_of_Working_Hours <= '06 PM') DEFAULT '06 PM', 
Salary int NOT NULL CHECK (Salary > 0),
Avg_Rating float CHECK (Avg_Rating >= 0 AND Avg_Rating <= 10) DEFAULT 0,
PRIMARY KEY (DID), 
UNIQUE (Username),
UNIQUE (Name),
FOREIGN KEY (Department_ID) REFERENCES Department
);

Create Table Scan
(
 SID int identity (1,1) NOT NULL CHECK (SID >= 1 AND SID <= 100),
 Name VARCHAR(30) NOT NULL,
 Price float NOT NULL CHECK (Price >= 100 AND Price <= 1000),
 PRIMARY KEY (SID),
 UNIQUE (Name)
);

Create Table Medication
(
 MID int identity (1,1) NOT NULL CHECK (MID >= 1 AND MID <= 500),
 Name VARCHAR(30) NOT NULL,
 Price float NOT NULL CHECK (Price >= 20 AND Price <= 1000),
 Exp_Date DATE CHECK (Exp_Date > CAST(getdate() AS DATE)),
 PRIMARY KEY (MID),
 UNIQUE (Name)
);


Create Table Room
(
 RID int identity (1,1) NOT NULL CHECK (RID >= 1 AND RID <= 500),
 Type VARCHAR(16) CHECK (Type = 'Examination Room' OR Type = 'Surgery Room' OR Type = 'ICU') NOT NULL,
 Size FLOAT  CHECK (Size >= 30 AND Size <= 60),
 Price FLOAT NOT NULL CHECK (Price >= 100 AND Price <= 1000),
 Department_ID int NOT NULL,
 PRIMARY KEY (RID),
 FOREIGN KEY (Department_ID) REFERENCES Department,
);

Create Table Registration 
(
RegID bigint identity (1,1) NOT NULL,
Reciptionist_ID bigint NOT NULL, 
Doctor_ID bigint NOT NULL,
Patient_ID bigint NOT NULL,
Room_ID int NOT NULL,
Date DATE CHECK (Date = CAST(getdate() AS DATE)) DEFAULT CAST(getdate() AS DATE), 
Reserved_Time_Slot TIME NOT NULL CHECK (Reserved_Time_Slot >= '08 AM' AND Reserved_Time_Slot <= '06 PM'),
State VARCHAR(18) CHECK (State = 'Waiting' OR State = 'Being Examined' OR State = 'Getting Scans' OR State = 'Buying Medications' OR State = 'Released') DEFAULT 'Waiting',
Diagnosis VARCHAR(1000), 
Comments VARCHAR(100),
PRIMARY KEY (RegID), 
FOREIGN KEY (Reciptionist_ID) REFERENCES Receptionist,
FOREIGN KEY (Doctor_ID) REFERENCES Doctor,
FOREIGN KEY (Patient_ID) REFERENCES Patient,
FOREIGN KEY (Room_ID) REFERENCES Room,
);

Create Table Ordered_Scans
(
Registration_ID bigint NOT NULL, 
Scan_ID int NOT NULL, 
Scan_Start_Time TIME CHECK (Scan_Start_Time >= '08 AM' AND Scan_Start_Time <= '06 PM'),
Scan_End_Time TIME CHECK (Scan_End_Time >= '08 AM' AND Scan_End_Time <= '06 PM'),
PRIMARY KEY (Registration_ID,Scan_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Scan_ID) REFERENCES Scan
)

Create Table Prescribed_Medications
(
Registration_ID bigint NOT NULL, 
Medication_ID int NOT NULL, 
Prescription_Time TIME CHECK (Prescription_Time >= '08 AM' AND Prescription_Time <= '06 PM'),
Dosage VARCHAR(30), 
PRIMARY KEY (Registration_ID,Medication_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Medication_ID) REFERENCES Medication
);

Create Table Doctor_Ratings
(
Patient_ID bigint NOT NULL, 
Doctor_ID bigint NOT NUll, 
Date DATE NOT NULL CHECK (Date = CAST(getdate() AS date)),
Rate FLOAT NOT NULL CHECK (Rate >= 0 AND Rate <= 10),
PRIMARY KEY (Patient_ID,Doctor_ID,Date),
FOREIGN KEY (Patient_ID) REFERENCES Patient,
FOREIGN KEY (Doctor_ID) REFERENCES Doctor
);

GO
CREATE VIEW Registration_DrRoomFees AS
SELECT Reg.Patient_ID as 'Patient_ID', Reg.Date, Reg.Reserved_Time_Slot, REg.RegID as 'Registration_ID', D.Salary as 'Doctor_Fees', R.Price as 'Room_Price'
FROM Registration as Reg, Room as R, Doctor as D
WHERE Reg.Doctor_ID = D.DID AND Reg.Room_ID = R.RID AND Reg.Room_ID = R.RID

GO
CREATE VIEW Registration_MedPrices AS 
SELECT Reg.RegID as 'Registration_ID', SUM(M.Price) as 'Medications_Price'
FROM Registration as Reg, Medication as M, Prescribed_Medications as PM
WHERE PM.Registration_ID = Reg.RegID AND PM.Medication_ID = M.MID
GROUP BY Reg.RegID

GO
CREATE VIEW Registration_ScanPrices AS
SELECT Reg.RegID as 'Registration_ID', SUM(S.Price) as 'Scans_Price'
FROM Registration as Reg, Scan as S, Ordered_Scans as OS
WHERE OS.Registration_ID = Reg.RegID AND OS.Scan_ID = S.SID
GROUP BY Reg.RegID

GO
CREATE VIEW Registration_Bills AS
SELECT Patient_ID, Date, Reserved_Time_Slot as 'Time Slot', D.Registration_ID as 'Registration ID', Doctor_Fees as 'Doctor Fees', Room_Price as 'Room Price', Medications_Price as 'Medications Price', Scans_Price as 'Scans Price'
FROM (Registration_MedPrices as M FULL OUTER JOIN Registration_ScanPrices as S ON (M.Registration_ID = S.Registration_ID)) FULL OUTER JOIN Registration_DrRoomFees as D ON (M.Registration_ID = D.Registration_ID)


GO
insert into Patient(Name,Username,Password,Gender,Age,Mobile_Number,Address)
values

('Mohamad',  'M16',  '1234', 'M',  5,  '01145585123',  'doky'),
('Ibrahim',  'I20',  '4567', 'M',  20, '01145585193',  'October'),
('Fatma',    'F90',  '4169', 'F',  17, '01236547965',  'Giza'),
('Anas',     'An14', '9621', 'M',  26, '01236967486',  'Alex'),
('Omar',     'OY12', '7896', 'M',  36, '01256379641',  'Cairo'),
('Heba',     'HE12', '9634', 'F',  25, '01245879374',  'Zamalek '),
('Jody',     'JK78', '9674', 'F',  14, '01036479512',  'Maadi'),
('Arwa',     'AI63', '9631', 'F',  62, '01145585123',  'Zamalek'),
('Nada',     'NH85', '7485', 'F',  17, '01697456314',  'Helwan'),
('Tsneem',   'TO96', '1045', 'F',  28, '01679641358',  'Downtown'),
('Alaa',     'NA97', '0147', 'F',  36, '03149756823',  'Mohandiseen'),
('Basant',   'BE96', '3104', 'F',  41, '01132467895',  'Manial'),
('Zidan',    'ZI97', '5274', 'M',  69, '01523654795',  'Nasr City'),
('Gohary',   'AG78', '7965', 'M',  20, '01369745893',  'Zamalek'),
('Maarof',   'AH95', '6370', 'M',  30, '01163649741',  'Downtown'),
('Hazem',    'HH85', '1417', 'M',  40, '01366974523',  'doky'),
('Marwan',   'MM63', '8254', 'M',  50, '01369645012',  'Alex'),
('Hesham',   'HE89', '0145', 'M',  54, '01123669741',  'doky'),
('Ashry',    'AW41', '7870', 'M',  29, '01149675853',  'doky'),
('Endy',     'EO98', '7896', 'F',  26, '01113674558',  'Zayed')


insert into Admin (Name,Username,Password)
Values
('Ali',  'A16',  '1234'),
('Adel', 'A20',  '9641'),
('Adham', 'D90',  '2457'),
('Adam',  'Af14', '2425'),
('Bahaa', 'cfe12', '1472'),
('Basma', 'rge12', '6344'),
('Basem', 'ac8', '5304'),
('Dalia',  'ed63', '0450'),
('Dania',  'asd85', '7200'),
('Doaa',   'rfb6', '4040'),
('Hend',   'asd7', '4234'),
('Dalal',   'Bdb6', '2734'),
('Eman',    'Zax7', '0043'),
('Farah',   'Age8', '6724'),
('Fady',   'Arg5', '0740'),
('Fares',    'Hvv5', '2704'),
('Ghada',   'Mcs3', '2740'),
('Ghannam',   'Hyt9', '0457'),
('Hala',    'AWfd', '2707'),
('Hanan',     'EOsv8', '8207')


insert into Receptionist(Name,Username,Password,Gender,Age,Mobile_Number,Address,Salary)
Values
('Hany','Ang5','2725','M',26,'01198760987','Maadi',5000),
('Hazem','H51','2727','M',36,'01145554433','Giza',6000),
('Helal','vfs0','3472','M',46,'01187998877','Cairo',7000),
('Habiba','scg0','2720','F',56,'01166554433','Alexandria',7000),
('Hadya','Hjh','5418','F',27,'01299887734','Garden Ciy',7000),
('Howaida','nhg90','9634','F',35,'01267676299','Korba',7000),
('Jumana','gju5','5052','F',52,'01278484847','Nasr City',7000),
('Khaled','bg5','3277','M',41,'01247474848','5th Settlement',6000),
('Karim','umh5','0452','M',32,'01204017481','Haram',7000),
('Laila','Ht5','7082','F',29,'01247471901','Remaya',6000),
('Lamis','tii5','7082','F',31,'01136281912','6th October',5000),
('Manar','u5uy','3470','F',35,'01174839323','Sheikh Zayed',6000),
('Marwa','1myu','7520','F',39,'01037373834','Helwan',7000),
('Mariam','dre52','9367','F',45,'01074732924','Mansoura',6000),
('Mazen','trtr5','0454','M',48,'01074483335','Downtown',6000),
('Moataz','uym6','7824','M',39,'01037383866','Degla',7000),
('Moatasem','H5fd','2070','M',34,'01099883357','Fayoum',7000),
('Maged','ih5f','0405','M',39,'01022555348','Gouna',7000),
('Menna','hpf5','7020','F',40,'01022255569','Marsa Allam',6000),
('Mayar','HM15','8308','F',27,'01137473210','Sharm Elsheikh',5000)


insert into Department(Name)
Values
('Emergency'),
('Cardiology'),
('Intensive Care Unit'),
('Neurology'),
('Oncology'),
('Anesthetics'),
('Burn Center'),
('General Surgery'),
('Infection Control'),
('Maternity'),
('Microbiology'),
('Nutrition and Dietetics'),
('Pharmacy'),
('Radiology'),
('Radiotherapy'),
('Renal'),
('Urology'),
('Coronary Care Unit'),
('Gastroenterology'),
('Haematology')

insert into Doctor(Name,Username,Password,Gender,Age,Mobile_Number,Address,Department_ID,Start_of_Working_Hours,End_of_Working_Hours,Salary,Avg_Rating)
values
('Noura','D76','1234','F',25,'01057688451','Giza',1,'08 AM' ,'01 PM' ,10000,7),
('Nadine','NA97','1479','F',23,'01047474747','Maadi',2,'09 AM','02 PM',30000,0),
('Nada','H5G6','1477','F',29,'01173222119','Cairo',3,'10 AM','04 PM',19000,0),
('Nader','G4GD6','8247','M',31,'01184393933','Alexandria',4,'11 AM','03 PM',20000,8),
('Nehal','HF4GF','8227','F',29,'01153621811','Korba',5,'11 AM','05 PM',10000,9),
('Nahla','J4R','7171','F',32,'01174939339','Haram',6,'10 AM','06 PM',30000,0),
('Naseem','FGD4','8071','M',35,'01038383998','Remaya',7,'08 AM','01 PM',30000,6),
('Nagy',',I45','8507','M',39,'01076218119','Helwan',8,'09 AM','03 PM',25000,0),
('Omar','KG85','9807','M',37,'01273738382','Mansoura',9,'11 AM','04 PM',30000,10),
('Omaima','UKMU5','6317','F',34,'01173737373','Downtown',10,'11 AM','05 PM',10000,0),
('Omara','GR54','8077','M',33,'01173939383','Degla',11,'10 AM','06 PM',20000,0),
('Osama','I5T','0720','M',38,'01284848433','Fayoum',12,'09 AM','01 PM',11000,0),
('Ola','LIU5','8073','F',36,'01238383832','Cairo',13,'11 AM','02 PM',30000,0),
('Asmaa','F4T','0071','F',41,'01083838811','Giza',13,'10 AM','03 PM',20000,0),
('Peter','IGFG','6701','M',44,'01227117322','Maadi',14,'08 AM','05 PM',26000,0),
('Passant','RFGT2','3467','F',50,'01294848383','Giza',15,'09 AM','06 PM',29000,0),
('Rana','ERH2','2047','F',34,'01038383838','Maadi',16,'09 AM','02 PM',15000,0),
('Rania','QWBNG','0436','F',41,'01011289282','Giza',17,'09 AM','04 PM',30000,0),
('Ramy','MYH4','6317','M',44,'01088833729','Maadi',18,'11 AM','06 PM',20000,0),
('Rola','96FR','0544','F',32,'01178990022','Remaya',19,'10 AM','05 PM',17000,0)


insert into Scan(Name,Price)
Values
('MRI',150),
('Thyroid scan',150),
('PET',200),
('X-ray',250),
('Ultrasound',150),
('DEXA',190),
('Fluoroscopy',175),
('Bone Scan',180),
('Nuchal Fold Scan',190),
('CT Ankle',200),
('CT Foot',150),
('CT Elbow',150),
('CT Clavicle',800),
('CT Sternoclavicular',250),
('CT Hand',150),
('CT Hip',140),
('CT Knee',170),
('CT Sacrum',180),
('CT Wrist',160)


insert into Medication(Name,Price,Exp_Date)
Values
('Acetaminophen',100,'2025-05-10'),
('Adderall',520,'2024-09-19'),
('Ciprofloxacin',70,'2023-07-24'),
('Citalopram',80,'2021-01-25'),
('Clindamycin',90,'2026-02-28'),
('Doxycycline',118,'2024-03-21'),
('Gabapentin',63,'2026-04-17'),
('Hydrochlorothiazide',97,'2021-05-19'),
('Ibuprofen',142,'2022-06-27'),
('Lexapro',74,'2025-09-28'),
('Lyrica',101,'2023-07-29'),
('Meloxicam',37,'2024-08-17'),
('Metformin',105,'2025-09-18'),
('Naproxen',80,'2022-10-14'),
('Omeprazole',55,'2023-11-21'),
('Pantoprazole',65,'2025-12-26'),
('Prednisone',71,'2024-03-15'),
('Trazodone',250,'2021-08-20'),
('Wellbutrin',190,'2021-12-18'),
('Xanax',90,'2021-05-20')


insert into Room(Type,Size,Price,Department_ID) 
Values
('Examination Room',40,900,1),
('ICU',50,800,2),
('Surgery Room',50,900,3),
('Examination Room',40,900,4),
('ICU',40,700,5),
('Examination Room',30,800,6),
('Examination Room',30,800,7),
('ICU',40,750,8),
('Surgery Room',60,850,9),
('ICU',60,900,10),
('Examination Room',50,900,11),
('Examination Room',50,900,12),
('ICU',60,800,13),
('Surgery Room',60,800,14),
('Examination Room',40,900,15),
('ICU',50,800,16),
('Examination Room',30,800,17),
('ICU',30,600,19),
('Surgery Room',30,900,18),
('Examination Room',30,800,20)


insert into Registration(Reciptionist_ID,Doctor_ID,Patient_ID,Room_ID,Date,Reserved_Time_Slot,State,Diagnosis,Comments)
Values
(1, 1, 1, 1, CAST(getdate() AS DATE), '08 AM', 'Waiting', 'Diabetes', 'Follow the medications strictly'),
(2, 2, 2, 2, CAST(getdate() AS DATE), '09 AM', 'Being Examined', 'Obesity', 'Run every day 1 km'),
(3, 5, 3, 1, CAST(getdate() AS DATE), '10 AM', 'Getting Scans', 'Depressive disorder', 'Not a severe case but needs care'),
(4, 7, 4, 1, CAST(getdate() AS DATE), '11 AM', 'Buying Medications', 'Anxiety', NULL),
(5, 6, 5, 1, CAST(getdate() AS DATE), '01 PM', 'Waiting', 'Asthma', 'dont stay for long in closed areas'),
(6, 3, 6, 3, CAST(getdate() AS DATE), '03 PM', 'Released', 'Hypertension', NULL)


insert into Ordered_Scans
Values
(1, 1, '08:30 AM', '09 AM'),
(2, 5, '10:30 AM', '11 AM'),
(3, 11, '11:30 AM', '01 PM'),
(4, 13, '9:00 AM', '10 AM'),
(5, 9, '10:30 AM', '11 AM')


insert into Prescribed_Medications
Values
(1, 1, '08:30 AM', '2ml'),
(2, 2, '09:30 AM', 'only once per night'),
(3, 5, '10:30 AM', '60 mg/day'),
(4, 4, '11:30 AM', '400 mg per day'),
(5, 9, '12:30 PM', '1 tab/day')

insert into Doctor_Ratings
Values
(1, 1, CAST(getdate() AS DATE), 7),
(2, 7, CAST(getdate() AS DATE), 6),
(8, 5, CAST(getdate() AS DATE), 9),
(12, 4, CAST(getdate() AS DATE), 8),
(3, 9, CAST(getdate() AS DATE), 10)