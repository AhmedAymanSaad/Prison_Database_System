﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PrisonDBApp
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectAllGuards()
        {
            string query = "select * from Guard;";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectGuardUsingID(int id)
        {
            string query = "select * from Guard where ID= '"+id+"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllInmates()
        {
            string query = "select * from Inmate;";
            return dbMan.ExecuteReader(query);
        }

        //-------------------------------------------------------------------------------------------------------
        public DataTable SelectAllSectors()
        {
            string query = "select SectorID from Sector;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllTransferredInmates()
        {
            string query = "select * from Released_Convict where Status= 'Transferred';";
            return dbMan.ExecuteReader(query);
        }

        //-------------------------------------------------------------------------------------------------------
        public DataTable SelectAllCellNumbers()
        {
            string query = "select CellNumber from Cell;";
            return dbMan.ExecuteReader(query);
        }

        //-------------------------------------------------------------------------------------------------------
        public DataTable SelectAllGuardIDs()
        {
            string query = "select ID from Guard;";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectAllSupercisors()
        {
            string query = "select Distinct Supervisor_ID from Guard;";
            return dbMan.ExecuteReader(query);
        }


        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectGuardTypes()
        {
            string query = "select Distinct Type from Guard;";
            return dbMan.ExecuteReader(query);
        }


        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectInmateIDs()
        {
            string query = "select ID from Inmate;";
            return dbMan.ExecuteReader(query);
        }


        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectInmateUsingHisID(int id)
        {
            string query = "select * from Inmate where ID="+id+" ;";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------------------------------------------------------------
        public DataTable SelectAvailableSolitaryCellNumbers()
        {
            string query = "select Solitarycellnumber from Solitary_Confinement where Starttime IS NULL ;";
            return dbMan.ExecuteReader(query);
        }




        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Hiring/firing Info Form-----------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

        //-------------------------------hire a guard with supervisor------------------------------------------------------------------
        public int HireAGuard(int ID, string First,char Mid ,string Last, string Guardtype, int S_ID, int Sector_ID)
        {
            string query = "insert into Guard (ID,Fname,Minit,Lname,Type,Supervisor_ID,Sectorno,Username)" +
                " values (" +ID+ " , '" +First+ "' ,'" +Mid+ "','" +Last+ "','" +Guardtype+ "'," +S_ID+ "," +Sector_ID+ ",null ) ; ";
            return dbMan.ExecuteNonQuery(query);
        }

        //-------------------------------hire a guard with no supervisor------------------------------------------------------------------
        public int HireAHeadGuard(int ID, string First, char Mid, string Last, string Guardtype, int Sector_ID)
        {
            string query = "insert into Guard (ID,Fname,Minit,Lname,Type,Supervisor_ID,Sectorno,Username)" +
                " values (" + ID + " , '" + First + "' ,'" + Mid + "','" + Last + "','" + Guardtype + "', null ," + Sector_ID + ",null ) ; ";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------Fire a guard using the ID--------------------------------------------------------------------
        public int FireAGuard(int ID)
        {
            string query = "DELETE FROM Guard WHERE ID='" + ID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateGuardInfo(string GuardType,int SupervisorID, int sectno,int id)
        {
            string query = "UPDATE Guard SET Type='" + GuardType + "', Supervisor_ID= '" + SupervisorID + "', Sectorno = '" + sectno+ "'" +
                "  WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateGuardInfoWithNoSupervisor(string GuardType, int sectno, int id)
        {
            string query = "UPDATE Guard SET Type='" + GuardType + "', Supervisor_ID= null, Sectorno = '" + sectno + "'" +
                "  WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Repairs Form----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------


        public DataTable SelectCellsToBeRepaired()
        {
            string query = "select Cellnumber,Repairs from Cell where Repairs!= 'null'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFacilitiesToBeRepaired()
        {
            string query = "select Facilitynumber,Facilitytype,Expenses,Sectorno from Facility where Expenses!= 0";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFacilitiesToBeRepairedLessThanASpecificSum(int sum)
        {
            string query = "select Facilitynumber,Facilitytype,Expenses,Sectorno from Facility where Expenses >= '"+sum+"'";
            return dbMan.ExecuteReader(query);
        }



        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Inmates Form----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

        public DataTable SelectCellNumbersHavingLessThanThreeInmates()
        {
            string query = "Select distinct Cellnumber from Cell,Inmate where (Cellnumber=Cellno ) group by Cellno,Cellnumber Having count(Cellno)<3 ";
            return dbMan.ExecuteReader(query);
        }

        public int SelectTheLastIDAndAddingOne()  // used for adding a default value in the id text box when adding an inmate
        {
            string query = "SELECT MAX(ID) +1 FROM Inmate";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int AdmitAnInmate(int ID, string First, string Mid, string Last, string Charge, decimal Sentence,DateTime ConDate, int cellno)
        {
            string query = " insert into Inmate (ID,Fname,Mname,Lname,Charge,Sentence,ConvictionDate,Cellno,SolitaryCellnumber,BehaviourScore)" +
                " values (" +ID+ ",'" + First + "' ,'" + Mid + "','" + Last + "','" + Charge + "',"+ Sentence + ",'" +ConDate+ "','" +cellno + "'" +
                ", null, null  ); ";
            return dbMan.ExecuteNonQuery(query);
        }


        //----------------------------------------------------For The Transfer of the convict---------------------------
        public int RemoveInmate(int num)
        {
            string query = "DELETE FROM Inmate WHERE ID='" + num + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public string SelectFirstNameUsingID(int num) 
        {
            string query = "SELECT Fname FROM Inmate WHERE ID='" + num + "';";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string SelectMiddleInitialUsingID(int num)
        {
            string query = "SELECT Mname FROM Inmate WHERE ID='" + num + "';";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string SelectLastNameUsingID(int num)
        {
            string query = "SELECT Lname FROM Inmate WHERE ID='" + num + "';";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string SelectSentenceUsingID(int num)
        {
            string query = "SELECT Charge FROM Inmate WHERE ID='" + num + "';";
            return dbMan.ExecuteScalar(query).ToString();
        }


        public int UpdateInmateToTransffered(int ID, string fname, char middle,string lastname, string sentence)
        {
            string query = " insert into Released_Convict (nationalID,Fname,Minit,Lname,Status,Originalsentence,ReleaseDate,ProbationPeriod)" +
                " values (" + ID + ",'" + fname + "' ,'" + middle + "','" + lastname + "','Transferred','" + sentence + "',null, null  ); ";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateInmateToReleased(int ID, string fname, char middle, string lastname, string sentence, DateTime date, int prohibation)
        {
            string query = " insert into Released_Convict (nationalID,Fname,Minit,Lname,Status,Originalsentence,ReleaseDate,ProbationPeriod)" +
                " values (" + ID + ",'" + fname + "' ,'" + middle + "','" + lastname + "','Released','" + sentence + "','"+date+"', '"+ prohibation + "'  ); ";
            return dbMan.ExecuteNonQuery(query);
        }



        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For IMPRISONED Inmates Form-----------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

        public int SelectBehaviourUsingID(int num)
        {
            string query = "SELECT BehaviourScore FROM Inmate WHERE ID='" + num + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int UpdateBehaviorScore(int BehaviorScore, int id)
        {

            string query = "UPDATE Inmate SET BehaviourScore='" + BehaviorScore + "' WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangeCells(int CellNo, int id)
        {

            string query = "UPDATE Inmate SET Cellno='" + CellNo + "' WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public int ChangeSentence(decimal NewSent, int id)
        {

            string query = "UPDATE Inmate SET Sentence='" + NewSent + "' WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangeToSolitaryConfinement(int CellNo, int id, DateTime startdate, decimal duration)
        {

            string query = "UPDATE Inmate SET SolitaryCellnumber='" + CellNo + "' WHERE ID='" + id + "';";
            string query1 = "UPDATE Solitary_Confinement SET Starttime='"+startdate+ "', duration='"+duration+ "' where Solitarycellnumber =" +
                " '"+ CellNo + "'  ";
            dbMan.ExecuteNonQuery(query);
            return dbMan.ExecuteNonQuery(query1);
        }

        public int CheckIfAlreadyInSolitaryConfinement(int num)
        {
            string query = "SELECT COUNT(SolitaryCellnumber) FROM Inmate WHERE ID ='" + num + "';";
            return (int)dbMan.ExecuteScalar(query);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Visitation Form-------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

        public DataTable SelectScheduledVisits(int num, DateTime TodayDate)
        {
            string query = "select InmateID,VisitorID,StartDate,EndDate from Visiting,Inmate where InmateID=ID and StartDate >= '"+TodayDate+"' and ID= " + num+ " " +
                "order by InmateID,VisitorID,StartDate ;";
            return dbMan.ExecuteReader(query);
        }


        public int CancelAVisit(int row, int id, DateTime todaydate)
        {

            string query = "  with cte(rownum)as (select row_number () over(partition by InmateID order by InmateID)" +
                " from [Visiting] where InmateID= "+id+ " and StartDate>= '"+ todaydate + "') delete from cte where rownum = " + row+"       ;";
            return dbMan.ExecuteNonQuery(query);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Civilian View Form----------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

<<<<<<< Updated upstream
        //------------------------------Civlian Account Creation-------------------------------------------------------------
        public int InsertCivilianAccount(int username, int password)
=======

        //=============================Guard Assignments======================================================
        public DataTable GetGuardAssignments()
        {
            string query = "select ID,Fname, Lname, Type, Sectorno from Guard";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetGuardCountInSector()
        {
            string query = "Select a.Sectorno as \"Sector Number\", a.Type as Count From (select count(*) Type, Sectorno from Guard , Sector where SectorID=Sectorno group by Sectorno) a";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSectorNo()
        {
            string query = "select SectorID from Sector";
            return dbMan.ExecuteReader(query);
        }
        

        //------------------------------Civlian Account Creation-------------------------------------------------------------
        public int InsertCivilianAccount(int username, int password)

>>>>>>> Stashed changes
        {
            string query = "INSERT into Log_in (ID, Password, Usertype)" + "Values (" + username + ", " + password + ", 'Civilian');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateVisitorInfo(int PhoneNumber)
        {
            string query = "Update visitor SET phone number =" + PhoneNumber + ";";
            return dbMan.ExecuteNonQuery(query);

        }

        public int BookAVisit(int inmateID, int VisitorID, DateTime StartDate, DateTime EndDate)
        {
            string query = "INSERT into Visiting (InmateID, VisitorID, StartDate, EndDate)" + "Values (" + inmateID + ", " + VisitorID + ", '" + StartDate + "', '" + EndDate + "', ';";
            return dbMan.ExecuteNonQuery(query);
        }
<<<<<<< Updated upstream
=======


        //============================================Inmate Data=====================================================
        public DataTable SelectJobs()
        {
            string query = "select * from Prisoner_Employment";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectInmatewithJob(int i)
        {
            string query = "select * from Inmate join Prisoner_Employment on ID=Inmateassigned where ID="+i;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectInmateJob(int i)
        {
            string query = "select * from Prisoner_Employment where JobID="+i;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetInmatesNoJob()
        {
            string query = "(select ID from Inmate) except (select ID from Inmate join Prisoner_Employment on ID=Inmateassigned)";
            return dbMan.ExecuteReader(query);
        }

        public int AssignInmateJob(int id,int sal,string job)
        {
            string query = "insert into  Prisoner_Employment (Inmateassigned,Salary,Jobdescription) "
                + "values ("+id+","+sal+",'"+job+"')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectInmateSector(int i)
        {
            string query = "select * from Inmate join Cell on Inmate.Cellno=Cell.Cellnumber join Sector on Sector.SectorID=cell.SectorID where Sector.SectorID=" + i;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllFacilities()
        {
            string query = "select * from Facility";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllFacilitiesRepaired()
        {
            string query = "select * from Facility where Expenses=0 or Expenses is null";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFacility(int i)
        {
            string query = "select * from Facility where Facilitynumber=" + i;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllCells()
        {
            string query = "select * from Cell";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllCellsRepaired()
        {
            string query = "select * from Cell where Repairs is null ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectCell(int i)
        {
            string query = "select * from Cell where Cellnumber=" + i;
            return dbMan.ExecuteReader(query);
        }
        public int ReportCell(int id, string report)
        {
            string query = "update Cell set Repairs='"+report+"' where Cellnumber= "+id;    
            return dbMan.ExecuteNonQuery(query);
        }
        public int ReportFacility(int id, int exp)
        {
            string q1 = "select Expenses from Facility where Facilitynumber="+id;
            int expf = exp + (int)dbMan.ExecuteScalar(q1);
            string query = "update Facility set Expenses='" +expf + "' where Facilitynumber= " + id;
            return dbMan.ExecuteNonQuery(query);
        }

>>>>>>> Stashed changes
    }
}
