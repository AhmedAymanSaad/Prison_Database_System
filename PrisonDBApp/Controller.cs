
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

        //-------------------------------------------------------------------------------------------------------
        public DataTable SelectAllSectors()
        {
            string query = "select SectorID from Sector;";
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

        //------------------------------Fire a guard using the ID--------------------------------------------------------------------
        public int FireAGuard(int ID)
        {
            string query = "DELETE FROM Guard WHERE ID='" + ID + "';";
            return dbMan.ExecuteNonQuery(query);
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


        //-------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------- For Cell Info Form--------------------------------------------------
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

    }
}
