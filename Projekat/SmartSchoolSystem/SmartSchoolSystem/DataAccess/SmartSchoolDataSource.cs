using System;
using SQLite.Net;
using System.IO;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SmartSchoolSystem.DataAccess
{
    public class SmartSchoolDataSource
    {
        String path;
        SQLiteConnection conn;
        public SmartSchoolDataSource()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MainDatabase.sqlite");
            Debug.WriteLine(path);
        }
        public SQLiteConnection konektuj()
        {
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<Model.Korisnik>();
            //conn.Execute("CREATE TABLE IF NOT EXISTS Korisnici (ID Integer Primary Key Autoincrement NOT NULL,"+ "Ime VARCHAR(50), Prezime VARCHAR(50),"+ "MjestoRodenja VARCHAR(50)"+ "username VARCHAR(100), pass VARCHAR(50))");
            //conn.CreateCommand("CREATE TABLE IF NOT EXISTS Korisnici (ID Integer Primary Key Autoincrement NOT NULL, Ime VARCHAR(50), Prezime VARCHAR(50), MjestoRodenja VARCHAR(50), Username VARCHAR(100), Pass VARCHAR(50))");
           
           
            conn.Execute("CREATE TABLE IF NOT EXISTS Korisnici (ID Integer Primary Key Autoincrement NOT NULL,"
                                                                + "Ime VARCHAR(50), Prezime VARCHAR(50),"
                                                                + "MjestoRodenja VARCHAR(50),"
                                                                + "Jmbg VARCHAR(20), Drzavljanstvo VARCHAR(10),"
                                                                + "Spol VARCHAR(10), Email VARCHAR(30),"
                                                                + "KontaktTel VARCHAR(20),"
                                                                + "Username VARCHAR(100), Pass VARCHAR(50))");
            conn.Execute("CREATE TABLE IF NOT EXISTS Ucenici (ID Integer Primary Key Autoincrement NOT NULL,"
                                                              + "Ime VARCHAR(50), Prezime VARCHAR(50),"
                                                              + "MjestoRodenja VARCHAR(50),"
                                                              + "Jmbg VARCHAR(20), Spol VARCHAR(10),"
                                                              + "ImeRod VARCHAR(50), PrezimeRod VARCHAR(50),"
                                                              + "ZanimanjeRod VARCHAR(60))");
            conn.Execute("CREATE TABLE IF NOT EXISTS Predmeti (ID Integer Primary Key Autoincrement NOT NULL,"
                                                              + "Naziv VARCHAR(30))");
            return conn;
            
        }
       
    }
}
